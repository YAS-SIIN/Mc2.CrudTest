
using FluentValidation;

using Mc2.CrudTest.Presentation.Domain.Entities;     
 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mc2.CrudTest.Presentation.Domain.Common
{
    public class CustomerFluentValidation : AbstractValidator<Customer>
    {
        public CustomerFluentValidation(Infrastructure.Context.MyDataBase context)
        {
            RuleFor(x => x.Email).NotNull().WithMessage("Email is Null or Empty!")
                .EmailAddress().WithMessage("Invalid email address format!");
        }
    }
}
