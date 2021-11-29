using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using DAO;

namespace Bussiness
{
    public class LibrarianBusiness
    {
        private LibrarianDAO libDao = new LibrarianDAO();
        public int processSearch(string name, string DoB, string address, string email, ref List<Librarian> list)
        {
            Librarian librarian = new Librarian();
            librarian.name = name;
            librarian.DoB = DoB;
            librarian.address = address;
            librarian.email = email;
            list = libDao.getListLibrarian(librarian);
            return 1;
        }
        public void processSave(string name, string phoneNum, string DoB,  string address, string email, ref List<Librarian> list)
        {
            Librarian librarian = new Librarian();
            librarian.name = name;
            librarian.phoneNum = phoneNum;
            librarian.DoB = DoB;
            librarian.address = address;
            librarian.email = email;
            libDao.saveLibrarian(librarian);
        }
        public void processDelete(string id)
        {
            Librarian librarian = new Librarian();
            librarian.id =id;
            libDao.deleteLibrarian(librarian);
        }
    }
}
