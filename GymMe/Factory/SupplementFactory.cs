using GymMe.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GymMe.Factory
{
    public class SupplementFactory
    {
        public static MsSupplement createSupplement(String name, DateTime expiry, int price, int typeID)
        {
            MsSupplement supplement = new MsSupplement();
            supplement.SupplementName = name;
            supplement.SupplementExpiryDate = expiry.Date;
            supplement.SupplementPrice = price;
            supplement.SupplementTypeID = typeID;

            return supplement;
        }


    }
}