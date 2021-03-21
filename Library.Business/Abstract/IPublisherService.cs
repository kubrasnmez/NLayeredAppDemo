using Library.Entities.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Business.Abstract
{
    public interface IPublisherService
    {
        List<Publisher> GetAll();
        void Add(Publisher publisher);
    }
}
