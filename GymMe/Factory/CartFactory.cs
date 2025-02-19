﻿using GymMe.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GymMe.Factory
{
    public class CartFactory
    {
        public static MsCart createCart(int userId, int supplementId, int quantity)
        {
            MsCart cart = new MsCart();
            cart.UserID = userId;
            cart.SupplementID = supplementId;
            cart.Quantity = quantity;
            return cart;
        }
    }
}