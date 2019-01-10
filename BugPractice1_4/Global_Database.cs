using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
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
                string sql = "insert into table_plan(plan_name,plan_priority,plan_status,plan_project,plan_manager,case_nums,description) " +
                    String.Format("values('{0}','{1}',1,'{2}','{3}','0','{4}')", p.name, p.priority, project_id, p.manager_id,p.description);
                MessageBox.Show(sql);
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
                    String.Format("values('{0}',1,'{1}','{2}',{3},{4})",name,managerName,description,managerID,planNums);
            command = new MySqlCommand(sql, conn);
            command.ExecuteNonQuery();

            string sql2 = String.Format("select project_id from table_project where project_name = '{0}' and manager_id = {1}", name, managerID);
            command = new MySqlCommand(sql2, conn);
            var reader = command.ExecuteReader();
            reader.Read();
            string projectID = reader[0].ToString();
            return projectID;
        }
        public static void SearchPlanInfo(string planID, out plan PLAN, out int plan_status, out string projectID)
        {
            MySqlConnection conn = new MySqlConnection(Conn);
            MySqlCommand command;
            conn.Open();

            string sql = String.Format("select plan_name, plan_priority, plan_status, plan_project ,description,plan_manager from table_plan where plan_id = {0}", planID);
            command = new MySqlCommand(sql, conn);
            var reader = command.ExecuteReader();
            reader.Read();

            string plan_name = reader["plan_name"].ToString();
            int plan_priority = int.Parse(reader["plan_priority"].ToString());
            plan_status = int.Parse(reader["plan_status"].ToString());
            projectID = reader["plan_project"].ToString();
            string description = reader["description"].ToString();
            string plan_managerID = reader["plan_manager"].ToString();

            reader.Close();
            string sql2 = String.Format("select user_name from table_user_info where user_id = {0}", plan_managerID);
            command = new MySqlCommand(sql2, conn);
            var reader2 = command.ExecuteReader();
            reader2.Read();
            string plan_managerName = reader2["user_name"].ToString();
           // MessageBox.Show(plan_managerName);
            PLAN = new plan(plan_name, description, plan_managerName, plan_managerID, plan_priority);
            conn.Close();

            
        }

        public static void AddCaseToDatabase(string name, int status, string description, string step,string planID)
        {
            MySqlConnection conn = new MySqlConnection(Conn);
            string sql = String.Format("insert into table_case(case_description, case_step, case_status, case_name, plan_id, bug_nums) values('{0}','{1}',{2},'{3}','{4}',0) ",description,step,status,name,planID);
            conn.Open();
            MySqlCommand command = new MySqlCommand(sql,conn);

            command.ExecuteNonQuery();
            conn.Close();
        }

        public static void DeleteCaseFromDatabase(string case_id)
        {
            MySqlConnection conn = new MySqlConnection(Conn);
            string sql = String.Format("delete from table_case where case_id = {0}",case_id);
            conn.Open();
            MySqlCommand command = new MySqlCommand(sql, conn);

            command.ExecuteNonQuery();
            conn.Close();
        }

        public static void AlterCaseFromDatabase(string case_id, string name, int status, string description, string step)
        {
            MySqlConnection conn = new MySqlConnection(Conn);
            string sql = String.Format("update table_case set case_name = '{0}', case_status={1}, case_description='{2}', case_step='{3}' where case_id = {4}",name,status,description,step,case_id);
            conn.Open();
            MySqlCommand command = new MySqlCommand(sql, conn);

            command.ExecuteNonQuery();
            conn.Close();
        }

        public static void AddPlanLock(string plan_id)
        {
            MySqlConnection conn = new MySqlConnection(Conn);
            string sql = String.Format("update table_plan set plan_lock = 1 where plan_id = {0}",plan_id);
            conn.Open();
            MySqlCommand command = new MySqlCommand(sql, conn);

            command.ExecuteNonQuery();
            conn.Close();
        }

        public static int SearchPlanLock(string plan_id)
        {
            MySqlConnection conn = new MySqlConnection(Conn);
            string sql = String.Format("select plan_lock from table_plan where plan_id = {0}", plan_id);
            conn.Open();
            MySqlCommand command = new MySqlCommand(sql, conn);

            var reader = command.ExecuteReader();
            reader.Read();
            int Lock = (int)reader[0];
            conn.Close();
            return Lock;
        }

        public static bool WhetherHaveBug(string caseID)
        {
            MySqlConnection conn = new MySqlConnection(Conn);
            string sql = String.Format("select bug_id from table_bug where case_id = {0}", caseID);
            conn.Open();
            MySqlCommand command = new MySqlCommand(sql, conn);

            var reader = command.ExecuteReader();
            bool result;
            if (reader.NextResult()) result = true;
            else result = false;

            conn.Close();
            return result;
        }

        public static void UploadTestResult(string caseID, int status)
        {
            MySqlConnection conn = new MySqlConnection(Conn);
            string sql = String.Format("update table_case set case_status = {0} where case_id = {1}", status, caseID);
            conn.Open();
            MySqlCommand command = new MySqlCommand(sql, conn);

            command.ExecuteNonQuery();
            conn.Close();
        }

        public static bool UpdatePlanStatus(string caseID, out string planID)
        {
            // 1: plan is completed.
            planID = "";
            MySqlConnection conn = new MySqlConnection(Conn);
            string sql = String.Format("select plan_id from table_case where case_id = {0} ", caseID);
            conn.Open();
            MySqlCommand command = new MySqlCommand(sql, conn);
            var reader = command.ExecuteReader();
            if (reader.Read())
            {
                planID = reader["plan_id"].ToString();
            }
            conn.Close();

            conn = new MySqlConnection(Conn);
             sql = String.Format("select * from table_plan p, table_case c where p.plan_id = c.plan_id and case_status != 3", planID);
            conn.Open();
            command = new MySqlCommand(sql, conn);
            reader = command.ExecuteReader();
            if (!reader.Read())
            {
                conn.Close();
                conn = new MySqlConnection(Conn);
                sql = String.Format("update table_plan set plan_status = 2 where plan_id = {0}", planID);
                conn.Open();
                command = new MySqlCommand(sql, conn);
                command.ExecuteNonQuery();
                conn.Close();
                return true;
            }
            else
            {
                conn.Close();
                return false;
            }
            
            
        }

        public static bool UpdateProjectStatus(string planID)
        {
            string projectID = "";
            MySqlConnection conn = new MySqlConnection(Conn);
            string sql = String.Format("select plan_project from table_plan where plan_id = {0} ", planID);
            conn.Open();
            MySqlCommand command = new MySqlCommand(sql, conn);
            var reader = command.ExecuteReader();
            if (reader.Read())
            {
                projectID = reader["plan_project"].ToString();
                
            }
            conn.Close();

            conn = new MySqlConnection(Conn);
            sql = String.Format("select * from table_plan p, table_project pr where p.plan_project = pr.project_d and plan_status != 2", projectID);
            conn.Open();
            command = new MySqlCommand(sql, conn);
            reader = command.ExecuteReader();
            if (!reader.Read())
            {
                conn.Close();
                conn = new MySqlConnection(Conn);
                sql = String.Format("update table_project set project_status = 2 where project_id = {0}", projectID);
                conn.Open();
                command = new MySqlCommand(sql, conn);
                command.ExecuteNonQuery();
                conn.Close();
                return true;
            }
            else return false;

        }

    }
}
