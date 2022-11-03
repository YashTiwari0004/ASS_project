using ASS_API.DbModels;
using ASS_API.Models;
using ASS_API.Reppository_Di;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASS_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        public readonly ICustomer customer = null;
        public CustomerController(ICustomer cust)
        {
            customer = cust;
        }
        [HttpPost]
        public async Task<IActionResult> CreateCustomer(CustomerModel registration)
        {
            var iak = await customer.AddCustomer(registration);
            return Ok(iak);
        }
        [HttpGet]
        public async Task<IActionResult> GetAllCustomers()
        {
            var cust = await customer.ShowCustomers();
            return Ok(cust);
        }

        [HttpGet("{userId}")]
        public async Task<IActionResult> GetCustomerId(int userId)
        {
            var user = await customer.GetCustomerById(userId);
            return Ok(user);
        }

        [HttpPut("{userId}")]
        public async Task<IActionResult> UdateCustomer(int userId, CustomerModel registration)
        {
            var user = await customer.UpdateCustomer(userId, registration);
            return Ok(user);
        }
        [HttpDelete("{userId}")]
        public async Task<IActionResult> DeleteCustomer(int userId)
        {
            var user = await customer.DeleteCustomer(userId);
            return Ok(user);
        }
        [HttpGet("login")]
        public async Task<IActionResult> Login([FromQuery] string eMail, [FromQuery]string password)
        {
            var cust = await customer.Login(eMail, password);
            if(cust == null)
            {
                return BadRequest("Invalid Email or Password");
            }
            return Ok(cust);
        }
    }
}
