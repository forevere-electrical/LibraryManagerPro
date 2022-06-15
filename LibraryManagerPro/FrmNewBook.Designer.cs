namespace LibraryManagerPro
{
    partial class FrmNewBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNewBook));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gbinfo = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblBookPosition = new System.Windows.Forms.Label();
            this.lblBookCount = new System.Windows.Forms.Label();
            this.lblBookName = new System.Windows.Forms.Label();
            this.lblBookId = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.txtBarCode = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAddCount = new System.Windows.Forms.TextBox();
            this.dgvBookList = new System.Windows.Forms.DataGridView();
            this.BarCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PublisherName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Author = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookPosition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbinfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookList)).BeginInit();
            this.SuspendLayout();
            // 
            // gbinfo
            // 
            this.gbinfo.Controls.Add(this.label1);
            this.gbinfo.Controls.Add(this.label6);
            this.gbinfo.Controls.Add(this.lblCategory);
            this.gbinfo.Controls.Add(this.lblBookPosition);
            this.gbinfo.Controls.Add(this.lblBookCount);
            this.gbinfo.Controls.Add(this.lblBookName);
            this.gbinfo.Controls.Add(this.lblBookId);
            this.gbinfo.Controls.Add(this.label9);
            this.gbinfo.Controls.Add(this.label10);
            this.gbinfo.Controls.Add(this.label2);
            this.gbinfo.Location = new System.Drawing.Point(333, 35);
            this.gbinfo.Name = "gbinfo";
            this.gbinfo.Size = new System.Drawing.Size(514, 186);
            this.gbinfo.TabIndex = 31;
            this.gbinfo.TabStop = false;
            this.gbinfo.Text = "[Book Basic Info]";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Book Name:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 86);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Book Count:";
            // 
            // lblCategory
            // 
            this.lblCategory.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblCategory.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCategory.Location = new System.Drawing.Point(326, 31);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(142, 26);
            this.lblCategory.TabIndex = 0;
            this.lblCategory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBookPosition
            // 
            this.lblBookPosition.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblBookPosition.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblBookPosition.Location = new System.Drawing.Point(326, 79);
            this.lblBookPosition.Name = "lblBookPosition";
            this.lblBookPosition.Size = new System.Drawing.Size(142, 26);
            this.lblBookPosition.TabIndex = 0;
            this.lblBookPosition.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBookCount
            // 
            this.lblBookCount.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblBookCount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblBookCount.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblBookCount.Location = new System.Drawing.Point(91, 79);
            this.lblBookCount.Name = "lblBookCount";
            this.lblBookCount.Size = new System.Drawing.Size(142, 26);
            this.lblBookCount.TabIndex = 0;
            this.lblBookCount.Text = "0";
            this.lblBookCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBookName
            // 
            this.lblBookName.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblBookName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblBookName.Location = new System.Drawing.Point(91, 34);
            this.lblBookName.Name = "lblBookName";
            this.lblBookName.Size = new System.Drawing.Size(142, 26);
            this.lblBookName.TabIndex = 0;
            this.lblBookName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBookId
            // 
            this.lblBookId.BackColor = System.Drawing.SystemColors.Control;
            this.lblBookId.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblBookId.Location = new System.Drawing.Point(91, 136);
            this.lblBookId.Name = "lblBookId";
            this.lblBookId.Size = new System.Drawing.Size(142, 26);
            this.lblBookId.TabIndex = 0;
            this.lblBookId.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(241, 86);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Book Location:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(11, 143);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Book Number:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(240, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Book Category:";
            // 
            // pbImage
            // 
            this.pbImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbImage.Location = new System.Drawing.Point(27, 35);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(249, 279);
            this.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImage.TabIndex = 33;
            this.pbImage.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(873, 43);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(111, 42);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close Window";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(873, 274);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(111, 40);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save ";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label13.Location = new System.Drawing.Point(286, 280);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(119, 27);
            this.label13.TabIndex = 34;
            this.label13.Text = "[Bar Code]:";
            // 
            // txtBarCode
            // 
            this.txtBarCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBarCode.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtBarCode.Location = new System.Drawing.Point(414, 276);
            this.txtBarCode.Name = "txtBarCode";
            this.txtBarCode.Size = new System.Drawing.Size(199, 35);
            this.txtBarCode.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(619, 282);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 21);
            this.label4.TabIndex = 34;
            this.label4.Text = "[New Book Count]:";
            // 
            // txtAddCount
            // 
            this.txtAddCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAddCount.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtAddCount.Location = new System.Drawing.Point(777, 276);
            this.txtAddCount.Name = "txtAddCount";
            this.txtAddCount.Size = new System.Drawing.Size(70, 35);
            this.txtAddCount.TabIndex = 1;
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
            this.BookPosition});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBookList.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvBookList.Location = new System.Drawing.Point(27, 364);
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
            this.dgvBookList.Size = new System.Drawing.Size(957, 356);
            this.dgvBookList.TabIndex = 38;
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
            this.Author.Width = 150;
            // 
            // BookCount
            // 
            this.BookCount.DataPropertyName = "BookCount";
            this.BookCount.HeaderText = "Book Count";
            this.BookCount.Name = "BookCount";
            this.BookCount.ReadOnly = true;
            // 
            // BookPosition
            // 
            this.BookPosition.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.BookPosition.DataPropertyName = "BookPosition";
            this.BookPosition.HeaderText = "Book Location";
            this.BookPosition.Name = "BookPosition";
            this.BookPosition.ReadOnly = true;
            // 
            // FrmNewBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 733);
            this.Controls.Add(this.dgvBookList);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtAddCount);
            this.Controls.Add(this.txtBarCode);
            this.Controls.Add(this.pbImage);
            this.Controls.Add(this.gbinfo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmNewBook";
            this.Text = "[New Book Available]";
            this.gbinfo.ResumeLayout(false);
            this.gbinfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbinfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblBookId;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblBookPosition;
        private System.Windows.Forms.Label lblBookCount;
        private System.Windows.Forms.Label lblBookName;
        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtBarCode;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAddCount;
        private System.Windows.Forms.DataGridView dgvBookList;
        private System.Windows.Forms.DataGridViewTextBoxColumn BarCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PublisherName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Author;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookPosition;
    }
}