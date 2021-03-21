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
    public class RentalManager : IRentalService
    {
        private IRentalDal _rentalDal;
        public RentalManager(IRentalDal rentalDal)
        {
            _rentalDal = rentalDal;
        }
        public void Add(Rental rental)
        {
            _rentalDal.Add(rental);
        }

        public List<Rental> GetAll()
        {
            return _rentalDal.GetAll();
        }
    }
}
