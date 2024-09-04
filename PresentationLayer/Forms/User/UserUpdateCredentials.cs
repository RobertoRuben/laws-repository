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
        public int userId;
        private  AuthService _authService;
        public UserUpdateCredentials(IUserRepository userRepository)
        {
            InitializeComponent();
            _authService = new AuthService(userRepository);
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (userId!=0)
            {
                if (!String.IsNullOrWhiteSpace(tboxPassword.Texts.Trim()))
                {
                    try
                    {
                        var user = new EntitiesLayer.Entities.User()
                        {
                            Password = tboxPassword.Texts.Trim(),
                        };

                        if (user.Password.Equals(tboxConfirmPassword.Texts))
                        {
                            _authService.UpdateCredentials(userId, user);
                            OkMessage("Contraseña actualizada actualizada");
                            Close();
                        }
                        else
                        {
                            ErrorMessage("La contraseña no coincide");
                        }
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
                    ErrorMessage("No se puede actualizar credenciales porque el campo contraseña no puede quedar en blanco");
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