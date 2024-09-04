using System.ComponentModel;

namespace PresentationLayer.Forms.User
{
    partial class UserDataForm
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.rbtnInactive = new Presentacion.CustomControls.CustomRadioButton();
            this.rbtnActivate = new Presentacion.CustomControls.CustomRadioButton();
            this.cboxRol = new Presentacion.CustomControls.CustomComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tboxConfirm = new PresentationLayer.Components.CustomTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tboxPassword = new PresentationLayer.Components.CustomTextBox();
            this.cboxEmployee = new Presentacion.CustomControls.CustomComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tboxUser = new PresentationLayer.Components.CustomTextBox();
            this.btnSave = new FontAwesome.Sharp.IconButton();
            this.btnSalir = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.lblSeccion = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.rbtnInactive);
            this.panel3.Controls.Add(this.rbtnActivate);
            this.panel3.Controls.Add(this.cboxRol);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.tboxConfirm);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.tboxPassword);
            this.panel3.Controls.Add(this.cboxEmployee);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.tboxUser);
            this.panel3.Location = new System.Drawing.Point(12, 68);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1015, 436);
            this.panel3.TabIndex = 74;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12.25F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(73)))), ((int)(((byte)(85)))));
            this.label6.Location = new System.Drawing.Point(360, 292);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 19);
            this.label6.TabIndex = 62;
            this.label6.Text = "Estado";
            // 
            // rbtnInactive
            // 
            this.rbtnInactive.CheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(168)))), ((int)(((byte)(86)))));
            this.rbtnInactive.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnInactive.Location = new System.Drawing.Point(444, 322);
            this.rbtnInactive.MinimumSize = new System.Drawing.Size(0, 21);
            this.rbtnInactive.Name = "rbtnInactive";
            this.rbtnInactive.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.rbtnInactive.Size = new System.Drawing.Size(99, 31);
            this.rbtnInactive.TabIndex = 61;
            this.rbtnInactive.Text = "Inactivo";
            this.rbtnInactive.UnCheckedColor = System.Drawing.Color.Gray;
            this.rbtnInactive.UseVisualStyleBackColor = true;
            // 
            // rbtnActivate
            // 
            this.rbtnActivate.Checked = true;
            this.rbtnActivate.CheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(168)))), ((int)(((byte)(86)))));
            this.rbtnActivate.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnActivate.Location = new System.Drawing.Point(360, 322);
            this.rbtnActivate.MinimumSize = new System.Drawing.Size(0, 21);
            this.rbtnActivate.Name = "rbtnActivate";
            this.rbtnActivate.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.rbtnActivate.Size = new System.Drawing.Size(99, 31);
            this.rbtnActivate.TabIndex = 60;
            this.rbtnActivate.TabStop = true;
            this.rbtnActivate.Text = "Activo";
            this.rbtnActivate.UnCheckedColor = System.Drawing.Color.Gray;
            this.rbtnActivate.UseVisualStyleBackColor = true;
            // 
            // cboxRol
            // 
            this.cboxRol.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboxRol.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboxRol.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cboxRol.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(193)))), ((int)(((byte)(202)))));
            this.cboxRol.BorderSize = 1;
            this.cboxRol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cboxRol.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.cboxRol.ForeColor = System.Drawing.Color.DimGray;
            this.cboxRol.IconColor = System.Drawing.Color.Silver;
            this.cboxRol.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cboxRol.ListTextColor = System.Drawing.Color.DimGray;
            this.cboxRol.Location = new System.Drawing.Point(16, 320);
            this.cboxRol.MinimumSize = new System.Drawing.Size(200, 30);
            this.cboxRol.Name = "cboxRol";
            this.cboxRol.Padding = new System.Windows.Forms.Padding(1);
            this.cboxRol.SelectedValue = null;
            this.cboxRol.Size = new System.Drawing.Size(296, 33);
            this.cboxRol.TabIndex = 58;
            this.cboxRol.Texts = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12.25F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(73)))), ((int)(((byte)(85)))));
            this.label5.Location = new System.Drawing.Point(16, 292);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 19);
            this.label5.TabIndex = 57;
            this.label5.Text = "Rol";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12.25F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(73)))), ((int)(((byte)(85)))));
            this.label4.Location = new System.Drawing.Point(10, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(186, 19);
            this.label4.TabIndex = 56;
            this.label4.Text = "Confirmar contraseña";
            // 
            // tboxConfirm
            // 
            this.tboxConfirm.AllowNull = false;
            this.tboxConfirm.AutoFocus = false;
            this.tboxConfirm.BackColor = System.Drawing.SystemColors.Window;
            this.tboxConfirm.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(193)))), ((int)(((byte)(202)))));
            this.tboxConfirm.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(168)))), ((int)(((byte)(86)))));
            this.tboxConfirm.BorderRadius = 3;
            this.tboxConfirm.BorderSize = 1;
            this.tboxConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxConfirm.ForeColor = System.Drawing.Color.DimGray;
            this.tboxConfirm.Location = new System.Drawing.Point(15, 246);
            this.tboxConfirm.Margin = new System.Windows.Forms.Padding(4);
            this.tboxConfirm.Multiline = false;
            this.tboxConfirm.Name = "tboxConfirm";
            this.tboxConfirm.Padding = new System.Windows.Forms.Padding(7);
            this.tboxConfirm.PasswordChar = true;
            this.tboxConfirm.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tboxConfirm.PlaceholderText = "";
            this.tboxConfirm.ReadOnly = false;
            this.tboxConfirm.Size = new System.Drawing.Size(973, 31);
            this.tboxConfirm.TabIndex = 55;
            this.tboxConfirm.Texts = "";
            this.tboxConfirm.UnderlinedStyle = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12.25F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(73)))), ((int)(((byte)(85)))));
            this.label3.Location = new System.Drawing.Point(10, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 19);
            this.label3.TabIndex = 54;
            this.label3.Text = "Contraseña";
            // 
            // tboxPassword
            // 
            this.tboxPassword.AllowNull = false;
            this.tboxPassword.AutoFocus = false;
            this.tboxPassword.BackColor = System.Drawing.SystemColors.Window;
            this.tboxPassword.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(193)))), ((int)(((byte)(202)))));
            this.tboxPassword.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(168)))), ((int)(((byte)(86)))));
            this.tboxPassword.BorderRadius = 3;
            this.tboxPassword.BorderSize = 1;
            this.tboxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxPassword.ForeColor = System.Drawing.Color.DimGray;
            this.tboxPassword.Location = new System.Drawing.Point(15, 179);
            this.tboxPassword.Margin = new System.Windows.Forms.Padding(4);
            this.tboxPassword.Multiline = false;
            this.tboxPassword.Name = "tboxPassword";
            this.tboxPassword.Padding = new System.Windows.Forms.Padding(7);
            this.tboxPassword.PasswordChar = true;
            this.tboxPassword.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tboxPassword.PlaceholderText = "";
            this.tboxPassword.ReadOnly = false;
            this.tboxPassword.Size = new System.Drawing.Size(973, 31);
            this.tboxPassword.TabIndex = 53;
            this.tboxPassword.Texts = "";
            this.tboxPassword.UnderlinedStyle = false;
            // 
            // cboxEmployee
            // 
            this.cboxEmployee.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboxEmployee.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboxEmployee.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cboxEmployee.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(193)))), ((int)(((byte)(202)))));
            this.cboxEmployee.BorderSize = 1;
            this.cboxEmployee.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cboxEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.cboxEmployee.ForeColor = System.Drawing.Color.DimGray;
            this.cboxEmployee.IconColor = System.Drawing.Color.Silver;
            this.cboxEmployee.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cboxEmployee.ListTextColor = System.Drawing.Color.DimGray;
            this.cboxEmployee.Location = new System.Drawing.Point(15, 44);
            this.cboxEmployee.MinimumSize = new System.Drawing.Size(200, 30);
            this.cboxEmployee.Name = "cboxEmployee";
            this.cboxEmployee.Padding = new System.Windows.Forms.Padding(1);
            this.cboxEmployee.SelectedValue = null;
            this.cboxEmployee.Size = new System.Drawing.Size(972, 33);
            this.cboxEmployee.TabIndex = 52;
            this.cboxEmployee.Texts = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12.25F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(73)))), ((int)(((byte)(85)))));
            this.label2.Location = new System.Drawing.Point(15, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 19);
            this.label2.TabIndex = 51;
            this.label2.Text = "Trabajador";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(73)))), ((int)(((byte)(85)))));
            this.label1.Location = new System.Drawing.Point(10, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 19);
            this.label1.TabIndex = 50;
            this.label1.Text = "Nombre de usuario";
            // 
            // tboxUser
            // 
            this.tboxUser.AllowNull = false;
            this.tboxUser.AutoFocus = false;
            this.tboxUser.BackColor = System.Drawing.SystemColors.Window;
            this.tboxUser.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(193)))), ((int)(((byte)(202)))));
            this.tboxUser.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(168)))), ((int)(((byte)(86)))));
            this.tboxUser.BorderRadius = 3;
            this.tboxUser.BorderSize = 1;
            this.tboxUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxUser.ForeColor = System.Drawing.Color.DimGray;
            this.tboxUser.Location = new System.Drawing.Point(15, 116);
            this.tboxUser.Margin = new System.Windows.Forms.Padding(4);
            this.tboxUser.Multiline = false;
            this.tboxUser.Name = "tboxUser";
            this.tboxUser.Padding = new System.Windows.Forms.Padding(7);
            this.tboxUser.PasswordChar = false;
            this.tboxUser.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tboxUser.PlaceholderText = "";
            this.tboxUser.ReadOnly = false;
            this.tboxUser.Size = new System.Drawing.Size(973, 31);
            this.tboxUser.TabIndex = 49;
            this.tboxUser.Texts = "";
            this.tboxUser.UnderlinedStyle = false;
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
            this.btnSave.Location = new System.Drawing.Point(12, 528);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(148, 40);
            this.btnSave.TabIndex = 71;
            this.btnSave.Text = "    Guardar";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.SaveBtn_Click);
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
            this.btnSalir.Location = new System.Drawing.Point(879, 528);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(148, 40);
            this.btnSalir.TabIndex = 72;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.ExitBtn_Click);
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
            this.panel2.TabIndex = 73;
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
            this.lblSeccion.Size = new System.Drawing.Size(143, 25);
            this.lblSeccion.TabIndex = 49;
            this.lblSeccion.Text = "Datos del Rol";
            // 
            // UserDataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1044, 580);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UserDataForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserDataForm";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label label6;
        public Presentacion.CustomControls.CustomRadioButton rbtnInactive;
        public Presentacion.CustomControls.CustomRadioButton rbtnActivate;

        public Presentacion.CustomControls.CustomComboBox cboxRol;
        private System.Windows.Forms.Label label5;

        private System.Windows.Forms.Label label3;
        public PresentationLayer.Components.CustomTextBox tboxPassword;
        private System.Windows.Forms.Label label4;
        public PresentationLayer.Components.CustomTextBox tboxConfirm;

        private System.Windows.Forms.Label label2;
        public Presentacion.CustomControls.CustomComboBox cboxEmployee;

        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        public PresentationLayer.Components.CustomTextBox tboxUser;
        private FontAwesome.Sharp.IconButton btnSave;
        private FontAwesome.Sharp.IconButton btnSalir;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Label lblSeccion;

        #endregion
    }
}