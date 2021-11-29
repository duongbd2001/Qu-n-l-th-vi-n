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
    public partial class PhieuMuon : Form
    {
        private VoteBusiness voteBuss = new VoteBusiness();
        public PhieuMuon()
        {
            InitializeComponent();
            voteSearch();
        }

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

        //Tìm kiếm phiếu
        private void btnSearch_Click(object sender, EventArgs e)
        {
            voteSearch();
        }

        //hàm view phiếu
        private void voteSearch()
        {
            List<Vote> list = new List<Vote>();
            voteBuss.processSearch(txbLibrarian.Text, txbIDReader.Text, txbDeposit.Text, txbBorrowDate.Text, txbReturnDate.Text, ref list);
            dataGridView1.DataSource = list;
            dataGridView1.Columns[0].HeaderCell.Value = "Mã phiếu";
            dataGridView1.Columns[1].HeaderCell.Value = "Mã người đọc";
            dataGridView1.Columns[2].HeaderCell.Value = "Mã thủ thư";
            dataGridView1.Columns[3].HeaderCell.Value = "tiền cọc";
            dataGridView1.Columns[4].HeaderCell.Value = "Ngày mượn";
            dataGridView1.Columns[5].HeaderCell.Value = "Ngày trả";
        }

        //Làm mới tìm kiếm
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            clearDataForm();
        }

        //Thêm phiếu
        private void btnAdd_Click(object sender, EventArgs e)
        {
            voteBuss.processSave(txbInsertIDLibrarian.Text, txbInsertIDReader.Text, txbInsertDeposit.Text, txbInsertBorrowDate.Text, txbInsertRetrunDate.Text,
                txbIDBook.Text, txbQuantity.Text);
            MessageBox.Show("Thêm thành công");
            voteSearch();
            txbInsertIDLibrarian.Clear();
            txbInsertIDReader.Clear();
            txbInsertDeposit.Clear();
            txbInsertBorrowDate.Clear();
            txbInsertRetrunDate.Clear();
            txbIDBook.Clear();
            txbQuantity.Clear();
        }

        //Xóa phiếu
        private void btnDelete_Click(object sender, EventArgs e)
        {
            voteBuss.processDelete(txbDelete.Text);
            voteSearch();
            MessageBox.Show("Xóa thành công");
        }

        private void clearDataForm()
        {
            txbLibrarian.Clear();
            txbIDReader.Clear();
            txbDeposit.Clear();
            txbBorrowDate.Clear();
            txbReturnDate.Clear();
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            ChiTietPhieuMuon chiTiet = new ChiTietPhieuMuon();
            chiTiet.Show();
            viewDetail(dataGridView1.Rows[0].Cells[0].Value.ToString(), txbIDBook.Text, dataGridView1.Rows[0].Cells[1].Value.ToString(), txbQuantity.Text);
            
        }

        //hàm thêm chi tiết phiếu
        private void viewDetail(string idVote, string idBook, string idReader, string quantity)
        {
            List<VoteDetail> list = new List<VoteDetail>();
            voteBuss.processViewDetail(idVote, idBook, idReader, quantity, ref list);
            dataGridView1.DataSource = list;
            dataGridView1.Columns[0].HeaderCell.Value = "Mã phiếu";
            dataGridView1.Columns[1].HeaderCell.Value = "Mã sách";
            dataGridView1.Columns[2].HeaderCell.Value = "Mã người đọc";
            dataGridView1.Columns[3].HeaderCell.Value = "số lượng";

        }
    }
}
