using Library.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Entities.Concreate
{
    public class Rental : IEntity
    {
        public int Id { get; set; }
        public DateTime ReturnDate { get; set; }
        public DateTime RentDate { get; set; }
        public int BookId { get; set; }
        public int CustomerId { get; set; }
    }
}
