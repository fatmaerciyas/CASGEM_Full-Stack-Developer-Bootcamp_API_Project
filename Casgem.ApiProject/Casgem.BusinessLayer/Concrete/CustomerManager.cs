using Casgem.BusinessLayer.Abstract;
using Casgem.DataAccsessLayer.Abstract;
using Casgem.EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casgem.BusinessLayer.Concrete
{
    public class CustomerManager : ICustomerService
    {
        private readonly ICustomerDal _CustomerDal;

        public CustomerManager(ICustomerDal CustomerDal)
        {
            _CustomerDal = CustomerDal;
        }

        public void TDelete(Customer t)
        {
            _CustomerDal.Delete(t);
        }

        public Customer TGetByID(int id)
        {
            return _CustomerDal.GetByID(id);
        }

        public List<Customer> TGetList()
        {
            return _CustomerDal.GetList();
        }

        public void TInsert(Customer t)
        {
            _CustomerDal.Insert(t);
        }

        public void TUpdate(Customer t)
        {
            _CustomerDal.Update(t);
        }
    }
}
