
using Mc2.CrudTest.Presentation.Domain.Dto;
using Mc2.CrudTest.Presentation.Domain.Entities;

using MediatR;

namespace Mc2.CrudTest.Application.Commands
{
    public class AddCustomerCommand : IRequest<bool>
    {
        public CustomerDTO CustomerDto { get; set; }

        public AddCustomerCommand(CustomerDTO dto)
        {
            CustomerDto = dto;
        }
    }
}