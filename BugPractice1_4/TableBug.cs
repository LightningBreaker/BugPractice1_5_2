using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugPractice1_4
{
    public class TableBug
    {
        private int bug_id;
        private int bug_status=1;
        private string bug_manager;
        private int manager_id;
        private string bug_name;
        private string bug_description;
        private string bug_reporter;
        private int reporter_id;
        private int bug_level;
        private int bug_reason=1;
        private int case_id=1;
        private int next_bug_id=-1;
        private int prior_bug_id = -1;
        private char head_tag;
        private string bug_analysis;


        public static string[] Str_status = new string[] { "待修复", "待确认修复", "已修复" };
        public static string[] Str_level = new string[] {"次要","一般","严重" };

        public static string Add_Bug(TableBug tableBug)
        {
            string cmd_para,cmd_value;
            cmd_para = " insert into" +
                " table_bug" +
                "(bug_manager," +
                "manager_id," +
                "bug_name,bug_description," +
                "bug_reporter,reporter_id," +
                "bug_level,case_id," +
                "head_tag";
            if (tableBug.next_bug_id != -1)
            {
                cmd_para = cmd_para + ",next_bug_id";
            }
             cmd_para =cmd_para+   ")";
            cmd_value = " values(" +
            "'" + tableBug.Bug_manager + "'," +
            " " + tableBug.Manager_id + " ," +
            "'" + tableBug.Bug_name + "'," +
            "'" + tableBug.Bug_description + "'," +
             "'" + tableBug.Bug_reporter + "'," +
             "" + tableBug.reporter_id.ToString() + "," +
             "" + tableBug.Bug_level + "," +
             "" + tableBug.Case_id + "," +

            "\"" + tableBug.Head_tag + "\"";
            if (tableBug.next_bug_id != -1)
            {
                cmd_value = cmd_value + ", " + tableBug.Next_bug_id + ""; 
            }

            cmd_value=cmd_value+");";


            return cmd_para+cmd_value;
        }
        public static  int DEVOLOPER=0;
        public static int TESTER = 1;
        public static bool Update_Bug(TableBug tableBug,int identity)
        {
            try {
                if (identity == TableBug.DEVOLOPER)
                {
                    MySqlConnection mycon = new MySqlConnection(Form1.CONSTR);
                    mycon.Open();
                    string str = "update table_bug set bug_reason="
                        + tableBug.Bug_reason.ToString() +
                        " ,bug_analysis=" + "'" + tableBug.Bug_analysis + "' " +
                        ",bug_status=" + tableBug.Bug_status.ToString() +
                        " where bug_id = " + tableBug.Bug_id;
                    MySqlCommand mycmd =
                        new MySqlCommand(str
                        , mycon);

                    if (mycmd.ExecuteNonQuery() > 0)
                        return true;
                    else
                        return false;
                }
                else
                {
                    return false;
                }

            } catch (Exception e)
            {
                throw e;
            }
            

        }
        public static List<string> Properties = new List<string>()
        { "bug_status","bug_manager","manager_id",
            "bug_name","bug_description","bug_reporter",
            "reporter_id","bug_level","bug_reason",
            "case_id","next_bug_id","head_tag",
            "bug_analysis","bug_id"};
        

        public static List<string> Names = new List<string>()
        {"缺陷id","缺陷名称","缺陷等级","缺陷报告人员","bug_next_id" };
        public int Bug_id { get => bug_id; set => bug_id = value; }
        public int Bug_status { get => bug_status; set => bug_status = value; }
        public string Bug_manager { get => bug_manager; set => bug_manager = value; }
        public int Manager_id { get => manager_id; set => manager_id = value; }
        public string Bug_name { get => bug_name; set => bug_name = value; }
        public string Bug_description { get => bug_description; set => bug_description = value; }
        public string Bug_reporter { get => bug_reporter; set => bug_reporter = value; }
        public int Reporter_id { get => reporter_id; set => reporter_id = value; }
        public int Bug_level { get => bug_level; set => bug_level = value; }
        public int Bug_reason { get { return bug_reason; } set => bug_reason = value; }
        public int Case_id { get => case_id; set => case_id = value; }
        public int Next_bug_id { get => next_bug_id; set => next_bug_id = value; }
        public char Head_tag { get => head_tag; set => head_tag = value; }
        public string Bug_analysis { get => bug_analysis; set => bug_analysis = value; }
        public int Prior_bug_id { get => prior_bug_id; set => prior_bug_id = value; }
    }
}
