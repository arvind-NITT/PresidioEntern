﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingAppTest
{
    public class CustomerBLTest
    {
        private CustomerBL _customerBL;
        private IRepository<int, Customer> _customerRepository;

        [SetUp]
        public void Setup()
        {
            _customerRepository = new CustomerRepository();
            _customerBL = new CustomerBL(_customerRepository);
        }

        [Test]
        public void AddCustomerSuccess()
        {
            // Arrange
            Customer customer = new Customer { Id = 1, Phone = "1234567890", Age = 30 };

            // Act
            var result = _customerBL.AddCustomer(customer);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(customer, result);
        }
        [Test]
        public void AddCustomerFail()
        {
            // Arrange
            Customer customer = new Customer { Id = 1, Phone = "1234567890", Age = 30 };

            // Act
            _customerBL.AddCustomer(customer);
            Customer customer1 = new Customer { Id = 1, Phone = "1234567890", Age = 30 };

            // Act
            var exception = Assert.Throws<ItemPresentException>(() => _customerBL.AddCustomer(customer1));
            //Assert
            Assert.AreEqual("Item already present", exception.Message);
        }

        [Test]
        public void DeleteCustomerSuccess()
        {
            // Arrange
            Customer customer = new Customer { Id = 1, Phone = "1234567890", Age = 30 };
            _customerBL.AddCustomer(customer);

            // Act
            var result = _customerBL.DeleteCustomer(customer.Id);

            // Assert
            Assert.IsTrue(result);
        }

        [Test]
        public void UpdateCustomerSuccess()
        {
            // Arrange
            Customer customer = new Customer { Id = 1, Phone = "1234567890", Age = 30 };
            _customerBL.AddCustomer(customer);

            // Modify the customer
            customer.Age = 35;

            // Act
            var result = _customerBL.UpdateCustomer(customer);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(customer, result);
        }

        [Test]
        public void GetCustomerByIdSuccess()
        {
            // Arrange
            Customer customer = new Customer { Id = 1, Phone = "1234567890", Age = 30 };
            _customerBL.AddCustomer(customer);

            // Act
            var result = _customerBL.GetCustomerById(customer.Id);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(customer, result);
        }

        [Test]
        public void GetCustomerByIdException()
        {
            // Arrange & Act & Assert
            Assert.Throws<NoCustomerWithGiveIdException>(() => _customerBL.GetCustomerById(999));
        }

        [Test]
        public void UpdateCustomerFail()
        {
            // Arrange
            Customer customer = new Customer { Id = 1, Phone = "1234567890", Age = 30 };
            _customerBL.AddCustomer(customer);
            Customer customer1 = new Customer { Id = 2, Phone = "1234567890", Age = 32 };

            // Act
            var exception = Assert.Throws<NoCustomerWithGiveIdException>(() => _customerBL.UpdateCustomer(customer1));
            //Assert
            Assert.AreEqual("Customer with the given Id is not present", exception.Message);
        }

        [Test]
        public void DeleteCustomerException()
        {
            // Arrange & Act & Assert
            Assert.Throws<NoCustomerWithGiveIdException>(() => _customerBL.DeleteCustomer(999));
        }
    }
}
