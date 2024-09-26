using GymMe.Handler;
using GymMe.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GymMe.Controller
{
    public class SupplementController
    {
        public static String validateSupplement(String name, DateTime expiryDate, 
            String price, String typeId)
        {
            if(name == "")
            {
                return "Name is Required";
            }else if (!name.Contains("Supplement"))
            {
                return "Name must Contains Supplement";
            }

            if(expiryDate == DateTime.MinValue)
            {
                return "Expiry Date is Required";
            }else if(expiryDate <= DateTime.Today)
            {
                return "Expiry Date is Invalid";
            }

            if(price == "")
            {
                return "Price is Required";
            }else if(Convert.ToInt32(price) <= 3000)
            {
                return "Price Must Be at Least 3000";
            }

            if(typeId == "")
            {
                return "Type ID is Required";
            }



            return SupplementHandler.insertSupplement(name,expiryDate,Convert.ToInt32(price),Convert.ToInt32(typeId));
        }

        public static String validateUpdate(int id, String name, DateTime expiryDate,
            String price, String typeId)
        {
            if (name == "")
            {
                return "Name is Required";
            }
            else if (!name.Contains("Supplement"))
            {
                return "Name must Contains Supplement";
            }

            if (expiryDate == DateTime.MinValue)
            {
                return "Expiry Date is Required";
            }
            else if (expiryDate <= DateTime.Today)
            {
                return "Expiry Date is Invalid";
            }

            if (price == "")
            {
                return "Price is Required";
            }
            else if (Convert.ToInt32(price) <= 3000)
            {
                return "Price Must Be at Least 3000";
            }

            if (typeId == "")
            {
                return "Type ID is Required";
            }

            return SupplementHandler.updateSupplement(id, name, expiryDate,
                Convert.ToInt32(price), Convert.ToInt32(typeId));
        }

        public static List<MsSupplement> getAllSupplement()
        {
            return SupplementHandler.getAllSupplement();
        }

        public static MsSupplement getSupplementById(int id)
        {
            return SupplementHandler.getSupplementById(id);
        }

        public static List<MsSupplementType> getAllSupplementType()
        {
            return SupplementHandler.getAllSupplementType();
        }

    }
}