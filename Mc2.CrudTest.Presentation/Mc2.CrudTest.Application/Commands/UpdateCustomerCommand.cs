 
using Mc2.CrudTest.Presentation.Domain.Dto;

using MediatR;

namespace Mc2.CrudTest.Application.Commands
{
    public class UpdateCustomerCommand : IRequest<bool>
    {
        public CustomerDTO CustomerDto { get; set; }

        public UpdateCustomerCommand(CustomerDTO dto)
        {
            this.CustomerDto = dto;
        }
    }
}