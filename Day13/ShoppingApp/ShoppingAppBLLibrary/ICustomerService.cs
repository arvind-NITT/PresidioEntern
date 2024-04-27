﻿using ShoppingAppModelLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingAppBLLibrary
{
    public interface ICustomerService
    {
        Customer AddCustomer(Customer customer);
        Customer UpdateCustomer(Customer customer);
        Customer GetCustomerById(int customerId);
        List<Customer> GetAllCustomers();
        bool DeleteCustomer(int customerId);
    }
}
