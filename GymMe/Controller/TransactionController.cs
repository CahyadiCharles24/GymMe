using GymMe.Model;
using GymMe.Handler;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Web;

namespace GymMe.Controller
{
    public class TransactionController
    {
        public static List<TransactionHeader> getTransactionHistory(int id)
        {
            return TransactionsHandler.getTransactionHistory(id);
        }

        public static List<TransactionHeader> getAllTransactionHeader()
        {
            return TransactionsHandler.getAllTransactionHeader();
        }

        public static void changeStatus(int id)
        {
            TransactionsHandler.changeStatus(id);
        }

        public static List<TransactionDetail> getTransactionDetailByID(int id)
        {
            return TransactionsHandler.getTransactionDetailByID(id);
        }

        public static void createTransactionHeader(int userId, DateTime date, String status)
        {
            TransactionsHandler.createTransactionHeader(userId, date, status);
        }

        public static TransactionHeader getTransactionId()
        {
            return TransactionsHandler.getTransactionId();
        }
        public static void createTransactionDetail(int transactionId, int supplementId, int quantity)
        {
            TransactionsHandler.createTransactionDetail(transactionId, supplementId, quantity); 
        }
    }
}