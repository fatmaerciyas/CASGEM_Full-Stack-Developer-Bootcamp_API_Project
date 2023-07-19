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
    public class ProductManager : IProductService
    {
        private readonly IProductDal _ProductDal;

        public ProductManager(IProductDal ProductDal)
        {
            _ProductDal = ProductDal;
        }

        public void TDelete(Product t)
        {
            _ProductDal.Delete(t);
        }

        public Product TGetByID(int id)
        {
            return _ProductDal.GetByID(id);
        }

        public List<Product> TGetList()
        {
            return _ProductDal.GetList();
        }

        public List<Product> TGetProductsWithCategories()
        {
            return _ProductDal.GetProductWithCategories();
        }

        public void TInsert(Product t)
        {
            _ProductDal.Insert(t);
        }

        public void TUpdate(Product t)
        {
            _ProductDal.Update(t);
        }
    }
}
