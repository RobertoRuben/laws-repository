using System;
using System.Data;
using System.Windows.Forms;
using BusinessLayer.Exceptions;
using BusinessLayer.Services;
using EntitiesLayer.Entities;
using PresentationLayer.Forms.Common;

namespace Presentacion.Formularios.Login
{
    public partial class LoginForm : Form
    {
        private readonly AuthService _authService;
        public LoginForm(AuthService authService)
        {
            InitializeComponent();
            _authService = authService;
        }
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                string nombreUsuario = tboxUsuario.Texts.Trim();
                string contraseña = tboxContraseña.Texts.Trim();

                Usuario usuario = _authService.Login(nombreUsuario, contraseña);
                OkMessage("Inicio de sesion exitoso");
                
                MainForm mainForm = new MainForm();
                mainForm.nombreTrabajador = usuario.Trabajador.Nombre;
                mainForm.nombreUsuario = usuario.NombreUsuario;
                mainForm.nombreRol = usuario.Rol.NombreDeRol;
                mainForm.idUsuario = usuario.CodUsuario;
                mainForm.Show();
                this.Hide();
            }
            catch (BusinessException exception)
            {
                ErrorMessage("Error de inicio de sesion: " + exception.Message);
            }

        }
        
        private void ErrorMessage(string message)
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void OkMessage(string message)
        {
            MessageBox.Show(message, "Operación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
