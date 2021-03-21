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
    public class PublisherManager : IPublisherService
    {
        private IPublisherDal _publisherDal;
        public PublisherManager(IPublisherDal publisherDal)
        {
            _publisherDal = publisherDal;
        }
        public void Add(Publisher publisher)
        {
            _publisherDal.Add(publisher);
        }

        public List<Publisher> GetAll()
        {
            return _publisherDal.GetAll();
        }
    }
}
