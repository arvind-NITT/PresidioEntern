﻿using ShoppingAppDALLibrary;
using ShoppingAppModelLibrary.Exceptions;
using ShoppingAppModelLibrary;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingAppBLLibrary
{
    public class ProductBL : IProductService
    {
        private readonly IRepository<int, Product> _productRepository;

        [ExcludeFromCodeCoverage]
        public ProductBL()
        {
            _productRepository = new ProductRepository();
        }

        public ProductBL(IRepository<int, Product> productRepository)
        {
            _productRepository = productRepository;
        }

        public Product AddProduct(Product product)
        {
            try
            {
                var addedProduct = _productRepository.Add(product);
                return addedProduct.Result;
            }
            catch (ItemPresentException ex)
            {
                Console.WriteLine(ex.Message);
                throw new ItemPresentException();
            }
        }

        public bool DeleteProduct(int productId)
        {
            var deletedProduct = _productRepository.Delete(productId);
            if (deletedProduct != null)
            {
                return true;
            }
            throw new NoProductWithGivenIdException();
        }

        [ExcludeFromCodeCoverage]
        public List<Product> GetAllProducts()
        {
            var products = _productRepository.GetAll().Result.ToList();
            if (products != null)
            {
                return products;
            }
            throw new NoProductWithGivenIdException();
        }

        public Product GetProductById(int productId)
        {
            var product = _productRepository.GetByKey(productId);
            if (product != null)
            {
                return product.Result;
            }
            throw new NoProductWithGivenIdException();
        }

        public Product UpdateProduct(Product product)
        {
            var updatedProduct = _productRepository.Update(product);
            if (updatedProduct != null)
            {
                return updatedProduct.Result;
            }
            throw new NoProductWithGivenIdException();
        }
    }
}
