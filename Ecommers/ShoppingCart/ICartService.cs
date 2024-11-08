﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart
{
    public interface ICartService
    {
        List<Cart>GetItems();

        bool AddtoCart(Item item);
        bool RemoveFromCart(Item item);
        bool Clear();
    }
}
