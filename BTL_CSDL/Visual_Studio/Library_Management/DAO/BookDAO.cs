using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Connector;
using Model;
using System.Data;
using System.Data.SqlClient;

namespace DAO
{
    public class BookDAO
    {
        private Connector.Connector connect = null;
        SqlDataAdapter adap = null;
        public BookDAO()
        {
            connect = new Connector.Connector();
        }
        public List<Book> getListBook(Book book)
        {
            Dictionary<String, object> param = new Dictionary<string, object>();
            List<Book> list = new List<Book>();
            string sql = "select id_sach,ten,tac_gia,the_loai,NXB,so_luong from sach where 1=1 ";

            CommonUtil.convertSQL(ref sql, ref param, "id_sach", book.id, "id");
            CommonUtil.convertLike(ref sql, ref param, "ten", book.name, "name");
            CommonUtil.convertLike(ref sql, ref param, "tac_gia", book.author, "author");
            CommonUtil.convertLike(ref sql, ref param, "the_loai", book.category, "category");
            CommonUtil.convertLike(ref sql, ref param, "NXB", book.publisher, "publisher");
            CommonUtil.convertSQL(ref sql, ref param, "so_luong", book.quantity, "quantity");

            adap = connect.getData(sql, param);

            DataTable dataTable = new DataTable();
            adap.Fill(dataTable);

            if (dataTable != null && dataTable.Rows != null && dataTable.Rows.Count > 0)
            {
                for (int i = 0; i < dataTable.Rows.Count; i++)
                {
                    Book bo = new Book();
                    bo.id = "S"+ dataTable.Rows[i][0].ToString();
                    bo.name = dataTable.Rows[i][1].ToString();
                    bo.author = dataTable.Rows[i][2].ToString();
                    bo.category = dataTable.Rows[i][3].ToString();
                    bo.publisher = dataTable.Rows[i][4].ToString();
                    bo.quantity = int.Parse( dataTable.Rows[i][5].ToString());
                    list.Add(bo);
                }
            }
            return list;
        }
        public void saveBook(Book book)
        {
            Dictionary<string, object> param = new Dictionary<string, object>();
            string sql = "insert into sach(ten, tac_gia, the_loai,NXB, so_luong) values (@ten,@tac_gia,@the_loai,@NXB,@so_luong)";
            param.Add("ten", book.name);
            param.Add("tac_gia", book.author);
            param.Add("the_loai", book.category);
            param.Add("NXB", book.publisher);
            param.Add("so_luong", book.quantity);
            connect.saveData(sql, param);
        }

        public void deleteBook(Book book)
        {
            Dictionary<string, object> param = new Dictionary<string, object>();
            string sql = "delete from sach where id_sach = @id";
            param.Add("id", book.id);
            connect.deleteData(sql, param);
        }
    }
}
