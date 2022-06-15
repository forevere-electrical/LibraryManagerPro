namespace LibraryManagerPro
{
    partial class FrmAddBook
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAddBook));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnTake = new System.Windows.Forms.Button();
            this.btnStartVideo = new System.Windows.Forms.Button();
            this.gbBook = new System.Windows.Forms.GroupBox();
            this.txtBookName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBookCount = new System.Windows.Forms.TextBox();
            this.txtBookPosition = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtBarCode = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cboBookCategory = new System.Windows.Forms.ComboBox();
            this.cboPublisher = new System.Windows.Forms.ComboBox();
            this.txtUnitPrice = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpPublishDate = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dgvBookList = new System.Windows.Forms.DataGridView();
            this.btnChoseImage = new System.Windows.Forms.Button();
            this.btnCloseVideo = new System.Windows.Forms.Button();
            this.pbCurrentImage = new System.Windows.Forms.PictureBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.BarCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PublisherName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Author = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Remainder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookPosition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbBook.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCurrentImage)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTake
            // 
            this.btnTake.Location = new System.Drawing.Point(203, 278);
            this.btnTake.Name = "btnTake";
            this.btnTake.Size = new System.Drawing.Size(88, 42);
            this.btnTake.TabIndex = 2;
            this.btnTake.Text = "Photo Snap";
            this.btnTake.UseVisualStyleBackColor = true;
            this.btnTake.Click += new System.EventHandler(this.btnTake_Click);
            // 
            // btnStartVideo
            // 
            this.btnStartVideo.Location = new System.Drawing.Point(20, 278);
            this.btnStartVideo.Name = "btnStartVideo";
            this.btnStartVideo.Size = new System.Drawing.Size(88, 42);
            this.btnStartVideo.TabIndex = 1;
            this.btnStartVideo.Text = "Start Camera";
            this.btnStartVideo.UseVisualStyleBackColor = true;
            this.btnStartVideo.Click += new System.EventHandler(this.btnStartVideo_Click);
            // 
            // gbBook
            // 
            this.gbBook.Controls.Add(this.txtBookName);
            this.gbBook.Controls.Add(this.label1);
            this.gbBook.Controls.Add(this.label3);
            this.gbBook.Controls.Add(this.txtBookCount);
            this.gbBook.Controls.Add(this.txtBookPosition);
            this.gbBook.Controls.Add(this.label4);
            this.gbBook.Controls.Add(this.label9);
            this.gbBook.Controls.Add(this.txtBarCode);
            this.gbBook.Controls.Add(this.label6);
            this.gbBook.Controls.Add(this.cboBookCategory);
            this.gbBook.Controls.Add(this.cboPublisher);
            this.gbBook.Controls.Add(this.txtUnitPrice);
            this.gbBook.Controls.Add(this.label5);
            this.gbBook.Controls.Add(this.txtAuthor);
            this.gbBook.Controls.Add(this.label8);
            this.gbBook.Controls.Add(this.label2);
            this.gbBook.Controls.Add(this.dtpPublishDate);
            this.gbBook.Controls.Add(this.label7);
            this.gbBook.Location = new System.Drawing.Point(491, 21);
            this.gbBook.Name = "gbBook";
            this.gbBook.Size = new System.Drawing.Size(499, 245);
            this.gbBook.TabIndex = 0;
            this.gbBook.TabStop = false;
            this.gbBook.Text = "[Book Basic Info]";
            // 
            // txtBookName
            // 
            this.txtBookName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBookName.Location = new System.Drawing.Point(84, 28);
            this.txtBookName.Name = "txtBookName";
            this.txtBookName.Size = new System.Drawing.Size(142, 20);
            this.txtBookName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Book Name：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(230, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Date Published：";
            // 
            // txtBookCount
            // 
            this.txtBookCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBookCount.Location = new System.Drawing.Point(319, 162);
            this.txtBookCount.Name = "txtBookCount";
            this.txtBookCount.Size = new System.Drawing.Size(142, 20);
            this.txtBookCount.TabIndex = 8;
            // 
            // txtBookPosition
            // 
            this.txtBookPosition.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBookPosition.Location = new System.Drawing.Point(84, 209);
            this.txtBookPosition.Name = "txtBookPosition";
            this.txtBookPosition.Size = new System.Drawing.Size(142, 20);
            this.txtBookPosition.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(240, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Saved Count：";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1, 216);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Shelf Location：";
            // 
            // txtBarCode
            // 
            this.txtBarCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBarCode.Location = new System.Drawing.Point(84, 164);
            this.txtBarCode.Name = "txtBarCode";
            this.txtBarCode.Size = new System.Drawing.Size(142, 20);
            this.txtBarCode.TabIndex = 7;
            this.txtBarCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBarCode_KeyDown);
            this.txtBarCode.Leave += new System.EventHandler(this.txtBarCode_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 169);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Bar Code：";
            // 
            // cboBookCategory
            // 
            this.cboBookCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBookCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboBookCategory.FormattingEnabled = true;
            this.cboBookCategory.Location = new System.Drawing.Point(319, 27);
            this.cboBookCategory.Name = "cboBookCategory";
            this.cboBookCategory.Size = new System.Drawing.Size(142, 21);
            this.cboBookCategory.TabIndex = 2;
            // 
            // cboPublisher
            // 
            this.cboPublisher.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPublisher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboPublisher.FormattingEnabled = true;
            this.cboPublisher.Location = new System.Drawing.Point(84, 74);
            this.cboPublisher.Name = "cboPublisher";
            this.cboPublisher.Size = new System.Drawing.Size(142, 21);
            this.cboPublisher.TabIndex = 3;
            // 
            // txtUnitPrice
            // 
            this.txtUnitPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUnitPrice.Location = new System.Drawing.Point(319, 117);
            this.txtUnitPrice.Name = "txtUnitPrice";
            this.txtUnitPrice.Size = new System.Drawing.Size(142, 20);
            this.txtUnitPrice.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(248, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Retail Price：";
            // 
            // txtAuthor
            // 
            this.txtAuthor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAuthor.Location = new System.Drawing.Point(83, 118);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(143, 20);
            this.txtAuthor.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(38, 125);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Author：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(260, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Category：";
            // 
            // dtpPublishDate
            // 
            this.dtpPublishDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpPublishDate.Location = new System.Drawing.Point(319, 72);
            this.dtpPublishDate.Name = "dtpPublishDate";
            this.dtpPublishDate.Size = new System.Drawing.Size(142, 20);
            this.dtpPublishDate.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 78);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Publisher：";
            // 
            // pbImage
            // 
            this.pbImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbImage.Location = new System.Drawing.Point(20, 21);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(217, 245);
            this.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImage.TabIndex = 19;
            this.pbImage.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(892, 278);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(98, 42);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Close Window";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Location = new System.Drawing.Point(491, 278);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(88, 42);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Confirm Add";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dgvBookList
            // 
            this.dgvBookList.AllowUserToAddRows = false;
            this.dgvBookList.AllowUserToDeleteRows = false;
            this.dgvBookList.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvBookList.ColumnHeadersHeight = 28;
            this.dgvBookList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BarCode,
            this.BookName,
            this.PublisherName,
            this.Author,
            this.BookCount,
            this.Remainder,
            this.BookPosition});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBookList.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvBookList.Location = new System.Drawing.Point(20, 338);
            this.dgvBookList.Name = "dgvBookList";
            this.dgvBookList.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBookList.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvBookList.RowTemplate.Height = 23;
            this.dgvBookList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBookList.Size = new System.Drawing.Size(970, 380);
            this.dgvBookList.TabIndex = 20;
            this.dgvBookList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBookList_CellContentClick);
            // 
            // btnChoseImage
            // 
            this.btnChoseImage.Location = new System.Drawing.Point(385, 278);
            this.btnChoseImage.Name = "btnChoseImage";
            this.btnChoseImage.Size = new System.Drawing.Size(88, 42);
            this.btnChoseImage.TabIndex = 3;
            this.btnChoseImage.Text = "Select Picture";
            this.btnChoseImage.UseVisualStyleBackColor = true;
            this.btnChoseImage.Click += new System.EventHandler(this.btnChoseImage_Click);
            // 
            // btnCloseVideo
            // 
            this.btnCloseVideo.Location = new System.Drawing.Point(111, 278);
            this.btnCloseVideo.Name = "btnCloseVideo";
            this.btnCloseVideo.Size = new System.Drawing.Size(89, 42);
            this.btnCloseVideo.TabIndex = 21;
            this.btnCloseVideo.Text = "Close Camera";
            this.btnCloseVideo.UseVisualStyleBackColor = true;
            this.btnCloseVideo.Click += new System.EventHandler(this.btnCloseVideo_Click);
            // 
            // pbCurrentImage
            // 
            this.pbCurrentImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbCurrentImage.Location = new System.Drawing.Point(256, 21);
            this.pbCurrentImage.Name = "pbCurrentImage";
            this.pbCurrentImage.Size = new System.Drawing.Size(217, 245);
            this.pbCurrentImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCurrentImage.TabIndex = 19;
            this.pbCurrentImage.TabStop = false;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(294, 278);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(88, 42);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Clear Selection";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // BarCode
            // 
            this.BarCode.DataPropertyName = "BarCode";
            this.BarCode.Frozen = true;
            this.BarCode.HeaderText = "Bar Code";
            this.BarCode.Name = "BarCode";
            this.BarCode.ReadOnly = true;
            this.BarCode.Width = 120;
            // 
            // BookName
            // 
            this.BookName.DataPropertyName = "BookName";
            this.BookName.HeaderText = "Book Name";
            this.BookName.Name = "BookName";
            this.BookName.ReadOnly = true;
            this.BookName.Width = 200;
            // 
            // PublisherName
            // 
            this.PublisherName.DataPropertyName = "PublisherName";
            this.PublisherName.HeaderText = "Publisher";
            this.PublisherName.Name = "PublisherName";
            this.PublisherName.ReadOnly = true;
            this.PublisherName.Width = 150;
            // 
            // Author
            // 
            this.Author.DataPropertyName = "Author";
            this.Author.HeaderText = "Author";
            this.Author.Name = "Author";
            this.Author.ReadOnly = true;
            this.Author.Width = 120;
            // 
            // BookCount
            // 
            this.BookCount.DataPropertyName = "BookCount";
            this.BookCount.HeaderText = "Saved Count";
            this.BookCount.Name = "BookCount";
            this.BookCount.ReadOnly = true;
            this.BookCount.Width = 80;
            // 
            // Remainder
            // 
            this.Remainder.DataPropertyName = "Remainder";
            this.Remainder.HeaderText = "Available Count";
            this.Remainder.Name = "Remainder";
            this.Remainder.ReadOnly = true;
            this.Remainder.Width = 80;
            // 
            // BookPosition
            // 
            this.BookPosition.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.BookPosition.DataPropertyName = "BookPosition";
            this.BookPosition.HeaderText = "Book Shelf Location";
            this.BookPosition.Name = "BookPosition";
            this.BookPosition.ReadOnly = true;
            // 
            // FrmAddBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 738);
            this.Controls.Add(this.btnCloseVideo);
            this.Controls.Add(this.dgvBookList);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnChoseImage);
            this.Controls.Add(this.btnTake);
            this.Controls.Add(this.btnStartVideo);
            this.Controls.Add(this.gbBook);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.pbCurrentImage);
            this.Controls.Add(this.pbImage);
            this.Controls.Add(this.btnAdd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmAddBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "[Add New Book]";
            this.gbBook.ResumeLayout(false);
            this.gbBook.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCurrentImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTake;
        private System.Windows.Forms.Button btnStartVideo;
        private System.Windows.Forms.GroupBox gbBook;
        private System.Windows.Forms.TextBox txtBookName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBarCode;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboPublisher;
        private System.Windows.Forms.TextBox txtUnitPrice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtpPublishDate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtBookCount;
        private System.Windows.Forms.TextBox txtBookPosition;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cboBookCategory;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvBookList;
        private System.Windows.Forms.Button btnChoseImage;
        private System.Windows.Forms.Button btnCloseVideo;
        private System.Windows.Forms.PictureBox pbCurrentImage;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.DataGridViewTextBoxColumn BarCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PublisherName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Author;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Remainder;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookPosition;
    }
}