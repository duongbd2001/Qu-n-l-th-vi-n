using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Model;

namespace DAO
{
    public class LibrarianDAO
    {
        private Connector.Connector connector = null;
        SqlDataAdapter adapter = null;
        public LibrarianDAO()
        {
            connector = new Connector.Connector();
        }
        /// <summary>
        /// Lấy và hiển thị dữ liệu từ DB
        /// </summary>
        /// <param name="librarian"></param>
        /// <returns></returns>
        public List<Librarian> getListLibrarian(Librarian librarian)
        {
            Dictionary<string, object> param = new Dictionary<string, object>();
            List<Librarian> list = new List<Librarian>();
            string sql = "select id_thu_thu, ten, sđt, ngay_sinh, dia_chi, email from thu_thu where 1=1 ";

            CommonUtil.convertSQL(ref sql, ref param, "id_thu_thu", librarian.id, "id");
            CommonUtil.convertLike(ref sql, ref param, "ten", librarian.name, "name");
            CommonUtil.convertLike(ref sql, ref param, "sđt", librarian.phoneNum, "phoneNum");
            CommonUtil.convertLike(ref sql, ref param, "ngay_sinh", librarian.DoB, "DoB");
            CommonUtil.convertLike(ref sql, ref param, "dia_chi", librarian.address, "address");
            CommonUtil.convertLike(ref sql, ref param, "email", librarian.email, "email");

            adapter = connector.getData(sql, param);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);


            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                Librarian lib = new Librarian();
                lib.id = "TT"+ dataTable.Rows[i][0].ToString();
                lib.name = dataTable.Rows[i][1].ToString();
                lib.phoneNum = dataTable.Rows[i][2].ToString();
                lib.DoB = dataTable.Rows[i][3].ToString();
                lib.address = dataTable.Rows[i][4].ToString();
                lib.email = dataTable.Rows[i][5].ToString();
                list.Add(lib);
            }
            return list;
        }

        /// <summary>
        /// Thêm dữ liệu vào DB
        /// </summary>
        /// <param name="librarian"></param>
        public void saveLibrarian(Librarian librarian)
        {
            Dictionary<string, object> param = new Dictionary<string, object>();
            string sql = "insert into Thu_thu(ten, sđt, ngay_sinh, dia_chi, email) values (@ten, @sdt, @ngay_sinh, @dia_chi, @email)";
            param.Add("ten", librarian.name);
            param.Add("sdt", librarian.phoneNum);
            param.Add("ngay_sinh", librarian.DoB);
            param.Add("dia_chi", librarian.address);
            param.Add("email", librarian.email);
            connector.saveData(sql, param);
        }

        /// <summary>
        /// Xóa dữ liệu khỏi DB
        /// </summary>
        public void deleteLibrarian(Librarian librarian) {
            Dictionary<string, object> param = new Dictionary<string, object>();
            string sql = "delete from Thu_thu where id_thu_thu = @id";
            param.Add("id", librarian.id);
            connector.deleteData(sql, param);
        }
    }
}
