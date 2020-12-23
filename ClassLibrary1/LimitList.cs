using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace TeleLibrary1
{
    public class LimitList : List<LimitInfo>
    {
        public static LimitList GetLimitList()
        {

            LimitList myList = new LimitList();

            SqlConnection cn = new SqlConnection();

            cn.ConnectionString = "Data Source=DESKTOP-GQ7HRNP\\SQLEXPRESS; Initial Catalog=TeleDB; Integrated Security=True";
            cn.Open();

            SqlCommand cm = cn.CreateCommand();
            cm.CommandType = CommandType.StoredProcedure;
            cm.CommandText = "GetLimitTeleList";

            SqlDataReader dr = cm.ExecuteReader();

            while (dr.Read())
            {
                LimitInfo newLimit = new LimitInfo();
                newLimit.LimitID = (int)dr["LimitID"];
                newLimit.LimitName = dr["LimitName"].ToString();

                myList.Add(newLimit);
            }
            return myList;
        }
    }
}