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
            tboxUser.Focus();
            _authService = authService;
            
            tboxUser.KeyPress += new KeyPressEventHandler(LoginBtn_KeyPress);
            tboxPassword.KeyPress += new KeyPressEventHandler(LoginBtn_KeyPress);
        }
        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MinimizeBtn_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            Login();
        }
        private void LoginBtn_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                Login();
                e.Handled = true;
            }
        }

        private void Login()
        {
            try
            {
                string userName = tboxUser.Texts.Trim();
                string password = tboxPassword.Texts.Trim();

                UserDTO userDto = _authService.Login(userName, password);
                
                string usuarioJson = JsonConvert.SerializeObject(userDto, Formatting.Indented);
                MessageBox.Show(usuarioJson, "Datos del Usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                OkMessage("Inicio de sesion exitoso");
                
                MainForm mainForm = new MainForm();
                mainForm.employeeName = userDto.EmployeeName;
                mainForm.userName = userDto.UserName;
                mainForm.rolName = userDto.RolName;
                mainForm.userId = userDto.CodUser;
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

        private void CloseBtn_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void MinimizeBtn_Click_1(object sender, EventArgs e){
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
