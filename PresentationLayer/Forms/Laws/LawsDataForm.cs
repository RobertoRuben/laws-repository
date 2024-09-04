using System;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using BusinessLayer.Exceptions;
using BusinessLayer.Services;
using BusinessLayer.Utilities;
using EntitiesLayer.Entities;

namespace PresentationLayer.Forms.Laws
{
    public partial class LawsDataForm : Form
    {
        public string operation = "";
        public int idUser;
        public int idLaw;
        private string serverPath = @"\\192.168.10.12\prueba\normatividad";

        private readonly LawService _lawService;
        private readonly CategoryService _categoryService;

        public LawsDataForm(LawService lawService, CategoryService categoryService)
        {
            InitializeComponent();
            SetDoubleBuffered(this);
            _lawService = lawService;
            _categoryService = categoryService;
            LoadCategory();
            
            this.Shown += new EventHandler(LawsDataForm_Shown);
        }

        private void btnLoadDocument_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = "c:\\";
            openFileDialog.Filter = "Todos los archivos (*.*)|*.*";
            openFileDialog.RestoreDirectory = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                tboxPathArchive.Texts = openFileDialog.FileName;
            }
            else
            {
                WarningMessage("No se seleccionó ningún archivo.");
            }
        }

        private void LoadCategory()
        {
            try
            {
                cboxCategory.DataSource = _categoryService.GetAll();
                cboxCategory.DisplayMember = "CategoryName";
                cboxCategory.ValueMember = "CodCategory";
                cboxCategory.Texts = "Seleccione la Categoria";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                var laws = new Law
                {
                    CodLaw = operation == "Actualizar" ? idLaw : 0,
                    CodUser = idUser,
                    CodCategory = (int)cboxCategory.SelectedValue,
                    LawNumber = Convert.ToString(tboxNumberLaw.Texts.Trim()),
                    LawName = tboxLawName.Texts.Trim(),
                    LawSummary = tboxLawSummary.Texts.Trim(),
                    PublicationDate = datePicker.Value.ToString().Trim(),
                    PageNumber = Convert.ToInt32(numPaginas.Value),
                    PublicationMedium = cboxPublicationMedium.Texts.Trim(),
                    PublicationLink = tboxPublicationLink.Texts.Trim(),
                    State = rbtnActive.Checked ? "Vigente" : rbtnInactive.Checked ? "Derogado" : null,
                    PathArchive = tboxPathArchive.Texts.Trim()
                };
                
                Console.WriteLine("userId: "+laws.CodUser);
                Console.WriteLine("CategoryId: "+laws.CodCategory);
                
                if (operation.Equals("Insertar"))
                {
                    _lawService.Insert(laws, idUser);
                    OkMessage("Norma registrada");
                    Close();
                }
                else if (operation.Equals("Actualizar"))
                {
                    bool result = _lawService.Update(laws, idUser);
                    if (result)
                    {
                        OkMessage("Norma actualizada con éxito.");
                        Close();
                    }
                    else
                    {
                        ErrorMessage("No se pudo actualizar los datos de la norma.");
                    }
                }
                else
                {
                    ErrorMessage("Operacion invalida");
                }

                //ClearForm();
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

        private void ErrorMessage(string message)
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void OkMessage(string message)
        {
            MessageBox.Show(message, "Operación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        
        private void WarningMessage(string message)
        {
            MessageBox.Show(message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        
        private void LawsDataForm_Shown(object sender, EventArgs e)
        {
            tboxNumberLaw.SetFocus();
        }
        private static void SetDoubleBuffered(Control control)
        {
            // Usando reflexión para obtener acceso a la propiedad DoubleBuffered
            PropertyInfo propInfo = typeof(Control).GetProperty("DoubleBuffered", BindingFlags.Instance | BindingFlags.NonPublic);
            propInfo.SetValue(control, true, null);

            // Aplicar a todos los controles anidados
            foreach (Control ctrl in control.Controls)
            {
                SetDoubleBuffered(ctrl);
            }
        }
    }
}