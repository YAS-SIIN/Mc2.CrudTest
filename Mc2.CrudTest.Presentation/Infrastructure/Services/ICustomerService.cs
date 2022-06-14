using Mc2.CrudTest.Presentation.Domain.Entities;
 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mc2.CrudTest.Presentation.Infrastructure.Services
{
   public interface ICustomerService
    {
        IQueryable<Customer> GetAll();

        Customer GetById(int id);

        Customer Insert(Customer ObjCustomer);
        Customer Update(Customer ObjCustomer);
        Customer Delete(Customer ObjCustomer);

    }
}
