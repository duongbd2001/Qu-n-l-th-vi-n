namespace Library_Management
{
    partial class PhieuMuon
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txbReturnDate = new System.Windows.Forms.TextBox();
            this.lbReturnDate = new System.Windows.Forms.Label();
            this.txbBorrowDate = new System.Windows.Forms.TextBox();
            this.txbDeposit = new System.Windows.Forms.TextBox();
            this.txbLibrarian = new System.Windows.Forms.TextBox();
            this.txbIDReader = new System.Windows.Forms.TextBox();
            this.lbBorrowDate = new System.Windows.Forms.Label();
            this.lb_idLibrarian = new System.Windows.Forms.Label();
            this.lbDeposit = new System.Windows.Forms.Label();
            this.lb_idReader = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txbInsertRetrunDate = new System.Windows.Forms.TextBox();
            this.lb_insertReturnDate = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txbInsertBorrowDate = new System.Windows.Forms.TextBox();
            this.txbInsertDeposit = new System.Windows.Forms.TextBox();
            this.txbInsertIDLibrarian = new System.Windows.Forms.TextBox();
            this.txbInsertIDReader = new System.Windows.Forms.TextBox();
            this.lb_insertBorrowDate = new System.Windows.Forms.Label();
            this.lb_insertDeposit = new System.Windows.Forms.Label();
            this.lb_insertLibrarian = new System.Windows.Forms.Label();
            this.lb_insertReader = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txbDelete = new System.Windows.Forms.TextBox();
            this.lbDelete = new System.Windows.Forms.Label();
            this.txbQuantity = new System.Windows.Forms.TextBox();
            this.txbIDBook = new System.Windows.Forms.TextBox();
            this.lbQuantity = new System.Windows.Forms.Label();
            this.lb_idBook = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Library_Management.Properties.Resources.quayLai;
            this.pictureBox1.Location = new System.Drawing.Point(-1, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(23, 20);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(28, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Quay lại";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txbReturnDate);
            this.groupBox1.Controls.Add(this.lbReturnDate);
            this.groupBox1.Controls.Add(this.txbBorrowDate);
            this.groupBox1.Controls.Add(this.txbDeposit);
            this.groupBox1.Controls.Add(this.txbLibrarian);
            this.groupBox1.Controls.Add(this.txbIDReader);
            this.groupBox1.Controls.Add(this.lbBorrowDate);
            this.groupBox1.Controls.Add(this.lb_idLibrarian);
            this.groupBox1.Controls.Add(this.lbDeposit);
            this.groupBox1.Controls.Add(this.lb_idReader);
            this.groupBox1.Controls.Add(this.btnRefresh);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Location = new System.Drawing.Point(31, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(456, 228);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm phiếu";
            // 
            // txbReturnDate
            // 
            this.txbReturnDate.Location = new System.Drawing.Point(332, 117);
            this.txbReturnDate.Name = "txbReturnDate";
            this.txbReturnDate.Size = new System.Drawing.Size(100, 20);
            this.txbReturnDate.TabIndex = 13;
            // 
            // lbReturnDate
            // 
            this.lbReturnDate.AutoSize = true;
            this.lbReturnDate.Location = new System.Drawing.Point(265, 120);
            this.lbReturnDate.Name = "lbReturnDate";
            this.lbReturnDate.Size = new System.Drawing.Size(47, 13);
            this.lbReturnDate.TabIndex = 12;
            this.lbReturnDate.Text = "Ngày trả";
            // 
            // txbBorrowDate
            // 
            this.txbBorrowDate.Location = new System.Drawing.Point(332, 75);
            this.txbBorrowDate.Name = "txbBorrowDate";
            this.txbBorrowDate.Size = new System.Drawing.Size(100, 20);
            this.txbBorrowDate.TabIndex = 11;
            // 
            // txbDeposit
            // 
            this.txbDeposit.Location = new System.Drawing.Point(332, 35);
            this.txbDeposit.Name = "txbDeposit";
            this.txbDeposit.Size = new System.Drawing.Size(100, 20);
            this.txbDeposit.TabIndex = 10;
            // 
            // txbLibrarian
            // 
            this.txbLibrarian.Location = new System.Drawing.Point(115, 78);
            this.txbLibrarian.Name = "txbLibrarian";
            this.txbLibrarian.Size = new System.Drawing.Size(100, 20);
            this.txbLibrarian.TabIndex = 9;
            // 
            // txbIDReader
            // 
            this.txbIDReader.Location = new System.Drawing.Point(115, 35);
            this.txbIDReader.Name = "txbIDReader";
            this.txbIDReader.Size = new System.Drawing.Size(100, 20);
            this.txbIDReader.TabIndex = 8;
            // 
            // lbBorrowDate
            // 
            this.lbBorrowDate.AutoSize = true;
            this.lbBorrowDate.Location = new System.Drawing.Point(253, 78);
            this.lbBorrowDate.Name = "lbBorrowDate";
            this.lbBorrowDate.Size = new System.Drawing.Size(61, 13);
            this.lbBorrowDate.TabIndex = 6;
            this.lbBorrowDate.Text = "Ngày mượn";
            // 
            // lb_idLibrarian
            // 
            this.lb_idLibrarian.AutoSize = true;
            this.lb_idLibrarian.Location = new System.Drawing.Point(42, 35);
            this.lb_idLibrarian.Name = "lb_idLibrarian";
            this.lb_idLibrarian.Size = new System.Drawing.Size(54, 13);
            this.lb_idLibrarian.TabIndex = 5;
            this.lb_idLibrarian.Text = "ID thủ thư";
            // 
            // lbDeposit
            // 
            this.lbDeposit.AutoSize = true;
            this.lbDeposit.Location = new System.Drawing.Point(265, 38);
            this.lbDeposit.Name = "lbDeposit";
            this.lbDeposit.Size = new System.Drawing.Size(49, 13);
            this.lbDeposit.TabIndex = 4;
            this.lbDeposit.Text = "Tiền cọc";
            // 
            // lb_idReader
            // 
            this.lb_idReader.AutoSize = true;
            this.lb_idReader.Location = new System.Drawing.Point(27, 78);
            this.lb_idReader.Name = "lb_idReader";
            this.lb_idReader.Size = new System.Drawing.Size(69, 13);
            this.lb_idReader.TabIndex = 3;
            this.lb_idReader.Text = "ID người đọc";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(268, 171);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 1;
            this.btnRefresh.Text = "Làm mới";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(179, 171);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 0;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(31, 295);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(697, 480);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txbInsertRetrunDate);
            this.groupBox2.Controls.Add(this.txbQuantity);
            this.groupBox2.Controls.Add(this.lb_insertReturnDate);
            this.groupBox2.Controls.Add(this.txbIDBook);
            this.groupBox2.Controls.Add(this.btnAdd);
            this.groupBox2.Controls.Add(this.lbQuantity);
            this.groupBox2.Controls.Add(this.txbInsertBorrowDate);
            this.groupBox2.Controls.Add(this.lb_idBook);
            this.groupBox2.Controls.Add(this.txbInsertDeposit);
            this.groupBox2.Controls.Add(this.txbInsertIDLibrarian);
            this.groupBox2.Controls.Add(this.txbInsertIDReader);
            this.groupBox2.Controls.Add(this.lb_insertBorrowDate);
            this.groupBox2.Controls.Add(this.lb_insertDeposit);
            this.groupBox2.Controls.Add(this.lb_insertLibrarian);
            this.groupBox2.Controls.Add(this.lb_insertReader);
            this.groupBox2.Location = new System.Drawing.Point(805, 35);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(350, 409);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thêm phiếu";
            // 
            // txbInsertRetrunDate
            // 
            this.txbInsertRetrunDate.Location = new System.Drawing.Point(134, 193);
            this.txbInsertRetrunDate.Name = "txbInsertRetrunDate";
            this.txbInsertRetrunDate.Size = new System.Drawing.Size(100, 20);
            this.txbInsertRetrunDate.TabIndex = 18;
            // 
            // lb_insertReturnDate
            // 
            this.lb_insertReturnDate.AutoSize = true;
            this.lb_insertReturnDate.Location = new System.Drawing.Point(63, 196);
            this.lb_insertReturnDate.Name = "lb_insertReturnDate";
            this.lb_insertReturnDate.Size = new System.Drawing.Size(47, 13);
            this.lb_insertReturnDate.TabIndex = 17;
            this.lb_insertReturnDate.Text = "Ngày trả";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(69, 340);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(74, 31);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txbInsertBorrowDate
            // 
            this.txbInsertBorrowDate.Location = new System.Drawing.Point(134, 154);
            this.txbInsertBorrowDate.Name = "txbInsertBorrowDate";
            this.txbInsertBorrowDate.Size = new System.Drawing.Size(100, 20);
            this.txbInsertBorrowDate.TabIndex = 16;
            // 
            // txbInsertDeposit
            // 
            this.txbInsertDeposit.Location = new System.Drawing.Point(134, 114);
            this.txbInsertDeposit.Name = "txbInsertDeposit";
            this.txbInsertDeposit.Size = new System.Drawing.Size(100, 20);
            this.txbInsertDeposit.TabIndex = 15;
            // 
            // txbInsertIDLibrarian
            // 
            this.txbInsertIDLibrarian.Location = new System.Drawing.Point(134, 75);
            this.txbInsertIDLibrarian.Name = "txbInsertIDLibrarian";
            this.txbInsertIDLibrarian.Size = new System.Drawing.Size(100, 20);
            this.txbInsertIDLibrarian.TabIndex = 14;
            // 
            // txbInsertIDReader
            // 
            this.txbInsertIDReader.Location = new System.Drawing.Point(134, 35);
            this.txbInsertIDReader.Name = "txbInsertIDReader";
            this.txbInsertIDReader.Size = new System.Drawing.Size(100, 20);
            this.txbInsertIDReader.TabIndex = 13;
            // 
            // lb_insertBorrowDate
            // 
            this.lb_insertBorrowDate.AutoSize = true;
            this.lb_insertBorrowDate.Location = new System.Drawing.Point(54, 157);
            this.lb_insertBorrowDate.Name = "lb_insertBorrowDate";
            this.lb_insertBorrowDate.Size = new System.Drawing.Size(61, 13);
            this.lb_insertBorrowDate.TabIndex = 10;
            this.lb_insertBorrowDate.Text = "Ngày mượn";
            // 
            // lb_insertDeposit
            // 
            this.lb_insertDeposit.AutoSize = true;
            this.lb_insertDeposit.Location = new System.Drawing.Point(61, 120);
            this.lb_insertDeposit.Name = "lb_insertDeposit";
            this.lb_insertDeposit.Size = new System.Drawing.Size(49, 13);
            this.lb_insertDeposit.TabIndex = 9;
            this.lb_insertDeposit.Text = "Tiền cọc";
            // 
            // lb_insertLibrarian
            // 
            this.lb_insertLibrarian.AutoSize = true;
            this.lb_insertLibrarian.Location = new System.Drawing.Point(56, 82);
            this.lb_insertLibrarian.Name = "lb_insertLibrarian";
            this.lb_insertLibrarian.Size = new System.Drawing.Size(54, 13);
            this.lb_insertLibrarian.TabIndex = 8;
            this.lb_insertLibrarian.Text = "ID thủ thư";
            // 
            // lb_insertReader
            // 
            this.lb_insertReader.AutoSize = true;
            this.lb_insertReader.Location = new System.Drawing.Point(48, 42);
            this.lb_insertReader.Name = "lb_insertReader";
            this.lb_insertReader.Size = new System.Drawing.Size(69, 13);
            this.lb_insertReader.TabIndex = 7;
            this.lb_insertReader.Text = "ID người đọc";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnDelete);
            this.groupBox3.Controls.Add(this.txbDelete);
            this.groupBox3.Controls.Add(this.lbDelete);
            this.groupBox3.Location = new System.Drawing.Point(805, 459);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(350, 138);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Xóa phiếu";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(50, 95);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(79, 20);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txbDelete
            // 
            this.txbDelete.Location = new System.Drawing.Point(159, 46);
            this.txbDelete.Name = "txbDelete";
            this.txbDelete.Size = new System.Drawing.Size(100, 20);
            this.txbDelete.TabIndex = 12;
            // 
            // lbDelete
            // 
            this.lbDelete.AutoSize = true;
            this.lbDelete.Location = new System.Drawing.Point(19, 49);
            this.lbDelete.Name = "lbDelete";
            this.lbDelete.Size = new System.Drawing.Size(120, 13);
            this.lbDelete.TabIndex = 6;
            this.lbDelete.Text = "Nhập ID phiếu cần xóa:";
            // 
            // txbQuantity
            // 
            this.txbQuantity.Location = new System.Drawing.Point(134, 283);
            this.txbQuantity.Name = "txbQuantity";
            this.txbQuantity.Size = new System.Drawing.Size(100, 20);
            this.txbQuantity.TabIndex = 3;
            // 
            // txbIDBook
            // 
            this.txbIDBook.Location = new System.Drawing.Point(134, 239);
            this.txbIDBook.Name = "txbIDBook";
            this.txbIDBook.Size = new System.Drawing.Size(100, 20);
            this.txbIDBook.TabIndex = 2;
            // 
            // lbQuantity
            // 
            this.lbQuantity.AutoSize = true;
            this.lbQuantity.Location = new System.Drawing.Point(62, 290);
            this.lbQuantity.Name = "lbQuantity";
            this.lbQuantity.Size = new System.Drawing.Size(49, 13);
            this.lbQuantity.TabIndex = 1;
            this.lbQuantity.Text = "Số lượng";
            // 
            // lb_idBook
            // 
            this.lb_idBook.AutoSize = true;
            this.lb_idBook.Location = new System.Drawing.Point(66, 246);
            this.lb_idBook.Name = "lb_idBook";
            this.lb_idBook.Size = new System.Drawing.Size(44, 13);
            this.lb_idBook.TabIndex = 0;
            this.lb_idBook.Text = "ID sách";
            // 
            // PhieuMuon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1205, 820);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "PhieuMuon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm mới phiếu mượn";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txbBorrowDate;
        private System.Windows.Forms.TextBox txbDeposit;
        private System.Windows.Forms.TextBox txbLibrarian;
        private System.Windows.Forms.TextBox txbIDReader;
        private System.Windows.Forms.Label lbBorrowDate;
        private System.Windows.Forms.Label lb_idLibrarian;
        private System.Windows.Forms.Label lbDeposit;
        private System.Windows.Forms.Label lb_idReader;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txbInsertBorrowDate;
        private System.Windows.Forms.TextBox txbInsertDeposit;
        private System.Windows.Forms.TextBox txbInsertIDLibrarian;
        private System.Windows.Forms.TextBox txbInsertIDReader;
        private System.Windows.Forms.Label lb_insertBorrowDate;
        private System.Windows.Forms.Label lb_insertDeposit;
        private System.Windows.Forms.Label lb_insertLibrarian;
        private System.Windows.Forms.Label lb_insertReader;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txbDelete;
        private System.Windows.Forms.Label lbDelete;
        private System.Windows.Forms.TextBox txbReturnDate;
        private System.Windows.Forms.Label lbReturnDate;
        private System.Windows.Forms.TextBox txbInsertRetrunDate;
        private System.Windows.Forms.Label lb_insertReturnDate;
        private System.Windows.Forms.TextBox txbQuantity;
        private System.Windows.Forms.TextBox txbIDBook;
        private System.Windows.Forms.Label lbQuantity;
        private System.Windows.Forms.Label lb_idBook;
    }
}