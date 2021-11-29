using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using DAO;

namespace Bussiness
{
    public class ReaderBusiness
    {
        private ReaderDAO readerDAO = new ReaderDAO();
        public void processSearch(string name, string DoB, string address, string phoneNum, string email, ref List<Reader> list)
        {
            Reader reader = new Reader();
            reader.name = name;
            reader.DoB = DoB;
            reader.address = address;
            reader.phoneNum = phoneNum;
            reader.email = email;
            list = readerDAO.getListReader(reader);
        }
        public void processSave(string name, string DoB, string address, string phoneNum, string email)
        {
            Reader reader = new Reader();
            reader.name = name;
            reader.DoB = DoB;
            reader.address = address;
            reader.phoneNum = phoneNum;
            reader.email = email;
            readerDAO.saveReader(reader);
        }
        public void processDelete(string id)
        {
            Reader reader = new Reader();
            reader.idReader = id;
            readerDAO.deleteReader(reader);

        }
    }
}
