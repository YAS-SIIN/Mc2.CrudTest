

using Mc2.CrudTest.Application.Commands;
using Mc2.CrudTest.Presentation.Domain.Entities;
using Mc2.CrudTest.Presentation.Infrastructure.Services;

using MediatR;

using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Mc2.CrudTest.Application.CommandHandler
{

    public class GetAllCustomerQueryHandler : IRequestHandler<GetAllCustomerQuery, List<Customer>>
    {
   
        private readonly ICustomerService _customerservice;
        public GetAllCustomerQueryHandler(ICustomerService customerservice)
        {
            _customerservice = customerservice;
        }
        public  Task<List<Customer>> Handle(GetAllCustomerQuery Command, CancellationToken cancellationToken)
        {
            List<Customer> customers =   _customerservice.GetAll().ToList() ;
            return Task.FromResult(customers);
        }
    }
}