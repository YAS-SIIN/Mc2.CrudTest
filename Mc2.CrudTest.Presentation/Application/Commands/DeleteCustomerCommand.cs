using MediatR;

namespace Mc2.CrudTest.Presentation.Application.Commands
{
    public class DeleteCustomerCommand : IRequest<bool>
    {
        public int Id { get; set; }

    }
}