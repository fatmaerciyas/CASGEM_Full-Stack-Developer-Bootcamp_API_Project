using Casgem.BusinessLayer.Abstract;
using Casgem.EntityLayer;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Casgem.ApiLayer.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        public IActionResult ProductList()
        {
            var values = _productService.TGetList();
            return Ok(values);
        }

        [HttpGet("{id}")]
        public IActionResult GetProduct(int id)
        {
            var value = _productService.TGetByID(id);
            return Ok(value);
        }

        [Route("GetProductListWithCategory")]
        [HttpGet]
        public IActionResult GetProductListWithCategory()
        {
            var values = _productService.TGetProductsWithCategories();
            return Ok(values);
        }

        [HttpPut]
        public IActionResult UpdateProduct(Product product)
        {
            _productService.TUpdate(product);
            return Ok();

        }


        [HttpPost]
        public IActionResult ProductAdd(Product product)
        {
            _productService.TInsert(product);
            return Ok();
        }


        [HttpDelete]
        public IActionResult ProductDelete(int id)
        {
            var value = _productService.TGetByID(id);
            _productService.TDelete(value);
            return Ok();
        }
    }
}

