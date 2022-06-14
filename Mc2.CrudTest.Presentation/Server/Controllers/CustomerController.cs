using CleanArchitecture.Domain.Common;

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
        public bool Post([FromBody] Customer Customer)
        {                       
            if (!Customer.PhoneNumber.IsValidPhone())
                return false;
            if (!Customer.BankAccountNumber.IsValidBankAccountNumber())
                return false;

            _customerservice.Insert(Customer);
            return true;
        }

        [HttpPut]
        public bool Put([FromBody] Customer Customer)
        {
            if (!Customer.PhoneNumber.IsValidPhone())
                return false;
            if (!Customer.BankAccountNumber.IsValidBankAccountNumber())
                return false;

            _customerservice.Update(Customer);
            return true;
        }

        [HttpDelete]
        public bool Delete(int Id)
        {
          var customer =  _customerservice.GetById(Id);
              _customerservice.Delete(customer);
            return true;
        }
    }
}
