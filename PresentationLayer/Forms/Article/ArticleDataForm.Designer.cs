using System.ComponentModel;

namespace PresentationLayer.Forms.Article
{
    partial class ArticleDataForm
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
            this.lblSection = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSave = new FontAwesome.Sharp.IconButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.numPaginas = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.rbtnInactive = new Presentacion.CustomControls.CustomRadioButton();
            this.rbtnActive = new Presentacion.CustomControls.CustomRadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.tboxDescription = new PresentationLayer.Components.CustomTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tboxArticleDenominartion = new PresentationLayer.Components.CustomTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxoArticleNumber = new PresentationLayer.Components.CustomTextBox();
            this.CloseBtn = new FontAwesome.Sharp.IconButton();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPaginas)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSection
            // 
            this.lblSection.AutoSize = true;
            this.lblSection.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSection.ForeColor = System.Drawing.Color.White;
            this.lblSection.Location = new System.Drawing.Point(64, 18);
            this.lblSection.Name = "lblSection";
            this.lblSection.Size = new System.Drawing.Size(190, 25);
            this.lblSection.TabIndex = 49;
            this.lblSection.Text = "Registrar artículos";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(168)))), ((int)(((byte)(86)))));
            this.panel2.Controls.Add(this.iconPictureBox1);
            this.panel2.Controls.Add(this.lblSection);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1044, 57);
            this.panel2.TabIndex = 65;
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(168)))), ((int)(((byte)(86)))));
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.List;
            this.iconPictureBox1.IconColor = System.Drawing.Color.White;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 40;
            this.iconPictureBox1.Location = new System.Drawing.Point(18, 11);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(40, 40);
            this.iconPictureBox1.TabIndex = 70;
            this.iconPictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(225)))), ((int)(((byte)(230)))));
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.CloseBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 57);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1044, 523);
            this.panel1.TabIndex = 66;
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
            this.btnSave.Location = new System.Drawing.Point(14, 471);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(148, 40);
            this.btnSave.TabIndex = 71;
            this.btnSave.Text = "    Guardar";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.numPaginas);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.rbtnInactive);
            this.panel3.Controls.Add(this.rbtnActive);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.tboxDescription);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.tboxArticleDenominartion);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.tbxoArticleNumber);
            this.panel3.Location = new System.Drawing.Point(14, 16);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1015, 356);
            this.panel3.TabIndex = 70;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 12.25F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(73)))), ((int)(((byte)(85)))));
            this.label10.Location = new System.Drawing.Point(238, 277);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(99, 19);
            this.label10.TabIndex = 72;
            this.label10.Text = "N° Paginas";
            // 
            // numPaginas
            // 
            this.numPaginas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.numPaginas.Location = new System.Drawing.Point(238, 306);
            this.numPaginas.Maximum = new decimal(new int[] { 500, 0, 0, 0 });
            this.numPaginas.Name = "numPaginas";
            this.numPaginas.Size = new System.Drawing.Size(138, 22);
            this.numPaginas.TabIndex = 69;
            this.numPaginas.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12.25F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(73)))), ((int)(((byte)(85)))));
            this.label5.Location = new System.Drawing.Point(15, 277);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 19);
            this.label5.TabIndex = 71;
            this.label5.Text = "Estado";
            // 
            // rbtnInactive
            // 
            this.rbtnInactive.CheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(168)))), ((int)(((byte)(86)))));
            this.rbtnInactive.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnInactive.Location = new System.Drawing.Point(99, 299);
            this.rbtnInactive.MinimumSize = new System.Drawing.Size(0, 21);
            this.rbtnInactive.Name = "rbtnInactive";
            this.rbtnInactive.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.rbtnInactive.Size = new System.Drawing.Size(99, 31);
            this.rbtnInactive.TabIndex = 70;
            this.rbtnInactive.Text = "Derogado";
            this.rbtnInactive.UnCheckedColor = System.Drawing.Color.Gray;
            this.rbtnInactive.UseVisualStyleBackColor = true;
            // 
            // rbtnActive
            // 
            this.rbtnActive.Checked = true;
            this.rbtnActive.CheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(168)))), ((int)(((byte)(86)))));
            this.rbtnActive.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnActive.Location = new System.Drawing.Point(15, 299);
            this.rbtnActive.MinimumSize = new System.Drawing.Size(0, 21);
            this.rbtnActive.Name = "rbtnActive";
            this.rbtnActive.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.rbtnActive.Size = new System.Drawing.Size(99, 31);
            this.rbtnActive.TabIndex = 68;
            this.rbtnActive.TabStop = true;
            this.rbtnActive.Text = "Vigente";
            this.rbtnActive.UnCheckedColor = System.Drawing.Color.Gray;
            this.rbtnActive.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12.25F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(73)))), ((int)(((byte)(85)))));
            this.label3.Location = new System.Drawing.Point(15, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 19);
            this.label3.TabIndex = 54;
            this.label3.Text = "Descripcion";
            // 
            // tboxDescription
            // 
            this.tboxDescription.AllowNull = false;
            this.tboxDescription.AutoFocus = false;
            this.tboxDescription.BackColor = System.Drawing.SystemColors.Window;
            this.tboxDescription.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(193)))), ((int)(((byte)(202)))));
            this.tboxDescription.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(168)))), ((int)(((byte)(86)))));
            this.tboxDescription.BorderRadius = 3;
            this.tboxDescription.BorderSize = 1;
            this.tboxDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxDescription.ForeColor = System.Drawing.Color.DimGray;
            this.tboxDescription.Location = new System.Drawing.Point(15, 177);
            this.tboxDescription.Margin = new System.Windows.Forms.Padding(4);
            this.tboxDescription.Multiline = true;
            this.tboxDescription.Name = "tboxDescription";
            this.tboxDescription.Padding = new System.Windows.Forms.Padding(7);
            this.tboxDescription.PasswordChar = false;
            this.tboxDescription.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tboxDescription.PlaceholderText = "";
            this.tboxDescription.ReadOnly = false;
            this.tboxDescription.Size = new System.Drawing.Size(981, 75);
            this.tboxDescription.TabIndex = 53;
            this.tboxDescription.Texts = "";
            this.tboxDescription.UnderlinedStyle = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12.25F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(73)))), ((int)(((byte)(85)))));
            this.label2.Location = new System.Drawing.Point(15, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 19);
            this.label2.TabIndex = 52;
            this.label2.Text = "Denominacion";
            // 
            // tboxArticleDenominartion
            // 
            this.tboxArticleDenominartion.AllowNull = false;
            this.tboxArticleDenominartion.AutoFocus = false;
            this.tboxArticleDenominartion.BackColor = System.Drawing.SystemColors.Window;
            this.tboxArticleDenominartion.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(193)))), ((int)(((byte)(202)))));
            this.tboxArticleDenominartion.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(168)))), ((int)(((byte)(86)))));
            this.tboxArticleDenominartion.BorderRadius = 3;
            this.tboxArticleDenominartion.BorderSize = 1;
            this.tboxArticleDenominartion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxArticleDenominartion.ForeColor = System.Drawing.Color.DimGray;
            this.tboxArticleDenominartion.Location = new System.Drawing.Point(15, 111);
            this.tboxArticleDenominartion.Margin = new System.Windows.Forms.Padding(4);
            this.tboxArticleDenominartion.Multiline = false;
            this.tboxArticleDenominartion.Name = "tboxArticleDenominartion";
            this.tboxArticleDenominartion.Padding = new System.Windows.Forms.Padding(7);
            this.tboxArticleDenominartion.PasswordChar = false;
            this.tboxArticleDenominartion.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tboxArticleDenominartion.PlaceholderText = "";
            this.tboxArticleDenominartion.ReadOnly = false;
            this.tboxArticleDenominartion.Size = new System.Drawing.Size(981, 31);
            this.tboxArticleDenominartion.TabIndex = 51;
            this.tboxArticleDenominartion.Texts = "";
            this.tboxArticleDenominartion.UnderlinedStyle = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(73)))), ((int)(((byte)(85)))));
            this.label1.Location = new System.Drawing.Point(15, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 19);
            this.label1.TabIndex = 50;
            this.label1.Text = "N° de Articulo";
            // 
            // tbxoArticleNumber
            // 
            this.tbxoArticleNumber.AllowNull = false;
            this.tbxoArticleNumber.AutoFocus = false;
            this.tbxoArticleNumber.BackColor = System.Drawing.SystemColors.Window;
            this.tbxoArticleNumber.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(193)))), ((int)(((byte)(202)))));
            this.tbxoArticleNumber.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(168)))), ((int)(((byte)(86)))));
            this.tbxoArticleNumber.BorderRadius = 3;
            this.tbxoArticleNumber.BorderSize = 1;
            this.tbxoArticleNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxoArticleNumber.ForeColor = System.Drawing.Color.DimGray;
            this.tbxoArticleNumber.Location = new System.Drawing.Point(15, 44);
            this.tbxoArticleNumber.Margin = new System.Windows.Forms.Padding(4);
            this.tbxoArticleNumber.Multiline = false;
            this.tbxoArticleNumber.Name = "tbxoArticleNumber";
            this.tbxoArticleNumber.Padding = new System.Windows.Forms.Padding(7);
            this.tbxoArticleNumber.PasswordChar = false;
            this.tbxoArticleNumber.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tbxoArticleNumber.PlaceholderText = "";
            this.tbxoArticleNumber.ReadOnly = false;
            this.tbxoArticleNumber.Size = new System.Drawing.Size(981, 31);
            this.tbxoArticleNumber.TabIndex = 49;
            this.tbxoArticleNumber.Texts = "";
            this.tbxoArticleNumber.UnderlinedStyle = false;
            // 
            // CloseBtn
            // 
            this.CloseBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(21)))), ((int)(((byte)(30)))));
            this.CloseBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(21)))), ((int)(((byte)(30)))));
            this.CloseBtn.FlatAppearance.BorderSize = 0;
            this.CloseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseBtn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.CloseBtn.ForeColor = System.Drawing.Color.White;
            this.CloseBtn.IconChar = FontAwesome.Sharp.IconChar.None;
            this.CloseBtn.IconColor = System.Drawing.Color.White;
            this.CloseBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.CloseBtn.IconSize = 32;
            this.CloseBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CloseBtn.Location = new System.Drawing.Point(883, 471);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(148, 40);
            this.CloseBtn.TabIndex = 69;
            this.CloseBtn.Text = "Salir";
            this.CloseBtn.UseVisualStyleBackColor = false;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // ArticleDataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1044, 580);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ArticleDataForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ArticleDataForm";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPaginas)).EndInit();
            this.ResumeLayout(false);
        }

        public FontAwesome.Sharp.IconButton btnSave;

        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.NumericUpDown numPaginas;
        private System.Windows.Forms.Label label5;
        public Presentacion.CustomControls.CustomRadioButton rbtnInactive;
        public Presentacion.CustomControls.CustomRadioButton rbtnActive;

        private System.Windows.Forms.Label label3;
        public PresentationLayer.Components.CustomTextBox tboxDescription;

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        public PresentationLayer.Components.CustomTextBox tbxoArticleNumber;
        public PresentationLayer.Components.CustomTextBox tboxArticleDenominartion;
        private System.Windows.Forms.Label label2;

        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;

        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton CloseBtn;

        public System.Windows.Forms.Label lblSection;
        private System.Windows.Forms.Panel panel2;

        #endregion
    }
}