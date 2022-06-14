using Mc2.CrudTest.Presentation.Application.Commands;
                                         
using Mc2.CrudTest.Presentation.Domain.Entities;
using Mc2.CrudTest.Presentation.Infrastructure.Services;

using MediatR;

using System.Threading;
using System.Threading.Tasks;

 

namespace Mc2.CrudTest.Presentation.Application.CommandHandler
{
    public class DeleteCustomerHandler : IRequestHandler<DeleteCustomerCommand, bool>
    {
        private readonly ICustomerService _customerservice;
        public DeleteCustomerHandler(ICustomerService customerservice)    
        {
            _customerservice = customerservice;
        }
        public  Task<bool> Handle(DeleteCustomerCommand Command, CancellationToken cancellationToken)
        {
            try
            {
                Customer customer = _customerservice.GetById(Command.Id);

                if (customer == null) return Task.FromResult(false); 

                _customerservice.Delete(customer);

                return Task.FromResult(true);
            }
            catch (System.Exception)
            {
                return Task.FromResult(false);
            }
           
        }
    }
}
