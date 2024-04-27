using ShoppingAppModelLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingAppBLLibrary
{
    public interface ICustomerServices
    {
        int AddCustomer(Customer Customer);
        Customer GetCustomerById(int id);
       
    }
}
