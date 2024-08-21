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
            this.rbtnInactivo = new Presentacion.CustomControls.CustomRadioButton();
            this.rbtnActivo = new Presentacion.CustomControls.CustomRadioButton();
            this.cboxRol = new Presentacion.CustomControls.CustomComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tboxConfirmarContraseña = new PresentationLayer.Components.CustomTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tboxContraseña = new PresentationLayer.Components.CustomTextBox();
            this.cboxTrabajador = new Presentacion.CustomControls.CustomComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tboxUsuario = new PresentationLayer.Components.CustomTextBox();
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
            this.panel3.Controls.Add(this.rbtnInactivo);
            this.panel3.Controls.Add(this.rbtnActivo);
            this.panel3.Controls.Add(this.cboxRol);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.tboxConfirmarContraseña);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.tboxContraseña);
            this.panel3.Controls.Add(this.cboxTrabajador);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.tboxUsuario);
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
            // rbtnInactivo
            // 
            this.rbtnInactivo.CheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(168)))), ((int)(((byte)(86)))));
            this.rbtnInactivo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnInactivo.Location = new System.Drawing.Point(444, 322);
            this.rbtnInactivo.MinimumSize = new System.Drawing.Size(0, 21);
            this.rbtnInactivo.Name = "rbtnInactivo";
            this.rbtnInactivo.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.rbtnInactivo.Size = new System.Drawing.Size(99, 31);
            this.rbtnInactivo.TabIndex = 61;
            this.rbtnInactivo.Text = "Inactivo";
            this.rbtnInactivo.UnCheckedColor = System.Drawing.Color.Gray;
            this.rbtnInactivo.UseVisualStyleBackColor = true;
            // 
            // rbtnActivo
            // 
            this.rbtnActivo.Checked = true;
            this.rbtnActivo.CheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(168)))), ((int)(((byte)(86)))));
            this.rbtnActivo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnActivo.Location = new System.Drawing.Point(360, 322);
            this.rbtnActivo.MinimumSize = new System.Drawing.Size(0, 21);
            this.rbtnActivo.Name = "rbtnActivo";
            this.rbtnActivo.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.rbtnActivo.Size = new System.Drawing.Size(99, 31);
            this.rbtnActivo.TabIndex = 60;
            this.rbtnActivo.TabStop = true;
            this.rbtnActivo.Text = "Activo";
            this.rbtnActivo.UnCheckedColor = System.Drawing.Color.Gray;
            this.rbtnActivo.UseVisualStyleBackColor = true;
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
            this.tboxConfirmarContraseña.Location = new System.Drawing.Point(15, 246);
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
            this.label3.Location = new System.Drawing.Point(10, 156);
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
            this.tboxContraseña.Location = new System.Drawing.Point(15, 179);
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
            // cboxTrabajador
            // 
            this.cboxTrabajador.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboxTrabajador.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboxTrabajador.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cboxTrabajador.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(193)))), ((int)(((byte)(202)))));
            this.cboxTrabajador.BorderSize = 1;
            this.cboxTrabajador.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cboxTrabajador.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.cboxTrabajador.ForeColor = System.Drawing.Color.DimGray;
            this.cboxTrabajador.IconColor = System.Drawing.Color.Silver;
            this.cboxTrabajador.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cboxTrabajador.ListTextColor = System.Drawing.Color.DimGray;
            this.cboxTrabajador.Location = new System.Drawing.Point(15, 44);
            this.cboxTrabajador.MinimumSize = new System.Drawing.Size(200, 30);
            this.cboxTrabajador.Name = "cboxTrabajador";
            this.cboxTrabajador.Padding = new System.Windows.Forms.Padding(1);
            this.cboxTrabajador.SelectedValue = null;
            this.cboxTrabajador.Size = new System.Drawing.Size(972, 33);
            this.cboxTrabajador.TabIndex = 52;
            this.cboxTrabajador.Texts = "";
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
            this.tboxUsuario.Location = new System.Drawing.Point(15, 116);
            this.tboxUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.tboxUsuario.Multiline = false;
            this.tboxUsuario.Name = "tboxUsuario";
            this.tboxUsuario.Padding = new System.Windows.Forms.Padding(7);
            this.tboxUsuario.PasswordChar = false;
            this.tboxUsuario.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tboxUsuario.PlaceholderText = "";
            this.tboxUsuario.ReadOnly = false;
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
            this.btnSave.Location = new System.Drawing.Point(12, 528);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(148, 40);
            this.btnSave.TabIndex = 71;
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
            this.btnSalir.Location = new System.Drawing.Point(879, 528);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(148, 40);
            this.btnSalir.TabIndex = 72;
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
        public Presentacion.CustomControls.CustomRadioButton rbtnInactivo;
        public Presentacion.CustomControls.CustomRadioButton rbtnActivo;

        public Presentacion.CustomControls.CustomComboBox cboxRol;
        private System.Windows.Forms.Label label5;

        private System.Windows.Forms.Label label3;
        public PresentationLayer.Components.CustomTextBox tboxContraseña;
        private System.Windows.Forms.Label label4;
        public PresentationLayer.Components.CustomTextBox tboxConfirmarContraseña;

        private System.Windows.Forms.Label label2;
        public Presentacion.CustomControls.CustomComboBox cboxTrabajador;

        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        public PresentationLayer.Components.CustomTextBox tboxUsuario;
        private FontAwesome.Sharp.IconButton btnSave;
        private FontAwesome.Sharp.IconButton btnSalir;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Label lblSeccion;

        #endregion
    }
}