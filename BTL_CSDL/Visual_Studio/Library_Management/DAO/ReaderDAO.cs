using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Model;

namespace DAO
{
    public class ReaderDAO
    {
        private Connector.Connector connector = null;
        SqlDataAdapter adap = null;

        public ReaderDAO()
        {
            connector = new Connector.Connector();
        }

        public List<Reader> getListReader(Reader reader)
        {
            Dictionary<string, object> param = new Dictionary<string, object>();
            List<Reader> list = new List<Reader>();
            string sql = "select id_nguoi_doc,ten,ngay_sinh,dia_chi,sđt, email from nguoi_doc where 1=1 ";
            CommonUtil.convertSQL(ref sql, ref param, "id_nguoi_doc", reader.idReader, "idReader");
            CommonUtil.convertLike(ref sql, ref param, "ten", reader.name, "name");
            CommonUtil.convertLike(ref sql, ref param, "ngay_sinh)", reader.DoB, "DoB");
            CommonUtil.convertLike(ref sql, ref param, "dia_chi", reader.address, "address");
            CommonUtil.convertLike(ref sql, ref param, "sđt", reader.phoneNum, "phoneNum");
            CommonUtil.convertLike(ref sql, ref param, "email", reader.email, "email");

            adap = connector.getData(sql, param);
            DataTable dataTable = new DataTable();
            adap.Fill(dataTable);

            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                Reader read = new Reader();
                read.idReader = "ND" + dataTable.Rows[i][0].ToString();
                read.name = dataTable.Rows[i][1].ToString();
                read.DoB = dataTable.Rows[i][2].ToString();
                read.address = dataTable.Rows[i][3].ToString();
                read.phoneNum = dataTable.Rows[i][4].ToString();
                read.email = dataTable.Rows[i][5].ToString();
                list.Add(read);
            }
            return list;
        }
        public void saveReader(Reader reader)
        {
            Dictionary<string, object> param = new Dictionary<string, object>();
            string sql = "insert into nguoi_doc(ten,ngay_sinh,dia_chi,sđt,email) values (@name,@DoB,@address,@phoneNum,@email)";
            param.Add("name", reader.name);
            param.Add("DoB", reader.DoB);
            param.Add("address", reader.address);
            param.Add("phoneNum", reader.phoneNum);
            param.Add("email", reader.email);
            connector.saveData(sql, param);
        }
        public void deleteReader(Reader reader)
        {
            Dictionary<string, object> param = new Dictionary<string, object>();
            string sql = "delete from nguoi_doc where id_nguoi_doc = @id ";
            param.Add("id", reader.idReader);
            connector.deleteData(sql, param);
        }
    }
}
