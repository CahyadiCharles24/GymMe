using GymMe.Factory;
using GymMe.Model;
using GymMe.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GymMe.Handler
{
    public class CartHandler
    {
        public static void createCart(int userId, int supplementId, int quantity)
        {
            MsCart cart = CartFactory.createCart(userId, supplementId, quantity);
            CartRepository.createCart(cart);
        }

        public static List<MsCart> getAllCart(int userId)
        {
            return CartRepository.getAllCart(userId);
        }

        public static void deleteCart(int userId)
        {
            CartRepository.deleteCart(userId);
        }
    }
}