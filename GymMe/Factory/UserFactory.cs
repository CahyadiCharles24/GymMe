using GymMe.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GymMe.Factory
{
    public class UserFactory
    {
        public static MsUser CreateUser(String username, String email, String gender,
            String password, DateTime DOB, String role )
        {
            MsUser us = new MsUser();
            us.UserName = username;
            us.UserEmail = email;
            us.UserGender = gender;
            us.UserPassword = password;
            us.UserDOB = DOB.Date;
            us.UserRole = role;

            return us;
        }




    }
}