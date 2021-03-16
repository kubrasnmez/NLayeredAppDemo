using Library.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Entities.Concreate
{
    public class Address : IEntity
    {
        public int Id { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string District { get; set; }
        public string Neightborhood { get; set; }
        public string Street { get; set; }
        public int ExteriorDoorNumber { get; set; }
        public int InteriorDoorNumber { get; set; }
    }
}
