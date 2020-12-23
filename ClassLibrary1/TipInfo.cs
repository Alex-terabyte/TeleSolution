using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace TeleLibrary1
{
    public class TipInfo
    {
        private int _tipID = 0;
        private string _tipName = "";

        public int TipID
        {
            get
            {
                return _tipID;
            }
            set
            {
                _tipID = value;
            }
        }
        public string TipName
        {
            get
            {
                return _tipName;
            }
            set
            {
                _tipName = value;
            }
        }

    }
}