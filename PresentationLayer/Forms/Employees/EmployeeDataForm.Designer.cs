using System.ComponentModel;

namespace PresentationLayer.Forms.Employees
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
            this.rbtnFemale = new Presentacion.CustomControls.CustomRadioButton();
            this.rbtnMale = new Presentacion.CustomControls.CustomRadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.tboxDni = new PresentationLayer.Components.CustomTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tboxMaternalLastName = new PresentationLayer.Components.CustomTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tboxFaternalLastName = new PresentationLayer.Components.CustomTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tboxName = new PresentationLayer.Components.CustomTextBox();
            this.btnSave = new FontAwesome.Sharp.IconButton();
            this.btnSalir = new FontAwesome.Sharp.IconButton();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblSection = new System.Windows.Forms.Label();
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
            this.panel3.Controls.Add(this.rbtnFemale);
            this.panel3.Controls.Add(this.rbtnMale);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.tboxDni);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.tboxMaternalLastName);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.tboxFaternalLastName);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.tboxName);
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
            this.label5.Size = new System.Drawing.Size(71, 19);
            this.label5.TabIndex = 59;
            this.label5.Text = "Gender";
            // 
            // rbtnFemale
            // 
            this.rbtnFemale.CheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(168)))), ((int)(((byte)(86)))));
            this.rbtnFemale.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnFemale.Location = new System.Drawing.Point(120, 309);
            this.rbtnFemale.MinimumSize = new System.Drawing.Size(0, 21);
            this.rbtnFemale.Name = "rbtnFemale";
            this.rbtnFemale.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.rbtnFemale.Size = new System.Drawing.Size(99, 31);
            this.rbtnFemale.TabIndex = 58;
            this.rbtnFemale.TabStop = true;
            this.rbtnFemale.Text = "Femenino";
            this.rbtnFemale.UnCheckedColor = System.Drawing.Color.Gray;
            this.rbtnFemale.UseVisualStyleBackColor = true;
            // 
            // rbtnMale
            // 
            this.rbtnMale.CheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(168)))), ((int)(((byte)(86)))));
            this.rbtnMale.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnMale.Location = new System.Drawing.Point(15, 309);
            this.rbtnMale.MinimumSize = new System.Drawing.Size(0, 21);
            this.rbtnMale.Name = "rbtnMale";
            this.rbtnMale.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.rbtnMale.Size = new System.Drawing.Size(99, 31);
            this.rbtnMale.TabIndex = 57;
            this.rbtnMale.TabStop = true;
            this.rbtnMale.Text = "Masculino";
            this.rbtnMale.UnCheckedColor = System.Drawing.Color.Gray;
            this.rbtnMale.UseVisualStyleBackColor = true;
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
            this.tboxDni.AutoFocus = false;
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
            // tboxMaternalLastName
            // 
            this.tboxMaternalLastName.AllowNull = false;
            this.tboxMaternalLastName.AutoFocus = false;
            this.tboxMaternalLastName.BackColor = System.Drawing.SystemColors.Window;
            this.tboxMaternalLastName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(193)))), ((int)(((byte)(202)))));
            this.tboxMaternalLastName.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(168)))), ((int)(((byte)(86)))));
            this.tboxMaternalLastName.BorderRadius = 3;
            this.tboxMaternalLastName.BorderSize = 1;
            this.tboxMaternalLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxMaternalLastName.ForeColor = System.Drawing.Color.DimGray;
            this.tboxMaternalLastName.Location = new System.Drawing.Point(15, 233);
            this.tboxMaternalLastName.Margin = new System.Windows.Forms.Padding(4);
            this.tboxMaternalLastName.Multiline = false;
            this.tboxMaternalLastName.Name = "tboxMaternalLastName";
            this.tboxMaternalLastName.Padding = new System.Windows.Forms.Padding(7);
            this.tboxMaternalLastName.PasswordChar = false;
            this.tboxMaternalLastName.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tboxMaternalLastName.PlaceholderText = "";
            this.tboxMaternalLastName.ReadOnly = false;
            this.tboxMaternalLastName.Size = new System.Drawing.Size(973, 31);
            this.tboxMaternalLastName.TabIndex = 53;
            this.tboxMaternalLastName.Texts = "";
            this.tboxMaternalLastName.UnderlinedStyle = false;
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
            // tboxFaternalLastName
            // 
            this.tboxFaternalLastName.AllowNull = false;
            this.tboxFaternalLastName.AutoFocus = false;
            this.tboxFaternalLastName.BackColor = System.Drawing.SystemColors.Window;
            this.tboxFaternalLastName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(193)))), ((int)(((byte)(202)))));
            this.tboxFaternalLastName.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(168)))), ((int)(((byte)(86)))));
            this.tboxFaternalLastName.BorderRadius = 3;
            this.tboxFaternalLastName.BorderSize = 1;
            this.tboxFaternalLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxFaternalLastName.ForeColor = System.Drawing.Color.DimGray;
            this.tboxFaternalLastName.Location = new System.Drawing.Point(15, 165);
            this.tboxFaternalLastName.Margin = new System.Windows.Forms.Padding(4);
            this.tboxFaternalLastName.Multiline = false;
            this.tboxFaternalLastName.Name = "tboxFaternalLastName";
            this.tboxFaternalLastName.Padding = new System.Windows.Forms.Padding(7);
            this.tboxFaternalLastName.PasswordChar = false;
            this.tboxFaternalLastName.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tboxFaternalLastName.PlaceholderText = "";
            this.tboxFaternalLastName.ReadOnly = false;
            this.tboxFaternalLastName.Size = new System.Drawing.Size(973, 31);
            this.tboxFaternalLastName.TabIndex = 51;
            this.tboxFaternalLastName.Texts = "";
            this.tboxFaternalLastName.UnderlinedStyle = false;
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
            // tboxName
            // 
            this.tboxName.AllowNull = false;
            this.tboxName.AutoFocus = false;
            this.tboxName.BackColor = System.Drawing.SystemColors.Window;
            this.tboxName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(193)))), ((int)(((byte)(202)))));
            this.tboxName.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(168)))), ((int)(((byte)(86)))));
            this.tboxName.BorderRadius = 3;
            this.tboxName.BorderSize = 1;
            this.tboxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxName.ForeColor = System.Drawing.Color.DimGray;
            this.tboxName.Location = new System.Drawing.Point(15, 97);
            this.tboxName.Margin = new System.Windows.Forms.Padding(4);
            this.tboxName.Multiline = false;
            this.tboxName.Name = "tboxName";
            this.tboxName.Padding = new System.Windows.Forms.Padding(7);
            this.tboxName.PasswordChar = false;
            this.tboxName.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tboxName.PlaceholderText = "";
            this.tboxName.ReadOnly = false;
            this.tboxName.Size = new System.Drawing.Size(973, 31);
            this.tboxName.TabIndex = 49;
            this.tboxName.Texts = "";
            this.tboxName.UnderlinedStyle = false;
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
            this.btnSalir.Click += new System.EventHandler(this.ExitBtn_Click);
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
            this.panel2.Controls.Add(this.lblSection);
            this.panel2.Controls.Add(this.iconPictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1044, 57);
            this.panel2.TabIndex = 64;
            // 
            // lblSection
            // 
            this.lblSection.AutoSize = true;
            this.lblSection.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSection.ForeColor = System.Drawing.Color.White;
            this.lblSection.Location = new System.Drawing.Point(73, 18);
            this.lblSection.Name = "lblSection";
            this.lblSection.Size = new System.Drawing.Size(217, 25);
            this.lblSection.TabIndex = 49;
            this.lblSection.Text = "Datos del Empleado";
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

        public Presentacion.CustomControls.CustomRadioButton rbtnMale;
        public Presentacion.CustomControls.CustomRadioButton rbtnFemale;

        private System.Windows.Forms.Label label4;
        public PresentationLayer.Components.CustomTextBox tboxDni;

        private System.Windows.Forms.Label label2;
        public PresentationLayer.Components.CustomTextBox tboxFaternalLastName;
        private System.Windows.Forms.Label label3;
        public PresentationLayer.Components.CustomTextBox tboxMaternalLastName;

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        public PresentationLayer.Components.CustomTextBox tboxName;
        private FontAwesome.Sharp.IconButton btnSave;
        private FontAwesome.Sharp.IconButton btnSalir;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Label lblSection;

        #endregion
    }
}