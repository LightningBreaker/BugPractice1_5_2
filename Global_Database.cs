using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace BugPractice1_4
{
    class Global_Database
    {
        public static string Conn = "Database='practice_in_school';" +
            "Data Source='192.168.43.116';User Id='root';" +
            "Password='TheFirstDon';charset='utf8';pooling=true";
        public static MySqlConnection conn = new MySqlConnection(Conn);

    }
}
