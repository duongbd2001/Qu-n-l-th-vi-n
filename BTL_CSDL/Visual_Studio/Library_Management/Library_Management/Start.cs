using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Library_Management
{
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Book_Management book = new Book_Management();
            this.Hide();
            book.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Thu_thu thu = new Thu_thu();
            this.Hide();
            thu.Show();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            PhieuMuon chiTiet = new PhieuMuon();
            this.Hide();
            chiTiet.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            NguoiDoc nguoiDoc = new NguoiDoc();
            this.Hide();
            nguoiDoc.Show();
        }
    }
}
