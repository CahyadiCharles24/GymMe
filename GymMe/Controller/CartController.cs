using GymMe.Handler;
using GymMe.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GymMe.Controller
{
    public class CartController
    {
        public static String createCart(int userId, int supplementId, int quantity)
        {
            if(quantity <= 0)
            {
                return "Quantity doesnt Valid";
            }

            CartHandler.createCart(userId, supplementId, quantity);
            return "";
        }

        public static List<MsCart> getAllCart(int userId)
        {
            return CartHandler.getAllCart(userId);
        }

        public static void deleteCart(int userId)
        {
            CartHandler.deleteCart(userId);
        }


    }
}