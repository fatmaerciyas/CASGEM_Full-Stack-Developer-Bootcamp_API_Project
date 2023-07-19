using Casgem.DataAccsessLayer.Abstract;
using Casgem.DataAccsessLayer.Concrete;
using Casgem.DataAccsessLayer.GenericRepositories;
using Casgem.EntityLayer;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casgem.DataAccsessLayer.EntityFramework
{
    public class EfProductDal : GenericRepository<Product>, IProductDal
    {
        public EfProductDal(Context context) : base(context)
        {
        }

        public List<Product> GetProductWithCategories()
        {
            using var context = new Context();
            return context.Products.Include(x => x.Category).ToList();
        }
    }
}
