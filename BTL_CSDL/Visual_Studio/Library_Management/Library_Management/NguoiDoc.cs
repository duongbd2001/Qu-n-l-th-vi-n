using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;
using Bussiness;

namespace Library_Management
{
    public partial class NguoiDoc : Form
    {
        public NguoiDoc()
        {
            InitializeComponent();
            processSearch();
        }
        private ReaderBusiness readerBusiness = new ReaderBusiness();
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Start start = new Start();
            this.Hide();
            start.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Start start = new Start();
            this.Hide();
            start.Show();
        }
        //Button tìm kiếm
        private void btnSearch_Click(object sender, EventArgs e)
        {
            processSearch();
        }


        //Hàm tìm kiếm
        public void processSearch()
        {
            List<Reader> list = new List<Reader>();
            readerBusiness.processSearch(txbNameReader.Text, txbDoBReader.Text, txbAddressReader.Text, txbPhoneNum.Text, txbEmail.Text, ref list);
            dataGridView1.DataSource = list;
            dataGridView1.Columns[0].HeaderCell.Value = "Mã người đọc";
            dataGridView1.Columns[1].HeaderCell.Value = "Tên";
            dataGridView1.Columns[2].HeaderCell.Value = "Ngày sinh";
            dataGridView1.Columns[3].HeaderCell.Value = "Địa chỉ";
            dataGridView1.Columns[4].HeaderCell.Value = "Số điện thoại";
            dataGridView1.Columns[5].HeaderCell.Value = "Email";
        }

        //Làm mới tìm kiếm
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txbNameReader.Clear();
            txbDoBReader.Clear();
            txbAddressReader.Clear();
            txbPhoneNum.Clear();
            txbEmail.Clear();
        }

        //Button thêm dữ liệu
        private void btnAdd_Click(object sender, EventArgs e)
        {
            readerBusiness.processSave(txbInsertNameReader.Text, txbInsertDoB.Text, txbInsertAddress.Text, txbInsertPhoneNum.Text, txbInsertEmail.Text);
            txbInsertNameReader.Clear();
            txbInsertDoB.Clear();
            txbInsertAddress.Clear();
            txbInsertPhoneNum.Clear();
            txbInsertEmail.Clear();
            MessageBox.Show("Thêm thành công");
            processSearch();
        }

        //Button xóa người đọc
        private void btnDelete_Click(object sender, EventArgs e)
        {
            readerBusiness.processDelete(txbDelete.Text);
            txbDelete.Clear();
            processSearch();
            MessageBox.Show("Xóa thành công");
        }
    }
}
