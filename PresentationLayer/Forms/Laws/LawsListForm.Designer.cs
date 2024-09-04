using System.ComponentModel;

namespace PresentationLayer.Forms.Laws
{
    partial class LawsListForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.searchTbox = new PresentationLayer.Components.CustomTextBox();
            this.ClearSearchBtn = new FontAwesome.Sharp.IconButton();
            this.label13 = new System.Windows.Forms.Label();
            this.DeleteBtn = new FontAwesome.Sharp.IconButton();
            this.label10 = new System.Windows.Forms.Label();
            this.lblResultados = new System.Windows.Forms.Label();
            this.dgvLaws = new System.Windows.Forms.DataGridView();
            this.UpdateBtn = new FontAwesome.Sharp.IconButton();
            this.AddBtn = new FontAwesome.Sharp.IconButton();
            this.btnPrevious = new FontAwesome.Sharp.IconButton();
            this.btnNext = new FontAwesome.Sharp.IconButton();
            this.OpenDocumentBtn = new FontAwesome.Sharp.IconButton();
            this.AddArticleBtn = new FontAwesome.Sharp.IconButton();
            this.DetailsBtn = new FontAwesome.Sharp.IconButton();
            this.ReportBtn = new FontAwesome.Sharp.IconButton();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLaws)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.panel2.Controls.Add(this.searchTbox);
            this.panel2.Controls.Add(this.ClearSearchBtn);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Location = new System.Drawing.Point(12, 13);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1020, 46);
            this.panel2.TabIndex = 65;
            // 
            // searchTbox
            // 
            this.searchTbox.AllowNull = false;
            this.searchTbox.AutoFocus = false;
            this.searchTbox.BackColor = System.Drawing.SystemColors.Window;
            this.searchTbox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(193)))), ((int)(((byte)(202)))));
            this.searchTbox.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(168)))), ((int)(((byte)(86)))));
            this.searchTbox.BorderRadius = 1;
            this.searchTbox.BorderSize = 1;
            this.searchTbox.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.searchTbox.ForeColor = System.Drawing.Color.DimGray;
            this.searchTbox.Location = new System.Drawing.Point(81, 7);
            this.searchTbox.Margin = new System.Windows.Forms.Padding(4);
            this.searchTbox.Multiline = false;
            this.searchTbox.Name = "searchTbox";
            this.searchTbox.Padding = new System.Windows.Forms.Padding(7);
            this.searchTbox.PasswordChar = false;
            this.searchTbox.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.searchTbox.PlaceholderText = "";
            this.searchTbox.ReadOnly = false;
            this.searchTbox.Size = new System.Drawing.Size(342, 35);
            this.searchTbox.TabIndex = 66;
            this.searchTbox.Texts = "";
            this.searchTbox.UnderlinedStyle = false;
            this.searchTbox._TextChanged += new System.EventHandler(this.searchTbox__TextChanged);
            // 
            // ClearSearchBtn
            // 
            this.ClearSearchBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(168)))), ((int)(((byte)(86)))));
            this.ClearSearchBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.ClearSearchBtn.FlatAppearance.BorderSize = 0;
            this.ClearSearchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearSearchBtn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.ClearSearchBtn.ForeColor = System.Drawing.Color.White;
            this.ClearSearchBtn.IconChar = FontAwesome.Sharp.IconChar.Eraser;
            this.ClearSearchBtn.IconColor = System.Drawing.Color.White;
            this.ClearSearchBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ClearSearchBtn.IconSize = 25;
            this.ClearSearchBtn.Location = new System.Drawing.Point(430, 7);
            this.ClearSearchBtn.Name = "ClearSearchBtn";
            this.ClearSearchBtn.Size = new System.Drawing.Size(42, 35);
            this.ClearSearchBtn.TabIndex = 55;
            this.ClearSearchBtn.UseVisualStyleBackColor = false;
            this.ClearSearchBtn.Click += new System.EventHandler(this.ClearSearchBtn_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.label13.Location = new System.Drawing.Point(10, 12);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(62, 20);
            this.label13.TabIndex = 21;
            this.label13.Text = "Buscar:";
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.DeleteBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(168)))), ((int)(((byte)(86)))));
            this.DeleteBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.DeleteBtn.FlatAppearance.BorderSize = 0;
            this.DeleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteBtn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.DeleteBtn.ForeColor = System.Drawing.Color.White;
            this.DeleteBtn.IconChar = FontAwesome.Sharp.IconChar.FileCircleXmark;
            this.DeleteBtn.IconColor = System.Drawing.Color.White;
            this.DeleteBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.DeleteBtn.IconSize = 32;
            this.DeleteBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DeleteBtn.Location = new System.Drawing.Point(320, 558);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(148, 40);
            this.DeleteBtn.TabIndex = 68;
            this.DeleteBtn.Text = "  Eliminar";
            this.DeleteBtn.UseVisualStyleBackColor = false;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(168)))), ((int)(((byte)(86)))));
            this.label10.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(12, 73);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(184, 22);
            this.label10.TabIndex = 67;
            this.label10.Text = "Normas Registradas";
            // 
            // lblResultados
            // 
            this.lblResultados.AutoSize = true;
            this.lblResultados.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.lblResultados.Location = new System.Drawing.Point(12, 421);
            this.lblResultados.Name = "lblResultados";
            this.lblResultados.Size = new System.Drawing.Size(150, 20);
            this.lblResultados.TabIndex = 66;
            this.lblResultados.Text = "Registro mostrados:";
            // 
            // dgvLaws
            // 
            this.dgvLaws.AllowUserToAddRows = false;
            this.dgvLaws.AllowUserToDeleteRows = false;
            this.dgvLaws.AllowUserToOrderColumns = true;
            this.dgvLaws.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvLaws.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLaws.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvLaws.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(245)))));
            this.dgvLaws.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvLaws.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(210)))), ((int)(((byte)(218)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(210)))), ((int)(((byte)(218)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLaws.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvLaws.ColumnHeadersHeight = 40;
            this.dgvLaws.EnableHeadersVisualStyles = false;
            this.dgvLaws.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(225)))), ((int)(((byte)(230)))));
            this.dgvLaws.Location = new System.Drawing.Point(12, 95);
            this.dgvLaws.Name = "dgvLaws";
            this.dgvLaws.ReadOnly = true;
            this.dgvLaws.RowHeadersVisible = false;
            this.dgvLaws.RowHeadersWidth = 35;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(251)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(225)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvLaws.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvLaws.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLaws.Size = new System.Drawing.Size(1017, 308);
            this.dgvLaws.TabIndex = 64;
            this.dgvLaws.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLaws_CellDoubleClick);
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.UpdateBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(168)))), ((int)(((byte)(86)))));
            this.UpdateBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.UpdateBtn.FlatAppearance.BorderSize = 0;
            this.UpdateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateBtn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.UpdateBtn.ForeColor = System.Drawing.Color.White;
            this.UpdateBtn.IconChar = FontAwesome.Sharp.IconChar.FilePen;
            this.UpdateBtn.IconColor = System.Drawing.Color.White;
            this.UpdateBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.UpdateBtn.IconSize = 32;
            this.UpdateBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.UpdateBtn.Location = new System.Drawing.Point(166, 558);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(148, 40);
            this.UpdateBtn.TabIndex = 63;
            this.UpdateBtn.Text = "  Modificar";
            this.UpdateBtn.UseVisualStyleBackColor = false;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // AddBtn
            // 
            this.AddBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AddBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(168)))), ((int)(((byte)(86)))));
            this.AddBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.AddBtn.FlatAppearance.BorderSize = 0;
            this.AddBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddBtn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.AddBtn.ForeColor = System.Drawing.Color.White;
            this.AddBtn.IconChar = FontAwesome.Sharp.IconChar.FileCirclePlus;
            this.AddBtn.IconColor = System.Drawing.Color.White;
            this.AddBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.AddBtn.IconSize = 32;
            this.AddBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddBtn.Location = new System.Drawing.Point(12, 558);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(148, 40);
            this.AddBtn.TabIndex = 62;
            this.AddBtn.Text = "Nuevo";
            this.AddBtn.UseVisualStyleBackColor = false;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrevious.IconChar = FontAwesome.Sharp.IconChar.ChevronLeft;
            this.btnPrevious.IconColor = System.Drawing.Color.DimGray;
            this.btnPrevious.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPrevious.IconSize = 20;
            this.btnPrevious.Location = new System.Drawing.Point(892, 409);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(62, 32);
            this.btnPrevious.TabIndex = 75;
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnNext
            // 
            this.btnNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNext.IconChar = FontAwesome.Sharp.IconChar.ChevronRight;
            this.btnNext.IconColor = System.Drawing.Color.DimGray;
            this.btnNext.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnNext.IconSize = 20;
            this.btnNext.Location = new System.Drawing.Point(954, 409);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(62, 32);
            this.btnNext.TabIndex = 74;
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // OpenDocumentBtn
            // 
            this.OpenDocumentBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.OpenDocumentBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(118)))), ((int)(((byte)(118)))));
            this.OpenDocumentBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.OpenDocumentBtn.FlatAppearance.BorderSize = 0;
            this.OpenDocumentBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OpenDocumentBtn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.OpenDocumentBtn.ForeColor = System.Drawing.Color.White;
            this.OpenDocumentBtn.IconChar = FontAwesome.Sharp.IconChar.FileDownload;
            this.OpenDocumentBtn.IconColor = System.Drawing.Color.White;
            this.OpenDocumentBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.OpenDocumentBtn.IconSize = 32;
            this.OpenDocumentBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.OpenDocumentBtn.Location = new System.Drawing.Point(838, 558);
            this.OpenDocumentBtn.Name = "OpenDocumentBtn";
            this.OpenDocumentBtn.Size = new System.Drawing.Size(178, 40);
            this.OpenDocumentBtn.TabIndex = 76;
            this.OpenDocumentBtn.Text = "     Abrir Documento";
            this.OpenDocumentBtn.UseVisualStyleBackColor = false;
            this.OpenDocumentBtn.Click += new System.EventHandler(this.btnOpenDocument_Click);
            // 
            // AddArticleBtn
            // 
            this.AddArticleBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.AddArticleBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(118)))), ((int)(((byte)(118)))));
            this.AddArticleBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.AddArticleBtn.FlatAppearance.BorderSize = 0;
            this.AddArticleBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddArticleBtn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.AddArticleBtn.ForeColor = System.Drawing.Color.White;
            this.AddArticleBtn.IconChar = FontAwesome.Sharp.IconChar.List;
            this.AddArticleBtn.IconColor = System.Drawing.Color.White;
            this.AddArticleBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.AddArticleBtn.IconSize = 32;
            this.AddArticleBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddArticleBtn.Location = new System.Drawing.Point(655, 558);
            this.AddArticleBtn.Name = "AddArticleBtn";
            this.AddArticleBtn.Size = new System.Drawing.Size(177, 40);
            this.AddArticleBtn.TabIndex = 77;
            this.AddArticleBtn.Text = "    Ver Articulos";
            this.AddArticleBtn.UseVisualStyleBackColor = false;
            this.AddArticleBtn.Click += new System.EventHandler(this.AddArticleBtn_Click);
            // 
            // DetailsBtn
            // 
            this.DetailsBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.DetailsBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(118)))), ((int)(((byte)(118)))));
            this.DetailsBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.DetailsBtn.FlatAppearance.BorderSize = 0;
            this.DetailsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DetailsBtn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.DetailsBtn.ForeColor = System.Drawing.Color.White;
            this.DetailsBtn.IconChar = FontAwesome.Sharp.IconChar.Info;
            this.DetailsBtn.IconColor = System.Drawing.Color.White;
            this.DetailsBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.DetailsBtn.IconSize = 32;
            this.DetailsBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DetailsBtn.Location = new System.Drawing.Point(12, 558);
            this.DetailsBtn.Name = "DetailsBtn";
            this.DetailsBtn.Size = new System.Drawing.Size(148, 40);
            this.DetailsBtn.TabIndex = 78;
            this.DetailsBtn.Text = "Ver Detalle";
            this.DetailsBtn.UseVisualStyleBackColor = false;
            this.DetailsBtn.Visible = false;
            this.DetailsBtn.Click += new System.EventHandler(this.DetailsBtn_Click);
            // 
            // ReportBtn
            // 
            this.ReportBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ReportBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(118)))), ((int)(((byte)(118)))));
            this.ReportBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.ReportBtn.FlatAppearance.BorderSize = 0;
            this.ReportBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReportBtn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.ReportBtn.ForeColor = System.Drawing.Color.White;
            this.ReportBtn.IconChar = FontAwesome.Sharp.IconChar.Print;
            this.ReportBtn.IconColor = System.Drawing.Color.White;
            this.ReportBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ReportBtn.IconSize = 32;
            this.ReportBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ReportBtn.Location = new System.Drawing.Point(166, 558);
            this.ReportBtn.Name = "ReportBtn";
            this.ReportBtn.Size = new System.Drawing.Size(148, 40);
            this.ReportBtn.TabIndex = 79;
            this.ReportBtn.Text = "Reporte";
            this.ReportBtn.UseVisualStyleBackColor = false;
            this.ReportBtn.Visible = false;
            // 
            // LawsListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1044, 610);
            this.Controls.Add(this.ReportBtn);
            this.Controls.Add(this.DetailsBtn);
            this.Controls.Add(this.AddArticleBtn);
            this.Controls.Add(this.OpenDocumentBtn);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lblResultados);
            this.Controls.Add(this.dgvLaws);
            this.Controls.Add(this.UpdateBtn);
            this.Controls.Add(this.AddBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LawsListForm";
            this.Text = "LawsListForm";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLaws)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        public FontAwesome.Sharp.IconButton ReportBtn;

        public FontAwesome.Sharp.IconButton DetailsBtn;

        public FontAwesome.Sharp.IconButton AddArticleBtn;

        public FontAwesome.Sharp.IconButton OpenDocumentBtn;

        public FontAwesome.Sharp.IconButton btnPrevious;
        public FontAwesome.Sharp.IconButton btnNext;

        private System.Windows.Forms.Panel panel2;
        private PresentationLayer.Components.CustomTextBox searchTbox;
        private FontAwesome.Sharp.IconButton ClearSearchBtn;
        private System.Windows.Forms.Label label13;
        public FontAwesome.Sharp.IconButton DeleteBtn;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblResultados;
        public System.Windows.Forms.DataGridView dgvLaws;
        public FontAwesome.Sharp.IconButton UpdateBtn;
        public FontAwesome.Sharp.IconButton AddBtn;

        #endregion
    }
}