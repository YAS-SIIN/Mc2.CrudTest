using Mc2.CrudTest.Presentation.Domain.Entities;
using Mc2.CrudTest.Presentation.Infrastructure.Services;
 
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

using System.Collections.Generic;

namespace Mc2.CrudTest.Presentation.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {                                                         
        private readonly ICustomerService _customerservice;
        public CustomerController( ICustomerService customerservice)
        {
            _customerservice = customerservice;
        }

        [HttpGet]
        public IEnumerable<Customer> Get()
        {                  
            return _customerservice.GetAll();
        }

        [HttpGet]
        public Customer GetById(int Id)
        {
            return _customerservice.GetById(Id);
        }

        [HttpPost]
        public Customer Post([FromBody] Customer Customer)
        {                                 
            return _customerservice.Insert(Customer);
        }

        [HttpPut]
        public Customer Put([FromBody] Customer Customer)
        {           
            return _customerservice.Update(Customer);
        }

        [HttpDelete]
        public Customer Delete(int Id)
        {
          var customer =  _customerservice.GetById(Id);
            return _customerservice.Delete(customer);
        }
    }
}
