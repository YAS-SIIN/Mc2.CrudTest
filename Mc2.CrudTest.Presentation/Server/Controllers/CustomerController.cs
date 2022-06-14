


using Mc2.CrudTest.Presentation.Application.Commands;
using Mc2.CrudTest.Presentation.Domain.Entities;

using MediatR;

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Mc2.CrudTest.Presentation.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private IMediator _mediator;

        protected IMediator Mediator => _mediator ??= HttpContext.RequestServices.GetService<IMediator>();

        [HttpGet, Route("[action]")]
        public IEnumerable<Customer> Get()
        {
            var aa = (IEnumerable<Customer>)Mediator.Send(new GetAllCustomerQuery(), CancellationToken.None);
            return (IEnumerable<Customer>)Mediator.Send(new GetAllCustomerQuery(), CancellationToken.None);
        }

        [HttpGet, Route("[action]")]
        public Customer GetById(int CustomerId)
        {
            return (Customer)Mediator.Send(new GetCustomerByIdQuery { Id= CustomerId });
        }

        [HttpPost, Route("[action]")]
        public Task<bool> Post([FromBody] AddCustomerCommand Customer)
        {
            return Mediator.Send(Customer);        
        }

        [HttpPut, Route("[action]")]
        public Task<bool> Put([FromBody] UpdateCustomerCommand Customer)
        {
            return Mediator.Send(Customer);    
        }

        [HttpDelete, Route("[action]")]
        public Task<bool> Delete(int CustomerId)
        {                                                      
            return Mediator.Send(new DeleteCustomerCommand { Id = CustomerId });    
        }
    }
}
