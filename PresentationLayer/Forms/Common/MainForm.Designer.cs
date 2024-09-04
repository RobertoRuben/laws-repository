using System.ComponentModel;

namespace PresentationLayer.Forms.Common
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pMenu = new System.Windows.Forms.Panel();
            this.usersSubMenu = new System.Windows.Forms.Panel();
            this.RolBtn = new FontAwesome.Sharp.IconButton();
            this.EmployeeBtn = new FontAwesome.Sharp.IconButton();
            this.UsersBtn = new FontAwesome.Sharp.IconButton();
            this.lawsSubMenu = new System.Windows.Forms.Panel();
            this.CategoriesBtn = new FontAwesome.Sharp.IconButton();
            this.LawsBtn = new FontAwesome.Sharp.IconButton();
            this.btnConsultas = new FontAwesome.Sharp.IconButton();
            this.pImage = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pBarraTitulo = new System.Windows.Forms.Panel();
            this.rolLbl = new System.Windows.Forms.Label();
            this.userNameLbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.UserProfielBtn = new FontAwesome.Sharp.IconButton();
            this.lblMainForm = new System.Windows.Forms.Label();
            this.btnMinimize = new FontAwesome.Sharp.IconButton();
            this.btnClose = new FontAwesome.Sharp.IconButton();
            this.btnMaximize = new FontAwesome.Sharp.IconButton();
            this.pContainer = new System.Windows.Forms.Panel();
            this.pMenu.SuspendLayout();
            this.usersSubMenu.SuspendLayout();
            this.lawsSubMenu.SuspendLayout();
            this.pImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pBarraTitulo.SuspendLayout();
            this.SuspendLayout();
            // 
            // pMenu
            // 
            this.pMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.pMenu.Controls.Add(this.usersSubMenu);
            this.pMenu.Controls.Add(this.UsersBtn);
            this.pMenu.Controls.Add(this.lawsSubMenu);
            this.pMenu.Controls.Add(this.LawsBtn);
            this.pMenu.Controls.Add(this.btnConsultas);
            this.pMenu.Controls.Add(this.pImage);
            this.pMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pMenu.Location = new System.Drawing.Point(0, 0);
            this.pMenu.Name = "pMenu";
            this.pMenu.Size = new System.Drawing.Size(220, 681);
            this.pMenu.TabIndex = 0;
            // 
            // usersSubMenu
            // 
            this.usersSubMenu.Controls.Add(this.RolBtn);
            this.usersSubMenu.Controls.Add(this.EmployeeBtn);
            this.usersSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.usersSubMenu.Location = new System.Drawing.Point(0, 341);
            this.usersSubMenu.Name = "usersSubMenu";
            this.usersSubMenu.Size = new System.Drawing.Size(220, 96);
            this.usersSubMenu.TabIndex = 7;
            // 
            // RolBtn
            // 
            this.RolBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.RolBtn.FlatAppearance.BorderSize = 0;
            this.RolBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RolBtn.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RolBtn.ForeColor = System.Drawing.Color.White;
            this.RolBtn.IconChar = FontAwesome.Sharp.IconChar.None;
            this.RolBtn.IconColor = System.Drawing.Color.White;
            this.RolBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.RolBtn.Location = new System.Drawing.Point(0, 40);
            this.RolBtn.Name = "RolBtn";
            this.RolBtn.Padding = new System.Windows.Forms.Padding(80, 0, 0, 0);
            this.RolBtn.Size = new System.Drawing.Size(220, 40);
            this.RolBtn.TabIndex = 1;
            this.RolBtn.Text = "Roles";
            this.RolBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.RolBtn.UseVisualStyleBackColor = true;
            this.RolBtn.Click += new System.EventHandler(this.RolBtn_Click);
            // 
            // EmployeeBtn
            // 
            this.EmployeeBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.EmployeeBtn.FlatAppearance.BorderSize = 0;
            this.EmployeeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EmployeeBtn.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployeeBtn.ForeColor = System.Drawing.Color.White;
            this.EmployeeBtn.IconChar = FontAwesome.Sharp.IconChar.None;
            this.EmployeeBtn.IconColor = System.Drawing.Color.White;
            this.EmployeeBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.EmployeeBtn.Location = new System.Drawing.Point(0, 0);
            this.EmployeeBtn.Name = "EmployeeBtn";
            this.EmployeeBtn.Padding = new System.Windows.Forms.Padding(80, 0, 0, 0);
            this.EmployeeBtn.Size = new System.Drawing.Size(220, 40);
            this.EmployeeBtn.TabIndex = 0;
            this.EmployeeBtn.Text = "Trabajadores";
            this.EmployeeBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.EmployeeBtn.UseVisualStyleBackColor = true;
            this.EmployeeBtn.Click += new System.EventHandler(this.EmployeesBtn_Click);
            // 
            // UsersBtn
            // 
            this.UsersBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.UsersBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(105)))), ((int)(((byte)(153)))));
            this.UsersBtn.FlatAppearance.BorderSize = 0;
            this.UsersBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UsersBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsersBtn.ForeColor = System.Drawing.Color.White;
            this.UsersBtn.IconChar = FontAwesome.Sharp.IconChar.UserGroup;
            this.UsersBtn.IconColor = System.Drawing.Color.White;
            this.UsersBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.UsersBtn.IconSize = 36;
            this.UsersBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.UsersBtn.Location = new System.Drawing.Point(0, 296);
            this.UsersBtn.Name = "UsersBtn";
            this.UsersBtn.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.UsersBtn.Size = new System.Drawing.Size(220, 45);
            this.UsersBtn.TabIndex = 6;
            this.UsersBtn.Text = "Usuarios";
            this.UsersBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.UsersBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.UsersBtn.UseVisualStyleBackColor = true;
            this.UsersBtn.Click += new System.EventHandler(this.UsersBtn_Click);
            // 
            // lawsSubMenu
            // 
            this.lawsSubMenu.Controls.Add(this.CategoriesBtn);
            this.lawsSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.lawsSubMenu.Location = new System.Drawing.Point(0, 248);
            this.lawsSubMenu.Name = "lawsSubMenu";
            this.lawsSubMenu.Size = new System.Drawing.Size(220, 48);
            this.lawsSubMenu.TabIndex = 5;
            // 
            // CategoriesBtn
            // 
            this.CategoriesBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.CategoriesBtn.FlatAppearance.BorderSize = 0;
            this.CategoriesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CategoriesBtn.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CategoriesBtn.ForeColor = System.Drawing.Color.White;
            this.CategoriesBtn.IconChar = FontAwesome.Sharp.IconChar.None;
            this.CategoriesBtn.IconColor = System.Drawing.Color.White;
            this.CategoriesBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.CategoriesBtn.Location = new System.Drawing.Point(0, 0);
            this.CategoriesBtn.Name = "CategoriesBtn";
            this.CategoriesBtn.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.CategoriesBtn.Size = new System.Drawing.Size(220, 40);
            this.CategoriesBtn.TabIndex = 0;
            this.CategoriesBtn.Text = "Categorias";
            this.CategoriesBtn.UseVisualStyleBackColor = true;
            this.CategoriesBtn.Click += new System.EventHandler(this.CategoriesBtn_Click);
            // 
            // LawsBtn
            // 
            this.LawsBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.LawsBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(105)))), ((int)(((byte)(153)))));
            this.LawsBtn.FlatAppearance.BorderSize = 0;
            this.LawsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LawsBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LawsBtn.ForeColor = System.Drawing.Color.White;
            this.LawsBtn.IconChar = FontAwesome.Sharp.IconChar.File;
            this.LawsBtn.IconColor = System.Drawing.Color.White;
            this.LawsBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.LawsBtn.IconSize = 36;
            this.LawsBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LawsBtn.Location = new System.Drawing.Point(0, 203);
            this.LawsBtn.Name = "LawsBtn";
            this.LawsBtn.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.LawsBtn.Size = new System.Drawing.Size(220, 45);
            this.LawsBtn.TabIndex = 4;
            this.LawsBtn.Text = "Normas";
            this.LawsBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LawsBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.LawsBtn.UseVisualStyleBackColor = true;
            this.LawsBtn.Click += new System.EventHandler(this.LawsBtn_Click);
            // 
            // btnConsultas
            // 
            this.btnConsultas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnConsultas.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(105)))), ((int)(((byte)(153)))));
            this.btnConsultas.FlatAppearance.BorderSize = 0;
            this.btnConsultas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultas.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultas.ForeColor = System.Drawing.Color.White;
            this.btnConsultas.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btnConsultas.IconColor = System.Drawing.Color.White;
            this.btnConsultas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnConsultas.IconSize = 36;
            this.btnConsultas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultas.Location = new System.Drawing.Point(0, 158);
            this.btnConsultas.Name = "btnConsultas";
            this.btnConsultas.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnConsultas.Size = new System.Drawing.Size(220, 45);
            this.btnConsultas.TabIndex = 2;
            this.btnConsultas.Text = "Consultas";
            this.btnConsultas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnConsultas.UseVisualStyleBackColor = true;
            this.btnConsultas.Click += new System.EventHandler(this.btnConsultas_Click);
            // 
            // pImage
            // 
            this.pImage.Controls.Add(this.pictureBox1);
            this.pImage.Dock = System.Windows.Forms.DockStyle.Top;
            this.pImage.Location = new System.Drawing.Point(0, 0);
            this.pImage.Name = "pImage";
            this.pImage.Size = new System.Drawing.Size(220, 158);
            this.pImage.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PresentationLayer.Properties.Resources.logo_muni;
            this.pictureBox1.Location = new System.Drawing.Point(37, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(137, 126);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // pBarraTitulo
            // 
            this.pBarraTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(236)))), ((int)(((byte)(240)))));
            this.pBarraTitulo.Controls.Add(this.rolLbl);
            this.pBarraTitulo.Controls.Add(this.userNameLbl);
            this.pBarraTitulo.Controls.Add(this.label2);
            this.pBarraTitulo.Controls.Add(this.label1);
            this.pBarraTitulo.Controls.Add(this.UserProfielBtn);
            this.pBarraTitulo.Controls.Add(this.lblMainForm);
            this.pBarraTitulo.Controls.Add(this.btnMinimize);
            this.pBarraTitulo.Controls.Add(this.btnClose);
            this.pBarraTitulo.Controls.Add(this.btnMaximize);
            this.pBarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pBarraTitulo.Location = new System.Drawing.Point(220, 0);
            this.pBarraTitulo.Name = "pBarraTitulo";
            this.pBarraTitulo.Size = new System.Drawing.Size(1044, 71);
            this.pBarraTitulo.TabIndex = 1;
            this.pBarraTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pBarraSuperior_MouseDown);
            // 
            // rolLbl
            // 
            this.rolLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rolLbl.AutoSize = true;
            this.rolLbl.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rolLbl.Location = new System.Drawing.Point(755, 39);
            this.rolLbl.Name = "rolLbl";
            this.rolLbl.Size = new System.Drawing.Size(34, 19);
            this.rolLbl.TabIndex = 18;
            this.rolLbl.Text = "Rol:";
            // 
            // userNameLbl
            // 
            this.userNameLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.userNameLbl.AutoSize = true;
            this.userNameLbl.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameLbl.Location = new System.Drawing.Point(755, 16);
            this.userNameLbl.Name = "userNameLbl";
            this.userNameLbl.Size = new System.Drawing.Size(40, 19);
            this.userNameLbl.TabIndex = 17;
            this.userNameLbl.Text = "User:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(716, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 17);
            this.label2.TabIndex = 16;
            this.label2.Text = "Rol:";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(689, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 17);
            this.label1.TabIndex = 15;
            this.label1.Text = "Usuario:";
            // 
            // UserProfielBtn
            // 
            this.UserProfielBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.UserProfielBtn.FlatAppearance.BorderSize = 0;
            this.UserProfielBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UserProfielBtn.ForeColor = System.Drawing.Color.Transparent;
            this.UserProfielBtn.IconChar = FontAwesome.Sharp.IconChar.UserCircle;
            this.UserProfielBtn.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(168)))), ((int)(((byte)(86)))));
            this.UserProfielBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.UserProfielBtn.IconSize = 55;
            this.UserProfielBtn.Location = new System.Drawing.Point(629, 12);
            this.UserProfielBtn.Name = "UserProfielBtn";
            this.UserProfielBtn.Size = new System.Drawing.Size(57, 48);
            this.UserProfielBtn.TabIndex = 14;
            this.UserProfielBtn.UseVisualStyleBackColor = true;
            this.UserProfielBtn.Click += new System.EventHandler(this.UsersProfileBtn_Click);
            // 
            // lblMainForm
            // 
            this.lblMainForm.Font = new System.Drawing.Font("Century Gothic", 22F, System.Drawing.FontStyle.Bold);
            this.lblMainForm.Location = new System.Drawing.Point(19, 19);
            this.lblMainForm.Name = "lblMainForm";
            this.lblMainForm.Size = new System.Drawing.Size(411, 40);
            this.lblMainForm.TabIndex = 0;
            this.lblMainForm.Text = "Bienvenido";
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnMinimize.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.btnMinimize.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(149)))), ((int)(((byte)(161)))));
            this.btnMinimize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMinimize.IconSize = 18;
            this.btnMinimize.Location = new System.Drawing.Point(965, 1);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(23, 17);
            this.btnMinimize.TabIndex = 12;
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnClose.IconChar = FontAwesome.Sharp.IconChar.Remove;
            this.btnClose.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(149)))), ((int)(((byte)(161)))));
            this.btnClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnClose.IconSize = 18;
            this.btnClose.Location = new System.Drawing.Point(1018, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(23, 17);
            this.btnClose.TabIndex = 10;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnMaximize
            // 
            this.btnMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximize.BackColor = System.Drawing.Color.Transparent;
            this.btnMaximize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnMaximize.FlatAppearance.BorderSize = 0;
            this.btnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximize.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnMaximize.IconChar = FontAwesome.Sharp.IconChar.ExternalLinkAlt;
            this.btnMaximize.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(149)))), ((int)(((byte)(161)))));
            this.btnMaximize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMaximize.IconSize = 18;
            this.btnMaximize.Location = new System.Drawing.Point(992, 0);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(23, 17);
            this.btnMaximize.TabIndex = 11;
            this.btnMaximize.UseVisualStyleBackColor = false;
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
            // 
            // pContainer
            // 
            this.pContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(236)))), ((int)(((byte)(240)))));
            this.pContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pContainer.Location = new System.Drawing.Point(220, 71);
            this.pContainer.Name = "pContainer";
            this.pContainer.Size = new System.Drawing.Size(1044, 610);
            this.pContainer.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(248)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.pContainer);
            this.Controls.Add(this.pBarraTitulo);
            this.Controls.Add(this.pMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menú Principal";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.pMenu.ResumeLayout(false);
            this.usersSubMenu.ResumeLayout(false);
            this.lawsSubMenu.ResumeLayout(false);
            this.pImage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pBarraTitulo.ResumeLayout(false);
            this.pBarraTitulo.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label rolLbl;
        private System.Windows.Forms.Label userNameLbl;

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton UserProfielBtn;

        private System.Windows.Forms.Label lblMainForm;

        private FontAwesome.Sharp.IconButton btnMinimize;
        private FontAwesome.Sharp.IconButton btnMaximize;
        private FontAwesome.Sharp.IconButton btnClose;


        private FontAwesome.Sharp.IconButton LawsBtn;
        private System.Windows.Forms.Panel lawsSubMenu;
        private FontAwesome.Sharp.IconButton CategoriesBtn;
        private FontAwesome.Sharp.IconButton UsersBtn;
        private System.Windows.Forms.Panel usersSubMenu;
        private FontAwesome.Sharp.IconButton RolBtn;
        private FontAwesome.Sharp.IconButton EmployeeBtn;

        private FontAwesome.Sharp.IconButton btnConsultas;

        private System.Windows.Forms.PictureBox pictureBox1;

        private System.Windows.Forms.Panel pContainer;

        private System.Windows.Forms.Panel pBarraTitulo;

        private System.Windows.Forms.Panel pImage;

        private System.Windows.Forms.Panel pMenu;

        #endregion
    }
}