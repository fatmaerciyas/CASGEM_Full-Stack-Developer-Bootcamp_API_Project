using Casgem.BusinessLayer.Abstract;
using Casgem.EntityLayer;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Casgem.ApiLayer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        private readonly ICustomerService _customerService;

        public CustomersController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        [HttpGet]
        public IActionResult CustomerList()
        {
            var values = _customerService.TGetList();
            return Ok(values);
        }

        [HttpGet("{id}")]
        public IActionResult GetCustomer(int id)
        {
            var value = _customerService.TGetByID(id);
            return Ok(value);
        }

        [HttpPut]
        public IActionResult UpdateCustomer(Customer customer)
        {
            _customerService.TUpdate(customer);
            return Ok();

        }


        [HttpPost]
        public IActionResult CustomerAdd(Customer customer)
        {
            _customerService.TInsert(customer);
            return Ok();
        }


        [HttpDelete]
        public IActionResult ProductDelete(int id)
        {
            var value = _customerService.TGetByID(id);
            _customerService.TDelete(value);
            return Ok();
        }
    }
}
