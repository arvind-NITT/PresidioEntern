using ShoppingDALLibrary;
using ShoppingModelLibrary;
using ShoppingModelLibrary.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingBLLibrary
{
    public class CartBL : ICartServices
    {
        public CartBL() { }
        readonly IRepository<int, Cart> _CartRepository;
        readonly IRepository<int, CartItem> _CartItemRepository;
        public CartBL(IRepository<int, Cart> CartRepository, IRepository<int, CartItem> CartItemRepository)
        {
            //_CartRepository = new CartRepository();//Tight coupling
            _CartRepository = CartRepository;//Loose coupling
            _CartItemRepository = CartItemRepository;
        }
        public int AddCart(Cart cart)
        {
            var result = _CartRepository.Add(cart: cart);
            if (result != null)
            {
                return 0;
            }
            throw new NoCartWithGiveIdException();
        }

        public Cart GetCartById(int id)
        {
            List<Cart>  Carts = (List<Cart>)_CartRepository.GetAll();
            for (int i = 0; i < Carts.Count; i++)
                if (Carts[i].Id == id)
                    return Carts[i];
            throw new NoCartWithGiveIdException();
        }

        public List<CartItem> GetCartItemsById(int id)
        {
            List<CartItem> carts = (List<CartItem>)_CartItemRepository.GetAll();
            List<CartItem> result = new List<CartItem>(); // Create a new list for the result

            foreach (var item in carts)
            {
                if (item.CartId == id)
                    result.Add(item);
            }
            return result;
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
