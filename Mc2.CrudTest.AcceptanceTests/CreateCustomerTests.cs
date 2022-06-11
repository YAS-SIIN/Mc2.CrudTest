using Mc2.CrudTest.Presentation.Models;
using Mc2.CrudTest.Presentation.Server.Controllers;
using Mc2.CrudTest.Presentation.Service;

using Microsoft.VisualStudio.TestTools.UnitTesting;

using Moq;

using Shouldly;

using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using Xunit;

namespace Mc2.CrudTest.AcceptanceTests
{
    [TestClass()]
    public class BddTddTests
    {
        private CustomerController _customercontroller;
        private readonly ICustomerService _customerservice;
        private readonly Mock<CustomerController> _mockRepo;
        public BddTddTests(ICustomerService customerservice )
        {
            _customerservice = customerservice;
            _customercontroller = new CustomerController(_customerservice);
            _mockRepo = new Mock<CustomerController>(_customerservice);
        }
        [TestMethod()]
        public void GetReturnsSuccess1()
        {
                                                                
            _mockRepo.Setup(foo =>
                 foo.Get()).Throws<InvalidOperationException>();            
            Assert.ThrowsException<InvalidOperationException>(() =>
                 _mockRepo.Object.Get());
        }

        [TestMethod]
        public void GetReturnsSuccess()
        {
            CustomerController controller = new CustomerController(_customerservice);
           
            var okResult = controller.Get();
                                                      

            // Assert
            Assert.IsNotNull(okResult);
            Assert.AreEqual("test", okResult);

            // Assert
            //Assert.ThrowsException<ArgumentNullException>(()=>_customercontroller.Get(), "customer");
        }

        [Fact]
        public void PostSuccess()
        {
            Customer customer = new Customer();
            customer.Firstname = "Test";
            customer.Lastname = "Testi";
            customer.DateOfBirth = DateTime.Now;
            customer.PhoneNumber = "09149611762";
            customer.Email = "aa@sds.com";
            customer.BankAccountNumber = "45345345";

            var okResult = _customercontroller.Post(customer);
            // Assert
            Assert.IsNotNull(okResult);
        }

        [Fact]
        public void PutSuccess()
        {
            Customer customer = new Customer();
            customer.Firstname = "Test";
            customer.Lastname = "TTTestt";
            customer.DateOfBirth = DateTime.Now;
            customer.PhoneNumber = "09149611762";
            customer.Email = "aa@sds.com";
            customer.BankAccountNumber = "45345345";

            var okResult = _customercontroller.Put(customer);
 
            Assert.IsNotNull(okResult);
        }

        [Fact]
        public void DeleteSuccess()
        {
            var okResult = _customercontroller.Delete(1);
  
            Assert.IsNotNull(okResult);  
        }

        [Fact]
        public void Customer_ValidRequest()
        {
            var okResult = _customercontroller.Get();

            var Customers = _mockRepo.Object.Get();

            okResult.ShouldBeOfType<Customer>();

            Customers.ShouldBeEmpty();
        }

        // Please create more tests based on project requirements as per in readme.md
    }
}
