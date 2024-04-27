using ShoppingAppModelLibrary.Exceptions;
using ShoppingAppModelLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingAppDALLibrary
{
    public class CartItemRepository : AbstractRepository<int, CartItem>
    {
        public override CartItem Delete(int key)
        {
            // Find the CartItem in the repository based on its key
            CartItem CartItemToRemove = items.FirstOrDefault(p => p.CartId == key);

            if (CartItemToRemove != null)
            {
                // If the CartItem is found, remove it from the repository
                items.Remove(CartItemToRemove);
            }
            else
            {
                // If the CartItem is not found, you may choose to throw an exception
                throw new NoCartItemWithGiveIdException();
            }

            // Return the deleted CartItem (if needed, such as for logging or further processing)
            return CartItemToRemove;
        }


        public override CartItem GetByKey(int key)
        {
            //Predicate<CartItem> findCartItem =(p)=>p.Id==key;
            //CartItem CartItem = items.ToList().Find(findCartItem);

            //CartItem CartItem = items.ToList().Find((p) => p.Id == key);

            CartItem CartItem = items.FirstOrDefault(p => p.CartId == key);
            return CartItem;

        }

        public override CartItem Update(CartItem item)
        {
            // Find the index of the CartItem in the repository based on its key
            CartItem CartItem = items.ToList().Find((p) => p.CartId == item.CartId);
            int index = CartItem.CartId;
            if (index != -1)
            {
                // If the CartItem is found, update its details with the provided item
                items[index] = item;
            }
            else
            {
                // If the CartItem is not found, you may choose to throw an exception
                throw new NoCartItemWithGiveIdException();
            }

            // Return the updated CartItem (if needed, such as for logging or further processing)
            return item;
        }

    }

}
