using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace TeleLibrary1
{
    public class LimitInfo
    {
        private int _limitID = 0;
        private string _limitName = "";

        public int LimitID
        {
            get
            {
                return _limitID;
            }
            set
            {
                _limitID = value;
            }
        }
        public string LimitName
        {
            get
            {
                return _limitName;
            }
            set
            {
                _limitName = value;
            }
        }
    }
}