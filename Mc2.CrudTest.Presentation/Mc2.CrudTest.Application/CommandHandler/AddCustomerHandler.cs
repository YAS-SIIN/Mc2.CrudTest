

using Mc2.CrudTest.Application.Commands;
using CleanArchitecture.Domain.Common;
                                         
using Mc2.CrudTest.Presentation.Domain.Entities;
using Mc2.CrudTest.Presentation.Infrastructure.Services;

using MediatR;

using System.Threading;
using System.Threading.Tasks;

namespace Mc2.CrudTest.Application.CommandHandler
{    
    public class AddCustomerHandler : IRequestHandler<AddCustomerCommand, bool>
    {
        private readonly ICustomerService _customerservice;
        public AddCustomerHandler(ICustomerService customerservice)
        {
           _customerservice = customerservice;
        }
        public Task<bool> Handle(AddCustomerCommand command, CancellationToken cancellationToken)
        {      
            try
            {
                Customer customer = new Customer()
                {
                    Firstname = command.CustomerDto.Firstname.ToUpper(),
                    Lastname = command.CustomerDto.Lastname.ToUpper(),
                    Email = command.CustomerDto.Email.ToUpper(),
                    PhoneNumber = command.CustomerDto.PhoneNumber,
                    BankAccountNumber = command.CustomerDto.BankAccountNumber,
                    DateOfBirth = command.CustomerDto.DateOfBirth
                };

                if (!customer.PhoneNumber.IsValidPhone()) return Task.FromResult(false);

                if (!customer.BankAccountNumber.IsValidBankAccountNumber()) return Task.FromResult(false);
                             
                _customerservice.Insert(customer);
                return Task.FromResult(true);                     
            }
            catch (System.Exception)
            {
                return Task.FromResult(false);
            }
        }
 
    }
}