using System.Collections.Generic;

using Mc2.CrudTest.Presentation.Domain.Entities;

using MediatR;

namespace Mc2.CrudTest.Presentation.Application.Commands
{
    public record GetAllCustomerQuery : IRequest<List<Customer>>;
}