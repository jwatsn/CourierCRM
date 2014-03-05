using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace CourierCRM
{
    class Settings
    {
        public static DataTable table;

      


        public static string get_setting(string str) { return table.Rows[0][str].ToString(); }
        
    }
}
