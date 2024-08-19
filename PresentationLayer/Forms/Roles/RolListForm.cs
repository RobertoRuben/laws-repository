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
        private string operacion = "";
        private RolService _rolService;
        public int idUsuario;
        
        public RolListForm(MainForm main, IRepository<Rol> rolRepository)
        {
            InitializeComponent();
            _rolService = new RolService(rolRepository);
            this.mainForm = main;
            tboxBusqueda.TextChanged += tboxBusqueda_TextChanged; 
            CargarDataGrid();
            FormatoDataGrid();
        }
        
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            RolService rolService = new RolService(new RolRepository());
            RoleDataForm roleDataForm = new RoleDataForm(rolService);
            
            roleDataForm.operacion = "Insertar";
            roleDataForm.idUsuario = idUsuario;
            roleDataForm.idRol = Convert.ToInt32(dgvRoles.CurrentRow.Cells[0].Value);
            this.mainForm.SetTransparency(true); 
            roleDataForm.ShowDialog();
            this.mainForm.SetTransparency(false); 
            CargarDataGrid();
            
        }
        
        private void btnModificar_Click(object sender, EventArgs e)
        {
            RolService rolService = new RolService(new RolRepository());
            RoleDataForm roleDataForm = new RoleDataForm(rolService);
            
            roleDataForm.operacion = "Actualizar";
            roleDataForm.idUsuario = idUsuario;
            roleDataForm.tboxNombreRol.Texts = dgvRoles.CurrentRow.Cells[1].Value.ToString().Trim();
            this.mainForm.SetTransparency(true); 
            roleDataForm.ShowDialog();
            this.mainForm.SetTransparency(false); 
            CargarDataGrid();
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvRoles.CurrentRow != null)
            {
                int idRol = Convert.ToInt32(dgvRoles.CurrentRow.Cells[0].Value);
                DialogResult result = MessageBox.Show("¿Deseas eliminar este rol?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        bool isDeleted = _rolService.Delete(idRol, idUsuario);
                        if (isDeleted)
                        {
                            OkMessage("Rol eliminado exitosamente.");
                            CargarDataGrid(); // Recarga la lista para reflejar la eliminación
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

        private void CargarDataGrid()
        {
            dgvRoles.DataSource = _rolService.GetAll();
            lblResultados.Text = "Total de Registros: " + Convert.ToString(dgvRoles.Rows.Count);
        }
        private void FormatoDataGrid()
        {
            dgvRoles.Columns[0].HeaderText = "Id";
            dgvRoles.Columns[1].HeaderText = "Nombre del rol";
            dgvRoles.Columns[0].Width = 120;
        }
        private void BuscarRoles()
        {
            try
            {
                var roles = _rolService.FindBy(tboxBusqueda.Texts.Trim());
                dgvRoles.DataSource = roles;
                lblResultados.Text = "Total de Registros: " + dgvRoles.RowCount;
            }
            catch (Exception e)
            {
                ErrorMessage(e.Message);
                tboxBusqueda.Clear();
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
        private void tboxBusqueda_TextChanged(object sender, EventArgs e)
        {
            BuscarRoles();
        }
    }
}