 
using Mc2.CrudTest.Presentation.Models;
using Mc2.CrudTest.Presentation.Service;

using Microsoft.VisualStudio.TestTools.UnitTesting;

using Moq;

using System.Collections.Generic;

namespace Mc2.CrudTest.AcceptanceTests
{     
    public static class MockCustomerRepository
    {
  
        public static Mock<ICustomerService> GetCustomerRepository()
        {
            Customer customer = new Customer
            {
                Id = 3,
                Firstname = "Ali",
                Lastname = "Sadeghi",
                PhoneNumber = "6456",
                Email = "aaa@bb.com",
                DateOfBirth = new System.DateTime(2000, 5, 03),
                BankAccountNumber = "4353534535",
            };
            List<Customer> Customers = new List<Customer>();
            Customers.Add(new Customer
            {
                Id = 1,
                Firstname = "bbbbaaa",
                Lastname = "aasss",
                PhoneNumber = "3214654154",
                Email = "asa@gmail.com",
                DateOfBirth = new System.DateTime(2002, 4, 30),
                BankAccountNumber = "54645645646456",
            });
            Customers.Add(new Customer
            {
                Id = 1,
                Firstname = "ffas",
                Lastname = "faaa",
                PhoneNumber = "3214654154",
                Email = "hfhdf@gmail.com",
                DateOfBirth = new System.DateTime(2002, 4, 15),
                BankAccountNumber = "4564565464676578",
            }); Customers.Add(new Customer
            {
                Id = 1,
                Firstname = "aas",
                Lastname = "ssff",
                PhoneNumber = "3214654154",
                Email = "asd@gdfg.com",
                DateOfBirth = new System.DateTime(2000, 1, 25),
                BankAccountNumber = "87697856746",
            });


            var mockRepo = new Mock<ICustomerService>();

            mockRepo.Setup(r => r.GetAll());

            mockRepo.Setup(r => r.GetById(It.IsAny<int>()));
                             
            mockRepo.Setup(r => r.Insert(customer));
            mockRepo.Setup(r => r.Insert(It.IsAny<Customer>()));

            mockRepo.Setup(r => r.Update(customer));
            mockRepo.Setup(r => r.Update(It.IsAny<Customer>()));

            mockRepo.Setup(r => r.Delete(customer));
            mockRepo.Setup(r => r.Delete(It.IsAny<Customer>()));

            return mockRepo;
        }
    }
}
