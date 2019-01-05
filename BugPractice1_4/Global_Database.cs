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
            "Data Source='localhost';User Id='root';" +
            "Password='TheFirstDon';charset='utf8';pooling=true";
        
        public static Dictionary<string,string> SearchTesterInfo()
        {
            Dictionary<string, string> result = new Dictionary<string, string>();
            MySqlConnection conn = new MySqlConnection(Conn);
            conn.Open();
            string sql = "select user_id, user_name from Table_user_info where type = 3";
            MySqlCommand command = new MySqlCommand(sql);
            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                string name = (string)reader["user_name"].ToString();
                string id = (string)reader["user_id"].ToString();
                result.Add(name, id);
            }
            reader.Close();
            conn.Close();

            return result;
        }
    }
}
