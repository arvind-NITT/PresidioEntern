﻿using ShoppingAppModelLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingAppBLLibrary
{
    public interface ICartItemService
    {
        CartItem AddCartItem(CartItem cartItem);
        CartItem GetCartItemById(int cartItemId);
        CartItem UpdateCartItem(CartItem cartItem);
        bool DeleteCartItem(int cartItemId);
    }
}
