using System;
using System.Windows.Forms;
using BusinessLayer.Services;
using DataLayer.Repositories;

namespace PresentationLayer.Forms.Article
{
    public partial class ArticleListForm : Form
    {
        public int lawCode;
        private string operation = "";
        public int idUsuario;
        public string module = "";

        private ArticleService _articleService;

        private int currentPage = 1;
        private int pageSize = 20;

        public ArticleListForm(ArticleService articleService)
        {
            _articleService = articleService;
            InitializeComponent();
            searchTbox.TextChanged += searchTbox__TextChanged;
            
        }
        

        // Método para cargar los datos en el DataGridView
        private void DataGridLoad(int pageNumber = 1)
        {
            currentPage = pageNumber;
            var article = _articleService.GetAll(lawCode, pageSize, pageNumber);

            dgvArticles.DataSource = article;

            btnNext.Enabled = article.Count == pageSize;

            lblResultados.Text = "Mostrando página: " + currentPage;
        }

        private void DataGridFormat()
        {
            dgvArticles.Columns[0].HeaderText = "Id";
            dgvArticles.Columns[1].HeaderText = "Id Norma";
            dgvArticles.Columns[2].HeaderText = "N° Articulo";
            dgvArticles.Columns[3].HeaderText = "Denominacion";
            dgvArticles.Columns[4].HeaderText = "Descripcion";
            dgvArticles.Columns[5].HeaderText = "Pagina";
            dgvArticles.Columns[6].HeaderText = "Estado";

            dgvArticles.Columns[0].Visible = false;
            dgvArticles.Columns[1].Visible = false;
            dgvArticles.Columns[4].Visible = false;

            dgvArticles.Columns[2].Width = 160;
            dgvArticles.Columns[3].Width = 520;
        }

        // Evento de cierre
        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            DataGridLoad(currentPage + 1);
            DataGridFormat();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (currentPage > 1)
            {
                DataGridLoad(currentPage - 1);
                DataGridFormat();
            }
        }

        private void ArticleListForm_Load(object sender, EventArgs e)
        {
            DataGridLoad();
            DataGridFormat();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            ArticleService articleService = new ArticleService(new ArticleRepository());
            ArticleDataForm articleDataForm = new ArticleDataForm(articleService);

            articleDataForm.operation = "Insertar";
            articleDataForm.idUser = idUsuario;
            articleDataForm.lawCod = lawCode;
            articleDataForm.ShowDialog();
            DataGridLoad();
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            ArticleService articleService = new ArticleService(new ArticleRepository());
            ArticleDataForm articleDataForm = new ArticleDataForm(articleService);

            articleDataForm.operation = "Actualizar";
            articleDataForm.idArticle = Convert.ToInt32(dgvArticles.CurrentRow.Cells[1].Value);
            articleDataForm.idUser = idUsuario;
            articleDataForm.lawCod = lawCode;

            articleDataForm.tbxoArticleNumber.Texts = dgvArticles.CurrentRow.Cells[2].Value.ToString().Trim();
            articleDataForm.tboxArticleDenominartion.Texts = dgvArticles.CurrentRow.Cells[3].Value.ToString().Trim();
            articleDataForm.tboxDescription.Texts = dgvArticles.CurrentRow.Cells[4].Value.ToString().Trim();
            articleDataForm.numPaginas.Value =
                Convert.ToDecimal(dgvArticles.CurrentRow.Cells[5].Value.ToString().Trim());

            string estado = dgvArticles.CurrentRow.Cells[6].Value.ToString();
            articleDataForm.rbtnActive.Checked = estado == "Vigente";
            articleDataForm.rbtnInactive.Checked = estado == "Derogada";
            articleDataForm.ShowDialog();
            DataGridLoad();
        }

        private void SearchArticle()
        {
            try
            {
                var article = _articleService.FindBy(lawCode, searchTbox.Texts.ToString());
                dgvArticles.DataSource = article;
                lblResultados.Text = "Total de Registros: " + dgvArticles.RowCount;
            }
            catch (Exception e)
            {
                ErrorMessage(e.Message);
                searchTbox.Clear();
            }
        }

        private void ErrorMessage(string mensaje)
        {
            MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void OkMessage(string mensaje)
        {
            MessageBox.Show(mensaje, "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void searchTbox__TextChanged(object sender, EventArgs e)
        {
            SearchArticle();
        }

        private void btnLimpiarBusqueda_Click(object sender, EventArgs e)
        {
            searchTbox.Clear();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            
            if (dgvArticles.CurrentRow != null)
            {
                int idArticle = Convert.ToInt32(dgvArticles.CurrentRow.Cells[0].Value);
                Console.WriteLine("Id articulo: " + idArticle);
                Console.WriteLine("Id usuario: " + idUsuario);

                DialogResult result = MessageBox.Show("¿Deseas eliminar esta articulo?", "Confirmación",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        bool isDeleted = _articleService.Delete(idArticle, idUsuario);
                        if (isDeleted)
                        {
                            OkMessage("Norma eliminada exitosamente.");
                            DataGridLoad();
                            DataGridFormat();
                        }
                        else
                        {
                            ErrorMessage("Error al eliminar el articulo.");
                        }
                    }
                    catch (Exception ex)
                    {
                        //ErrorMessage("Error del sistema al eliminar el articlo: " + ex.Message);
                        string errorMessage = $"Error del sistema al eliminar el artículo: {ex.Message}\n\n" +
                                              $"Detalles de la excepción:\n" +
                                              $"{ex.StackTrace}";
                        ErrorMessage(errorMessage);
                    }
                }
            }
            else
            {
                ErrorMessage("Debes seleccionar un articulo para eliminar.");
                
            }
        }

        private void DetailsBtn_Click(object sender, EventArgs e)
        {
            ArticleService articleService = new ArticleService(new ArticleRepository());
            ArticleDataForm articleDataForm = new ArticleDataForm(articleService);

            articleDataForm.operation = "Actualizar";
            articleDataForm.idArticle = Convert.ToInt32(dgvArticles.CurrentRow.Cells[1].Value);
            articleDataForm.idUser = idUsuario;
            articleDataForm.lawCod = lawCode;

            articleDataForm.tbxoArticleNumber.Texts = dgvArticles.CurrentRow.Cells[2].Value.ToString().Trim();
            articleDataForm.tboxArticleDenominartion.Texts = dgvArticles.CurrentRow.Cells[3].Value.ToString().Trim();
            articleDataForm.tboxDescription.Texts = dgvArticles.CurrentRow.Cells[4].Value.ToString().Trim();
            articleDataForm.numPaginas.Value =
                Convert.ToDecimal(dgvArticles.CurrentRow.Cells[5].Value.ToString().Trim());

            string estado = dgvArticles.CurrentRow.Cells[6].Value.ToString();
            articleDataForm.rbtnActive.Checked = estado == "Vigente";
            articleDataForm.rbtnInactive.Checked = estado == "Derogada";

            articleDataForm.btnSave.Visible = false;

            articleDataForm.tbxoArticleNumber.ReadOnly = true;
            articleDataForm.tboxArticleDenominartion.ReadOnly = true;
            articleDataForm.tboxDescription.ReadOnly = true;
            articleDataForm.numPaginas.ReadOnly = true;
            articleDataForm.rbtnActive.Enabled = false;
            articleDataForm.rbtnInactive.Enabled = false;
            
            articleDataForm.ShowDialog();
        }
    }
}