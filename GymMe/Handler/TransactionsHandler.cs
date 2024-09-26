using GymMe.Factory;
using GymMe.Model;
using GymMe.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GymMe.Handler
{
    public class TransactionsHandler
    {
        public static List<TransactionHeader> getTransactionHistory(int id)
        {
            return TransactionHeaderRepository.getTransactionHistory(id); 
        }

        public static List<TransactionHeader> getAllTransactionHeader()
        {
            return TransactionHeaderRepository.getAllTransactionHeader();
        }

        public static void changeStatus(int id)
        {
            TransactionHeaderRepository.changeStatus(id);
        }

        public static List<TransactionDetail> getTransactionDetailByID(int id)
        {
            return TransactionDetailRepository.getTransactionDetailByID(id);
        }

        public static void createTransactionHeader(int userId, DateTime date, String status)
        {
            TransactionHeader th =  TransactionFactory.createTransactionHeader(userId, date, status);
            TransactionHeaderRepository.createTransactionHeader(th);
        }

        public static TransactionHeader getTransactionId()
        {
            return TransactionHeaderRepository.getTransactionId();
        }

        public static void createTransactionDetail(int transactionId, int supplementId, int quantity)
        {
            TransactionDetail td = TransactionFactory.createTransactionDetail(transactionId,supplementId, quantity);
            TransactionDetailRepository.createTransactionDetail(td);
        }
    }
}