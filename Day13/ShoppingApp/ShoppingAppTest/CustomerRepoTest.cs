﻿using ShoppingAppDALLibrary;
using ShoppingAppModelLibrary;
using ShoppingAppModelLibrary.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingAppTest
{
    public class CustomerRepoTest
    {
        IRepository<int, Customer> repository;
        [SetUp]
        public void Setup()
        {
            repository = new CustomerRepository();
        }

        [Test]
        public void AddSuccessTest()
        {
            Customer customer = new Customer() { Id = 1, Age = 22, Phone = "345654" };
            var result = repository.Add(customer);

            //Assert
            Assert.IsNotNull(result);
        }

        [Test]
        public void AddFailTest()
        {
            Customer customer = new Customer() { Id = 1, Age = 22, Phone = "345654" };
            repository.Add(customer);
            Customer customer1 = new Customer() { Id = 1, Age = 22, Phone = "345654" };
            var exception = Assert.Throws<ItemPresentException>(() => repository.Add(customer1));
            //Assert
            Assert.AreEqual("Item already present", exception.Message);
        }

        [Test]
        public void GetAllSuccessTest()
        {
            Customer customer = new Customer() { Id = 1, Age = 22, Phone = "345654" };
            repository.Add(customer);
            Customer customer1 = new Customer() { Id = 2, Age = 23, Phone = "76542" };
            repository.Add(customer1);
            List<Customer> customers = repository.GetAll().Result.ToList();

            //Assert
            Assert.AreEqual(2, customers.Count);
        }

        [Test]
        public void GetAllFailTest()
        {
            List<Customer> customers = repository.GetAll().Result.ToList();

            //Assert
            Assert.IsEmpty(customers);
        }

        [Test]
        public void GetIdSuccessTest()
        {
            Customer customer = new Customer() { Id = 1, Age = 22, Phone = "345654" };
            repository.Add(customer);
            var result = repository.GetByKey(1);
            Assert.IsNotNull(result);
        }

        [Test]
        public void GetIdFailTest()
        {
            Customer customer = new Customer() { Id = 1, Age = 22, Phone = "345654" };
            repository.Add(customer);
            var exception = Assert.Throws<NoCustomerWithGiveIdException>(() => repository.GetByKey(2));
            //Assert
            Assert.AreEqual("Customer with the given Id is not present", exception.Message);
        }

        [Test]
        public void DeleteSuccessTest()
        {
            Customer customer = new Customer() { Id = 1, Age = 22, Phone = "345654" };
            repository.Add(customer);
            var result = repository.Delete(1);
            Assert.IsNotNull(result);
        }

        [Test]
        public void DeleteFailTest()
        {
            Customer customer = new Customer() { Id = 1, Age = 22, Phone = "345654" };
            repository.Add(customer);
            var exception = Assert.Throws<NoCustomerWithGiveIdException>(() => repository.Delete(2));
            //Assert
            Assert.AreEqual("Customer with the given Id is not present", exception.Message);
        }
        [Test]
        public void UpdateSuccessTest()
        {
            Customer customer = new Customer() { Id = 1, Age = 22, Phone = "345654" };
            repository.Add(customer);
            Customer customer1 = new Customer() { Id = 1, Age = 23, Phone = "345654" };
            var result = repository.Update(customer1);
            Assert.AreEqual(23, result.Result.Age);
        }

        [Test]
        public void UpdateFailTest()
        {
            Customer customer = new Customer() { Id = 1, Age = 22, Phone = "345654" };
            repository.Add(customer);
            Customer customer1 = new Customer() { Id = 2, Age = 23, Phone = "345654" };
            var exception = Assert.Throws<NoCustomerWithGiveIdException>(() => repository.Update(customer1));
            //Assert
            Assert.AreEqual("Customer with the given Id is not present", exception.Message);
        }
    }
}
