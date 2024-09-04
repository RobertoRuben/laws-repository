using System;
using System.Windows.Forms;
using BusinessLayer.Services;
using DataLayer.Repositories;
using EntitiesLayer.Entities;
using PresentationLayer.Forms.Common;

namespace PresentationLayer.Forms.Roles
{
    public partial class RolListForm : Form
    {
        private MainForm mainForm; 
        private string operation = "";
        private RolService _rolService;
        public int userId;
        
        public RolListForm(MainForm main, IRepository<Rol> rolRepository)
        {
            InitializeComponent();
            _rolService = new RolService(rolRepository);
            this.mainForm = main;
            searchTbox.TextChanged += SearchTbox_TextChanged; 
            DataGridLoad();
            DataGridFormat();
        }
        
        private void AddBtn_Click(object sender, EventArgs e)
        {
            RolService rolService = new RolService(new RolRepository());
            RoleDataForm roleDataForm = new RoleDataForm(rolService);
            
            roleDataForm.operation = "Insertar";
            roleDataForm.lblSection.Text = "Registrar Rol";
            roleDataForm.userId = userId;
            this.mainForm.SetTransparency(true); 
            roleDataForm.ShowDialog();
            this.mainForm.SetTransparency(false); 
            DataGridLoad();
            
        }
        
        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            RolService rolService = new RolService(new RolRepository());
            RoleDataForm roleDataForm = new RoleDataForm(rolService);
            
            roleDataForm.operation = "Actualizar";
            roleDataForm.userId = userId;
            roleDataForm.lblSection.Text = "Actualizar Rol";
            roleDataForm.rolId = Convert.ToInt32(dgvRoles.CurrentRow.Cells[0].Value);
            roleDataForm.tboxRole.Texts = dgvRoles.CurrentRow.Cells[1].Value.ToString().Trim();
            this.mainForm.SetTransparency(true); 
            roleDataForm.ShowDialog();
            this.mainForm.SetTransparency(false); 
            DataGridLoad();
        }
        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (dgvRoles.CurrentRow != null)
            {
                int idRol = Convert.ToInt32(dgvRoles.CurrentRow.Cells[0].Value);
                DialogResult result = MessageBox.Show("¿Deseas eliminar este rol?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        bool isDeleted = _rolService.Delete(idRol, userId);
                        if (isDeleted)
                        {
                            OkMessage("Rol eliminado exitosamente.");
                            DataGridLoad();
                        }
                        else
                        {
                            ErrorMessage("Error al eliminar el rol.");
                        }
                    }
                    catch (Exception ex)
                    {
                        ErrorMessage("Error al eliminar el rol: " + ex.Message);
                    }
                }
            }
            else
            {
                ErrorMessage("Seleccione un rol para eliminar.");
            }
        }

        private void DataGridLoad()
        {
            dgvRoles.DataSource = _rolService.GetAll();
            lblResultados.Text = "Total de Registros: " + Convert.ToString(dgvRoles.Rows.Count);
        }
        private void DataGridFormat()
        {
            dgvRoles.Columns[0].HeaderText = "Id";
            dgvRoles.Columns[1].HeaderText = "Nombre del rol";
            dgvRoles.Columns[0].Width = 120;
        }
        private void SearchRol()
        {
            try
            {
                var roles = _rolService.FindBy(searchTbox.Texts.Trim());
                dgvRoles.DataSource = roles;
                lblResultados.Text = "Total de Registros: " + dgvRoles.RowCount;
            }
            catch (Exception e)
            {
                ErrorMessage(e.Message);
                searchTbox.Clear();
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
        private void SearchTbox_TextChanged(object sender, EventArgs e)
        {
            SearchRol();
        }
        private void ClearSearchBtn_Click(object sender, EventArgs e)
        {
            searchTbox.Clear();
        }
    }
}