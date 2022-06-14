using Mc2.CrudTest.Presentation.Application.Commands;
using Mc2.CrudTest.Presentation.Domain.Entities;
using Mc2.CrudTest.Presentation.Infrastructure.Services;

using MediatR;

using System.Threading;
using System.Threading.Tasks;
 


namespace Mc2.CrudTest.Presentation.Application.CommandHandler
{
    public class GetCustomerByIdHandler : IRequestHandler<GetCustomerByIdQuery, Customer>
    {
        private readonly ICustomerService _customerservice;
        public GetCustomerByIdHandler(ICustomerService customerservice)
        {
            _customerservice = customerservice;
        }
        public Task<Customer> Handle(GetCustomerByIdQuery Command, CancellationToken cancellationToken)
        {
            Customer customer =  _customerservice.GetById(Command.Id);
            return Task.FromResult(customer);
        }
    }
}