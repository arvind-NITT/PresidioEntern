using ShoppingAppModelLibrary;
using ShoppingAppModelLibrary.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingAppDALLibrary
{
    public class ProductRepository : AbstractRepository<int, Product>
    {
        public override Product Delete(int key)
        {
            // Find the product in the repository based on its key
            Product productToRemove = items.FirstOrDefault(p => p.Id == key);

            if (productToRemove != null)
            {
                // If the product is found, remove it from the repository
                items.Remove(productToRemove);
            }
            else
            {
                // If the product is not found, you may choose to throw an exception
                throw new NoProductWithGiveIdException();
            }

            // Return the deleted product (if needed, such as for logging or further processing)
            return productToRemove;
        }


        public override Product GetByKey(int key)
        {
            //Predicate<Product> findProduct =(p)=>p.Id==key;
            //Product product = items.ToList().Find(findProduct);

            //Product product = items.ToList().Find((p) => p.Id == key);

            Product product = items.FirstOrDefault(p => p.Id == key);
            return product;

        }

        public override Product Update(Product item)
        {
            // Find the index of the product in the repository based on its key
            Product product = items.ToList().Find((p) => p.Id == item.Id);
            int index = product.Id;
            if (index != -1)
            {
                // If the product is found, update its details with the provided item
                items[index] = item;
            }
            else
            {
                // If the product is not found, you may choose to throw an exception
                throw new NoProductWithGiveIdException();
            }

            // Return the updated product (if needed, such as for logging or further processing)
            return item;
        }

    }
}
