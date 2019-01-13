using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugPractice1_4
{
    public class TableBug
    {
        private int bug_id=-1;
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

        public static string Add_Bug_To_Case(TableBug tableBug)
        {
            string cmd_add_bug_to_case;
            cmd_add_bug_to_case = "update table_case set bug_nums=bug_nums+1 where case_id=" + tableBug.case_id.ToString();

            return cmd_add_bug_to_case;

        }


        public static int  Add_Bug_To_Table(TableBug tableBug,bool is_child)
        {
            MySqlConnection mycon = new MySqlConnection(Form1.CONSTR);
            mycon.Open();

            MySqlCommand mycmd =
                new MySqlCommand(TableBug.Add_Bug(tableBug)
                , mycon);

            if (mycmd.ExecuteNonQuery() > 0)
            {

                if (!is_child)
                {
                    mycmd = new MySqlCommand(TableBug.Add_Bug_To_Case(tableBug), mycon);


                    if (mycmd.ExecuteNonQuery() > 0)
                    {
                        mycon.Close();
                        return -1;
                        
                    }
                       
                    else
                    {
                        mycon.Close();
                        return -2;
                    }
                        
                }
                else
                {
                    mycmd = new MySqlCommand(TableBug.Add_Link_To_Table(tableBug), mycon);

                    MySqlDataReader dr= mycmd.ExecuteReader();
                    if (dr.Read())
                    {

                     int res=   (int)dr.GetValue(0);
                        dr.Close();
                        mycon.Close();
                        return res;
                    }
                    else
                    {
                        dr.Close();
                        mycon.Close();
                        return -2;
                    }
                    
                }
                
            }
            else
            {
                mycon.Close();
                return -2;
            }

        }

        public static TableBug Select_From_Table_Bug2(int id)
        {
            TableBug tableBug = new TableBug();
            string cmd_str = "select * from table_bug where bug_id=" + id.ToString();
            MySqlConnection mycon = new MySqlConnection(Form1.CONSTR);
            mycon.Open();
            MySqlCommand mycmd = new MySqlCommand(cmd_str, mycon);

            MySqlDataReader dr = mycmd.ExecuteReader();

            if (dr.Read())
            {
                tableBug.Bug_id = id;
                tableBug.Bug_description= dr["bug_description"].ToString();
                tableBug.Bug_status = int.Parse(dr["bug_status"].ToString());
                if (tableBug.Bug_status != 1)
                {
                    tableBug.Bug_reason = int.Parse(dr["bug_reason"].ToString());
                    tableBug.Bug_analysis = dr["bug_analysis"].ToString();
                    if (dr["next_bug_id"].ToString().Length != 0)
                    {
                        tableBug.Next_bug_id = int.Parse(dr["next_bug_id"].ToString());
                    }
                    else
                    {
                        tableBug.Next_bug_id = -1;
                    }
                }

                dr.Close();
                mycon.Close();
                return tableBug;
            }
            else
            {
                dr.Close();
                mycon.Close();
                return null;
            }

        }
        public static bool Update_Next_Id(TableBug tableBug)
        {
            string cmd_str = "update table_bug set next_bug_id="
                + tableBug.Next_bug_id.ToString() +
                " where bug_id=" + tableBug.Bug_id;

            MySqlConnection mycon = new MySqlConnection(Form1.CONSTR);
            mycon.Open();
            MySqlCommand mycmd = new MySqlCommand(cmd_str,mycon);

            if (mycmd.ExecuteNonQuery() > 0)
            {
                mycon.Close();
                return true;
            }
            else
            {
                mycon.Close();
                return false;
            }



        }

        public static string Add_Link_To_Table(TableBug tableBug)
        {
            string cmd_para;
            cmd_para = "select max(bug_id) from table_bug where case_id=" + tableBug.Case_id;

            return cmd_para;
        }
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

        
        public static int Update_Bug(TableBug tableBug,int identity)
        {
            MySqlConnection mycon = new MySqlConnection(Form1.CONSTR);
            mycon.Open();

            try
            {
               

                if (identity == TableBug.DEVOLOPER)
                {

                    string str = "update table_bug set bug_reason="
                        + tableBug.Bug_reason.ToString() +
                        " ,bug_analysis=" + "'" + tableBug.Bug_analysis + "' " +
                        ",bug_status=" + tableBug.Bug_status.ToString() +
                        " where bug_id = " + tableBug.Bug_id;
                   




                    MySqlCommand mycmd =
                        new MySqlCommand(str
                        , mycon);

                    if (mycmd.ExecuteNonQuery() > 0)
                    {
                        mycon.Close();
                        return 1;

                    }
                        
                    else
                    {
                        mycon.Close();
                        return 0;
                    }
                      
                }
                else
                {
                    string str = "update table_bug set bug_status="
                        + tableBug.Bug_status +
                        " ,bug_description= '"+tableBug.Bug_description+"'"+
                        " where bug_id="
                        + tableBug.Bug_id + "";

                    string str2 = "update table_case set bug_nums=bug_nums-1 where case_id=" + tableBug.Case_id;
                    MySqlCommand mycmd =
                       new MySqlCommand(str
                       , mycon);

                    if (mycmd.ExecuteNonQuery() > 0)
                    {
                        if (tableBug.Bug_status == 3)
                        {
                            mycmd = new MySqlCommand(str2, mycon);
                            if (mycmd.ExecuteNonQuery() > 0)
                            {
                                mycon.Close();
                                if (Is_Case_Complete(tableBug.Case_id))
                                {
                                    string plan_id;
                                    if (Global_Database.UpdatePlanStatus(tableBug.Case_id.ToString(), out plan_id))
                                    {
                                        if (Global_Database.UpdateProjectStatus(plan_id))
                                        {
                                            return 4;
                                        }
                                        else
                                        {
                                            return 3;
                                        }
                                    } else
                                    {
                                        return 2;
                                    }
                                }
                                   
                                else
                                    return 1;
                            }
                            else
                            {
                                mycon.Close();
                                return 0;
                            }

                        }
                        else
                        {
                            mycon.Close();
                            return 1;
                        }



                    }

                    else
                    {
                        mycon.Close();
                        return 0;
                    }
                        

                    
                }

            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                mycon.Close();   
            }
            

        }

        public static int Select_From_Table_Bug(int id)
        {
            string cmd_str = "select bug_status from table_bug where bug_id=" + id.ToString();
            MySqlConnection mycon = new MySqlConnection(Form1.CONSTR);
            mycon.Open();
            MySqlCommand mycmd = new MySqlCommand(cmd_str, mycon);

            MySqlDataReader dr = mycmd.ExecuteReader();

            if (dr.Read())
            {
                if (dr.GetValue(0).ToString().Length == 0)
                {
                    return -1;
                }
                else
                {
                    return int.Parse(dr.GetValue(0).ToString());

                }

            }
            else
            {
                return  -1;
            }

        }

        public static int Get_Next_Id(int id)
        {
            string cmd_str = "select next_bug_id from table_bug where bug_id=" + id.ToString();
            MySqlConnection mycon = new MySqlConnection(Form1.CONSTR);
            mycon.Open();
            MySqlCommand mycmd = new MySqlCommand(cmd_str,mycon);

            MySqlDataReader dr = mycmd.ExecuteReader();

            if (dr.Read())
            {
                if (dr.GetValue(0).ToString().Length==0)
                {
                    return -1;
                }
                else
                {
                    return int.Parse(dr.GetValue(0).ToString());

                }

            }
            else
            {
                return -1;
            }

        }

        private static bool Is_Case_Complete(int case_id)
        {
            string cmd_case = "select * from table_case where bug_nums=0 and case_id=" + case_id.ToString() + ";";
            string cmd_case_delete_bug = "update table_case set case_status=3 where case_id=" + case_id.ToString() + ";";
            MySqlConnection mycon = new MySqlConnection(Form1.CONSTR);
            mycon.Open();

            MySqlCommand mycmd = new MySqlCommand(cmd_case, mycon);
            MySqlDataReader dr = mycmd.ExecuteReader();
            if (dr.Read())
            {
                
                
                

                mycmd = new MySqlCommand(cmd_case_delete_bug, mycon);

                if (mycmd.ExecuteNonQuery() > 0)
                {

                    dr.Close();
                    mycon.Close();
                    return true;
                }
                    
                else
                {
                    dr.Close();
                    mycon.Close();
                    return false;
                }
                    

            }
            else
            {
                dr.Close();
                mycon.Close();
                return false;
            }

        }
        public static DataTable CreateBugTable(List<string> arrlist, MySqlDataReader dataReader, string tableName)
        {
            DataTable dt = new DataTable(tableName);

            for (int i = 0; i < arrlist.Count; i++)
            {
                DataColumn dtColumn = new DataColumn();
                dtColumn.ColumnName = (string)arrlist[i];
                dt.Columns.Add(dtColumn);

            }

            DataRow dtRow;
            while (dataReader.Read())
            {
                dtRow = dt.NewRow();
                //将需要读取的几行

                for (int i = 0; i < arrlist.Count; i++)
                {

                    try
                    {
                        if (i == 1 || i == 3 || i == 4 || i == 5 || i == 11 || i == 12)
                        {
                            dtRow[(string)arrlist[i]] = dataReader.GetValue(i).ToString();
                        }
                        else
                            dtRow[(string)arrlist[i]] = (int)dataReader.GetValue(i);



                    }
                    catch
                    {
                        dtRow[(string)arrlist[i]] = System.DBNull.Value;


                    }
                }
                //
                dt.Rows.Add(dtRow);

            }


            return dt;

        }
        public static List<string> Properties = new List<string>()
        { "bug_status","bug_manager","manager_id",
            "bug_name","bug_description","bug_reporter",
            "reporter_id","bug_level","bug_reason",
            "case_id","next_bug_id","head_tag",
            "bug_analysis","bug_id"};
        

        public static List<string> Names = new List<string>()
        {"缺陷id","缺陷名称","缺陷等级","缺陷报告人员","用例id","bug_next_id" };
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
