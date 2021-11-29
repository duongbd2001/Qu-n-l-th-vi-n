using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using Model;

namespace Bussiness
{
    public class VoteDetailBusiness
    {
        private VoteDetailDAO voteDetailDAO = new VoteDetailDAO();
        public void processViewDetail(string idVote, string idBook, string idReader, string quantity, ref List<VoteDetail> list)
        {
            VoteDetail voteDetail = new VoteDetail();
            voteDetail.idVote = idVote;
            voteDetail.idBook = idBook;
            voteDetail.idReader = idReader;
            voteDetail.quantity = quantity;
            list = voteDetailDAO.viewDetail(voteDetail);
        }
    }
}
