using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using FontAwesome.Sharp;
using System.Drawing;
using DataLayer.Repositories;
using EntitiesLayer.Entities;
using Presentacion.Formularios.CategoriaNormas;
using PresentationLayer.Forms.Employees;
using PresentationLayer.Forms.Laws;
using PresentationLayer.Forms.Roles;
using PresentationLayer.Forms.User;


namespace PresentationLayer.Forms.Common
{
    public partial class MainForm : Form
    {
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form formularioHijoActual;
        
        public string employeeName;
        public string userName;
        public string rolName;

        public int userId;
        
        private MainForm mainForm;

        public MainForm()
        {
            InitializeComponent();
            CustomizeDesign();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 45);
            pMenu.Controls.Add(leftBorderBtn);

            this.ControlBox = false;
            //Ocultar barra de titulo
            this.Text = string.Empty;

            SetDoubleBuffered(this, true);  
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            lblMainForm.Text = "Bienvenido " + employeeName;
            userNameLbl.Text = userName;
            rolLbl.Text = rolName;
            ConfigureMenuByRole();
        }
        private void ConfigureMenuByRole()
        {
            if (rolName.Equals("Administrador", StringComparison.OrdinalIgnoreCase))
            {
                btnConsultas.Visible = true;
                LawsBtn.Visible = true;
                UsersBtn.Visible = true;
            }
            else if (rolName.Equals("Editor", StringComparison.OrdinalIgnoreCase))
            {
                btnConsultas.Visible = true;
                LawsBtn.Visible = true;
                UsersBtn.Visible = false;
            }
            else if (rolName.Equals("Usuario", StringComparison.OrdinalIgnoreCase))
            {
                btnConsultas.Visible = true;
                LawsBtn.Visible = false;
                UsersBtn.Visible = false;
            }
            else
            {
                // Oculta todos los botones en caso de un rol no identificado
                btnConsultas.Visible = false;
                LawsBtn.Visible = false;
                UsersBtn.Visible = false;
            }
        }


        private void CustomizeDesign()
        {
            usersSubMenu.Visible = false;
            lawsSubMenu.Visible = false;
        }

        private void HideSubmenu()
        {
            if (usersSubMenu.Visible == true)
            {
                usersSubMenu.Visible = false;
            }
            
            if (lawsSubMenu.Visible == true)
            {
                lawsSubMenu.Visible = false;
            }
        }

        private void ShowSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                HideSubmenu();
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
            HideSubmenu();
            ILawRepository lawRepository = new LawRepository();
            LawsListForm lawsListForm = new LawsListForm(this, lawRepository);
            lawsListForm.idUsuario = userId;
            lawsListForm.AddBtn.Visible = false;
            lawsListForm.UpdateBtn.Visible = false;
            lawsListForm.DeleteBtn.Visible = false;
            //lawsListForm.AddArticleBtn.Visible = false;
            lawsListForm.DetailsBtn.Visible = true;
            lawsListForm.ReportBtn.Visible = true;
            lawsListForm.module = "Consultas";

            OpenChildForm(lawsListForm);
        }

        private void LawsBtn_Click(object sender, EventArgs e)
        {
            lblMainForm.Text = "Gestión de Normas";
            ShowSubMenu(lawsSubMenu);
            ActivateButton(sender, RGBColors.color);
            ILawRepository lawRepository = new LawRepository();
            LawsListForm lawsListForm = new LawsListForm(this, lawRepository);
            lawsListForm.idUsuario = userId;
            OpenChildForm(lawsListForm);
        }

        private void CategoriesBtn_Click(object sender, EventArgs e)
        {
            lblMainForm.Text = "Gestión de Categorías";
            IRepository<CategoryLaw> categoryRepository = new CategoryRepository();
            CategoryListForm categoryListForm = new CategoryListForm(main: this, categoryRepository);
            categoryListForm.idUsuario = userId;
            OpenChildForm(categoryListForm);
        }

        private void UsersBtn_Click(object sender, EventArgs e)
        {
            lblMainForm.Text = "Gestión de Usuarios";
            ShowSubMenu(usersSubMenu);
            ActivateButton(sender, RGBColors.color);
            IUserRepository userRepository = new UserRepository();
            UserListForm userListForm = new UserListForm(this, userRepository);
            userListForm.userSesionId = userId;
            OpenChildForm(userListForm);
        }
        private void UsersProfileBtn_Click(object sender, EventArgs e)
        {
            IUserRepository userRepository = new UserRepository();
            UserUpdateCredentials userUpdateCredentials = new UserUpdateCredentials(userRepository);
            userUpdateCredentials.tboxUser.Texts = userName;
            userUpdateCredentials.userId = userId;
            this.SetTransparency(true);
            userUpdateCredentials.ShowDialog(); 
            this.SetTransparency(false); 
        }
        private void EmployeesBtn_Click(object sender, EventArgs e)
        {
            lblMainForm.Text = "Gestión de Trabajadores";
            IEmployeeRepository employeeRepository = new EmployeeRepository();
            EmployeeListForm employeeListForm = new EmployeeListForm(this, employeeRepository);
            employeeListForm.userId = userId;
            OpenChildForm(employeeListForm);
        }
        private void RolBtn_Click(object sender, EventArgs e)
        {
            lblMainForm.Text = "Gestión de Roles";
            IRepository<Rol> rolRepository = new RolRepository();
            RolListForm rolListForm = new RolListForm(this, rolRepository);
            rolListForm.userId = userId;
            OpenChildForm(rolListForm);
        }
        private void OpenChildForm(Form childForm)
        {
            if (formularioHijoActual != null)
            {
                formularioHijoActual.Close();
            }
            formularioHijoActual = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pContainer.Controls.Add(childForm);
            pContainer.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
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
        
        private void SetDoubleBuffered(Control control, bool enable)
        {
            var doubleBufferPropertyInfo = control.GetType().GetProperty("DoubleBuffered", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic);
            doubleBufferPropertyInfo?.SetValue(control, enable, null);

            foreach (Control childControl in control.Controls)
            {
                SetDoubleBuffered(childControl, enable);  // Aplicar recursivamente
            }
        }

        
    }
}