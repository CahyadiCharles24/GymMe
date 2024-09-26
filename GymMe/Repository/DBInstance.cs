using GymMe.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace GymMe.Repository
{
    public class DBInstance
    {
        private static myDatabaseEntities1 instance;

        public static myDatabaseEntities1 getInstance()
        {
            if(instance == null)
            {
                instance = new myDatabaseEntities1();
            }
            return instance;
        }


    }
}