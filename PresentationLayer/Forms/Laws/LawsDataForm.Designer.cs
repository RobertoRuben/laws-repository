using System.ComponentModel;

namespace PresentationLayer.Forms.Laws
{
    partial class LawsDataForm
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
            this.btnSalir = new FontAwesome.Sharp.IconButton();
            this.label5 = new System.Windows.Forms.Label();
            this.rbtnInactive = new Presentacion.CustomControls.CustomRadioButton();
            this.rbtnActive = new Presentacion.CustomControls.CustomRadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.tboxNumberLaw = new PresentationLayer.Components.CustomTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tboxPublicationLink = new PresentationLayer.Components.CustomTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tboxLawSummary = new PresentationLayer.Components.CustomTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tboxLawName = new PresentationLayer.Components.CustomTextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.datePicker = new PresentationLayer.Components.CustomDatePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.numPaginas = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cboxPublicationMedium = new Presentacion.CustomControls.CustomComboBox();
            this.cboxCategory = new Presentacion.CustomControls.CustomComboBox();
            this.btnLoadDocument = new FontAwesome.Sharp.IconButton();
            this.label6 = new System.Windows.Forms.Label();
            this.tboxPathArchive = new PresentationLayer.Components.CustomTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSave = new FontAwesome.Sharp.IconButton();
            this.lblSection = new System.Windows.Forms.Label();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPaginas)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
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
            this.btnSalir.Location = new System.Drawing.Point(884, 526);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(148, 40);
            this.btnSalir.TabIndex = 61;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12.25F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(73)))), ((int)(((byte)(85)))));
            this.label5.Location = new System.Drawing.Point(15, 450);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 19);
            this.label5.TabIndex = 59;
            this.label5.Text = "Estado";
            // 
            // rbtnInactive
            // 
            this.rbtnInactive.CheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(168)))), ((int)(((byte)(86)))));
            this.rbtnInactive.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnInactive.Location = new System.Drawing.Point(99, 472);
            this.rbtnInactive.MinimumSize = new System.Drawing.Size(0, 21);
            this.rbtnInactive.Name = "rbtnInactive";
            this.rbtnInactive.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.rbtnInactive.Size = new System.Drawing.Size(99, 31);
            this.rbtnInactive.TabIndex = 10;
            this.rbtnInactive.Text = "Derogado";
            this.rbtnInactive.UnCheckedColor = System.Drawing.Color.Gray;
            this.rbtnInactive.UseVisualStyleBackColor = true;
            // 
            // rbtnActive
            // 
            this.rbtnActive.Checked = true;
            this.rbtnActive.CheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(168)))), ((int)(((byte)(86)))));
            this.rbtnActive.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnActive.Location = new System.Drawing.Point(15, 472);
            this.rbtnActive.MinimumSize = new System.Drawing.Size(0, 21);
            this.rbtnActive.Name = "rbtnActive";
            this.rbtnActive.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.rbtnActive.Size = new System.Drawing.Size(99, 31);
            this.rbtnActive.TabIndex = 9;
            this.rbtnActive.TabStop = true;
            this.rbtnActive.Text = "Vigente";
            this.rbtnActive.UnCheckedColor = System.Drawing.Color.Gray;
            this.rbtnActive.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12.25F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(73)))), ((int)(((byte)(85)))));
            this.label4.Location = new System.Drawing.Point(15, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 19);
            this.label4.TabIndex = 56;
            this.label4.Text = "N° Norma";
            // 
            // tboxNumberLaw
            // 
            this.tboxNumberLaw.AllowNull = false;
            this.tboxNumberLaw.AutoFocus = false;
            this.tboxNumberLaw.BackColor = System.Drawing.SystemColors.Window;
            this.tboxNumberLaw.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(193)))), ((int)(((byte)(202)))));
            this.tboxNumberLaw.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(168)))), ((int)(((byte)(86)))));
            this.tboxNumberLaw.BorderRadius = 3;
            this.tboxNumberLaw.BorderSize = 1;
            this.tboxNumberLaw.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxNumberLaw.ForeColor = System.Drawing.Color.DimGray;
            this.tboxNumberLaw.Location = new System.Drawing.Point(15, 39);
            this.tboxNumberLaw.Margin = new System.Windows.Forms.Padding(4);
            this.tboxNumberLaw.Multiline = false;
            this.tboxNumberLaw.Name = "tboxNumberLaw";
            this.tboxNumberLaw.Padding = new System.Windows.Forms.Padding(7);
            this.tboxNumberLaw.PasswordChar = false;
            this.tboxNumberLaw.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tboxNumberLaw.PlaceholderText = "";
            this.tboxNumberLaw.ReadOnly = false;
            this.tboxNumberLaw.Size = new System.Drawing.Size(985, 31);
            this.tboxNumberLaw.TabIndex = 1;
            this.tboxNumberLaw.Texts = "";
            this.tboxNumberLaw.UnderlinedStyle = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12.25F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(73)))), ((int)(((byte)(85)))));
            this.label3.Location = new System.Drawing.Point(15, 245);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(195, 19);
            this.label3.TabIndex = 54;
            this.label3.Text = "Link Publicacion - web";
            // 
            // tboxPublicationLink
            // 
            this.tboxPublicationLink.AllowNull = false;
            this.tboxPublicationLink.AutoFocus = false;
            this.tboxPublicationLink.BackColor = System.Drawing.SystemColors.Window;
            this.tboxPublicationLink.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(193)))), ((int)(((byte)(202)))));
            this.tboxPublicationLink.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(168)))), ((int)(((byte)(86)))));
            this.tboxPublicationLink.BorderRadius = 3;
            this.tboxPublicationLink.BorderSize = 1;
            this.tboxPublicationLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxPublicationLink.ForeColor = System.Drawing.Color.DimGray;
            this.tboxPublicationLink.Location = new System.Drawing.Point(15, 268);
            this.tboxPublicationLink.Margin = new System.Windows.Forms.Padding(4);
            this.tboxPublicationLink.Multiline = false;
            this.tboxPublicationLink.Name = "tboxPublicationLink";
            this.tboxPublicationLink.Padding = new System.Windows.Forms.Padding(7);
            this.tboxPublicationLink.PasswordChar = false;
            this.tboxPublicationLink.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tboxPublicationLink.PlaceholderText = "";
            this.tboxPublicationLink.ReadOnly = false;
            this.tboxPublicationLink.Size = new System.Drawing.Size(985, 31);
            this.tboxPublicationLink.TabIndex = 4;
            this.tboxPublicationLink.Texts = "";
            this.tboxPublicationLink.UnderlinedStyle = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12.25F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(73)))), ((int)(((byte)(85)))));
            this.label2.Location = new System.Drawing.Point(15, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 19);
            this.label2.TabIndex = 52;
            this.label2.Text = "Resumen";
            // 
            // tboxLawSummary
            // 
            this.tboxLawSummary.AllowNull = false;
            this.tboxLawSummary.AutoFocus = false;
            this.tboxLawSummary.BackColor = System.Drawing.SystemColors.Window;
            this.tboxLawSummary.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(193)))), ((int)(((byte)(202)))));
            this.tboxLawSummary.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(168)))), ((int)(((byte)(86)))));
            this.tboxLawSummary.BorderRadius = 3;
            this.tboxLawSummary.BorderSize = 1;
            this.tboxLawSummary.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxLawSummary.ForeColor = System.Drawing.Color.DimGray;
            this.tboxLawSummary.Location = new System.Drawing.Point(15, 158);
            this.tboxLawSummary.Margin = new System.Windows.Forms.Padding(4);
            this.tboxLawSummary.Multiline = true;
            this.tboxLawSummary.Name = "tboxLawSummary";
            this.tboxLawSummary.Padding = new System.Windows.Forms.Padding(7);
            this.tboxLawSummary.PasswordChar = false;
            this.tboxLawSummary.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tboxLawSummary.PlaceholderText = "";
            this.tboxLawSummary.ReadOnly = false;
            this.tboxLawSummary.Size = new System.Drawing.Size(985, 75);
            this.tboxLawSummary.TabIndex = 3;
            this.tboxLawSummary.Texts = "";
            this.tboxLawSummary.UnderlinedStyle = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(73)))), ((int)(((byte)(85)))));
            this.label1.Location = new System.Drawing.Point(15, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 19);
            this.label1.TabIndex = 50;
            this.label1.Text = "Nombre de Norma";
            // 
            // tboxLawName
            // 
            this.tboxLawName.AllowNull = false;
            this.tboxLawName.AutoFocus = false;
            this.tboxLawName.BackColor = System.Drawing.SystemColors.Window;
            this.tboxLawName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(193)))), ((int)(((byte)(202)))));
            this.tboxLawName.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(168)))), ((int)(((byte)(86)))));
            this.tboxLawName.BorderRadius = 3;
            this.tboxLawName.BorderSize = 1;
            this.tboxLawName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxLawName.ForeColor = System.Drawing.Color.DimGray;
            this.tboxLawName.Location = new System.Drawing.Point(15, 97);
            this.tboxLawName.Margin = new System.Windows.Forms.Padding(4);
            this.tboxLawName.Multiline = false;
            this.tboxLawName.Name = "tboxLawName";
            this.tboxLawName.Padding = new System.Windows.Forms.Padding(7);
            this.tboxLawName.PasswordChar = false;
            this.tboxLawName.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tboxLawName.PlaceholderText = "";
            this.tboxLawName.ReadOnly = false;
            this.tboxLawName.Size = new System.Drawing.Size(985, 31);
            this.tboxLawName.TabIndex = 2;
            this.tboxLawName.Texts = "";
            this.tboxLawName.UnderlinedStyle = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.datePicker);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.numPaginas);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.cboxPublicationMedium);
            this.panel3.Controls.Add(this.cboxCategory);
            this.panel3.Controls.Add(this.btnLoadDocument);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.tboxPathArchive);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.rbtnInactive);
            this.panel3.Controls.Add(this.rbtnActive);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.tboxNumberLaw);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.tboxPublicationLink);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.tboxLawSummary);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.tboxLawName);
            this.panel3.Location = new System.Drawing.Point(12, 6);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1020, 514);
            this.panel3.TabIndex = 62;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12.25F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(73)))), ((int)(((byte)(85)))));
            this.label9.Location = new System.Drawing.Point(775, 312);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(162, 19);
            this.label9.TabIndex = 69;
            this.label9.Text = "Fecha Publicacion";
            // 
            // datePicker
            // 
            this.datePicker.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(193)))), ((int)(((byte)(202)))));
            this.datePicker.BorderSize = 1;
            this.datePicker.CustomFormat = "";
            this.datePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datePicker.Location = new System.Drawing.Point(775, 332);
            this.datePicker.MinimumSize = new System.Drawing.Size(4, 35);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(162, 35);
            this.datePicker.SkinColor = System.Drawing.Color.White;
            this.datePicker.TabIndex = 7;
            this.datePicker.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(73)))), ((int)(((byte)(85)))));
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 12.25F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(73)))), ((int)(((byte)(85)))));
            this.label10.Location = new System.Drawing.Point(238, 450);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(99, 19);
            this.label10.TabIndex = 67;
            this.label10.Text = "N° Paginas";
            // 
            // numPaginas
            // 
            this.numPaginas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.numPaginas.Location = new System.Drawing.Point(238, 479);
            this.numPaginas.Maximum = new decimal(new int[] { 500, 0, 0, 0 });
            this.numPaginas.Name = "numPaginas";
            this.numPaginas.Size = new System.Drawing.Size(138, 22);
            this.numPaginas.TabIndex = 10;
            this.numPaginas.Value = new decimal(new int[] { 11, 0, 0, 0 });
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12.25F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(73)))), ((int)(((byte)(85)))));
            this.label8.Location = new System.Drawing.Point(393, 312);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(163, 19);
            this.label8.TabIndex = 66;
            this.label8.Text = "Medio Publicacion";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12.25F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(73)))), ((int)(((byte)(85)))));
            this.label7.Location = new System.Drawing.Point(15, 312);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 19);
            this.label7.TabIndex = 65;
            this.label7.Text = "Categoria";
            // 
            // cboxPublicationMedium
            // 
            this.cboxPublicationMedium.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboxPublicationMedium.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboxPublicationMedium.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cboxPublicationMedium.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(193)))), ((int)(((byte)(202)))));
            this.cboxPublicationMedium.BorderSize = 1;
            this.cboxPublicationMedium.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cboxPublicationMedium.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.cboxPublicationMedium.ForeColor = System.Drawing.Color.DimGray;
            this.cboxPublicationMedium.IconColor = System.Drawing.Color.Silver;
            this.cboxPublicationMedium.Items.AddRange(new object[] { "Diario El Peruano", "Portal web del Congreso de la República ", "Portal web del Poder Judicial", "Otros" });
            this.cboxPublicationMedium.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cboxPublicationMedium.ListTextColor = System.Drawing.Color.DimGray;
            this.cboxPublicationMedium.Location = new System.Drawing.Point(393, 334);
            this.cboxPublicationMedium.MinimumSize = new System.Drawing.Size(200, 30);
            this.cboxPublicationMedium.Name = "cboxPublicationMedium";
            this.cboxPublicationMedium.Padding = new System.Windows.Forms.Padding(1);
            this.cboxPublicationMedium.SelectedValue = null;
            this.cboxPublicationMedium.Size = new System.Drawing.Size(372, 33);
            this.cboxPublicationMedium.TabIndex = 6;
            this.cboxPublicationMedium.Texts = "";
            // 
            // cboxCategory
            // 
            this.cboxCategory.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboxCategory.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboxCategory.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cboxCategory.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(193)))), ((int)(((byte)(202)))));
            this.cboxCategory.BorderSize = 1;
            this.cboxCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cboxCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.cboxCategory.ForeColor = System.Drawing.Color.DimGray;
            this.cboxCategory.IconColor = System.Drawing.Color.Silver;
            this.cboxCategory.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cboxCategory.ListTextColor = System.Drawing.Color.DimGray;
            this.cboxCategory.Location = new System.Drawing.Point(15, 334);
            this.cboxCategory.MinimumSize = new System.Drawing.Size(200, 30);
            this.cboxCategory.Name = "cboxCategory";
            this.cboxCategory.Padding = new System.Windows.Forms.Padding(1);
            this.cboxCategory.SelectedValue = null;
            this.cboxCategory.Size = new System.Drawing.Size(372, 33);
            this.cboxCategory.TabIndex = 5;
            this.cboxCategory.Texts = "";
            // 
            // btnLoadDocument
            // 
            this.btnLoadDocument.IconChar = FontAwesome.Sharp.IconChar.FileUpload;
            this.btnLoadDocument.IconColor = System.Drawing.Color.Gray;
            this.btnLoadDocument.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLoadDocument.IconSize = 25;
            this.btnLoadDocument.Location = new System.Drawing.Point(698, 399);
            this.btnLoadDocument.Name = "btnLoadDocument";
            this.btnLoadDocument.Size = new System.Drawing.Size(63, 31);
            this.btnLoadDocument.TabIndex = 62;
            this.btnLoadDocument.UseVisualStyleBackColor = true;
            this.btnLoadDocument.Click += new System.EventHandler(this.btnLoadDocument_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12.25F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(73)))), ((int)(((byte)(85)))));
            this.label6.Location = new System.Drawing.Point(15, 376);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 19);
            this.label6.TabIndex = 61;
            this.label6.Text = "Ruta Archivo";
            // 
            // tboxPathArchive
            // 
            this.tboxPathArchive.AllowNull = false;
            this.tboxPathArchive.AutoFocus = false;
            this.tboxPathArchive.BackColor = System.Drawing.SystemColors.Window;
            this.tboxPathArchive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(193)))), ((int)(((byte)(202)))));
            this.tboxPathArchive.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(168)))), ((int)(((byte)(86)))));
            this.tboxPathArchive.BorderRadius = 3;
            this.tboxPathArchive.BorderSize = 1;
            this.tboxPathArchive.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxPathArchive.ForeColor = System.Drawing.Color.DimGray;
            this.tboxPathArchive.Location = new System.Drawing.Point(15, 399);
            this.tboxPathArchive.Margin = new System.Windows.Forms.Padding(4);
            this.tboxPathArchive.Multiline = false;
            this.tboxPathArchive.Name = "tboxPathArchive";
            this.tboxPathArchive.Padding = new System.Windows.Forms.Padding(7);
            this.tboxPathArchive.PasswordChar = false;
            this.tboxPathArchive.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tboxPathArchive.PlaceholderText = "";
            this.tboxPathArchive.ReadOnly = true;
            this.tboxPathArchive.Size = new System.Drawing.Size(676, 31);
            this.tboxPathArchive.TabIndex = 8;
            this.tboxPathArchive.Texts = "";
            this.tboxPathArchive.UnderlinedStyle = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(225)))), ((int)(((byte)(230)))));
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.btnSalir);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 57);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1044, 573);
            this.panel1.TabIndex = 65;
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
            this.btnSave.Location = new System.Drawing.Point(12, 526);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(148, 40);
            this.btnSave.TabIndex = 59;
            this.btnSave.Text = "    Guardar";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblSection
            // 
            this.lblSection.AutoSize = true;
            this.lblSection.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSection.ForeColor = System.Drawing.Color.White;
            this.lblSection.Location = new System.Drawing.Point(73, 18);
            this.lblSection.Name = "lblSection";
            this.lblSection.Size = new System.Drawing.Size(148, 25);
            this.lblSection.TabIndex = 49;
            this.lblSection.Text = "Datos de Law";
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(168)))), ((int)(((byte)(86)))));
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.List;
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
            this.panel2.TabIndex = 66;
            // 
            // LawsDataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1044, 630);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LawsDataForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LawsDataForm";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPaginas)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label label9;

        public PresentationLayer.Components.CustomDatePicker datePicker;

        private System.Windows.Forms.Label label10;

        public System.Windows.Forms.NumericUpDown numPaginas;

        public Presentacion.CustomControls.CustomComboBox cboxPublicationMedium;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;

        public Presentacion.CustomControls.CustomComboBox cboxCategory;

        public FontAwesome.Sharp.IconButton btnLoadDocument;

        private System.Windows.Forms.Label label6;
        public PresentationLayer.Components.CustomTextBox tboxPathArchive;

        private FontAwesome.Sharp.IconButton btnSalir;
        private System.Windows.Forms.Label label5;
        public Presentacion.CustomControls.CustomRadioButton rbtnInactive;
        public Presentacion.CustomControls.CustomRadioButton rbtnActive;
        private System.Windows.Forms.Label label4;
        public PresentationLayer.Components.CustomTextBox tboxNumberLaw;
        private System.Windows.Forms.Label label3;
        public PresentationLayer.Components.CustomTextBox tboxPublicationLink;
        private System.Windows.Forms.Label label2;
        public PresentationLayer.Components.CustomTextBox tboxLawSummary;
        private System.Windows.Forms.Label label1;
        public PresentationLayer.Components.CustomTextBox tboxLawName;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        public FontAwesome.Sharp.IconButton btnSave;
        public System.Windows.Forms.Label lblSection;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.Panel panel2;

        #endregion
    }
}