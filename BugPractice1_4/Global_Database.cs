using System;
using System.ComponentModel;
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
        
        public static Dictionary<string,string> SearchTesterInfo()
        {
            Dictionary<string, string> result = new Dictionary<string, string>();
            MySqlConnection conn = new MySqlConnection(Conn);
            conn.Open();
            string sql = "select user_id, user_name from Table_user_info where type = 3";
            MySqlCommand command = new MySqlCommand(sql,conn);
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

        public static void AddPlanToDatabase(BindingList<plan> plans, string project_id)
        {
            MySqlConnection conn = new MySqlConnection(Conn);
            MySqlCommand command;
            conn.Open();
            
            foreach(var p in plans)
            {
                string sql = "insert into table_plan(plan_name,plan_priority,plan_status，plan_project,plan_manager,case_nums) " +
                    String.Format("values({0},{1},0,{2},{3},0)", p.name, p.priority, project_id, p.manager_id);
                command = new MySqlCommand(sql,conn);
                command.ExecuteNonQuery();
            }
            conn.Close();
        }

        public static string AddProjectToDatabase(string name,string description,string managerID, string managerName,int planNums)
        {
            MySqlConnection conn = new MySqlConnection(Conn);
            MySqlCommand command;
            conn.Open();
            string sql = "insert into table_project(project_name,project_status,project_manager,project_description,manager_id,plan_nums) " +
                    String.Format("values({0},0,{1},{2},{3},{4})",name,managerName,description,managerID,planNums);
            command = new MySqlCommand(sql, conn);
            command.ExecuteNonQuery();

            string sql2 = String.Format("select project_id from table_project where project_name = {0} and manager_id = {1}", name, managerID);
            command = new MySqlCommand(sql2, conn);
            var reader = command.ExecuteReader();
            reader.Read();
            string projectID = reader[0].ToString();
            return projectID;
        }
    }
}
