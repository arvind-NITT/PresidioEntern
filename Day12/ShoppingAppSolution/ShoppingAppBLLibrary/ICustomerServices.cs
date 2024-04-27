using ShoppingModelLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingBLLibrary
{
    public interface ICustomerServices
    {
        int AddCustomer(Customer Customer);
        Customer GetCustomerById(int id);
       
    }
}
