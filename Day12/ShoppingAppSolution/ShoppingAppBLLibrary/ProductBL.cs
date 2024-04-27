using ShoppingModelLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingBLLibrary
{
    public class ProductBL : IProductServices
    {
        public int AddProduct(Product Product)
        {
            throw new NotImplementedException();
        }

        public Product ChangeProductPrice(int id, double price)
        {
            throw new NotImplementedException();
        }

        public Product GetProductById(int id)
        {
            throw new NotImplementedException();
        }

        public Product GetProductByName(string ProductName)
        {
            throw new NotImplementedException();
        }

        public Product GetProductQuantityInHandById(int id)
        {
            throw new NotImplementedException();
        }

        public bool IsProductAvailable(TimeOnly time, int Productid)
        {
            throw new NotImplementedException();
        }
    }
}
