using GymMe.Dataset;
using GymMe.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GymMe.Repository
{
    public class TransactionHeaderRepository
    {
        private static myDatabaseEntities1 db = DBInstance.getInstance();

        public static List<TransactionHeader> getAllTransactionHeader()
        {
            List<TransactionHeader> th = db.TransactionHeaders.ToList();
            return th;
        }

        public static void changeStatus(int id)
        {
            TransactionHeader th = (from x in db.TransactionHeaders where x.TransactionID == id select x).FirstOrDefault();
            th.Status = "handled";
            db.SaveChanges();
        }

        public static DataSet1 getDataSet(List<TransactionHeader> headerList)
        {
            DataSet1 dataSet = new DataSet1();
            foreach(TransactionHeader th in headerList)
            {
                var headerRow = dataSet.TransactionHeader.NewRow();
                headerRow["TransactionID"] = th.TransactionID;
                headerRow["UserID"] = th.UserID;
                headerRow["TransactionDate"] = th.TransactionDate;

                int subtotal = 0;
                foreach(TransactionDetail td in th.TransactionDetails)
                {
                    var detailRow = dataSet.TransactionDetail.NewRow();
                    detailRow["TransactionID"] = th.TransactionID;
                    detailRow["SupplementName"] = td.MsSupplement.SupplementName;
                    detailRow["Quantity"] = td.Quantity;
                    detailRow["SupplementPrice"] = td.MsSupplement.SupplementPrice;

                    int detailSubTotal = td.Quantity * td.MsSupplement.SupplementPrice;
                    detailRow["SubTotal"] = detailSubTotal;

                    subtotal += detailSubTotal;
                    dataSet.TransactionDetail.Rows.Add(detailRow);
                }
                headerRow["Total"] = subtotal;
                dataSet.TransactionHeader.Rows.Add(headerRow);
            }
            return dataSet;
        }

        public static List<TransactionHeader> getTransactionHistory(int id)
        {
            List<TransactionHeader> th = db.TransactionHeaders.Where(u=>u.UserID == id) .ToList();
            return th;
        }

        public static void createTransactionHeader(TransactionHeader th)
        {
            db.TransactionHeaders.Add(th);
            db.SaveChanges();
        }

        public static TransactionHeader getTransactionId()
        {
            return db.TransactionHeaders.ToList().LastOrDefault();
        }
    }
}