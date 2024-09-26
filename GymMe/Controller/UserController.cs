using GymMe.Handler;
using GymMe.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text.RegularExpressions;
using System.Web;

namespace GymMe.Controller
{
    public class UserController
    {
        public static String validateNewUser(String username, String email, String gender, String password, 
            String Cpass, DateTime DOB, String role)
        {
            if (username=="")
            {
                return "Username is Required";
            }
            else if (!Regex.IsMatch(username, @"^[a-zA-Z\s]+$"))
            {
                return "Username only Contains Alphabet and Spaces only";
            }
            else if(username.Length<5 || username.Length>15)
            {
                return "username length between 5 to 15";
            }

            if (email == "")
            {
                return "Email is Required";
            }
            else if (!email.Contains(".com"))
            {
                return "Email must contain .com";
            }

            if (gender == "")
            {
                return "Gender Must Choosen";
            }

            if (password == "")
            {
                return "Password is Required";
            }
            else if (Cpass == "")
            {
                return "Confirm pass field is required";
            }else if(password != Cpass)
            {
                return "Password doesn't match with Confirm Password";
            }

            if (DOB == DateTime.MinValue)
            {
                return "Select DOB!";
            }

            return UserHandler.registUser(username,email,password, gender, DOB, role);
        }

        public static String validateLogin(String username, String password)
        {
            if(username == "")
            {
                return "Username cannot be empty!";
            }
            if(password == "")
            {
                return "Password cannot be empty";
            }

            return UserHandler.loginUser(username,password);
        }

        public static string validateUpdate(int userID, string email, string username, string gender, DateTime DOB, string newPassword)
        {
            if (username == "")
            {
                return "Username is Required";
            }
            else if (!Regex.IsMatch(username, @"^[a-zA-Z\s]+$"))
            {
                return "Username only Contains Alphabet and Spaces only";
            }
            else if (username.Length < 5 || username.Length > 15)
            {
                return "username length between 5 to 15";
            }

            if (email == "")
            {
                return "Email is Required";
            }
            else if (!email.Contains(".com"))
            {
                return "Email must contain .com";
            }

            if (gender == "")
            {
                return "Gender Must Choosen";
            }

            if (DOB == DateTime.MinValue)
            {
                return "Select DOB!";
            }

            if (newPassword == "")
            {
                return "Password is Required";
            }

            return UserHandler.UpdateUser(userID, email, username, DOB, gender, newPassword);
        }
        public static string validateOldPassword(int userID, string password)
        {
            if (password == "")
            {
                return "Password is Required";
            }
            return UserHandler.OldPassword(userID, password);
        }


        public static MsUser getUserById(String id)
        {
            return UserHandler.getUserById(id);
        }

        public static MsUser getUserByUsername(String username)
        {
            return UserHandler.getUserByUsername(username);
        }

        public static List<MsUser> getAllCustomer()
        {
            return UserHandler.getAllCustomer();
        }

    }
}