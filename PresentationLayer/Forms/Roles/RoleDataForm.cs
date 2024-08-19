using System;
using System.Windows.Forms;
using BusinessLayer.Exceptions;
using BusinessLayer.Services;
using BusinessLayer.Utilities;
using EntitiesLayer.Entities;

namespace PresentationLayer.Forms.Roles
{
    public partial class RoleDataForm : Form
    {
        public string operacion = "";
        public int idUsuario;
        public int idRol;
        private readonly RolService _rolService;

        public RoleDataForm(RolService rolService)
        {
            InitializeComponent();
            _rolService = rolService;
        }

        private void ClearForm()
        {
            tboxNombreRol.Clear();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ErrorMessage(string message)
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void OkMessage(string message)
        {
            MessageBox.Show(message, "Operación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                var rol = new Rol
                {
                    CodRol = operacion == "Actualizar"
                        ? idRol
                        : 0, // Asume que tboxCodRol es un TextBox para el ID del rol
                    NombreDeRol = TextTransformer.CapitalizeFirstLetter(tboxNombreRol.Texts.Trim())
                };

                if (operacion == "Insertar")
                {
                    _rolService.Insert(rol, idUsuario);
                    OkMessage("Rol registrado");
                    Close();
                }
                else if (operacion == "Actualizar")
                {
                    bool result = _rolService.Update(rol, idUsuario);
                    if (result)
                    {
                        OkMessage("Rol actualizado con éxito.");
                        Close();
                    }
                    else
                    {
                        ErrorMessage("No se pudo actualizar el rol.");
                    }
                }
                else
                {
                    ErrorMessage("Operación no válida.");
                }

                ClearForm();
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
    }
}