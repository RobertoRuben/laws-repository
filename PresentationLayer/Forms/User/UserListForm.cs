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
        private string operacion = "";
        public int idUsuarioSesion;
        
        private UserService _userService;
        
        public UserListForm(MainForm main, IUsuarioRepository userRepository)
        {
            InitializeComponent();
            _userService = new UserService(userRepository);
            this.mainForm = main;
            tboxBusqueda.TextChanged += tboxBusqueda_TextChanged; 
            CargarDataGrid();
            FormatoDataGrid();
        }

        private void CargarDataGrid()
        {
            dgvUsers.DataSource = _userService.GetAll();
            lblResultados.Text = "Total de Registros: " + Convert.ToString(dgvUsers.Rows.Count);
        }
        private void BuscarUsuarios()
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
        private void FormatoDataGrid()
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

        private void btnLimpiarBusqueda_Click(object sender, EventArgs e)
        {
            tboxBusqueda.Clear();
        }

        private void tboxBusqueda_TextChanged(object sender, EventArgs e)
        {
            BuscarUsuarios();
        }

        private void btnInhabilitar_Click(object sender, EventArgs e)
        {
            if (dgvUsers.CurrentRow != null)
            {
                int idUser = Convert.ToInt32(dgvUsers.CurrentRow.Cells[0].Value);
                DialogResult result = MessageBox.Show("¿Deseas eliminar inhabilitar a este usuario?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        bool isDesable = _userService.Disable(idUser, idUsuarioSesion);
                        if (isDesable)
                        {
                            OkMessage("Usuario inhabilitado.");
                            CargarDataGrid();
                        }
                        else
                        {
                            ErrorMessage("Error al inhabilitar al usuario.");
                        }
                    }
                    catch (Exception ex)
                    {
                        ErrorMessage("Error al eliminar el la categoria: " + ex.Message);
                    }
                }
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            UserService userService = new UserService(new UsuarioRepository());
            RolService rolService = new RolService(new RolRepository());
            EmployeeService employeeService = new EmployeeService(new EmployeeRepository());
            UserDataForm userDataForm = new UserDataForm(userService, employeeService, rolService);

            userDataForm.operacion = "Insertar";
            userDataForm.idUsuarioSesion = idUsuarioSesion;
            userDataForm.lblSeccion.Text = "Registrar Usuario";
            Console.WriteLine("El id del usuario de la sesion activa es: " + userDataForm.idUsuarioSesion);
            this.mainForm.SetTransparency(true);
            userDataForm.ShowDialog();
            this.mainForm.SetTransparency(false);
            CargarDataGrid();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            UserService userService = new UserService(new UsuarioRepository());
            RolService rolService = new RolService(new RolRepository());
            EmployeeService employeeService = new EmployeeService(new EmployeeRepository());
            UserDataForm userDataForm = new UserDataForm(userService, employeeService, rolService);

            userDataForm.operacion = "Actualizar";
            userDataForm.idUsuarioSesion = idUsuarioSesion;
            userDataForm.idUsuario = Convert.ToInt32(dgvUsers.CurrentRow.Cells[0].Value);

            userDataForm.cboxTrabajador.Texts = dgvUsers.CurrentRow.Cells[1].Value.ToString();
            userDataForm.cboxTrabajador.Enabled = false;
            userDataForm.tboxUsuario.Texts = dgvUsers.CurrentRow.Cells[2].Value.ToString();
            userDataForm.cboxRol.Texts = dgvUsers.CurrentRow.Cells[3].Value.ToString();

            string estado = dgvUsers.CurrentRow.Cells[4].Value.ToString();
            userDataForm.rbtnActivo.Checked = estado == "Activo";
            userDataForm.rbtnInactivo.Checked = estado == "Inactivo";
            
            
            userDataForm.lblSeccion.Text = "Actualizar datos de usuario";
            Console.WriteLine("El id del usuario de la sesion activa es: " + userDataForm.idUsuarioSesion);
            Console.WriteLine("El id del registro a modificar es: " + userDataForm.idUsuario);
            this.mainForm.SetTransparency(true);
            userDataForm.ShowDialog();
            this.mainForm.SetTransparency(false);
            CargarDataGrid();
        }
    }
}