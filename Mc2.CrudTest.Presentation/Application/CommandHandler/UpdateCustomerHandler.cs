using CleanArchitecture.Domain.Common;

using Mc2.CrudTest.Application.Commands;
using Mc2.CrudTest.Presentation.Domain.Entities;
using Mc2.CrudTest.Presentation.Infrastructure.Services;

using MediatR;

using System;
using System.Threading;
using System.Threading.Tasks;



namespace Mc2.CrudTest.Application.CommandHandler
{
    public class UpdateCustomerHandler : IRequestHandler<UpdateCustomerCommand, bool>
    {
        private readonly ICustomerService _customerservice;  
        public UpdateCustomerHandler(ICustomerService customerservice)
        {
            _customerservice = customerservice;
        }
        public  Task<bool> Handle(UpdateCustomerCommand Command, CancellationToken cancellationToken)
        {
            try
            {
                Customer customer = new Customer()
                {
                    Firstname = Command.CustomerDto.Firstname.ToUpper(),
                    Lastname = Command.CustomerDto.Lastname.ToUpper(),
                    Email = Command.CustomerDto.Email.ToUpper(),
                    PhoneNumber = Command.CustomerDto.PhoneNumber,
                    BankAccountNumber = Command.CustomerDto.BankAccountNumber,
                    DateOfBirth = Command.CustomerDto.DateOfBirth
                };

                if (!customer.PhoneNumber.IsValidPhone()) return Task.FromResult(false);

                if (!customer.BankAccountNumber.IsValidBankAccountNumber()) return Task.FromResult(false);


                _customerservice.Update(customer);
      ;
                return Task.FromResult(true);
            }
            catch (Exception e)
            {
                return Task.FromResult(false);
            }
        }
    }
}