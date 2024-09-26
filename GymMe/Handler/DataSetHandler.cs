using GymMe.Dataset;
using GymMe.Model;
using GymMe.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GymMe.Handler
{
    public class DataSetHandler
    {
        public static DataSet1 getDataSet(List<TransactionHeader> headerList)
        {
            return TransactionHeaderRepository.getDataSet(headerList);
        }

    }
}