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
        public string operation = "";
        public int userId;
        public int rolId;
        private readonly RolService _rolService;

        public RoleDataForm(RolService rolService)
        {
            InitializeComponent();
            _rolService = rolService;
            this.Shown += new EventHandler(RoleDataForm_Shown);
        }
        
        private void SaveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                var rol = new Rol
                {
                    CodRol = operation == "Actualizar" ? rolId : 0, // Asume que tboxCodRol es un TextBox para el ID del rol
                    RolName = TextTransformer.CapitalizeFirstLetter(tboxRole.Texts.Trim())
                };

                if (operation == "Insertar")
                {
                    _rolService.Insert(rol, userId);
                    OkMessage("Rol registrado");
                    Close();
                }
                else if (operation == "Actualizar")
                {
                    bool result = _rolService.Update(rol, userId);
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
        
        private void ExitBtn_Click(object sender, EventArgs e)
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
        private void RoleDataForm_Shown(object sender, EventArgs e)
        {
            tboxRole.SetFocus();
        }
    }
}