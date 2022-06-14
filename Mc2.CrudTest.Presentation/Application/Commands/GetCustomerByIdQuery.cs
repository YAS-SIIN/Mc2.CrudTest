
using Mc2.CrudTest.Presentation.Domain.Entities;

using MediatR;

namespace Mc2.CrudTest.Presentation.Application.Commands
{
    public class GetCustomerByIdQuery : IRequest<Customer>
    {
        public int Id { get; set; }
        
    }
}
