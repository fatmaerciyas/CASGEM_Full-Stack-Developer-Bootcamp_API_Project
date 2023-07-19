using Casgem.DataAccsessLayer.Abstract;
using Casgem.DataAccsessLayer.Concrete;
using Casgem.DataAccsessLayer.GenericRepositories;
using Casgem.EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casgem.DataAccsessLayer.EntityFramework
{
    public class EfCustomerDal : GenericRepository<Customer>, ICustomerDal
    {
        public EfCustomerDal(Context context) : base(context)
        {
        }
    }
}
