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
    public class AuthorManager : IAuthorService
    {
        private IAuthorDal _authorDal;
        public AuthorManager(IAuthorDal authorDal)
        {
            _authorDal = authorDal;
        }
        public void Add(Author author)
        {
            _authorDal.Add(author);
        }

        public List<Author> GetAll()
        {
            return _authorDal.GetAll();
        }
    }
}
