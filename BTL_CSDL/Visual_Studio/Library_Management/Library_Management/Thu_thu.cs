using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;
using Bussiness;

namespace Library_Management
{
    public partial class Thu_thu : Form
    {
        private LibrarianBusiness libBuss = new LibrarianBusiness();
        public Thu_thu()
        {
            InitializeComponent();
            librarianSearch();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-OHVB6QL;Initial Catalog=btl_csdl;Integrated Security=True");
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

        //Button Tìm kiếm thủ thư theo trường
        private void btnSearch_infor_librarian_Click(object sender, EventArgs e)
        {
            librarianSearch();
        }
        private void librarianSearch()
        {
            List<Librarian> list = new List<Librarian>();
            LibrarianBusiness librarianBusiness = new LibrarianBusiness();
            int result = librarianBusiness.processSearch(txbSearch_name.Text, txbSearch_DoB.Text, txbSearch_Address.Text, txbSearch_email.Text, ref list);
            if (result == -1)
            {
                MessageBox.Show("Số điện thoại sai định dạng");
            }
            else
            {
                dataGridView1.DataSource = list;
                dataGridView1.Columns[0].HeaderCell.Value = "Mã thủ thư";
                dataGridView1.Columns[1].HeaderCell.Value = "Tên";
                dataGridView1.Columns[2].HeaderCell.Value = "Số điện thoại";
                dataGridView1.Columns[3].HeaderCell.Value = "Ngày sinh";
                dataGridView1.Columns[4].HeaderCell.Value = "Địa chỉ";
                dataGridView1.Columns[5].HeaderCell.Value = "Email";
                
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            List<Librarian> list = new List<Librarian>();
            libBuss.processSave(txbAdd_name.Text, txbAdd_PhoneNum.Text, txbAdd_DoB.Text, txbAdd_Address.Text, txbAdd_email.Text, ref list);
            MessageBox.Show("Thêm thành công");
            librarianSearch();
            clearFormDataLibrarian();
        }
        private void clearFormDataLibrarian()
        {
            txbAdd_name.Clear();
            txbAdd_PhoneNum.Clear();
            txbAdd_DoB.Clear();
            txbAdd_Address.Clear();
            txbAdd_email.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            libBuss.processDelete(txbDeleteID.Text);
            librarianSearch();
            MessageBox.Show("Xóa thành công");

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txbSearch_name.Clear();
            txbSearch_DoB.Clear();
            txbSearch_Address.Clear();
            txbSearch_email.Clear();
        }

        #region Key Down Enter
        private void txbDeleteID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnDelete.PerformClick();
            }
        }

        private void txbSearch_name_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSearch_infor_librarian.PerformClick();
            }
        }

        private void txbSearch_DoB_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSearch_infor_librarian.PerformClick();
            }
        }

        private void txbSearch_Address_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSearch_infor_librarian.PerformClick();
            }
        }

        private void txbSearch_email_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSearch_infor_librarian.PerformClick();
            }
        }

        private void txbAdd_email_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnAdd.PerformClick();
            }
        }
        #endregion
    }
}
