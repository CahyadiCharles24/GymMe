using GymMe.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GymMe.Repository
{
    public class SupplementTypeRepository
    {

        private static myDatabaseEntities1 db = DBInstance.getInstance();
        public static MsSupplementType getSupplementType(int typeID)
        {
            return db.MsSupplementTypes.Where(u=>u.SupplementTypeID == typeID).FirstOrDefault();
        }

        public static List<MsSupplementType> getAllSupplementType()
        {
            List<MsSupplementType> mt = db.MsSupplementTypes.ToList();
            return mt;
        }
    }
}