using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace TeleLibrary1
{
    public class TeleInfo
    {
        private int _teleID = 0;
        private string _teleName = "";
        private DateTime _teleDataBirth = DateTime.Today;
        private string _telePresenterName = "";
        private string _telePresenterSecondName = "";



        public int TeleID
        {
            get
            {
                return _teleID;
            }
            set
            {
                _teleID = value;
            }
        }
        public string TeleName
        {
            get
            {
                return _teleName;
            }
            set
            {
                _teleName = value;
            }
        }

        public DateTime TeleDataBirth
        {
            get
            {
                return _teleDataBirth;
            }
            set
            {
                _teleDataBirth = value;
            }
        }

        public string TelePresenterName
        {
            get
            {
                return _telePresenterName;
            }
            set
            {
                _telePresenterName = value;
            }
        }

        public string TelePresenterSecondName
        {
            get
            {
                return _telePresenterSecondName;
            }
            set
            {
                _telePresenterSecondName = value;
            }
        }

        public string TelePresenterFullName
        {
            get
            {
                return _telePresenterName + " " + _telePresenterSecondName;
            }
        }

        public void InsertTele()
        {
            try
            {
                SqlConnection cn = new SqlConnection();

                cn.ConnectionString = "Data Source=DESKTOP-GQ7HRNP\\SQLEXPRESS; Initial Catalog=TeleDB; Integrated Security=True";
                cn.Open();

                SqlCommand cm = cn.CreateCommand();
                cm.CommandType = CommandType.StoredProcedure;
                cm.CommandText = "InsertTele";

                cm.Parameters.Add(new SqlParameter("@TeleDataBirth", _teleDataBirth));
                cm.Parameters.Add(new SqlParameter("@TeleName", _teleName));
                cm.Parameters.Add(new SqlParameter("@TelePresenterName", _telePresenterName));
                cm.Parameters.Add(new SqlParameter("@TelePresenterSecondName", _telePresenterSecondName));

                cm.ExecuteNonQuery();
            }
            catch (Exception msg)
            {
                Console.WriteLine(msg);
                throw;
            }
        }

        public void DeleteTele()
        {
            SqlConnection cn = new SqlConnection();

            cn.ConnectionString = "Data Source=DESKTOP-GQ7HRNP\\SQLEXPRESS; Initial Catalog=TeleDB; Integrated Security=True";
            cn.Open();

            SqlCommand cm = cn.CreateCommand();
            cm.CommandType = CommandType.StoredProcedure;
            cm.CommandText = "DeleteTele";

            cm.Parameters.Add(new SqlParameter("@TeleID", _teleID));

            cm.ExecuteNonQuery();
        }

        public void UpdateTele()
        {
            SqlConnection cn = new SqlConnection();

            cn.ConnectionString = "Data Source=DESKTOP-GQ7HRNP\\SQLEXPRESS; Initial Catalog=TeleDB; Integrated Security=True";
            cn.Open();

            SqlCommand cm = cn.CreateCommand();
            cm.CommandType = CommandType.StoredProcedure;
            cm.CommandText = "UpdateTele";

            cm.Parameters.Add(new SqlParameter("@TeleID", _teleID));
            cm.Parameters.Add(new SqlParameter("@TeleName", _teleName));
            cm.Parameters.Add(new SqlParameter("@TeleDataBirth", _teleDataBirth));           
            cm.Parameters.Add(new SqlParameter("@TelePresenterName", _telePresenterName));
            cm.Parameters.Add(new SqlParameter("@TelePresenterSecondName", _telePresenterSecondName));

            cm.ExecuteNonQuery();
        }

        public void GetTele(int teleID)
        {
            SqlConnection cn = new SqlConnection();

            cn.ConnectionString = "Data Source=DESKTOP-GQ7HRNP\\SQLEXPRESS; Initial Catalog=TeleDB; Integrated Security=True";
            cn.Open();

            SqlCommand cm = cn.CreateCommand();
            cm.CommandType = CommandType.StoredProcedure;
            cm.CommandText = "GetTele";

            cm.Parameters.Add(new SqlParameter("@TeleID", teleID));

            SqlDataReader dr = cm.ExecuteReader();

            while (dr.Read())
            {              
                _teleName = dr["TeleName"].ToString();               
                _teleDataBirth = (DateTime)dr["TeleDataBirth"];
                _telePresenterName = dr["TelePresenterName"].ToString();
                _telePresenterSecondName = dr["TelePresenterSecondName"].ToString();
                _teleID = (int)dr["TeleID"];
            }
        }
    }
}