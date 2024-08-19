using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using FontAwesome.Sharp;
using System.Drawing;
using DataLayer.Repositories;
using EntitiesLayer.Entities;
using Presentacion.Formularios.CategoriaNormas;
using PresentationLayer.Forms.Employee;
using PresentationLayer.Forms.Roles;
namespace PresentationLayer.Forms.Common
{
    public partial class MainForm : Form
    {
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form formularioHijoActual;
        
        public string nombreTrabajador;
        public string nombreUsuario;
        public string nombreRol;

        public int idUsuario;

        public MainForm()
        {
            InitializeComponent();
            PersonalizarDiseño();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 45);
            pMenu.Controls.Add(leftBorderBtn);

            this.ControlBox = false;
            //Ocultar barra de titulo
            this.Text = string.Empty;

            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            lblMainForm.Text = "Bienvenido " + nombreTrabajador;
            lblNombreUsuario.Text = nombreUsuario;
            lblNombreRol.Text = nombreRol;
        }

        private void PersonalizarDiseño()
        {
            subMenuUsuarios.Visible = false;
           // subMenuVentas.Visible = false;
            subMenuNormas.Visible = false;
        }

        private void OcultarSubMenu()
        {
            if (subMenuUsuarios.Visible == true)
            {
                subMenuUsuarios.Visible = false;
            }
            
            if (subMenuNormas.Visible == true)
            {
                subMenuNormas.Visible = false;
            }
        }

        private void MostrarSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                OcultarSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }

        private struct RGBColors
        {
            public static Color color = Color.FromArgb(2, 168, 86);
            public static Color color2 = Color.FromArgb(200, 241, 51, 51);
        }

        //Methods
        private void ActivateButton(object senderBtn, Color color)
        {
            DisableButton();
            if (senderBtn != null)
            {
                //Button
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(26, 32, 36);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                //Left border button
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
            }
        }

        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(26, 32, 36);
                currentBtn.ForeColor = Color.White;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.White;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }
        //Botones
        private void btnConsultas_Click(object sender, EventArgs e)
        {
            lblMainForm.Text = "Consulta de Normas";
            ActivateButton(sender, RGBColors.color);
            OcultarSubMenu();
        }

        private void btnNormas_Click(object sender, EventArgs e)
        {
            lblMainForm.Text = "Gestión de Normas";
            MostrarSubMenu(subMenuNormas);
            ActivateButton(sender, RGBColors.color);
        }

        private void btnCategorias_Click(object sender, EventArgs e)
        {
            lblMainForm.Text = "Gestión de Categorías";
            IRepository<CategoriaDeNorma> categoryRepository = new CategoriaRepository();
            CategoryListForm categoryListForm = new CategoryListForm(main: this, categoryRepository);
            categoryListForm.idUsuario = idUsuario;
            AbrirFormularioHijo(categoryListForm);
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            lblMainForm.Text = "Gestión de Usuarios";
            MostrarSubMenu(subMenuUsuarios);
            ActivateButton(sender, RGBColors.color);
        }
        private void btnTrabajadores_Click(object sender, EventArgs e)
        {
            lblMainForm.Text = "Gestión de Trabajadores";
            IRepository<Trabajador> employeeRepository = new EmployeeRepository();
            EmployeeListForm employeeListForm = new EmployeeListForm(this, employeeRepository);
            employeeListForm.idUsuario = idUsuario;
            AbrirFormularioHijo(employeeListForm);
        }
        private void tbnRoles_Click(object sender, EventArgs e)
        {
            lblMainForm.Text = "Gestión de Roles";
            IRepository<Rol> rolRepository = new RolRepository();
            RolListForm rolListForm = new RolListForm(this, rolRepository);
            rolListForm.idUsuario = idUsuario;
            AbrirFormularioHijo(rolListForm);
        }
        private void AbrirFormularioHijo(Form formularioHijo)
        {
            if (formularioHijoActual != null)
            {
                formularioHijoActual.Close();
            }
            formularioHijoActual = formularioHijo;
            formularioHijo.TopLevel = false;
            formularioHijo.FormBorderStyle = FormBorderStyle.None;
            formularioHijo.Dock = DockStyle.Fill;
            pContainer.Controls.Add(formularioHijo);
            pContainer.Tag = formularioHijo;
            formularioHijo.BringToFront();
            formularioHijo.Show();
        }
        
        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void pBarraSuperior_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;
        }
        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        
        public void SetTransparency(bool isTransparent)
        {
            this.Opacity = isTransparent ? 0.75 : 1.0;
        }
        
    }
}