using System;
using System.Windows.Forms;
using BusinessLayer.Services;
using DataLayer.Repositories;
using PresentationLayer.Forms.Common;

namespace PresentationLayer.Forms.Employees
{
    public partial class EmployeeListForm : Form
    {
        private MainForm mainForm;
        private string operation = "";
        private EmployeeService _employeeService;
        public int userId;
        
        private int currentPage = 1;
        private int pageSize = 20; 

        public EmployeeListForm(MainForm main, IEmployeeRepository employeeRepository)
        {
            InitializeComponent();
            _employeeService = new EmployeeService(employeeRepository);
            this.mainForm = main;
            searchTbox.TextChanged += SearchTbox_TextChanged; 
            DataGridLoad();
            DataGridFormat();
        }

        public void DataGridLoad(int pageNumber = 1)
        {
            currentPage = pageNumber;
            var employee = _employeeService.GetAll(pageSize, pageNumber); 

            dgvEmployees.DataSource = employee; 
            
            btnNext.Enabled = employee.Count == pageSize;
            
            lblResultados.Text = $"Mostrando página: {currentPage}";
        }
        
        private void btnNext_Click(object sender, EventArgs e)
        {
            DataGridLoad(currentPage + 1);
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (currentPage > 1)
            {
                DataGridLoad(currentPage - 1);
            }
        }
        private void DataGridFormat()
        {
            dgvEmployees.Columns[0].HeaderText = "Id";
            dgvEmployees.Columns[1].HeaderText = "Dni";
            dgvEmployees.Columns[2].HeaderText = "Nombre";
            dgvEmployees.Columns[3].HeaderText = "Apellido Paterno";
            dgvEmployees.Columns[4].HeaderText = "Apellido Materno";
            dgvEmployees.Columns[5].HeaderText = "Sexo";
            dgvEmployees.Columns[0].Width = 80;
            dgvEmployees.Columns[1].Width = 100;
            dgvEmployees.Columns[2].Width = 180;
            dgvEmployees.Columns[3].Width = 180;
            dgvEmployees.Columns[4].Width = 180;
            dgvEmployees.Columns[5].Width = 80;
        }
        
        private void CategorySearch()
        {
            try
            {
                var employee = _employeeService.FindBy(searchTbox.Texts.Trim());
                dgvEmployees.DataSource = employee;
                lblResultados.Text = "Registros con coincidencia: " + dgvEmployees.RowCount;
            }
            catch (Exception ex)
            {
                ErrorMessage(ex.Message);
                searchTbox.Clear();
            }
        }

        private void ErrorMessage(string mensaje)
        {
            MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void OkMessage(string mensaje)
        {
            MessageBox.Show(mensaje, "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void SearchTbox_TextChanged(object sender, EventArgs e)
        {
            CategorySearch();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            EmployeeService employeeService = new EmployeeService(new EmployeeRepository());
            EmployeeDataForm employeeDataForm = new EmployeeDataForm(employeeService);
            employeeDataForm.operation = "Insertar";
            employeeDataForm.lblSection.Text = "Registrar Trabajador";
            employeeDataForm.userId = userId;
            this.mainForm.SetTransparency(true);
            employeeDataForm.ShowDialog();
            DataGridLoad();
            this.mainForm.SetTransparency(false); 
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            EmployeeService employeeService = new EmployeeService(new EmployeeRepository());
            EmployeeDataForm employeeDataForm = new EmployeeDataForm(employeeService);
            employeeDataForm.operation = "Actualizar";
            employeeDataForm.lblSection.Text = "Actualizar datos de trabajador";
            employeeDataForm.userId = userId;
            
            employeeDataForm.employeeId = Convert.ToInt32(dgvEmployees.CurrentRow.Cells[0].Value);
            employeeDataForm.tboxDni.Texts = dgvEmployees.CurrentRow.Cells[1].Value.ToString().Trim();
            employeeDataForm.tboxName.Texts = dgvEmployees.CurrentRow.Cells[2].Value.ToString().Trim();
            employeeDataForm.tboxFaternalLastName.Texts = dgvEmployees.CurrentRow.Cells[3].Value.ToString().Trim();
            employeeDataForm.tboxMaternalLastName.Texts = dgvEmployees.CurrentRow.Cells[4].Value.ToString().Trim();
            
            string state = dgvEmployees.CurrentRow.Cells[5].Value.ToString().Trim();
            employeeDataForm.rbtnMale.Checked = state == "M";
            employeeDataForm.rbtnFemale.Checked = state == "F";
            
            this.mainForm.SetTransparency(true);
            employeeDataForm.ShowDialog();
            DataGridLoad();
            this.mainForm.SetTransparency(false); 
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (dgvEmployees.CurrentRow != null)
            {
                int employeeId = Convert.ToInt32(dgvEmployees.CurrentRow.Cells[0].Value);
                DialogResult result = MessageBox.Show("¿Deseas eliminar a este trabajador?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        bool isDeleted = _employeeService.Delete(employeeId, userId);
                        if (isDeleted)
                        {
                            OkMessage("Trabajador eliminado exitosamente.");
                            DataGridLoad();
                        }
                        else
                        {
                            ErrorMessage("Error al eliminar el trabajador.");
                        }
                    }
                    catch (Exception ex)
                    {
                        ErrorMessage("Error al eliminar el la categoria: " + ex.Message);
                    }
                }
            }
            else
            {
                ErrorMessage("Seleccione un trabajador para eliminar.");
            }
        }

        private void ClearSearchBtn_Click(object sender, EventArgs e)
        {
            searchTbox.Clear();
        }
    }
}