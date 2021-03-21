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
    public class AddressManager : IAddressService
    {
        private IAddressDal _addressDal;
        public AddressManager(IAddressDal addressDal)
        {
            _addressDal = addressDal;
        }
        public void Add(Address address)
        {
            _addressDal.Add(address);
        }

        public void Delete(Address address)
        {
            throw new NotImplementedException();
        }

        public List<Address> GetAll()
        {
            return _addressDal.GetAll();
        }

        public void Update(Address address)
        {
            throw new NotImplementedException();
        }
    }
}
