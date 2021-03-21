using Library.Business.Abstract;
using Library.DataAccess.Abstract;
using Library.Entities.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Business.Concreate
{
    public class BookManager : IBookService
    {
        private IBookDal _bookDal;
        public BookManager(IBookDal bookDal)
        {
            _bookDal = bookDal;
        }

        public void Add(Book book)
        {
            _bookDal.Add(book);
        }

        public List<Book> GetAll()
        {
            //business code 
            return _bookDal.GetAll();
        }

        public List<Book> GetBookByCategory(int categoryId)
        {
            return _bookDal.GetAll(b => b.CategoryId == categoryId);
        }

        public List<Book> GetBooksByBookName(string bookName)
        {
            return _bookDal.GetAll(b => b.Name.ToLower().Contains(bookName.ToLower()));
        }

        public void Update(Book book)
        {
            _bookDal.Update(book);
        }
    }
}
