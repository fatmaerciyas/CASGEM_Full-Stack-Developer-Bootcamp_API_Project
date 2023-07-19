﻿using Casgem.EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casgem.BusinessLayer.Abstract
{
    public interface IProductService : IGenericService<Product>
    {
        public List<Product> TGetProductsWithCategories();
    }
}
