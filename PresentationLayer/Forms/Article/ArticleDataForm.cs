using System;
using System.Windows.Forms;
using BusinessLayer.Exceptions;
using BusinessLayer.Services;
using EntitiesLayer.Entities;

namespace PresentationLayer.Forms.Article
{
    public partial class ArticleDataForm : Form
    {
        public string operation = "";
        public int lawCod;
        public int idUser;
        public int idArticle;

        private readonly ArticleService _articleService;
        
        public ArticleDataForm(ArticleService articleService)
        {
            InitializeComponent();
            _articleService = articleService;

            this.Shown += new EventHandler(ArticleDataForm_Show);
        }
        private void ErrorMessage(string message)
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void OkMessage(string message)
        {
            MessageBox.Show(message, "Operación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ArticleDataForm_Show(object sender, EventArgs e)
        {
            tbxoArticleNumber.SetFocus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Console.WriteLine("id: " + idUser);
            Console.WriteLine("Operacion: " + operation);
            Console.WriteLine("id norma: " + lawCod);
            try
            {
                var article = new EntitiesLayer.Entities.Article()
                {
                    CodArticle = operation == "Actualizar" ? idArticle : 0,
                    CodLaw = lawCod,
                    ArticleNumber = Convert.ToInt32(tbxoArticleNumber.Texts.Trim()),
                    Denomination = tboxArticleDenominartion.Texts.Trim(),
                    Description = tboxDescription.Texts.Trim(),
                    PageNumber = Convert.ToInt32(numPaginas.Value),
                    State = rbtnActive.Checked ? "Vigente" : rbtnInactive.Checked ? "Derogado" : null
                };

                if (operation.Equals("Insertar"))
                {
                    _articleService.Insert(article, idUser);
                    OkMessage("Articulo registrado");
                    Close();
                }
                else if (operation.Equals("Actualizar"))
                {
                    bool result = _articleService.Update(article, idUser);
                    if (result)
                    {
                        OkMessage("Articulo actualizado con exito");
                        Close();
                    }
                    else
                    {
                        ErrorMessage("No se pudo actualizar el articulo");
                    }
                }
                else
                {
                    ErrorMessage("Operacion no valida");
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

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}