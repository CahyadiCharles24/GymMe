using GymMe.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GymMe.Repository
{
    public class CartRepository
    {
        private static myDatabaseEntities1 db = DBInstance.getInstance();
        public static void createCart(MsCart cart)
        {
            db.MsCarts.Add(cart);
            db.SaveChanges();
        }

        public static List<MsCart> getAllCart(int userId)
        {
            List<MsCart> cart = db.MsCarts.Where(u=>u.UserID==userId).ToList();
            return cart;
        }

        public static void deleteCart(int userId)
        {
            var cartItems = getAllCart(userId);
            foreach(var cartItem in cartItems)
            {
                db.MsCarts.Remove(cartItem);
            }
            db.SaveChanges();
        }

    }
}