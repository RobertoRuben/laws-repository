using System;
using System.Globalization;
using System.Windows.Forms;
using BusinessLayer.Services;
using DataLayer.Repositories;
using PresentationLayer.Forms.Article;
using PresentationLayer.Forms.Common;

namespace PresentationLayer.Forms.Laws
{
    public partial class LawsListForm : Form
    {
        private MainForm mainForm;
        private string operacion = "";
        public int idUsuario;
        private int currentPage = 1;
        private int pageSize = 20;

        public string module = "Registro";

        private LawService _lawService;

        public LawsListForm(MainForm main, ILawRepository lawRepository)
        {
            InitializeComponent();
            _lawService = new LawService(lawRepository);
            this.mainForm = main;
            searchTbox.TextChanged += searchTbox__TextChanged; 
            
            // Activar doble buffer
            SetDoubleBuffered(dgvLaws);
            
            CargarDataGrid();
            FormatoDataGrid();
        }

        public void CargarDataGrid(int pageNumber = 1)
        {
            currentPage = pageNumber;
            var laws = _lawService.GetAll(pageSize, pageNumber);

            dgvLaws.DataSource = laws;

            btnNext.Enabled = laws.Count == pageSize;

            lblResultados.Text = "Mostrando página: " + currentPage;
        }

        public void FormatoDataGrid()
        {
            dgvLaws.Columns[0].HeaderText = "Id";
            dgvLaws.Columns[1].HeaderText = "N° Norma";
            dgvLaws.Columns[2].HeaderText = "Nombre";
            dgvLaws.Columns[3].HeaderText = "Categoria";
            dgvLaws.Columns[4].HeaderText = "Resumen";
            dgvLaws.Columns[5].HeaderText = "F. Publicacion";
            dgvLaws.Columns[6].HeaderText = "N° Paginas";
            dgvLaws.Columns[7].HeaderText = "M. Publicación";
            dgvLaws.Columns[8].HeaderText = "Link";
            dgvLaws.Columns[9].HeaderText = "State";
            dgvLaws.Columns[10].HeaderText = "Path";

            dgvLaws.Columns[1].Width = 80;
            dgvLaws.Columns[2].Width = 160;
            dgvLaws.Columns[3].Width = 110;
            dgvLaws.Columns[5].Width = 80;
            dgvLaws.Columns[7].Width = 140;

            dgvLaws.Columns[0].Visible = false;
            dgvLaws.Columns[4].Visible = false;
            dgvLaws.Columns[6].Visible = false;
            dgvLaws.Columns[8].Visible = false;
            dgvLaws.Columns[9].Visible = false;
            dgvLaws.Columns[10].Visible = false;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            CargarDataGrid(currentPage + 1);
        }
        private void searchTbox__TextChanged(object sender, EventArgs e)
        {
            CategorySearch();
        }
        
        private void CategorySearch()
        {
            try
            {
                var law = _lawService.FindBy(searchTbox.Texts.Trim());
                dgvLaws.DataSource = law;
                lblResultados.Text = "Registros con coincidencia: " + dgvLaws.RowCount;
            }
            catch (Exception ex)
            {
                ErrorMessage(ex.Message);
                searchTbox.Clear();
            }
        }

