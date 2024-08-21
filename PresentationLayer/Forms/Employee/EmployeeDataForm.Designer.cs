using System.ComponentModel;

namespace PresentationLayer.Forms.Employee
{
    partial class EmployeeDataForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.rbtnFemenino = new Presentacion.CustomControls.CustomRadioButton();
            this.rbtnMasculino = new Presentacion.CustomControls.CustomRadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.tboxDni = new PresentationLayer.Components.CustomTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tboxApellidoMaterno = new PresentationLayer.Components.CustomTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tboxApellidoPaterno = new PresentationLayer.Components.CustomTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tboxNombre = new PresentationLayer.Components.CustomTextBox();
            this.btnSave = new FontAwesome.Sharp.IconButton();
            this.btnSalir = new FontAwesome.Sharp.IconButton();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(225)))), ((int)(((byte)(230)))));
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.btnSalir);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 57);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1044, 553);
            this.panel1.TabIndex = 63;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.rbtnFemenino);
            this.panel3.Controls.Add(this.rbtnMasculino);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.tboxDni);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.tboxApellidoMaterno);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.tboxApellidoPaterno);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.tboxNombre);
            this.panel3.Location = new System.Drawing.Point(12, 21);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1015, 416);
            this.panel3.TabIndex = 62;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12.25F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(73)))), ((int)(((byte)(85)))));
            this.label5.Location = new System.Drawing.Point(15, 278);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 19);
            this.label5.TabIndex = 59;
            this.label5.Text = "Sexo";
            // 
            // rbtnFemenino
            // 
            this.rbtnFemenino.CheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(168)))), ((int)(((byte)(86)))));
            this.rbtnFemenino.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnFemenino.Location = new System.Drawing.Point(120, 309);
            this.rbtnFemenino.MinimumSize = new System.Drawing.Size(0, 21);
            this.rbtnFemenino.Name = "rbtnFemenino";
            this.rbtnFemenino.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.rbtnFemenino.Size = new System.Drawing.Size(99, 31);
            this.rbtnFemenino.TabIndex = 58;
            this.rbtnFemenino.TabStop = true;
            this.rbtnFemenino.Text = "Femenino";
            this.rbtnFemenino.UnCheckedColor = System.Drawing.Color.Gray;
            this.rbtnFemenino.UseVisualStyleBackColor = true;
            // 
            // rbtnMasculino
            // 
            this.rbtnMasculino.CheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(168)))), ((int)(((byte)(86)))));
            this.rbtnMasculino.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnMasculino.Location = new System.Drawing.Point(15, 309);
            this.rbtnMasculino.MinimumSize = new System.Drawing.Size(0, 21);
            this.rbtnMasculino.Name = "rbtnMasculino";
            this.rbtnMasculino.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.rbtnMasculino.Size = new System.Drawing.Size(99, 31);
            this.rbtnMasculino.TabIndex = 57;
            this.rbtnMasculino.TabStop = true;
            this.rbtnMasculino.Text = "Masculino";
            this.rbtnMasculino.UnCheckedColor = System.Drawing.Color.Gray;
            this.rbtnMasculino.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12.25F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(73)))), ((int)(((byte)(85)))));
            this.label4.Location = new System.Drawing.Point(15, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 19);
            this.label4.TabIndex = 56;
            this.label4.Text = "Dni";
            // 
            // tboxDni
            // 
            this.tboxDni.AllowNull = false;
            this.tboxDni.BackColor = System.Drawing.SystemColors.Window;
            this.tboxDni.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(193)))), ((int)(((byte)(202)))));
            this.tboxDni.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(168)))), ((int)(((byte)(86)))));
            this.tboxDni.BorderRadius = 3;
            this.tboxDni.BorderSize = 1;
            this.tboxDni.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxDni.ForeColor = System.Drawing.Color.DimGray;
            this.tboxDni.Location = new System.Drawing.Point(15, 39);
            this.tboxDni.Margin = new System.Windows.Forms.Padding(4);
            this.tboxDni.Multiline = false;
            this.tboxDni.Name = "tboxDni";
            this.tboxDni.Padding = new System.Windows.Forms.Padding(7);
            this.tboxDni.PasswordChar = false;
            this.tboxDni.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tboxDni.PlaceholderText = "";
            this.tboxDni.ReadOnly = false;
            this.tboxDni.Size = new System.Drawing.Size(973, 31);
            this.tboxDni.TabIndex = 55;
            this.tboxDni.Texts = "";
            this.tboxDni.UnderlinedStyle = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12.25F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(73)))), ((int)(((byte)(85)))));
            this.label3.Location = new System.Drawing.Point(15, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 19);
            this.label3.TabIndex = 54;
            this.label3.Text = "Apellido Materno";
            // 
            // tboxApellidoMaterno
            // 
            this.tboxApellidoMaterno.AllowNull = false;
            this.tboxApellidoMaterno.BackColor = System.Drawing.SystemColors.Window;
            this.tboxApellidoMaterno.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(193)))), ((int)(((byte)(202)))));
            this.tboxApellidoMaterno.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(168)))), ((int)(((byte)(86)))));
            this.tboxApellidoMaterno.BorderRadius = 3;
            this.tboxApellidoMaterno.BorderSize = 1;
            this.tboxApellidoMaterno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxApellidoMaterno.ForeColor = System.Drawing.Color.DimGray;
            this.tboxApellidoMaterno.Location = new System.Drawing.Point(15, 233);
            this.tboxApellidoMaterno.Margin = new System.Windows.Forms.Padding(4);
            this.tboxApellidoMaterno.Multiline = false;
            this.tboxApellidoMaterno.Name = "tboxApellidoMaterno";
            this.tboxApellidoMaterno.Padding = new System.Windows.Forms.Padding(7);
            this.tboxApellidoMaterno.PasswordChar = false;
            this.tboxApellidoMaterno.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tboxApellidoMaterno.PlaceholderText = "";
            this.tboxApellidoMaterno.ReadOnly = false;
            this.tboxApellidoMaterno.Size = new System.Drawing.Size(973, 31);
            this.tboxApellidoMaterno.TabIndex = 53;
            this.tboxApellidoMaterno.Texts = "";
            this.tboxApellidoMaterno.UnderlinedStyle = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12.25F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(73)))), ((int)(((byte)(85)))));
            this.label2.Location = new System.Drawing.Point(15, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 19);
            this.label2.TabIndex = 52;
            this.label2.Text = "Apellido Paterno";
            // 
            // tboxApellidoPaterno
            // 
            this.tboxApellidoPaterno.AllowNull = false;
            this.tboxApellidoPaterno.BackColor = System.Drawing.SystemColors.Window;
            this.tboxApellidoPaterno.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(193)))), ((int)(((byte)(202)))));
            this.tboxApellidoPaterno.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(168)))), ((int)(((byte)(86)))));
            this.tboxApellidoPaterno.BorderRadius = 3;
            this.tboxApellidoPaterno.BorderSize = 1;
            this.tboxApellidoPaterno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxApellidoPaterno.ForeColor = System.Drawing.Color.DimGray;
            this.tboxApellidoPaterno.Location = new System.Drawing.Point(15, 165);
            this.tboxApellidoPaterno.Margin = new System.Windows.Forms.Padding(4);
            this.tboxApellidoPaterno.Multiline = false;
            this.tboxApellidoPaterno.Name = "tboxApellidoPaterno";
            this.tboxApellidoPaterno.Padding = new System.Windows.Forms.Padding(7);
            this.tboxApellidoPaterno.PasswordChar = false;
            this.tboxApellidoPaterno.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tboxApellidoPaterno.PlaceholderText = "";
            this.tboxApellidoPaterno.ReadOnly = false;
            this.tboxApellidoPaterno.Size = new System.Drawing.Size(973, 31);
            this.tboxApellidoPaterno.TabIndex = 51;
            this.tboxApellidoPaterno.Texts = "";
            this.tboxApellidoPaterno.UnderlinedStyle = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(73)))), ((int)(((byte)(85)))));
            this.label1.Location = new System.Drawing.Point(15, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 19);
            this.label1.TabIndex = 50;
            this.label1.Text = "Nombres";
            // 
            // tboxNombre
            // 
            this.tboxNombre.AllowNull = false;
            this.tboxNombre.BackColor = System.Drawing.SystemColors.Window;
            this.tboxNombre.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(193)))), ((int)(((byte)(202)))));
            this.tboxNombre.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(168)))), ((int)(((byte)(86)))));
            this.tboxNombre.BorderRadius = 3;
            this.tboxNombre.BorderSize = 1;
            this.tboxNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxNombre.ForeColor = System.Drawing.Color.DimGray;
            this.tboxNombre.Location = new System.Drawing.Point(15, 97);
            this.tboxNombre.Margin = new System.Windows.Forms.Padding(4);
            this.tboxNombre.Multiline = false;
            this.tboxNombre.Name = "tboxNombre";
            this.tboxNombre.Padding = new System.Windows.Forms.Padding(7);
            this.tboxNombre.PasswordChar = false;
            this.tboxNombre.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tboxNombre.PlaceholderText = "";
            this.tboxNombre.ReadOnly = false;
            this.tboxNombre.Size = new System.Drawing.Size(973, 31);
            this.tboxNombre.TabIndex = 49;
            this.tboxNombre.Texts = "";
            this.tboxNombre.UnderlinedStyle = false;
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
            this.btnSave.Location = new System.Drawing.Point(12, 501);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(148, 40);
            this.btnSave.TabIndex = 59;
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
            this.btnSalir.Location = new System.Drawing.Point(879, 501);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(148, 40);
            this.btnSalir.TabIndex = 61;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(168)))), ((int)(((byte)(86)))));
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.User;
            this.iconPictureBox1.IconColor = System.Drawing.Color.White;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 40;
            this.iconPictureBox1.Location = new System.Drawing.Point(27, 12);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(40, 40);
            this.iconPictureBox1.TabIndex = 48;
            this.iconPictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(168)))), ((int)(((byte)(86)))));
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.iconPictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1044, 57);
            this.panel2.TabIndex = 64;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(73, 18);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(217, 25);
            this.label9.TabIndex = 49;
            this.label9.Text = "Datos del Empleado";
            // 
            // EmployeeDataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1044, 610);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EmployeeDataForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EmployeeDataForm";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label label5;

        public Presentacion.CustomControls.CustomRadioButton rbtnMasculino;
        public Presentacion.CustomControls.CustomRadioButton rbtnFemenino;

        private System.Windows.Forms.Label label4;
        public PresentationLayer.Components.CustomTextBox tboxDni;

        private System.Windows.Forms.Label label2;
        public PresentationLayer.Components.CustomTextBox tboxApellidoPaterno;
        private System.Windows.Forms.Label label3;
        public PresentationLayer.Components.CustomTextBox tboxApellidoMaterno;

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        public PresentationLayer.Components.CustomTextBox tboxNombre;
        private FontAwesome.Sharp.IconButton btnSave;
        private FontAwesome.Sharp.IconButton btnSalir;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label9;

        #endregion
    }
}