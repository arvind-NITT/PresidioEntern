using ShoppingAppDALLibrary;
using ShoppingAppModelLibrary;
using ShoppingAppModelLibrary.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingAppBLLibrary
{
    public class CartItemBL : ICartItemServices
    {
        readonly IRepository<int, CartItem> _CartItemRepository;
        public CartItemBL(IRepository<int, CartItem> CartItemRepository)
        {
            //_CartRepository = new CartRepository();//Tight coupling

            _CartItemRepository = CartItemRepository;
        }
        public int AddCartItem(CartItem CartItem)
        {
            var result = _CartItemRepository.Add(CartItem);
            if (result != null)
            {
                return result.CartId;
            }
            throw new NoCartItemWithGiveIdException();
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
