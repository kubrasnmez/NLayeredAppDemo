using Library.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Entities.Concreate
{
   public class Publisher : IEntity
    {
        public int Id { get; set; }
        public string PublisherName { get; set; }
        public string TelephoneNumber { get; set; }
        public int AddressId { get; set; }
    }
}
