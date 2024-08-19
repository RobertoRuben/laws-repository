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

        public EmployeeListForm(MainForm main, IRepository<Trabajador> employeeRepository)
        {
            InitializeComponent();
            _employeeService = new EmployeeService(employeeRepository);
            this.mainForm = main;
            tboxBusqueda.TextChanged += tboxBusqueda_TextChanged; 
            CargarDatagrid();
            FormatoDataGrid();
        }

        public void CargarDatagrid()
        {
            dgvEmployees.DataSource = _employeeService.GetAll();
            lblResultados.Text = "Registros mostrados: " + Convert.ToString(dgvEmployees.Rows.Count) + " de 635";
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
    }
}