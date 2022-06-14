using Mc2.CrudTest.Presentation.Infrastructure.UnitOfWork;
using Mc2.CrudTest.Presentation.Domain;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mc2.CrudTest.Presentation.Domain.Entities;

namespace Mc2.CrudTest.Presentation.Infrastructure.Services
{
  public class CustomerService:ICustomerService
    { 
        private readonly IUnitOfWork _uw;
        public CustomerService(IUnitOfWork uw)
        {
            _uw = uw;
        }

        public IQueryable<Customer> GetAll()
        {
            return _uw.GetRepository<Customer>().GetAll();
        }

        public Customer GetById(int id)
        {
            return _uw.GetRepository<Customer>().GetById(id);
        }

        public Customer Insert(Customer ObjCustomer)
        {

            _uw.GetRepository<Customer>().Add(ObjCustomer);
            _uw.SaveChanges();
            return ObjCustomer;
        }

        public Customer Update(Customer ObjCustomer)
        {               
            _uw.GetRepository<Customer>().Update(ObjCustomer);
            _uw.SaveChanges();
            return ObjCustomer;
        }

        public Customer Delete(Customer ObjCustomer)
        {           
            _uw.GetRepository<Customer>().Delete(ObjCustomer);
            _uw.SaveChanges();
            return ObjCustomer;
        }
    }
}
