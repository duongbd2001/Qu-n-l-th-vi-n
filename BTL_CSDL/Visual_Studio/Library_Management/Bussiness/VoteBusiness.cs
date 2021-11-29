using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using DAO;

namespace Bussiness
{
    public class VoteBusiness
    {
        private VoteDAO voteDAO = new VoteDAO();
        public void processSearch(string idLibrarian, string idReader, string diposit, string borrowDate, string returnDate, ref List<Vote> list)
        {
            Vote vote = new Vote();
            vote.idLibrarian = idLibrarian;
            vote.idReader = idReader;
            vote.diposit = diposit;
            vote.borrowDate = borrowDate;
            vote.returnDate = returnDate;
            list = voteDAO.getListVote(vote);
        }
        public void processSave(string idLibrarian, string idReader, string diposit, string borrowDate, string returnDate, string idBook, string quantity)
        {
            Vote vote = new Vote();
            vote.idLibrarian = idLibrarian;
            vote.idReader = idReader;
            vote.diposit = diposit;
            vote.borrowDate = borrowDate;
            vote.returnDate = returnDate;
            voteDAO.saveVote(vote);

            VoteDetail voteDetail = new VoteDetail();
            voteDetail.idVote = vote.idVote;
            voteDetail.idReader = vote.idReader;
            voteDetail.idBook = idBook;
            voteDetail.quantity = quantity;
            voteDAO.saveVoteDetail(voteDetail);
        }

        public void processDelete(string id)
        {
            Vote vote = new Vote();
            vote.idVote = id;
            voteDAO.deleteVote(vote);
        }

        public void processViewDetail(string idVote, string idBook, string idReader, string quantity, ref List<VoteDetail> list)
        {
            VoteDetail voteDetail = new VoteDetail();
            voteDetail.idVote = idVote;
            voteDetail.idBook = idBook;
            voteDetail.idReader = idReader;
            voteDetail.quantity = quantity;
            list = voteDAO.viewDetail(voteDetail);
        }
    }
}
