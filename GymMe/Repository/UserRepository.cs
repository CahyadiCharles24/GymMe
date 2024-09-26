using GymMe.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;

namespace GymMe.Repository
{
    public class UserRepository
    {
        private static myDatabaseEntities1 db = DBInstance.getInstance();
        public static MsUser getUserByUsername(String username)
        {

            return db.MsUsers.Where(u=>u.UserName == username).FirstOrDefault();
        }
        public static MsUser getUserById(String id)
        {

            return db.MsUsers.Where(u => u.UserID.ToString() == id).FirstOrDefault();
        }
        public static void Register(MsUser newUser)
        {
            db.MsUsers.Add(newUser);
            db.SaveChanges();

        }

        public static MsUser checkLogin(String username, String password)
        {

            return db.MsUsers.Where(u=> u.UserName == username && u.UserPassword==password).FirstOrDefault();
        }

        public static List<MsUser> getAllCustomer()
        {
            List<MsUser> customer = (from x in db.MsUsers where x.UserRole == "customer" select x).ToList();
            return customer;
        }

        public static void UpdateUser(int userID, string Email, string Username, DateTime DOB, string Gender, string newPassword)
        {
            MsUser user = (from x in db.MsUsers where x.UserID == userID select x).FirstOrDefault();
            user.UserEmail = Email;
            user.UserName = Username;
            user.UserDOB = DOB;
            user.UserGender = Gender;
            user.UserPassword = newPassword;
            db.SaveChanges();

        }
        public static MsUser OldPassword(int userID, string password)
        {
            MsUser user = db.MsUsers.Where(u => u.UserID == userID && u.UserPassword == password).FirstOrDefault();
            return user;
        }


    }
}