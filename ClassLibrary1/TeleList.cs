using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace TeleLibrary1
{
    public class TeleList : List<TeleInfo>
    {


        public static TeleList GetDefaultTeleList()
        {
            
            TeleList myList = new TeleList();

            SqlConnection cn = new SqlConnection();

            cn.ConnectionString = "Data Source=DESKTOP-GQ7HRNP\\SQLEXPRESS; Initial Catalog=TeleDB; Integrated Security=True";
            cn.Open();

            SqlCommand cm = cn.CreateCommand();
            cm.CommandType = CommandType.StoredProcedure;
            cm.CommandText = "GetTeleList";

            SqlDataReader dr = cm.ExecuteReader();

            while(dr.Read())
            {
                TeleInfo newTele = new TeleInfo();
                newTele.TeleID = (int)dr["TeleID"];
                newTele.TeleName = dr["TeleName"].ToString();
                newTele.TeleDataBirth = (DateTime) dr["TeleDataBirth"];
                newTele.TelePresenterName = dr["TelePresenterName"].ToString();
                newTele.TelePresenterSecondName = dr["TelePresenterSecondName"].ToString();
                newTele.TipID = (int)dr["TipID"];
                newTele.TipName = dr["TipName"].ToString();
                newTele.LimitID = (int)dr["LimitID"];
                newTele.LimitName = dr["LimitName"].ToString();
                myList.Add(newTele);
            }
            return myList;
        }
    }
}
 