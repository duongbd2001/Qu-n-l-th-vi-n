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
using Bussiness;
using Model;

namespace Library_Management
{
    public partial class Book_Management : Form
    {
        private BookBusiness bookBuss = new BookBusiness();
        public Book_Management()
        {
            InitializeComponent();
            processSearch();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Start start = new Start();
            this.Hide();
            start.Show();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            Start start = new Start();
            this.Hide();
            start.Show();
        }

        private void textBox7_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                processSearch();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            processSearch();
        }

        private void processSearch()
        {
            List<Book> listBook = new List<Book>();
            int ketqua = bookBuss.processSearch(txtBookName.Text, txtAuthor.Text, txtCategoryBook.Text, txtPublisherBook.Text, ref listBook);
            if (ketqua == 0)
            {
                dataGridView1.DataSource = listBook;

                dataGridView1.Columns[0].HeaderCell.Value = "Mã sách";
                dataGridView1.Columns[1].HeaderCell.Value = "Tên sách";
                dataGridView1.Columns[2].HeaderCell.Value = "Tác giả";
                dataGridView1.Columns[3].HeaderCell.Value = "Thể loại";
                dataGridView1.Columns[4].HeaderCell.Value = "NXB";
                dataGridView1.Columns[5].HeaderCell.Value = "Số lượng";
            }
            if (ketqua == 1)
                MessageBox.Show("Số lượng sách phải là 1 số nguyên");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Book> listBook = new List<Book>();

            int result =  bookBuss.processSave(txb_name_insertBook.Text, txb_author_insertBook.Text, txb_category_insertBook.Text, 
                txb_publisher_insertBook.Text, txb_quantity_insertBook.Text, ref listBook);

            if (result == 0)
            {
                MessageBox.Show("Thêm thành công");
                processSearch();
                clearFormDataBook();
            }
            if (result == 4)
            {
                MessageBox.Show("ID không được trống");
            }
            if (result == 1)
            {
                MessageBox.Show("ID phải là số nguyên");
            }
            if (result == 2)
            {
                MessageBox.Show("Số lượng phải là số nguyên");
            }
            if (result == 3)
            {
                MessageBox.Show("Sách này đã tồn tại");
            }
        }
        private void clearFormDataBook()
        {
            txb_name_insertBook.Clear();
            txb_category_insertBook.Clear();
            txb_author_insertBook.Clear();
            txb_publisher_insertBook.Clear();
            txb_quantity_insertBook.Clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            bookBuss.processDelete(txb_idBookToDelete.Text);
            processSearch();
            MessageBox.Show("Xóa thành công");
        }

        private void txb_idBookToDelete_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnDelete.PerformClick();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtBookName.Clear();
            txtAuthor.Clear();
            txtCategoryBook.Clear();
            txtPublisherBook.Clear();
        }
    }
}
