﻿using ShoppingAppModelLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingAppBLLibrary
{
    public interface IProductService
    {
        Product AddProduct(Product product);
        Product GetProductById(int productId);
        List<Product> GetAllProducts();
        Product UpdateProduct(Product product);
        bool DeleteProduct(int productId);
    }
}
