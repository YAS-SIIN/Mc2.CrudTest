
using FluentValidation;

using Mc2.CrudTest.Presentation.Domain.Entities;
 //using Mc2.CrudTest.Presentation.Infrastructure;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c2.CrudTest.Application.Validators
{
    public class CustomerFluentValidation : AbstractValidator<Customer>
    {
        //public CustomerFluentValidation(MyDataBase context)
        //{   
        //    RuleFor(x => x.Email).NotNull().WithMessage("Email is Null or Empty!")
        //        .EmailAddress().WithMessage("Invalid email address format!");                                
        //}
    }
}
