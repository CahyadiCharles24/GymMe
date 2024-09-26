using GymMe.Dataset;
using GymMe.Handler;
using GymMe.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GymMe.Controller
{
    public class DataSetController
    {
        public static DataSet1 getDataSet(List<TransactionHeader> headerList)
        {
            return DataSetHandler.getDataSet(headerList);
        }
    }
}