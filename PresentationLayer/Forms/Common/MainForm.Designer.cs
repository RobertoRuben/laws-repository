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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.pMenu = new System.Windows.Forms.Panel();
            this.subMenuUsuarios = new System.Windows.Forms.Panel();
            this.tbnRoles = new FontAwesome.Sharp.IconButton();
            this.btnTrabajadores = new FontAwesome.Sharp.IconButton();
            this.btnUsuarios = new FontAwesome.Sharp.IconButton();
            this.subMenuNormas = new System.Windows.Forms.Panel();
            this.btnCategorias = new FontAwesome.Sharp.IconButton();
            this.btnNormas = new FontAwesome.Sharp.IconButton();
            this.btnConsultas = new FontAwesome.Sharp.IconButton();
            this.pImage = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pBarraTitulo = new System.Windows.Forms.Panel();
            this.lblNombreRol = new System.Windows.Forms.Label();
            this.lblNombreUsuario = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPerfil = new FontAwesome.Sharp.IconButton();
            this.lblMainForm = new System.Windows.Forms.Label();
            this.btnMinimize = new FontAwesome.Sharp.IconButton();
            this.btnClose = new FontAwesome.Sharp.IconButton();
            this.btnMaximize = new FontAwesome.Sharp.IconButton();
            this.pContainer = new System.Windows.Forms.Panel();
            this.pMenu.SuspendLayout();
            this.subMenuUsuarios.SuspendLayout();
            this.subMenuNormas.SuspendLayout();
            this.pImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pBarraTitulo.SuspendLayout();
            this.SuspendLayout();
            // 
            // pMenu
            // 
            this.pMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.pMenu.Controls.Add(this.subMenuUsuarios);
            this.pMenu.Controls.Add(this.btnUsuarios);
            this.pMenu.Controls.Add(this.subMenuNormas);
            this.pMenu.Controls.Add(this.btnNormas);
            this.pMenu.Controls.Add(this.btnConsultas);
            this.pMenu.Controls.Add(this.pImage);
            this.pMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pMenu.Location = new System.Drawing.Point(0, 0);
            this.pMenu.Name = "pMenu";
            this.pMenu.Size = new System.Drawing.Size(220, 681);
            this.pMenu.TabIndex = 0;
            // 
            // subMenuUsuarios
            // 
            this.subMenuUsuarios.Controls.Add(this.tbnRoles);
            this.subMenuUsuarios.Controls.Add(this.btnTrabajadores);
            this.subMenuUsuarios.Dock = System.Windows.Forms.DockStyle.Top;
            this.subMenuUsuarios.Location = new System.Drawing.Point(0, 341);
            this.subMenuUsuarios.Name = "subMenuUsuarios";
            this.subMenuUsuarios.Size = new System.Drawing.Size(220, 96);
            this.subMenuUsuarios.TabIndex = 7;
            // 
            // tbnRoles
            // 
            this.tbnRoles.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbnRoles.FlatAppearance.BorderSize = 0;
            this.tbnRoles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tbnRoles.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbnRoles.ForeColor = System.Drawing.Color.White;
            this.tbnRoles.IconChar = FontAwesome.Sharp.IconChar.None;
            this.tbnRoles.IconColor = System.Drawing.Color.White;
            this.tbnRoles.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.tbnRoles.Location = new System.Drawing.Point(0, 40);
            this.tbnRoles.Name = "tbnRoles";
            this.tbnRoles.Padding = new System.Windows.Forms.Padding(80, 0, 0, 0);
            this.tbnRoles.Size = new System.Drawing.Size(220, 40);
            this.tbnRoles.TabIndex = 1;
            this.tbnRoles.Text = "Rol";
            this.tbnRoles.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbnRoles.UseVisualStyleBackColor = true;
            this.tbnRoles.Click += new System.EventHandler(this.tbnRoles_Click);
            // 
            // btnTrabajadores
            // 
            this.btnTrabajadores.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTrabajadores.FlatAppearance.BorderSize = 0;
            this.btnTrabajadores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTrabajadores.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrabajadores.ForeColor = System.Drawing.Color.White;
            this.btnTrabajadores.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnTrabajadores.IconColor = System.Drawing.Color.White;
            this.btnTrabajadores.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTrabajadores.Location = new System.Drawing.Point(0, 0);
            this.btnTrabajadores.Name = "btnTrabajadores";
            this.btnTrabajadores.Padding = new System.Windows.Forms.Padding(80, 0, 0, 0);
            this.btnTrabajadores.Size = new System.Drawing.Size(220, 40);
            this.btnTrabajadores.TabIndex = 0;
            this.btnTrabajadores.Text = "Trabajadores";
            this.btnTrabajadores.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTrabajadores.UseVisualStyleBackColor = true;
            this.btnTrabajadores.Click += new System.EventHandler(this.btnTrabajadores_Click);
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUsuarios.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(105)))), ((int)(((byte)(153)))));
            this.btnUsuarios.FlatAppearance.BorderSize = 0;
            this.btnUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsuarios.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsuarios.ForeColor = System.Drawing.Color.White;
            this.btnUsuarios.IconChar = FontAwesome.Sharp.IconChar.UserGroup;
            this.btnUsuarios.IconColor = System.Drawing.Color.White;
            this.btnUsuarios.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnUsuarios.IconSize = 36;
            this.btnUsuarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsuarios.Location = new System.Drawing.Point(0, 296);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnUsuarios.Size = new System.Drawing.Size(220, 45);
            this.btnUsuarios.TabIndex = 6;
            this.btnUsuarios.Text = "Usuarios";
            this.btnUsuarios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsuarios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUsuarios.UseVisualStyleBackColor = true;
            this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
            // 
            // subMenuNormas
            // 
            this.subMenuNormas.Controls.Add(this.btnCategorias);
            this.subMenuNormas.Dock = System.Windows.Forms.DockStyle.Top;
            this.subMenuNormas.Location = new System.Drawing.Point(0, 248);
            this.subMenuNormas.Name = "subMenuNormas";
            this.subMenuNormas.Size = new System.Drawing.Size(220, 48);
            this.subMenuNormas.TabIndex = 5;
            // 
            // btnCategorias
            // 
            this.btnCategorias.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCategorias.FlatAppearance.BorderSize = 0;
            this.btnCategorias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCategorias.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCategorias.ForeColor = System.Drawing.Color.White;
            this.btnCategorias.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnCategorias.IconColor = System.Drawing.Color.White;
            this.btnCategorias.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCategorias.Location = new System.Drawing.Point(0, 0);
            this.btnCategorias.Name = "btnCategorias";
            this.btnCategorias.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnCategorias.Size = new System.Drawing.Size(220, 40);
            this.btnCategorias.TabIndex = 0;
            this.btnCategorias.Text = "Categorias";
            this.btnCategorias.UseVisualStyleBackColor = true;
            this.btnCategorias.Click += new System.EventHandler(this.btnCategorias_Click);
            // 
            // btnNormas
            // 
            this.btnNormas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNormas.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(105)))), ((int)(((byte)(153)))));
            this.btnNormas.FlatAppearance.BorderSize = 0;
            this.btnNormas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNormas.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNormas.ForeColor = System.Drawing.Color.White;
            this.btnNormas.IconChar = FontAwesome.Sharp.IconChar.File;
            this.btnNormas.IconColor = System.Drawing.Color.White;
            this.btnNormas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnNormas.IconSize = 36;
            this.btnNormas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNormas.Location = new System.Drawing.Point(0, 203);
            this.btnNormas.Name = "btnNormas";
            this.btnNormas.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnNormas.Size = new System.Drawing.Size(220, 45);
            this.btnNormas.TabIndex = 4;
            this.btnNormas.Text = "Normas";
            this.btnNormas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNormas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNormas.UseVisualStyleBackColor = true;
            this.btnNormas.Click += new System.EventHandler(this.btnNormas_Click);
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
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(211, 106);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // pBarraTitulo
            // 
            this.pBarraTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(236)))), ((int)(((byte)(240)))));
            this.pBarraTitulo.Controls.Add(this.lblNombreRol);
            this.pBarraTitulo.Controls.Add(this.lblNombreUsuario);
            this.pBarraTitulo.Controls.Add(this.label2);
            this.pBarraTitulo.Controls.Add(this.label1);
            this.pBarraTitulo.Controls.Add(this.btnPerfil);
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
            // lblNombreRol
            // 
            this.lblNombreRol.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNombreRol.AutoSize = true;
            this.lblNombreRol.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreRol.Location = new System.Drawing.Point(755, 39);
            this.lblNombreRol.Name = "lblNombreRol";
            this.lblNombreRol.Size = new System.Drawing.Size(34, 19);
            this.lblNombreRol.TabIndex = 18;
            this.lblNombreRol.Text = "Rol:";
            // 
            // lblNombreUsuario
            // 
            this.lblNombreUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNombreUsuario.AutoSize = true;
            this.lblNombreUsuario.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreUsuario.Location = new System.Drawing.Point(755, 16);
            this.lblNombreUsuario.Name = "lblNombreUsuario";
            this.lblNombreUsuario.Size = new System.Drawing.Size(62, 19);
            this.lblNombreUsuario.TabIndex = 17;
            this.lblNombreUsuario.Text = "Usuario:";
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
            // btnPerfil
            // 
            this.btnPerfil.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPerfil.FlatAppearance.BorderSize = 0;
            this.btnPerfil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPerfil.ForeColor = System.Drawing.Color.Transparent;
            this.btnPerfil.IconChar = FontAwesome.Sharp.IconChar.UserCircle;
            this.btnPerfil.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(168)))), ((int)(((byte)(86)))));
            this.btnPerfil.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPerfil.IconSize = 55;
            this.btnPerfil.Location = new System.Drawing.Point(629, 12);
            this.btnPerfil.Name = "btnPerfil";
            this.btnPerfil.Size = new System.Drawing.Size(57, 48);
            this.btnPerfil.TabIndex = 14;
            this.btnPerfil.UseVisualStyleBackColor = true;
            this.btnPerfil.Click += new System.EventHandler(this.btnPerfil_Click);
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
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.pMenu.ResumeLayout(false);
            this.subMenuUsuarios.ResumeLayout(false);
            this.subMenuNormas.ResumeLayout(false);
            this.pImage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pBarraTitulo.ResumeLayout(false);
            this.pBarraTitulo.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label lblNombreRol;
        private System.Windows.Forms.Label lblNombreUsuario;

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton btnPerfil;

        private System.Windows.Forms.Label lblMainForm;

        private FontAwesome.Sharp.IconButton btnMinimize;
        private FontAwesome.Sharp.IconButton btnMaximize;
        private FontAwesome.Sharp.IconButton btnClose;


        private FontAwesome.Sharp.IconButton btnNormas;
        private System.Windows.Forms.Panel subMenuNormas;
        private FontAwesome.Sharp.IconButton btnCategorias;
        private FontAwesome.Sharp.IconButton btnUsuarios;
        private System.Windows.Forms.Panel subMenuUsuarios;
        private FontAwesome.Sharp.IconButton tbnRoles;
        private FontAwesome.Sharp.IconButton btnTrabajadores;

        private FontAwesome.Sharp.IconButton btnConsultas;

        private System.Windows.Forms.PictureBox pictureBox1;

        private System.Windows.Forms.Panel pContainer;

        private System.Windows.Forms.Panel pBarraTitulo;

        private System.Windows.Forms.Panel pImage;

        private System.Windows.Forms.Panel pMenu;

        #endregion
    }
}