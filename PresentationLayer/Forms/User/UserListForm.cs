using System;
using System.Windows.Forms;
using BusinessLayer.Services;
using DataLayer.Repositories;
using EntitiesLayer.Entities;
using PresentationLayer.Forms.Common;

namespace PresentationLayer.Forms.User
{
    public partial class UserListForm : Form
    {
        private MainForm mainForm;
        private string operation = "";
        public int userSesionId;
        
        private UserService _userService;
        
        public UserListForm(MainForm main, IUserRepository userRepository)
        {
            InitializeComponent();
            _userService = new UserService(userRepository);
            this.mainForm = main;
            tboxBusqueda.TextChanged += SearchTbox_TextChanged; 
            DataGridLoad();
            DataGridFormat();
        }

        private void DataGridLoad()
        {
            dgvUsers.DataSource = _userService.GetAll();
            lblResultados.Text = "Total de Registros: " + Convert.ToString(dgvUsers.Rows.Count);
        }
        private void UserSearch()
        {
            try
            {
                var user = _userService.FindBy(tboxBusqueda.Texts.Trim());
                dgvUsers.DataSource = user;
                lblResultados.Text = "Registros con coincidencia: " + dgvUsers.RowCount;
            }
            catch (Exception e)
            {
                ErrorMessage(e.Message);
                tboxBusqueda.Clear();
            }
        }
        private void DataGridFormat()
        {
            dgvUsers.Columns[0].HeaderText = "Id";
            dgvUsers.Columns[1].HeaderText = "Trabajador";
            dgvUsers.Columns[2].HeaderText = "Usuario";
            dgvUsers.Columns[3].HeaderText = "Rol";
            dgvUsers.Columns[4].HeaderText = "Estado";
            dgvUsers.Columns[0].Width = 80;
            dgvUsers.Columns[1].Width = 220;
            dgvUsers.Columns[2].Width = 140;
            dgvUsers.Columns[3].Width = 140;
            dgvUsers.Columns[4].Width = 140;
        }
        private void ErrorMessage(string mensaje)
        {
            MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void OkMessage(string mensaje)
        {
            MessageBox.Show(mensaje, "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ClearSearchBtn_Click(object sender, EventArgs e)
        {
            tboxBusqueda.Clear();
        }

        private void SearchTbox_TextChanged(object sender, EventArgs e)
        {
            UserSearch();
        }

        private void DisableBtn_Click(object sender, EventArgs e)
        {
            if (dgvUsers.CurrentRow != null)
            {
                int idUser = Convert.ToInt32(dgvUsers.CurrentRow.Cells[0].Value);
                DialogResult result = MessageBox.Show("¿Deseas eliminar inhabilitar a este usuario?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        bool isDesable = _userService.Disable(idUser, userSesionId);
                        if (isDesable)
                        {
                            OkMessage("Usuario inhabilitado.");
                            DataGridLoad();
                        }
                        else
                        {
                            ErrorMessage("Error al inhabilitar al usuario.");
                        }
                    }
                    catch (Exception ex)
                    {
                        ErrorMessage("Error al eliminar el usuario: " + ex.Message);
                    }
                }
            }
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            UserService userService = new UserService(new UserRepository());
            RolService rolService = new RolService(new RolRepository());
            EmployeeService employeeService = new EmployeeService(new EmployeeRepository());
            UserDataForm userDataForm = new UserDataForm(userService, employeeService, rolService);

            userDataForm.operation = "Insertar";
            userDataForm.userSesionId = userSesionId;
            userDataForm.lblSeccion.Text = "Registrar Usuario";
            this.mainForm.SetTransparency(true);
            userDataForm.ShowDialog();
            this.mainForm.SetTransparency(false);
            DataGridLoad();
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            UserService userService = new UserService(new UserRepository());
            RolService rolService = new RolService(new RolRepository());
            EmployeeService employeeService = new EmployeeService(new EmployeeRepository());
            UserDataForm userDataForm = new UserDataForm(userService, employeeService, rolService);

            userDataForm.operation = "Actualizar";
            userDataForm.userSesionId = userSesionId;
            userDataForm.UserId = Convert.ToInt32(dgvUsers.CurrentRow.Cells[0].Value);

            userDataForm.cboxEmployee.Texts = dgvUsers.CurrentRow.Cells[1].Value.ToString();
            userDataForm.cboxEmployee.Enabled = false;
            userDataForm.tboxUser.Texts = dgvUsers.CurrentRow.Cells[2].Value.ToString();
            userDataForm.cboxRol.Texts = dgvUsers.CurrentRow.Cells[3].Value.ToString();

            string estado = dgvUsers.CurrentRow.Cells[4].Value.ToString();
            userDataForm.rbtnActivate.Checked = estado == "Activo";
            userDataForm.rbtnInactive.Checked = estado == "Inactivo";
            
            
            userDataForm.lblSeccion.Text = "Actualizar datos de usuario";
            this.mainForm.SetTransparency(true);
            userDataForm.ShowDialog();
            this.mainForm.SetTransparency(false);
            DataGridLoad();
        }
    }
}