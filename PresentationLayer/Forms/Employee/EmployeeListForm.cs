using System;
using System.Windows.Forms;
using BusinessLayer.Services;
using DataLayer.Repositories;
using EntitiesLayer.Entities;
using PresentationLayer.Forms.Common;
using PresentationLayer.Forms.Employee;

namespace PresentationLayer.Forms.Employee
{
    public partial class EmployeeListForm : Form
    {
        private MainForm mainForm;
        private string operacion = "";
        private EmployeeService _employeeService;
        public int idUsuario;
        
        private int currentPage = 1;
        private int pageSize = 20; 

        public EmployeeListForm(MainForm main, IEmployeeRepository employeeRepository)
        {
            InitializeComponent();
            _employeeService = new EmployeeService(employeeRepository);
            this.mainForm = main;
            tboxBusqueda.TextChanged += tboxBusqueda_TextChanged; 
            CargarDatagrid();
            FormatoDataGrid();
        }

        public void CargarDatagrid(int pageNumber = 1)
        {
            currentPage = pageNumber;
            var trabajadores = _employeeService.GetAll(pageSize, pageNumber); 

            dgvEmployees.DataSource = trabajadores; 
            
            btnNext.Enabled = trabajadores.Count == pageSize;
            
            lblResultados.Text = $"Mostrando página: {currentPage}";
        }
        
        private void btnNext_Click(object sender, EventArgs e)
        {
            CargarDatagrid(currentPage + 1);
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (currentPage > 1)
            {
                CargarDatagrid(currentPage - 1);
            }
        }
        private void FormatoDataGrid()
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
        
        private void BuscarCategoria()
        {
            try
            {
                var employee = _employeeService.FindBy(tboxBusqueda.Texts.Trim());
                dgvEmployees.DataSource = employee;
                lblResultados.Text = "Registros con coincidencia: " + dgvEmployees.RowCount;
            }
            catch (Exception e)
            {
                ErrorMessage(e.Message);
                tboxBusqueda.Clear();
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

        private void tboxBusqueda_TextChanged(object sender, EventArgs e)
        {
            BuscarCategoria();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            EmployeeService employeeService = new EmployeeService(new EmployeeRepository());
            EmployeeDataForm employeeDataForm = new EmployeeDataForm(employeeService);
            employeeDataForm.operacion = "Insertar";
            employeeDataForm.idUsuario = idUsuario;
            this.mainForm.SetTransparency(true);
            employeeDataForm.ShowDialog();
            CargarDatagrid();
            this.mainForm.SetTransparency(false); 
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            EmployeeService employeeService = new EmployeeService(new EmployeeRepository());
            EmployeeDataForm employeeDataForm = new EmployeeDataForm(employeeService);
            employeeDataForm.operacion = "Actualizar";
            employeeDataForm.idUsuario = idUsuario;
            
            employeeDataForm.idEmpleado = Convert.ToInt32(dgvEmployees.CurrentRow.Cells[0].Value);
            employeeDataForm.tboxDni.Texts = dgvEmployees.CurrentRow.Cells[1].Value.ToString().Trim();
            employeeDataForm.tboxNombre.Texts = dgvEmployees.CurrentRow.Cells[2].Value.ToString().Trim();
            employeeDataForm.tboxApellidoPaterno.Texts = dgvEmployees.CurrentRow.Cells[3].Value.ToString().Trim();
            employeeDataForm.tboxApellidoMaterno.Texts = dgvEmployees.CurrentRow.Cells[4].Value.ToString().Trim();
            
            string estado = dgvEmployees.CurrentRow.Cells[5].Value.ToString().Trim();
            employeeDataForm.rbtnMasculino.Checked = estado == "M";
            employeeDataForm.rbtnFemenino.Checked = estado == "F";
            
            this.mainForm.SetTransparency(true);
            employeeDataForm.ShowDialog();
            CargarDatagrid();
            this.mainForm.SetTransparency(false); 
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvEmployees.CurrentRow != null)
            {
                int idEmployee = Convert.ToInt32(dgvEmployees.CurrentRow.Cells[0].Value);
                DialogResult result = MessageBox.Show("¿Deseas eliminar a este trabajador?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        bool isDeleted = _employeeService.Delete(idEmployee, idUsuario);
                        if (isDeleted)
                        {
                            OkMessage("Trabajador eliminada exitosamente.");
                            CargarDatagrid();
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

        private void btnLimpiarBusqueda_Click(object sender, EventArgs e)
        {
            tboxBusqueda.Clear();
        }
    }
}