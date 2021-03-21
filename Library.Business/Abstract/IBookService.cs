using Library.Entities.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Business.Abstract
{
    public interface IBookService
    {
        List<Book> GetAll();
        List<Book> GetBookByCategory(int categoryId);
        List<Book> GetBooksByBookName(string bookName);
        void Add(Book book);
        void Update(Book book);
        void Delete(Book book);
    }
}
