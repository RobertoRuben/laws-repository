using System;
using System.Windows.Forms;
using BusinessLayer.Exceptions;
using BusinessLayer.Services;
using DataLayer.Repositories;
using EntitiesLayer.Entities;
using PresentationLayer.Forms.Common;

namespace PresentationLayer.Forms.User
{
    public partial class UserUpdateCredentials : Form
    {
        public int idUsuario;
        private  AuthService _authService;
        public UserUpdateCredentials(IUsuarioRepository userRepository)
        {
            InitializeComponent();
            _authService = new AuthService(userRepository);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (idUsuario!=0)
            {
                try
                {
                    var user = new Usuario()
                    {
                        Contraseña = tboxContraseña.Texts.Trim(),
                    };

                    _authService.UpdateCredentials(idUsuario, user);
                    OkMessage("Contraseña actualizada");
                    Close();
                }
                catch (ValidationException ex)
                {
                    ErrorMessage($"Error de validación: {ex.Message}");
                }
                catch (BusinessException ex)
                {
                    ErrorMessage($"Error de negocio: {ex.Message}");
                }
                catch (Exception ex)
                {
                    ErrorMessage($"Error inesperado: {ex.Message}");
                }
            }
            else
            {
                ErrorMessage("No se esta obteniendo el id del usuario");
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