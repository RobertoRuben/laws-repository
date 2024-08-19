using System;
using System.Windows.Forms;
using BusinessLayer.Exceptions;
using BusinessLayer.Services;
using BusinessLayer.Utilities;
using EntitiesLayer.Entities;

namespace Presentacion.Formularios.CategoriaNormas
{
    public partial class CategoryDataForm : Form
    {
        public string operacion = "";
        public int idUsuario;
        public int idCategoria;

        private readonly CategoryService _categoryService;

        public CategoryDataForm(CategoryService categoryService)
        {
            InitializeComponent();
            _categoryService = categoryService;
        }

        private void ClearForm()
        {
            tboxNombreRol.Clear();
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
                var category = new CategoriaDeNorma
                {
                    CodTipoNorma = operacion == "Actualizar" ? idCategoria : 0, // Asume que tboxCodRol es un TextBox para el ID del rol
                    TipoDeNorma = TextTransformer.CapitalizeFirstLetter(tboxNombreRol.Texts.Trim())
                };

                if (operacion == "Insertar")
                {
                    _categoryService.Insert(category, idUsuario);
                    OkMessage("Categoria de Norma registrada");
                    Close();
                }
                else if (operacion == "Actualizar")
                {
                    bool result = _categoryService.Update(category, idUsuario);
                    if (result)
                    {
                        OkMessage("Categoria actualizada con éxito.");
                        Close();
                    }
                    else
                    {
                        ErrorMessage("No se pudo actualizar la categoria.");
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

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
