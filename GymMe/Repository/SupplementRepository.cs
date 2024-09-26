using GymMe.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GymMe.Repository
{
    public class SupplementRepository
    {
        private static myDatabaseEntities1 db = DBInstance.getInstance();
        public static List<MsSupplement> getAllSupplement()
        {
            List<MsSupplement> supplement = db.MsSupplements.ToList();
            return supplement;
        }

        public static void insertSupplement(MsSupplement supplement)
        {
            db.MsSupplements.Add(supplement);
            db.SaveChanges();
        }

        public static MsSupplement getSupplementById(int Id)
        {
            return db.MsSupplements.Where(u=>u.SupplementID == Id).FirstOrDefault();
        }

        public static void deleteSupplement(int id)
        {
            MsSupplement ms = getSupplementById(id);
            db.MsSupplements.Remove(ms);
            db.SaveChanges();
        }

        public static void updateSupplement(int id, String name, DateTime expiry, int price, int typeID)
        {
            MsSupplement ms = (from x in db.MsSupplements where x.SupplementID == id select x).FirstOrDefault();
            ms.SupplementName = name;
            ms.SupplementExpiryDate = expiry.Date;
            ms.SupplementPrice = price;
            ms.SupplementTypeID = typeID;
            db.SaveChanges();
        }

    }
}