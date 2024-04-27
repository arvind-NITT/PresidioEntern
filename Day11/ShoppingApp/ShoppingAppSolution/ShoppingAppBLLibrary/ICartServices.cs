using ShoppingAppModelLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingAppBLLibrary
{
    public interface ICartServices
    {
        int AddCart(Cart Cart);
        Cart GetCartById(int id);
        Cart GetCustomerIdByCartId(int id);
        List<CartItem> GetCartItemsById(int id);
    }
}
