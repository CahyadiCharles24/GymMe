using GymMe.Factory;
using GymMe.Model;
using GymMe.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GymMe.Handler
{
    public class SupplementHandler
    {
        public static String insertSupplement(String name, DateTime expiry, int price, int typeID)
        {
            MsSupplementType checkTypeID = SupplementTypeRepository.getSupplementType(typeID);

            if (checkTypeID == null)
            {
                return "Invalid Type ID";
            }

            MsSupplement supp = SupplementFactory.createSupplement(name, expiry, price, typeID);
            SupplementRepository.insertSupplement(supp);
            return "";
        }

        public static String updateSupplement(int id, String name, DateTime expiry, int price, int typeID)
        {
            MsSupplementType mtype = SupplementTypeRepository.getSupplementType(typeID);

            if (mtype == null)
            {
                return "Wrong Type ID";
            }

            SupplementRepository.updateSupplement(id, name, expiry, price, typeID);
            return "";
        }

        public static List<MsSupplement> getAllSupplement()
        {
            return SupplementRepository.getAllSupplement();
        }

        public static MsSupplement getSupplementById(int id)
        {
            return SupplementRepository.getSupplementById(id);
        }

        public static List<MsSupplementType> getAllSupplementType()
        {
            return SupplementTypeRepository.getAllSupplementType();
        }
    }
}