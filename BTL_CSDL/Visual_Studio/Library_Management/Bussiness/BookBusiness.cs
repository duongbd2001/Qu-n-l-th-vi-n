using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using System.Data;
using System.Data.SqlClient;
using DAO;

namespace Bussiness
{
    public class BookBusiness
    {
        private BookDAO bookDAO = new BookDAO();

        /// <summary>
        /// lấy dữ liệu bảng sách trong DB
        /// </summary>
        /// <param name="nameBook"></param>
        /// <param name="author"></param>
        /// <param name="categoty"></param>
        /// <param name="publisher"></param>
        /// <param name="lst"></param>
        /// <returns></returns>
        public int processSearch(string nameBook, string author, string categoty, string publisher, ref List<Book> lst)
        {
            Book book = new Book();
            book.name = nameBook;
            book.author = author;
            book.category = categoty;
            book.publisher = publisher;
            lst = bookDAO.getListBook(book);
            return 0;
        }

        /// <summary>
        /// thêm sách vào DB
        /// </summary>
        /// <param name="nameBook"></param>
        /// <param name="author"></param>
        /// <param name="category"></param>
        /// <param name="publisher"></param>
        /// <param name="quantity"></param>
        /// <param name="lst"></param>
        /// <returns></returns>
        public int processSave(string nameBook, string author, string category, string publisher, string quantity, ref List<Book> lst)
        {
            Book book = new Book();
            book.name = nameBook;
            book.author = author;
            book.category = category;
            book.publisher = publisher;
            try
            {
                book.quantity = int.Parse(quantity);
            }
            catch (Exception)
            {
                return 2;
            }
            bookDAO.saveBook(book);
            return 0;
        }

        /// <summary>
        /// Xóa khỏi DB
        /// </summary>
        /// <param name="id"></param>
        public void processDelete(string id)
        {
            Book book = new Book();
            book.id = id;
            bookDAO.deleteBook(book);
        }
    }
}
