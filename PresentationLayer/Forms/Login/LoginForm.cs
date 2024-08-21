using System;
using System.Windows.Forms;
using BusinessLayer.Exceptions;
using BusinessLayer.Services;
using EntitiesLayer.DTOs;
using EntitiesLayer.Entities;
using PresentationLayer.Forms.Common;
using Newtonsoft.Json;

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

                UserDTO userDto = _authService.Login(nombreUsuario, contraseña);
                
                // Serializa el objeto usuario a formato JSON para mostrarlo
                string usuarioJson = JsonConvert.SerializeObject(userDto, Formatting.Indented);
                MessageBox.Show(usuarioJson, "Datos del Usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                OkMessage("Inicio de sesion exitoso");
                
                MainForm mainForm = new MainForm();
                mainForm.nombreTrabajador = userDto.NombreTrabajador;
                mainForm.nombreUsuario = userDto.NombreUsuario;
                mainForm.nombreRol = userDto.NombreRol;
                mainForm.idUsuario = userDto.CodUsuario;
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
