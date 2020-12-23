using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace TeleLibrary1
{
    public class TipList : List<TipInfo>
    {
        public static TipList GetTipList()
        {

            TipList myList = new TipList();

            SqlConnection cn = new SqlConnection();

            cn.ConnectionString = "Data Source=DESKTOP-GQ7HRNP\\SQLEXPRESS; Initial Catalog=TeleDB; Integrated Security=True";
            cn.Open();

            SqlCommand cm = cn.CreateCommand();
            cm.CommandType = CommandType.StoredProcedure;
            cm.CommandText = "GetTipList";

            SqlDataReader dr = cm.ExecuteReader();

            while (dr.Read())
            {
                TipInfo newTip = new TipInfo();
                newTip.TipID = (int)dr["TipID"];
                newTip.TipName = dr["TipName"].ToString();

                myList.Add(newTip);
            }
            return myList;
        }
    }
}