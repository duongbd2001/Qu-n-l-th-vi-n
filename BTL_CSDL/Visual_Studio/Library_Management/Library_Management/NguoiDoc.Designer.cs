namespace Library_Management
{
    partial class NguoiDoc
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txbDelete = new System.Windows.Forms.TextBox();
            this.lbDelete = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txbInsertEmail = new System.Windows.Forms.TextBox();
            this.lbInsertEmail = new System.Windows.Forms.Label();
            this.txbInsertPhoneNum = new System.Windows.Forms.TextBox();
            this.lb_insertReturnDate = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txbInsertAddress = new System.Windows.Forms.TextBox();
            this.txbInsertDoB = new System.Windows.Forms.TextBox();
            this.txbInsertNameReader = new System.Windows.Forms.TextBox();
            this.lb_insertBorrowDate = new System.Windows.Forms.Label();
            this.lb_insertDeposit = new System.Windows.Forms.Label();
            this.lb_insertReader = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txbEmail = new System.Windows.Forms.TextBox();
            this.lbEmail = new System.Windows.Forms.Label();
            this.txbPhoneNum = new System.Windows.Forms.TextBox();
            this.lbPhoneNum = new System.Windows.Forms.Label();
            this.txbAddressReader = new System.Windows.Forms.TextBox();
            this.txbDoBReader = new System.Windows.Forms.TextBox();
            this.txbNameReader = new System.Windows.Forms.TextBox();
            this.txbIDReader = new System.Windows.Forms.TextBox();
            this.lbAddress = new System.Windows.Forms.Label();
            this.lb_idReader = new System.Windows.Forms.Label();
            this.lbDoB = new System.Windows.Forms.Label();
            this.lbNameReader = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnDelete);
            this.groupBox3.Controls.Add(this.txbDelete);
            this.groupBox3.Controls.Add(this.lbDelete);
            this.groupBox3.Location = new System.Drawing.Point(811, 354);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(350, 138);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Xóa người đọc";
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
            this.txbDelete.Location = new System.Drawing.Point(167, 46);
            this.txbDelete.Name = "txbDelete";
            this.txbDelete.Size = new System.Drawing.Size(100, 20);
            this.txbDelete.TabIndex = 12;
            // 
            // lbDelete
            // 
            this.lbDelete.AutoSize = true;
            this.lbDelete.Location = new System.Drawing.Point(19, 49);
            this.lbDelete.Name = "lbDelete";
            this.lbDelete.Size = new System.Drawing.Size(142, 13);
            this.lbDelete.TabIndex = 6;
            this.lbDelete.Text = "Nhập ID người đọc cần xóa:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txbInsertEmail);
            this.groupBox2.Controls.Add(this.lbInsertEmail);
            this.groupBox2.Controls.Add(this.txbInsertPhoneNum);
            this.groupBox2.Controls.Add(this.lb_insertReturnDate);
            this.groupBox2.Controls.Add(this.btnAdd);
            this.groupBox2.Controls.Add(this.txbInsertAddress);
            this.groupBox2.Controls.Add(this.txbInsertDoB);
            this.groupBox2.Controls.Add(this.txbInsertNameReader);
            this.groupBox2.Controls.Add(this.lb_insertBorrowDate);
            this.groupBox2.Controls.Add(this.lb_insertDeposit);
            this.groupBox2.Controls.Add(this.lb_insertReader);
            this.groupBox2.Location = new System.Drawing.Point(811, 43);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(350, 286);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thêm người đọc";
            // 
            // txbInsertEmail
            // 
            this.txbInsertEmail.Location = new System.Drawing.Point(144, 191);
            this.txbInsertEmail.Name = "txbInsertEmail";
            this.txbInsertEmail.Size = new System.Drawing.Size(100, 20);
            this.txbInsertEmail.TabIndex = 20;
            // 
            // lbInsertEmail
            // 
            this.lbInsertEmail.AutoSize = true;
            this.lbInsertEmail.Location = new System.Drawing.Point(65, 194);
            this.lbInsertEmail.Name = "lbInsertEmail";
            this.lbInsertEmail.Size = new System.Drawing.Size(32, 13);
            this.lbInsertEmail.TabIndex = 19;
            this.lbInsertEmail.Text = "Email";
            // 
            // txbInsertPhoneNum
            // 
            this.txbInsertPhoneNum.Location = new System.Drawing.Point(144, 153);
            this.txbInsertPhoneNum.Name = "txbInsertPhoneNum";
            this.txbInsertPhoneNum.Size = new System.Drawing.Size(100, 20);
            this.txbInsertPhoneNum.TabIndex = 18;
            // 
            // lb_insertReturnDate
            // 
            this.lb_insertReturnDate.AutoSize = true;
            this.lb_insertReturnDate.Location = new System.Drawing.Point(65, 153);
            this.lb_insertReturnDate.Name = "lb_insertReturnDate";
            this.lb_insertReturnDate.Size = new System.Drawing.Size(70, 13);
            this.lb_insertReturnDate.TabIndex = 17;
            this.lb_insertReturnDate.Text = "Số điện thoại";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(69, 239);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(74, 31);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txbInsertAddress
            // 
            this.txbInsertAddress.Location = new System.Drawing.Point(144, 114);
            this.txbInsertAddress.Name = "txbInsertAddress";
            this.txbInsertAddress.Size = new System.Drawing.Size(100, 20);
            this.txbInsertAddress.TabIndex = 16;
            // 
            // txbInsertDoB
            // 
            this.txbInsertDoB.Location = new System.Drawing.Point(144, 74);
            this.txbInsertDoB.Name = "txbInsertDoB";
            this.txbInsertDoB.Size = new System.Drawing.Size(100, 20);
            this.txbInsertDoB.TabIndex = 15;
            // 
            // txbInsertNameReader
            // 
            this.txbInsertNameReader.Location = new System.Drawing.Point(144, 31);
            this.txbInsertNameReader.Name = "txbInsertNameReader";
            this.txbInsertNameReader.Size = new System.Drawing.Size(100, 20);
            this.txbInsertNameReader.TabIndex = 13;
            // 
            // lb_insertBorrowDate
            // 
            this.lb_insertBorrowDate.AutoSize = true;
            this.lb_insertBorrowDate.Location = new System.Drawing.Point(85, 117);
            this.lb_insertBorrowDate.Name = "lb_insertBorrowDate";
            this.lb_insertBorrowDate.Size = new System.Drawing.Size(40, 13);
            this.lb_insertBorrowDate.TabIndex = 10;
            this.lb_insertBorrowDate.Text = "Địa chỉ";
            // 
            // lb_insertDeposit
            // 
            this.lb_insertDeposit.AutoSize = true;
            this.lb_insertDeposit.Location = new System.Drawing.Point(71, 80);
            this.lb_insertDeposit.Name = "lb_insertDeposit";
            this.lb_insertDeposit.Size = new System.Drawing.Size(54, 13);
            this.lb_insertDeposit.TabIndex = 9;
            this.lb_insertDeposit.Text = "Ngày sinh";
            // 
            // lb_insertReader
            // 
            this.lb_insertReader.AutoSize = true;
            this.lb_insertReader.Location = new System.Drawing.Point(99, 38);
            this.lb_insertReader.Name = "lb_insertReader";
            this.lb_insertReader.Size = new System.Drawing.Size(26, 13);
            this.lb_insertReader.TabIndex = 7;
            this.lb_insertReader.Text = "Tên";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(37, 303);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(697, 480);
            this.dataGridView1.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txbEmail);
            this.groupBox1.Controls.Add(this.lbEmail);
            this.groupBox1.Controls.Add(this.txbPhoneNum);
            this.groupBox1.Controls.Add(this.lbPhoneNum);
            this.groupBox1.Controls.Add(this.txbAddressReader);
            this.groupBox1.Controls.Add(this.txbDoBReader);
            this.groupBox1.Controls.Add(this.txbNameReader);
            this.groupBox1.Controls.Add(this.txbIDReader);
            this.groupBox1.Controls.Add(this.lbAddress);
            this.groupBox1.Controls.Add(this.lb_idReader);
            this.groupBox1.Controls.Add(this.lbDoB);
            this.groupBox1.Controls.Add(this.lbNameReader);
            this.groupBox1.Controls.Add(this.btnRefresh);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Location = new System.Drawing.Point(37, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(456, 228);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm người đọc";
            // 
            // txbEmail
            // 
            this.txbEmail.Location = new System.Drawing.Point(318, 121);
            this.txbEmail.Name = "txbEmail";
            this.txbEmail.Size = new System.Drawing.Size(100, 20);
            this.txbEmail.TabIndex = 15;
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Location = new System.Drawing.Point(263, 124);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(32, 13);
            this.lbEmail.TabIndex = 14;
            this.lbEmail.Text = "Email";
            // 
            // txbPhoneNum
            // 
            this.txbPhoneNum.Location = new System.Drawing.Point(318, 81);
            this.txbPhoneNum.Name = "txbPhoneNum";
            this.txbPhoneNum.Size = new System.Drawing.Size(100, 20);
            this.txbPhoneNum.TabIndex = 13;
            // 
            // lbPhoneNum
            // 
            this.lbPhoneNum.AutoSize = true;
            this.lbPhoneNum.Location = new System.Drawing.Point(225, 88);
            this.lbPhoneNum.Name = "lbPhoneNum";
            this.lbPhoneNum.Size = new System.Drawing.Size(70, 13);
            this.lbPhoneNum.TabIndex = 12;
            this.lbPhoneNum.Text = "Số điện thoại";
            // 
            // txbAddressReader
            // 
            this.txbAddressReader.Location = new System.Drawing.Point(318, 38);
            this.txbAddressReader.Name = "txbAddressReader";
            this.txbAddressReader.Size = new System.Drawing.Size(100, 20);
            this.txbAddressReader.TabIndex = 11;
            // 
            // txbDoBReader
            // 
            this.txbDoBReader.Location = new System.Drawing.Point(81, 121);
            this.txbDoBReader.Name = "txbDoBReader";
            this.txbDoBReader.Size = new System.Drawing.Size(100, 20);
            this.txbDoBReader.TabIndex = 10;
            // 
            // txbNameReader
            // 
            this.txbNameReader.Location = new System.Drawing.Point(81, 78);
            this.txbNameReader.Name = "txbNameReader";
            this.txbNameReader.Size = new System.Drawing.Size(100, 20);
            this.txbNameReader.TabIndex = 9;
            // 
            // txbIDReader
            // 
            this.txbIDReader.Location = new System.Drawing.Point(81, 35);
            this.txbIDReader.Name = "txbIDReader";
            this.txbIDReader.Size = new System.Drawing.Size(100, 20);
            this.txbIDReader.TabIndex = 8;
            // 
            // lbAddress
            // 
            this.lbAddress.AutoSize = true;
            this.lbAddress.Location = new System.Drawing.Point(255, 42);
            this.lbAddress.Name = "lbAddress";
            this.lbAddress.Size = new System.Drawing.Size(40, 13);
            this.lbAddress.TabIndex = 6;
            this.lbAddress.Text = "Địa chỉ";
            // 
            // lb_idReader
            // 
            this.lb_idReader.AutoSize = true;
            this.lb_idReader.Location = new System.Drawing.Point(6, 38);
            this.lb_idReader.Name = "lb_idReader";
            this.lb_idReader.Size = new System.Drawing.Size(69, 13);
            this.lb_idReader.TabIndex = 5;
            this.lb_idReader.Text = "ID người đọc";
            // 
            // lbDoB
            // 
            this.lbDoB.AutoSize = true;
            this.lbDoB.Location = new System.Drawing.Point(21, 128);
            this.lbDoB.Name = "lbDoB";
            this.lbDoB.Size = new System.Drawing.Size(54, 13);
            this.lbDoB.TabIndex = 4;
            this.lbDoB.Text = "Ngày sinh";
            // 
            // lbNameReader
            // 
            this.lbNameReader.AutoSize = true;
            this.lbNameReader.Location = new System.Drawing.Point(49, 81);
            this.lbNameReader.Name = "lbNameReader";
            this.lbNameReader.Size = new System.Drawing.Size(26, 13);
            this.lbNameReader.TabIndex = 3;
            this.lbNameReader.Text = "Tên";
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
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(34, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Quay lại";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Library_Management.Properties.Resources.quayLai;
            this.pictureBox1.Location = new System.Drawing.Point(5, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(23, 20);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // NguoiDoc
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
            this.Name = "NguoiDoc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý người đọc";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txbDelete;
        private System.Windows.Forms.Label lbDelete;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txbInsertPhoneNum;
        private System.Windows.Forms.Label lb_insertReturnDate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txbInsertAddress;
        private System.Windows.Forms.TextBox txbInsertDoB;
        private System.Windows.Forms.TextBox txbInsertNameReader;
        private System.Windows.Forms.Label lb_insertBorrowDate;
        private System.Windows.Forms.Label lb_insertDeposit;
        private System.Windows.Forms.Label lb_insertReader;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txbPhoneNum;
        private System.Windows.Forms.Label lbPhoneNum;
        private System.Windows.Forms.TextBox txbAddressReader;
        private System.Windows.Forms.TextBox txbDoBReader;
        private System.Windows.Forms.TextBox txbNameReader;
        private System.Windows.Forms.TextBox txbIDReader;
        private System.Windows.Forms.Label lbAddress;
        private System.Windows.Forms.Label lb_idReader;
        private System.Windows.Forms.Label lbDoB;
        private System.Windows.Forms.Label lbNameReader;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txbEmail;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.TextBox txbInsertEmail;
        private System.Windows.Forms.Label lbInsertEmail;
    }
}