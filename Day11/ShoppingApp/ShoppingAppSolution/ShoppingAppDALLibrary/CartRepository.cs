using ShoppingAppModelLibrary.Exceptions;
using ShoppingAppModelLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingAppDALLibrary
{
    public class CartRepository : AbstractRepository<int, Cart>
    {
        public override Cart Delete(int key)
        {
            // Find the Cart in the repository based on its key
            Cart CartToRemove = items.FirstOrDefault(p => p.Id == key);

            if (CartToRemove != null)
            {
                // If the Cart is found, remove it from the repository
                items.Remove(CartToRemove);
            }
            else
            {
                // If the Cart is not found, you may choose to throw an exception
                throw new NoCartWithGiveIdException();
            }

            // Return the deleted Cart (if needed, such as for logging or further processing)
            return CartToRemove;
        }


        public override Cart GetByKey(int key)
        {
            //Predicate<Cart> findCart =(p)=>p.Id==key;
            //Cart Cart = items.ToList().Find(findCart);

            //Cart Cart = items.ToList().Find((p) => p.Id == key);

            Cart Cart = items.FirstOrDefault(p => p.Id == key);
            return Cart;

        }

        public List<CartItem> getAllCartItems()
        {

        }
        public override Cart Update(Cart item)
        {
            // Find the index of the Cart in the repository based on its key
            Cart Cart = items.ToList().Find((p) => p.Id == item.Id);
            int index = Cart.Id;
            if (index != -1)
            {
                // If the Cart is found, update its details with the provided item
                items[index] = item;
            }
            else
            {
                // If the Cart is not found, you may choose to throw an exception
                throw new NoCartWithGiveIdException();
            }

            // Return the updated Cart (if needed, such as for logging or further processing)
            return item;
        }

    }

}
