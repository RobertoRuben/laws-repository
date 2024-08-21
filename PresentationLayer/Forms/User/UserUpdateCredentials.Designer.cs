using System.ComponentModel;

namespace PresentationLayer.Forms.User
{
    partial class UserUpdateCredentials
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
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.lblSeccion = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.tboxConfirmarContraseña = new PresentationLayer.Components.CustomTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tboxContraseña = new PresentationLayer.Components.CustomTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tboxUsuario = new PresentationLayer.Components.CustomTextBox();
            this.btnSave = new FontAwesome.Sharp.IconButton();
            this.btnSalir = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(168)))), ((int)(((byte)(86)))));
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.User;
            this.iconPictureBox1.IconColor = System.Drawing.Color.White;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 40;
            this.iconPictureBox1.Location = new System.Drawing.Point(27, 10);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(40, 40);
            this.iconPictureBox1.TabIndex = 50;
            this.iconPictureBox1.TabStop = false;
            // 
            // lblSeccion
            // 
            this.lblSeccion.AutoSize = true;
            this.lblSeccion.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeccion.ForeColor = System.Drawing.Color.White;
            this.lblSeccion.Location = new System.Drawing.Point(73, 18);
            this.lblSeccion.Name = "lblSeccion";
            this.lblSeccion.Size = new System.Drawing.Size(253, 25);
            this.lblSeccion.TabIndex = 49;
            this.lblSeccion.Text = "Actualizar credenciales";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.tboxConfirmarContraseña);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.tboxContraseña);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.tboxUsuario);
            this.panel3.Location = new System.Drawing.Point(12, 74);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1015, 436);
            this.panel3.TabIndex = 78;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12.25F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(73)))), ((int)(((byte)(85)))));
            this.label4.Location = new System.Drawing.Point(10, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(186, 19);
            this.label4.TabIndex = 56;
            this.label4.Text = "Confirmar contraseña";
            // 
            // tboxConfirmarContraseña
            // 
            this.tboxConfirmarContraseña.AllowNull = false;
            this.tboxConfirmarContraseña.BackColor = System.Drawing.SystemColors.Window;
            this.tboxConfirmarContraseña.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(193)))), ((int)(((byte)(202)))));
            this.tboxConfirmarContraseña.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(168)))), ((int)(((byte)(86)))));
            this.tboxConfirmarContraseña.BorderRadius = 3;
            this.tboxConfirmarContraseña.BorderSize = 1;
            this.tboxConfirmarContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxConfirmarContraseña.ForeColor = System.Drawing.Color.DimGray;
            this.tboxConfirmarContraseña.Location = new System.Drawing.Point(15, 168);
            this.tboxConfirmarContraseña.Margin = new System.Windows.Forms.Padding(4);
            this.tboxConfirmarContraseña.Multiline = false;
            this.tboxConfirmarContraseña.Name = "tboxConfirmarContraseña";
            this.tboxConfirmarContraseña.Padding = new System.Windows.Forms.Padding(7);
            this.tboxConfirmarContraseña.PasswordChar = false;
            this.tboxConfirmarContraseña.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tboxConfirmarContraseña.PlaceholderText = "";
            this.tboxConfirmarContraseña.ReadOnly = false;
            this.tboxConfirmarContraseña.Size = new System.Drawing.Size(973, 31);
            this.tboxConfirmarContraseña.TabIndex = 55;
            this.tboxConfirmarContraseña.Texts = "";
            this.tboxConfirmarContraseña.UnderlinedStyle = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12.25F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(73)))), ((int)(((byte)(85)))));
            this.label3.Location = new System.Drawing.Point(10, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 19);
            this.label3.TabIndex = 54;
            this.label3.Text = "Contraseña";
            // 
            // tboxContraseña
            // 
            this.tboxContraseña.AllowNull = false;
            this.tboxContraseña.BackColor = System.Drawing.SystemColors.Window;
            this.tboxContraseña.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(193)))), ((int)(((byte)(202)))));
            this.tboxContraseña.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(168)))), ((int)(((byte)(86)))));
            this.tboxContraseña.BorderRadius = 3;
            this.tboxContraseña.BorderSize = 1;
            this.tboxContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxContraseña.ForeColor = System.Drawing.Color.DimGray;
            this.tboxContraseña.Location = new System.Drawing.Point(15, 101);
            this.tboxContraseña.Margin = new System.Windows.Forms.Padding(4);
            this.tboxContraseña.Multiline = false;
            this.tboxContraseña.Name = "tboxContraseña";
            this.tboxContraseña.Padding = new System.Windows.Forms.Padding(7);
            this.tboxContraseña.PasswordChar = false;
            this.tboxContraseña.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tboxContraseña.PlaceholderText = "";
            this.tboxContraseña.ReadOnly = false;
            this.tboxContraseña.Size = new System.Drawing.Size(973, 31);
            this.tboxContraseña.TabIndex = 53;
            this.tboxContraseña.Texts = "";
            this.tboxContraseña.UnderlinedStyle = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(73)))), ((int)(((byte)(85)))));
            this.label1.Location = new System.Drawing.Point(10, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 19);
            this.label1.TabIndex = 50;
            this.label1.Text = "Nombre del usuario";
            // 
            // tboxUsuario
            // 
            this.tboxUsuario.AllowNull = false;
            this.tboxUsuario.BackColor = System.Drawing.SystemColors.Window;
            this.tboxUsuario.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(193)))), ((int)(((byte)(202)))));
            this.tboxUsuario.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(168)))), ((int)(((byte)(86)))));
            this.tboxUsuario.BorderRadius = 3;
            this.tboxUsuario.BorderSize = 1;
            this.tboxUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxUsuario.ForeColor = System.Drawing.Color.DimGray;
            this.tboxUsuario.Location = new System.Drawing.Point(15, 38);
            this.tboxUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.tboxUsuario.Multiline = false;
            this.tboxUsuario.Name = "tboxUsuario";
            this.tboxUsuario.Padding = new System.Windows.Forms.Padding(7);
            this.tboxUsuario.PasswordChar = false;
            this.tboxUsuario.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tboxUsuario.PlaceholderText = "";
            this.tboxUsuario.ReadOnly = true;
            this.tboxUsuario.Size = new System.Drawing.Size(973, 31);
            this.tboxUsuario.TabIndex = 49;
            this.tboxUsuario.Texts = "";
            this.tboxUsuario.UnderlinedStyle = false;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(168)))), ((int)(((byte)(86)))));
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            this.btnSave.IconColor = System.Drawing.Color.White;
            this.btnSave.IconFont = FontAwesome.Sharp.IconFont.Regular;
            this.btnSave.IconSize = 32;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(12, 534);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(148, 40);
            this.btnSave.TabIndex = 75;
            this.btnSave.Text = "    Guardar";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(21)))), ((int)(((byte)(30)))));
            this.btnSalir.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(21)))), ((int)(((byte)(30)))));
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnSalir.IconColor = System.Drawing.Color.White;
            this.btnSalir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSalir.IconSize = 32;
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.Location = new System.Drawing.Point(879, 534);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(148, 40);
            this.btnSalir.TabIndex = 76;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(168)))), ((int)(((byte)(86)))));
            this.panel2.Controls.Add(this.iconPictureBox1);
            this.panel2.Controls.Add(this.lblSeccion);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1044, 57);
            this.panel2.TabIndex = 77;
            // 
            // UserUpdateCredentials
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1044, 580);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UserUpdateCredentials";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserUpdateCredentials";
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
        }

        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        public System.Windows.Forms.Label lblSeccion;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label4;
        public PresentationLayer.Components.CustomTextBox tboxConfirmarContraseña;
        private System.Windows.Forms.Label label3;
        public PresentationLayer.Components.CustomTextBox tboxContraseña;
        private System.Windows.Forms.Label label1;
        public PresentationLayer.Components.CustomTextBox tboxUsuario;
        private FontAwesome.Sharp.IconButton btnSave;
        private FontAwesome.Sharp.IconButton btnSalir;
        private System.Windows.Forms.Panel panel2;

        #endregion
    }
}