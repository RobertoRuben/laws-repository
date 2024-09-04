using System;
using System.Windows.Forms;
using BusinessLayer.Services;
using DataLayer.Repositories;
using EntitiesLayer.Entities;
using PresentationLayer.Forms.Common;

namespace Presentacion.Formularios.CategoriaNormas
{
    public partial class CategoryListForm : Form
    {
        private MainForm mainForm;
        public string operacion="";
        private CategoryService _categoryService;
        public int idUsuario;

        public CategoryListForm(MainForm main, IRepository<CategoryLaw> categoryRepository)
        {
            InitializeComponent();
            _categoryService = new CategoryService(categoryRepository);
            this.mainForm = main;
            tboxBusqueda.TextChanged += tboxBusqueda_TextChanged; 
            CargarDataGrid();
            FormatoDataGrid();
        }

        private void CargarDataGrid()
        {
            dgvCategoriaNormas.DataSource = _categoryService.GetAll();
            lblResultados.Text = "Total de Registros: " + Convert.ToString(dgvCategoriaNormas.Rows.Count);
        }
        
        private void FormatoDataGrid()
        {
            dgvCategoriaNormas.Columns[0].HeaderText = "Id";
            dgvCategoriaNormas.Columns[1].HeaderText = "Nombre de la categoría";
            dgvCategoriaNormas.Columns[0].Width = 120;
        }
        
        private void BuscarCategoria()
        {
            try
            {
                var category = _categoryService.FindBy(tboxBusqueda.Texts.Trim());
                dgvCategoriaNormas.DataSource = category;
                lblResultados.Text = "Total de Registros: " + dgvCategoriaNormas.RowCount;
            }
            catch (Exception e)
            {
                ErrorMessage(e.Message);
                tboxBusqueda.Clear();
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

        private void tboxBusqueda_TextChanged(object sender, EventArgs e)
        {
            BuscarCategoria();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            CategoryService categoryService = new CategoryService(new CategoryRepository());
            CategoryDataForm categoryDataForm = new CategoryDataForm(categoryService);
            
            categoryDataForm.operacion = "Insertar";
            categoryDataForm.lblSection.Text = "Registrar nueva categoría";
            categoryDataForm.idUsuario = idUsuario;
            categoryDataForm.idCategoria = Convert.ToInt32(dgvCategoriaNormas.CurrentRow.Cells[0].Value);
            this.mainForm.SetTransparency(true); 
            categoryDataForm.ShowDialog();
            CargarDataGrid();
            this.mainForm.SetTransparency(false); 
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            CategoryService categoryService = new CategoryService(new CategoryRepository());
            CategoryDataForm categoryDataForm = new CategoryDataForm(categoryService);
            
            categoryDataForm.operacion = "Actualizar";
            categoryDataForm.lblSection.Text = "Actualizar datos de categoría";
            categoryDataForm.idUsuario = idUsuario;
            categoryDataForm.tboxCategoryName.Texts = dgvCategoriaNormas.CurrentRow.Cells[1].Value.ToString().Trim();
            this.mainForm.SetTransparency(true); 
            categoryDataForm.ShowDialog();
            CargarDataGrid();
            this.mainForm.SetTransparency(false); 
            
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvCategoriaNormas.CurrentRow != null)
            {
                int idCategoria = Convert.ToInt32(dgvCategoriaNormas.CurrentRow.Cells[0].Value);
                DialogResult result = MessageBox.Show("¿Deseas eliminar esta categoría de norma?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        bool isDeleted = _categoryService.Delete(idCategoria, idUsuario);
                        if (isDeleted)
                        {
                            OkMessage("Categoria eliminada exitosamente.");
                            CargarDataGrid(); 
                        }
                        else
                        {
                            ErrorMessage("Error al eliminar la categoria de norma.");
                        }
                    }
                    catch (Exception ex)
                    {
                        ErrorMessage("Error al eliminar el la categoria: " + ex.Message);
                    }
                }
            }
            else
            {
                ErrorMessage("Seleccione un categoria para eliminar.");
            }
        }

        private void btnLimpiarBusqueda_Click(object sender, EventArgs e)
        {
            tboxBusqueda.Clear();
        }
    }
}