        private void btnOpenDocument_Click(object sender, EventArgs e)
        {
            if (dgvLaws.CurrentRow != null)
            {
                var pathCell = dgvLaws.CurrentRow.Cells[10];

                if (pathCell != null && !string.IsNullOrEmpty(pathCell.Value?.ToString()))
                {
                    string path = pathCell.Value.ToString().Trim();
                    try
                    {
                        _lawService.OpenDocument(path);
                    }
                    catch (ArgumentException ex)
                    {
                        ErrorMessage(ex.Message);
                    }
                }
                else
                {
                    ErrorMessage("La ruta del documento no está disponible.");
                }
            }
            else
            {
                ErrorMessage("Por favor seleccione una fila antes de intentar abrir un documento.");
            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (currentPage > 1)
            {
                CargarDataGrid(currentPage - 1);
            }
        }

        private void ClearSearchBtn_Click(object sender, EventArgs e)
        {
            searchTbox.Clear();
        }

        private void ErrorMessage(string message)
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void OkMessage(string message)
        {
            MessageBox.Show(message, "Operación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            LawService lawService = new LawService(new LawRepository());
            CategoryService categoryService = new CategoryService(new CategoryRepository());
            LawsDataForm lawsDataForm = new LawsDataForm(lawService, categoryService);
            lawsDataForm.lblSection.Text = "Registrar Norma";
            lawsDataForm.operation = "Insertar";
            lawsDataForm.idUser = idUsuario;
            lawsDataForm.cboxPublicationMedium.SelectedIndex = 0;
            this.mainForm.SetTransparency(true);
            lawsDataForm.ShowDialog();
            CargarDataGrid();
            this.mainForm.SetTransparency(false);
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            LawService lawService = new LawService(new LawRepository());
            CategoryService categoryService = new CategoryService(new CategoryRepository());
            LawsDataForm lawsDataForm = new LawsDataForm(lawService, categoryService);
            lawsDataForm.lblSection.Text = "Actualizar Norma";
            lawsDataForm.operation = "Actualizar";
            lawsDataForm.idUser = idUsuario;
            lawsDataForm.idLaw = Convert.ToInt32(dgvLaws.CurrentRow.Cells[0].Value);

            //Cargar datos a componentes
            lawsDataForm.tboxNumberLaw.Texts = dgvLaws.CurrentRow.Cells[1].Value.ToString().Trim();
            lawsDataForm.tboxLawName.Texts = dgvLaws.CurrentRow.Cells[2].Value.ToString().Trim();
            lawsDataForm.cboxCategory.Texts = dgvLaws.CurrentRow.Cells[3].Value.ToString().Trim();
            lawsDataForm.tboxLawSummary.Texts = dgvLaws.CurrentRow.Cells[4].Value.ToString().Trim();
            lawsDataForm.tboxPublicationLink.Texts = dgvLaws.CurrentRow.Cells[8].Value.ToString().Trim();
            lawsDataForm.cboxPublicationMedium.Texts = dgvLaws.CurrentRow.Cells[7].Value.ToString().Trim();
            lawsDataForm.tboxPathArchive.Texts = dgvLaws.CurrentRow?.Cells[10]?.Value?.ToString().Trim() ?? "";
            lawsDataForm.numPaginas.Value = Convert.ToDecimal(dgvLaws.CurrentRow.Cells[6].Value.ToString().Trim());
            DateTime.TryParseExact(dgvLaws.CurrentRow?.Cells[5]?.Value?.ToString().Split(' ')[0], "dd/MM/yyyy",
                CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime dateValue);
            lawsDataForm.datePicker.Value = dateValue;

            string estado = dgvLaws.CurrentRow.Cells[9].Value.ToString();
            lawsDataForm.rbtnActive.Checked = estado == "Vigente";
            lawsDataForm.rbtnInactive.Checked = estado == "Derogada";

            //Mostrar y hacer transparente el fondo
            this.mainForm.SetTransparency(true);
            lawsDataForm.ShowDialog();
            CargarDataGrid();
            this.mainForm.SetTransparency(false);
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (dgvLaws.CurrentRow != null)
            {
                int idLaw = Convert.ToInt32(dgvLaws.CurrentRow.Cells[0].Value);
                DialogResult result = MessageBox.Show("¿Deseas eliminar esta norma?", "Confirmación",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        bool isDeleted = _lawService.Delete(idLaw, idUsuario);
                        if (isDeleted)
                        {
                            OkMessage("Norma eliminada exitosamente.");
                            CargarDataGrid();
                        }
                        else
                        {
                            ErrorMessage("Error al eliminar la norma.");
                        }
                    }
                    catch (Exception ex)
                    {
                        ErrorMessage("Error al eliminar el la norma: " + ex.Message);
                    }
                }
            }
            else
            {
                ErrorMessage("Seleccione un trabajador para eliminar.");
            }
        }

        private void AddArticleBtn_Click(object sender, EventArgs e)
        {
            
            if (dgvLaws.CurrentRow != null)
            {
                LawService lawService = new LawService(new LawRepository());
                CategoryService categoryService = new CategoryService(new CategoryRepository());
                LawsDataForm lawsDataForm = new LawsDataForm(lawService, categoryService);
                

                ArticleService articleService = new ArticleService(new ArticleRepository());
                ArticleListForm articleListForm = new ArticleListForm(articleService);
                articleListForm.module = module;
                Console.WriteLine("Operacion del modulo: " + articleListForm.module);
                if (articleListForm.module.Equals("Consultas"))
                {
                    articleListForm.UpdateBtn.Visible = false;
                    articleListForm.AddBtn.Visible = false;  // Oculta el botón "Actualizar"
                    articleListForm.DeleteBtn.Visible = false;  // Oculta el botón "Eliminar"
                    articleListForm.DetailsBtn.Visible = true;
                }
                else
                {
                    articleListForm.UpdateBtn.Visible = true;
                    articleListForm.AddBtn.Visible = true;
                    articleListForm.DeleteBtn.Visible = true;
                }
                articleListForm.idUsuario = idUsuario;
                articleListForm.lawCode = Convert.ToInt32(dgvLaws.CurrentRow.Cells[0].Value);

                string lawNumber = lawsDataForm.tboxNumberLaw.Texts = dgvLaws.CurrentRow.Cells[1].Value.ToString().Trim();
            
                string lawName = lawsDataForm.tboxLawName.Texts = dgvLaws.CurrentRow.Cells[2].Value.ToString().Trim();
            

                articleListForm.lblSection.Text = "Norma N° " + lawNumber + " - " + lawName;

                //Mostrar y hacer transparente el fondo
                this.mainForm.SetTransparency(true);
                articleListForm.ShowDialog();
                this.mainForm.SetTransparency(false);
            }
            else
            {
                ErrorMessage("Debese seleccionar una norma antes de registrar articulos");
            }

        }
        private void DetailsBtn_Click(object sender, EventArgs e)
        {
            LawService lawService = new LawService(new LawRepository());
            CategoryService categoryService = new CategoryService(new CategoryRepository());
            LawsDataForm lawsDataForm = new LawsDataForm(lawService, categoryService);
            
            lawsDataForm.lblSection.Text = "Datos de la Norma";
            lawsDataForm.idUser = idUsuario;
            lawsDataForm.idLaw = Convert.ToInt32(dgvLaws.CurrentRow.Cells[0].Value);

            lawsDataForm.tboxNumberLaw.Texts = dgvLaws.CurrentRow.Cells[1].Value.ToString().Trim();
            lawsDataForm.tboxLawName.Texts = dgvLaws.CurrentRow.Cells[2].Value.ToString().Trim();
            lawsDataForm.cboxCategory.Texts = dgvLaws.CurrentRow.Cells[3].Value.ToString().Trim();
            lawsDataForm.tboxLawSummary.Texts = dgvLaws.CurrentRow.Cells[4].Value.ToString().Trim();
            lawsDataForm.tboxPublicationLink.Texts = dgvLaws.CurrentRow.Cells[8].Value.ToString().Trim();
            lawsDataForm.cboxPublicationMedium.Texts = dgvLaws.CurrentRow.Cells[7].Value.ToString().Trim();
            lawsDataForm.tboxPathArchive.Texts = dgvLaws.CurrentRow?.Cells[10]?.Value?.ToString().Trim() ?? "";
            lawsDataForm.numPaginas.Value = Convert.ToDecimal(dgvLaws.CurrentRow.Cells[6].Value.ToString().Trim());
            DateTime.TryParseExact(dgvLaws.CurrentRow?.Cells[5]?.Value?.ToString().Split(' ')[0], "dd/MM/yyyy",
                CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime dateValue);
            lawsDataForm.datePicker.Value = dateValue;

            string estado = dgvLaws.CurrentRow.Cells[9].Value.ToString();
            lawsDataForm.rbtnActive.Checked = estado == "Vigente";
            lawsDataForm.rbtnInactive.Checked = estado == "Derogada";

            lawsDataForm.tboxNumberLaw.ReadOnly = true;
            lawsDataForm.tboxLawName.ReadOnly = true;
            lawsDataForm.cboxCategory.Enabled = false;
            lawsDataForm.tboxLawSummary.ReadOnly = true;
            lawsDataForm.tboxPublicationLink.ReadOnly = true;
            lawsDataForm.cboxPublicationMedium.Enabled = false;
            lawsDataForm.tboxPathArchive.ReadOnly = true;
            lawsDataForm.numPaginas.Enabled = false;
            lawsDataForm.rbtnActive.Enabled = false;
            lawsDataForm.rbtnInactive.Enabled = false;
            lawsDataForm.btnLoadDocument.Visible = false;
            lawsDataForm.datePicker.Enabled = true;

            lawsDataForm.btnSave.Visible = false;

            //Mostrar y hacer transparente el fondo
            this.mainForm.SetTransparency(true);
            lawsDataForm.ShowDialog();
            CargarDataGrid();
            this.mainForm.SetTransparency(false);
        }

        private void dgvLaws_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            LawService lawService = new LawService(new LawRepository());
            CategoryService categoryService = new CategoryService(new CategoryRepository());
            LawsDataForm lawsDataForm = new LawsDataForm(lawService, categoryService);
            
            lawsDataForm.lblSection.Text = "Datos de la Norma";
            lawsDataForm.idUser = idUsuario;
            lawsDataForm.idLaw = Convert.ToInt32(dgvLaws.CurrentRow.Cells[0].Value);

            lawsDataForm.tboxNumberLaw.Texts = dgvLaws.CurrentRow.Cells[1].Value.ToString().Trim();
            lawsDataForm.tboxLawName.Texts = dgvLaws.CurrentRow.Cells[2].Value.ToString().Trim();
            lawsDataForm.cboxCategory.Texts = dgvLaws.CurrentRow.Cells[3].Value.ToString().Trim();
            lawsDataForm.tboxLawSummary.Texts = dgvLaws.CurrentRow.Cells[4].Value.ToString().Trim();
            lawsDataForm.tboxPublicationLink.Texts = dgvLaws.CurrentRow.Cells[8].Value.ToString().Trim();
            lawsDataForm.cboxPublicationMedium.Texts = dgvLaws.CurrentRow.Cells[7].Value.ToString().Trim();
            lawsDataForm.tboxPathArchive.Texts = dgvLaws.CurrentRow?.Cells[10]?.Value?.ToString().Trim() ?? "";
            lawsDataForm.numPaginas.Value = Convert.ToDecimal(dgvLaws.CurrentRow.Cells[6].Value.ToString().Trim());
            DateTime.TryParseExact(dgvLaws.CurrentRow?.Cells[5]?.Value?.ToString().Split(' ')[0], "dd/MM/yyyy",
                CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime dateValue);
            lawsDataForm.datePicker.Value = dateValue;

            string estado = dgvLaws.CurrentRow.Cells[9].Value.ToString();
            lawsDataForm.rbtnActive.Checked = estado == "Vigente";
            lawsDataForm.rbtnInactive.Checked = estado == "Derogada";

            lawsDataForm.tboxNumberLaw.ReadOnly = true;
            lawsDataForm.tboxLawName.ReadOnly = true;
            lawsDataForm.cboxCategory.Enabled = false;
            lawsDataForm.tboxLawSummary.ReadOnly = true;
            lawsDataForm.tboxPublicationLink.ReadOnly = true;
            lawsDataForm.cboxPublicationMedium.Enabled = false;
            lawsDataForm.tboxPathArchive.ReadOnly = true;
            lawsDataForm.numPaginas.Enabled = false;
            lawsDataForm.rbtnActive.Enabled = false;
            lawsDataForm.rbtnInactive.Enabled = false;
            lawsDataForm.btnLoadDocument.Visible = false;
            lawsDataForm.datePicker.Enabled = true;

            lawsDataForm.btnSave.Visible = false;

            //Mostrar y hacer transparente el fondo
            this.mainForm.SetTransparency(true);
            lawsDataForm.ShowDialog();
            CargarDataGrid();
            this.mainForm.SetTransparency(false);
        }
        
        // Método para activar el doble buffer en un control
        private static void SetDoubleBuffered(Control control)
        {
            // Obtener tipo y propiedad de control
            Type dgvType = control.GetType();
            System.Reflection.PropertyInfo pi = dgvType.GetProperty("DoubleBuffered", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic);
    
            // Establecer la propiedad DoubleBuffered en true
            pi.SetValue(control, true, null);
        }
        
    }
}