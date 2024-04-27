using ShoppingModelLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingBLLibrary
{
    public class CartItemBL : ICartItemServices
    {
        public int AddCartItem(CartItem CartItem)
        {
            throw new NotImplementedException();
        }

        public CartItem ChangeCartItemPrice(int id, double price)
        {
            throw new NotImplementedException();
        }

        public CartItem GetCartItemById(int id)
        {
            throw new NotImplementedException();
        }

        public DateTime GetCartItemExpiryDate(int id)
        {
            throw new NotImplementedException();
        }

        public CartItem GetCartItemQuantityInHandById(int id)
        {
            throw new NotImplementedException();
        }

        public bool IsCartItemAvailable(DateTime time, int CartItemid)
        {
            throw new NotImplementedException();
        }

        public CartItem UpdateCartItemDiscount(int id, double Discount)
        {
            throw new NotImplementedException();
        }
    }
}
