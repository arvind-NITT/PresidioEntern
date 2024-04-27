
using ShoppingModelLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingBLLibrary
{
    public class CartBL : ICartServices
    {
        public CartBL() { }

        public int AddCart(Cart Cart)
        {
            throw new NotImplementedException();
        }

        public Cart GetCartById(int id)
        {
            throw new NotImplementedException();
        }

        public List<CartItem> GetCartItemsById(int id)
        {
            throw new NotImplementedException();
        }
        public bool ShippingCharge(int id)
        {
            throw new NotImplementedException();
        }
        public bool DiscountAppliedOrNot(int id)
        {
            throw new NotImplementedException();
        }

        public Cart GetCustomerIdByCartId(int id)
        {
            throw new NotImplementedException();
        }

    }
}
