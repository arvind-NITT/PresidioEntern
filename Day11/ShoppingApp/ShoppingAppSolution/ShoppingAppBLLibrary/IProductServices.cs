using ShoppingAppModelLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingAppBLLibrary
{
    public interface IProductServices
    {
        int AddProduct(Product Product);
        Product ChangeProductPrice(int id, double price);
        Product GetProductById(int id);
        Product GetProductQuantityInHandById(int id);
        Product GetProductByName(string ProductName);

        bool IsProductAvailable(TimeOnly time, int Productid);
    }
}
