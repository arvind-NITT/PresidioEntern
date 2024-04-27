using ShoppingModelLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingBLLibrary
{
    public interface ICartServices
    {
        int AddCart(Cart Cart);
        Cart GetCartById(int id);
        Cart GetCustomerIdByCartId(int id);
        List<CartItem> GetCartItemsById(int id);
    }
}
