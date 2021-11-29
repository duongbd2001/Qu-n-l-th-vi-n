using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using Connector;
using System.Data;
using System.Data.SqlClient;

namespace DAO
{
    public class VoteDetailDAO
    {
        private Connector.Connector connector = null;
        SqlDataAdapter adap = null;
        public VoteDetailDAO()
        {
            connector = new Connector.Connector();
        }
        public List<VoteDetail> viewDetail(VoteDetail voteDetail)
        {
            Dictionary<string, object> param = new Dictionary<string, object>();
            List<VoteDetail> list = new List<VoteDetail>();
            string sql = "select id_phieu, id_sach, id_nguoi_doc, so_luong from chi_tiet_phieu_muon where 1=1 ";
            CommonUtil.convertSQL(ref sql, ref param, "id_phieu", voteDetail.idVote, "idVote");
            CommonUtil.convertSQL(ref sql, ref param, "id_sach", voteDetail.idBook, "idBook");
            CommonUtil.convertSQL(ref sql, ref param, "id_nguoi_doc", voteDetail.idReader, "idReader");
            adap = connector.getData(sql, param);
            DataTable dataTable = new DataTable();
            adap.Fill(dataTable);
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                VoteDetail voteDetail1 = new VoteDetail();
                voteDetail1.idVote = "PM" + dataTable.Rows[i][0].ToString();
                voteDetail1.idBook = "S" + dataTable.Rows[i][1].ToString();
                voteDetail1.idReader = "ND" + dataTable.Rows[i][2].ToString();
                voteDetail1.quantity = dataTable.Rows[i][0].ToString();
                list.Add(voteDetail1);
            }

            return list;
        }
    }
}
