using Library.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Entities.Concreate
{
    public class Author : IEntity
    {
        public int Id { get; set; }
        public string AuthorName { get; set; }
        public string AuthorSurname { get; set; }
        public string Email { get; set; }
        public string TeleponeNumber { get; set; }
        public string Autobiography { get; set; }
    }
}
