﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSR.DatabaseAPI
{
    class StockItemsAPI
    {
        public StockItemsAPI()
        {

        }

        public ICollection<Domain.StockItems> GetStockItem_List(String Bp_No)
        {
            ICollection<Domain.StockItems> stockItemData = null;

            List<SqlParameter> sqlParametersList = new List<SqlParameter>();

            String sql = "SELECT * FROM StockItems WHERE Ac_No = ";


            for (int i = 0; i < BusinessAPI.BusinessSingleton.Instance.GetAC_List(Bp_No).Count; i++)
            {
                String tempParamName = "@ac_No" + i.ToString();
                SqlParameter ac_param = new SqlParameter(tempParamName, Convert.ToInt32(BusinessAPI.BusinessSingleton.Instance.GetAC_List(Bp_No).ElementAt(i)));

                sqlParametersList.Add(ac_param);

                if (i == BusinessAPI.BusinessSingleton.Instance.GetAC_List(Bp_No).Count - 1)
                {
                    sql = string.Concat(sql, tempParamName);
                }
                else
                {
                    sql = string.Concat(sql, tempParamName + " AND Ac_No = ");
                }

            }

            using (SqlDataReader dataReader = DBAccessSingleton.Instance.MyExecuteQuery(sql, sqlParametersList))
            {
                stockItemData = new List<Domain.StockItems>();

                while (dataReader.Read())
                {
                    String ItemCode = dataReader["ItemCode"].ToString();
                    String ItemDesc = dataReader["ItemDesc"].ToString();
                    String LookUp = dataReader["LookUp"].ToString();
                    String BarCode = dataReader["BarCode"].ToString();
                    String AC_No = dataReader["AC_No"].ToString();
                    String Unit = dataReader["Unit"].ToString();
                    String ActiveFlag = dataReader["ActiveFlag"].ToString();

                    Domain.StockItems temp = new Domain.StockItems(Bp_No, ItemCode, ItemDesc, LookUp, BarCode, AC_No, Unit, ActiveFlag);
                    stockItemData.Add(temp);
                }

                dataReader.Close();

            }
            return stockItemData;
        }

        public ICollection<Domain.StockItems> GetFilterStockItem_List(ICollection<Domain.StockItems> stockItemList, string searchString, string lookUpString)
        {

            List<string> searchStringList = searchString.Split(' ').ToList();

            List<string> lookUpStringList = lookUpString.Split(' ').ToList();

            ICollection<Domain.StockItems> results = (
                                           from item in stockItemList
                                           where 
                                                searchStringList.All(sTring => item.ItemDesc.ToUpperInvariant().Contains(sTring.ToUpperInvariant()))
                                                &&
                                                lookUpStringList.All(sTring => item.LookUp.ToUpperInvariant().Contains(sTring.ToUpperInvariant()))
                                           //where item.ItemDesc.ToLower().Contains(searchString.ToUpperInvariant()) && item.LookUp.Contains(lookUpString)
                                           select item
                                           ).ToList();

            return results;
        }

        public ICollection<String> GetLookUpCode_List(ICollection<Domain.StockItems> stockItemList)
        {
            ICollection<String> results = (
                                from item in stockItemList
                                select item.LookUp
                                ).Distinct().ToList();

            return results;
        }
    }
}
