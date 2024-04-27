using ShoppingModelLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingBLLibrary
{
    public interface ICartItemServices
    {
        int AddCartItem(CartItem CartItem);
        CartItem ChangeCartItemPrice(int id, double price);
        CartItem UpdateCartItemDiscount(int id, double Discount);
        CartItem GetCartItemById(int id);
        CartItem GetCartItemQuantityInHandById(int id);
        DateTime GetCartItemExpiryDate(int id);
        bool IsCartItemAvailable(DateTime time, int CartItemid);
    }
}
