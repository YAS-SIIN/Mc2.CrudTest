using MediatR;

namespace Mc2.CrudTest.Application.Commands
{
    public class DeleteCustomerCommand : IRequest<bool>
    {
        public int Id { get; set; }

    }
}