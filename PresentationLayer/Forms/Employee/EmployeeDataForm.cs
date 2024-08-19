using System;
using System.Windows.Forms;
using BusinessLayer.Services;

namespace PresentationLayer.Forms.Employee
{
    public partial class EmployeeDataForm : Form
    {
        public string operacion = "";
        public int idUsuario;
        public int idEmpleado;

        private readonly EmployeeService _employeeService;
        public EmployeeDataForm(EmployeeService employeeService)
        {
            InitializeComponent();
            _employeeService = employeeService;
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}