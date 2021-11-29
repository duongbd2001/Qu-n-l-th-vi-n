using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using System.Data;
using System.Data.SqlClient;


namespace DAO
{
    public class VoteDAO
    {
        private Connector.Connector connector = null;
        SqlDataAdapter adap = null;
        public VoteDAO()
        {
            connector = new Connector.Connector();
        }

        //Hiển thị phiếu
        public List<Vote> getListVote(Vote vote)
        {
            Dictionary<string, object> param = new Dictionary<string, object>();
            List<Vote> list = new List<Vote>();
            string sql = "select id_phieu, id_thu_thu, id_nguoi_doc, tien_coc, ngay_muon, ngay_tra from phieu_muon where 1=1 ";
            CommonUtil.convertSQL(ref sql, ref param, "id_phieu", vote.idVote, "idVote");
            CommonUtil.convertLike(ref sql, ref param, "id_thu_thu", vote.idLibrarian, "idLibrarian");
            CommonUtil.convertLike(ref sql, ref param, "id_nguoi_doc", vote.idReader, "idReader");
            CommonUtil.convertLike(ref sql, ref param, "tien_coc", vote.diposit, "diposit");
            CommonUtil.convertLike(ref sql, ref param, "ngay_muon", vote.borrowDate, "borrowDate");
            CommonUtil.convertLike(ref sql, ref param, "ngay_tra", vote.returnDate, "returnDate");

            adap = connector.getData(sql, param);
            DataTable data = new DataTable();
            adap.Fill(data);
            for (int i = 0; i < data.Rows.Count; i++)
            {
                Vote vo = new Vote();
                vo.idVote = "PM" + data.Rows[i][0].ToString();
                vo.idLibrarian = data.Rows[i][1].ToString();
                vo.idReader = data.Rows[i][2].ToString();
                vo.diposit = data.Rows[i][3].ToString();
                vo.borrowDate = data.Rows[i][4].ToString();
                vo.returnDate = data.Rows[i][5].ToString();
                list.Add(vo);
            }
            return list;
        }
        //Thêm phiếu
        public void saveVote(Vote vote)
        {
            Dictionary<string, object> param = new Dictionary<string, object>();
            string sql = "insert into phieu_muon(id_thu_thu, id_nguoi_doc, tien_coc, ngay_muon, ngay_tra) values (@idLibrarian, @idReader, @diposit, @borrowDate, @returnDate)";
            param.Add("idLibrarian", vote.idLibrarian);
            param.Add("idReader", vote.idReader);
            param.Add("diposit", vote.diposit);
            param.Add("borrowDate", vote.borrowDate);
            param.Add("returnDate", vote.returnDate);
            connector.saveData(sql, param);
        }

        //Thêm chi tiết phiếu
        public void saveVoteDetail(VoteDetail voteDetail)
        {
            Dictionary<string, object> param = new Dictionary<string, object>();
            string sql = "insert into chi_tiet_phieu_muon(id_phieu, id_sach,id_nguoi_doc,so_luong) values (@idVote,@idBook,@idReader,@quantity)";
            param.Add("idVote", voteDetail.idVote);
            param.Add("idBook", voteDetail.idBook);
            param.Add("idReader", voteDetail.idReader);
            param.Add("quantity", voteDetail.quantity);
            connector.saveData(sql, param);
        }

        //Xóa phiếu
        public void deleteVote(Vote vote)
        {
            Dictionary<string, object> param = new Dictionary<string, object>();
            string sql = "delete from phieu_muon where id_phieu = @id";
            param.Add("id", vote.idVote);
            connector.deleteData(sql, param);
        }

        //Hiển thị chi tiết phiếu
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
