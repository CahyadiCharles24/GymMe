using GymMe.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GymMe.Factory
{
    public class TransactionFactory
    {
        public static TransactionHeader createTransactionHeader(int userId, DateTime date, String status)
        {
            TransactionHeader th = new TransactionHeader();
            th.UserID = userId;
            th.TransactionDate = date;
            th.Status = status;
            return th;
        }

        public static TransactionDetail createTransactionDetail(int transactionId, int supplementId, int quantity)
        {
            TransactionDetail td = new TransactionDetail();
            td.TransactionID = transactionId;
            td.SupplementID = supplementId;
            td.Quantity = quantity;
            return td;
        }

    }
}