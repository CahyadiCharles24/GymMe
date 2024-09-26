using GymMe.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GymMe.Repository
{
    public class TransactionDetailRepository
    {
        private static myDatabaseEntities1 db = DBInstance.getInstance();

        public static List<TransactionDetail> getTransactionDetailByID(int id)
        {
            List<TransactionDetail> td = db.TransactionDetails.Where(u => u.TransactionID == id).ToList();
            return td;
        }

        public static void createTransactionDetail(TransactionDetail td)
        {
            db.TransactionDetails.Add(td);
            db.SaveChanges();
        }

    }
}