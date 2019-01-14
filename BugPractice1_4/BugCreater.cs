using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace BugPractice1_4
{
    public partial class BugCreater : Form
    {
        public BugCreater()
        {
            InitializeComponent();
            table_bug.Head_tag = '1';
        }
        private int pre_id=-1;
        private int case_id=1;
        private int ret_id = -1;

        
        private int next_id = -1;
        public BugCreater(int _pre_id,int case_id)
        {
            InitializeComponent();
            this.pre_id = _pre_id;
            if (_pre_id != -1)
                table_bug.Head_tag = '0';
            else
                table_bug.Head_tag = '1';

            table_bug.Prior_bug_id = _pre_id;


        }

        int global_bug_id = -1;
        public BugCreater(string bug_id)
        {
            InitializeComponent();
            global_bug_id =int.Parse( bug_id);
            
        }


        private void Search_AuditView(int bug_id)
        {
            for (int i = 0; i < this.waiting_audit_grid.Rows.Count; i++)
            {
                
                int search_id =int.Parse(waiting_audit_grid.Rows[i].Cells[0].Value.ToString().Trim());

                
                if (search_id==bug_id)
                {
                    this.waiting_audit_grid.CurrentCell = this.waiting_audit_grid.Rows[i].Cells[0];
                    break;
                }

            }



        }


        public int Return_bug_id()
        {
            return this.table_bug.Bug_id;

        }


        public BugCreater(int _case_id)
        {
            InitializeComponent();
            this.case_id = _case_id;
            table_bug.Head_tag = '1';
            table_bug.Case_id = _case_id;

        }
        private const int OK_LEN = 5;
        private bool[] is_ok = new bool[OK_LEN] ;
        private Label[] confirm_labels = new Label[8];

        private void init_labels()
        {
            confirm_labels[0] = bug_cre_lbl_bug_name;
            confirm_labels[1] = bug_cre_lbl_reporter;
            confirm_labels[2] = bug_cre_lbl_manager;
            confirm_labels[3] = bug_cre_lbl_level;
            confirm_labels[4] = bug_cre_lbl_status;
            confirm_labels[5] = bug_cre_lbl_caseId;
            confirm_labels[6] = bug_cre_lbl_p_bug_id;
         

        }
        private void init_is_ok()
        {
            for (int i = 0; i < OK_LEN; i++)
                is_ok[i] = false;
            is_ok[2] = true;
        }
        private bool insert_ok()
        {
            for (int i = 0; i < OK_LEN; i++)
                if (!is_ok[i])
                    return false;

            return true;

        }
        bool is_info_complete()
        {
            int len_desc = bug_cre_description.Text.Length;
            int len_name = bug_cre_text_bug_name.Text.Length;
            string name = bug_cre_text_bug_name.Text;
            string desc = bug_cre_description.Text;
            if (len_desc < 5 || len_name < 1)
            {
             
                is_ok[0] = false;
                is_ok[1] = false;

                return false;
            }
            else
            {
                
                table_bug.Bug_name = name;
                table_bug.Bug_description = desc;
                is_ok[0] = true;
                is_ok[1] = true;
                return true;
            }
        }
        private void bug_cre_btn_next1_Click(object sender, EventArgs e)
        {
            if (!is_info_complete())
            {
                MessageBox.Show("请完善信息");
            }
            else
            {
                bug_cre_tabControl.SelectedIndex = 1;
                bug_cre_tabControl_SelectedIndexChanged(sender, e);
            }
            
            
        }

        
        
        private TableBug table_bug=new TableBug();
      
      
        private void bug_cre_tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (bug_cre_tabControl.SelectedIndex == 2)
            {
                is_info_complete();
                write_labels();
            }
            if (bug_cre_tabControl.SelectedIndex == 3)
            {
                bug_cre_audit_status_filter.SelectedIndex = 0;
                init_grid_waiting_audit(0,-1);
                if (global_bug_id != -1)
                {
                    Search_AuditView(global_bug_id);
                    
                }
                bug_audit_vision_combo.Enabled = false;
            }


        }

        DataTable tableBug;


        
        private void init_grid_waiting_audit(int para_status,int para_case_id)
        {
            MySqlConnection mycon = new MySqlConnection(Form1.CONSTR);
            mycon.Open();

            MySqlCommand mycmd = null ;
            string tmp_str = null;
            if (para_status == 0)
                tmp_str = "select * from table_bug " +
                 "where " + " reporter_id =" + Global_Userinfo.userid + " and head_tag= '1' ";

            else
            {
                tmp_str = "select * from table_bug " +
                "where " + " reporter_id =" + Global_Userinfo.userid + " and head_tag= '1' " + " and bug_status=" + para_status.ToString();
            }

            if (para_case_id != -1)
            {
                tmp_str = tmp_str + " and case_id=" + para_case_id;

            }
            mycmd = new MySqlCommand(tmp_str, mycon);
            MySqlDataReader dataReader = mycmd.ExecuteReader();
            tableBug =TableBug.CreateBugTable(TableBug.Properties, dataReader, "TableBugAuditing");


            DataView ListViewInfo = new DataView(tableBug);
            waiting_audit_grid.Columns.Clear();
            waiting_audit_grid.AutoGenerateColumns = false;
            waiting_audit_grid.DataSource = ListViewInfo;

            dataReader.Close();
            mycon.Close();
            int[] add_list = new int[] { 13, 3, 7, 1,9 ,10 };

            for (int i = 0; i < add_list.Length; i++)
            {

                DataGridViewTextBoxColumn dtcTimeStamp = new DataGridViewTextBoxColumn();
                dtcTimeStamp.DataPropertyName = TableBug.Properties[add_list[i]];//SQL语句得到的列名，可从集合中获得
                dtcTimeStamp.HeaderText = TableBug.Names[i];//列头显示的汉字
                dtcTimeStamp.Width = 110;
                waiting_audit_grid.Columns.Add(dtcTimeStamp);//最后一定要添加进去

            }


        }

        private void write_labels()
        {
            confirm_labels[0].Text = table_bug.Bug_name;
            confirm_labels[1].Text = Global_Userinfo.username;

            table_bug.Bug_reporter = Global_Userinfo.username;
            table_bug.Reporter_id =int.Parse( Global_Userinfo.userid);


            confirm_labels[2].Text = table_bug.Bug_manager;
            confirm_labels[3].Text = TableBug.Str_level[table_bug.Bug_level-1];
            confirm_labels[4].Text = TableBug.Str_status[table_bug.Bug_status-1];
            confirm_labels[5].Text =(table_bug.Case_id).ToString();
            confirm_labels[6].Text = (table_bug.Prior_bug_id).ToString();
           
            table_bug.Next_bug_id = next_id;
        }

        private void BugCreater_Load(object sender, EventArgs e)
        {
            bug_cre_audit_desc.Enabled = false;
            bug_cre_bug_level.SelectedIndex = 0;
            table_bug.Bug_level = 1;
            init_is_ok();
            init_developer_gridView();
            init_labels();

            if (global_bug_id != -1)
            {
             
                bug_cre_tabControl.SelectedIndex = 3;
            }

            if (pre_id != -1)
            {
                Console.WriteLine(pre_id.ToString());
                tabPage_audit.Parent = null;
                
            }

        }
        DataTable m_listViewInfo=null;
        private void init_developer_gridView()
        {
            MySqlConnection mycon = new MySqlConnection(Form1.CONSTR);
            mycon.Open();
            MySqlCommand mycmd = new MySqlCommand("select * from table_user_info " +
                "where type = 4  and"+ " is_verified = '1' ", mycon);
            MySqlDataReader dataReader = mycmd.ExecuteReader();
            m_listViewInfo = CreateDeveloperTable(DeveloperColumnList, dataReader);

            
            DataView dvListViewInfo = new DataView(m_listViewInfo);
            bug_cre_dev_gridView.Columns.Clear();
            bug_cre_dev_gridView.AutoGenerateColumns = false;
            bug_cre_dev_gridView.DataSource = dvListViewInfo;
            
            dataReader.Close();
            mycon.Close();

           for(int i=0;i<DeveloperColumnList.Count;i++)
            {
                DataGridViewTextBoxColumn dtcTimeStamp = new DataGridViewTextBoxColumn();
                dtcTimeStamp.DataPropertyName = DeveloperColumnList[i];//SQL语句得到的列名，可从集合中获得
                dtcTimeStamp.HeaderText =DeveloperNameList[i] ;//列头显示的汉字
                dtcTimeStamp.Width = 110;
                bug_cre_dev_gridView.Columns.Add(dtcTimeStamp);//最后一定要添加进去

            }
            


        }
        protected List<String> DeveloperColumnList = new List<string>() {"user_id","user_name","telephone","email" };
        protected List<String> DeveloperNameList = new List<string>() { "负责人id", "姓名", "电话号码", "邮箱" };
        protected DataTable CreateDeveloperTable(List<string> arrlist, MySqlDataReader dataReader)
        {
            DataTable dt = new DataTable("developer_table");

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
                int j = 0;
                for (int i = 0; i < 6; i++)
                {
                    if (i == 2 || i == 3)
                        continue;
                    try
                    {
                        if (i == 0)
                        {
                            dtRow[(string)arrlist[j]] = (int)dataReader.GetValue(i);
                        }
                        else
                        dtRow[(string)arrlist[j]] = dataReader.GetValue(i).ToString();

                        j++;
                    }
                    catch
                    {
                        dtRow[(string)arrlist[j]] = System.DBNull.Value;
                        j++;
                        
                    }
                }
                //
                dt.Rows.Add(dtRow);
        
            }


            return dt;
        }

        private void bug_cre_bug_level_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (bug_cre_bug_level.SelectedIndex == 0)
            {
                bug_cre_bug_level.ForeColor = Color.LimeGreen;
                table_bug.Bug_level = 1;

            }
            else if (bug_cre_bug_level.SelectedIndex == 1)
            {
                bug_cre_bug_level.ForeColor = Color.Blue;
                table_bug.Bug_level = 2;
            }
            else
            {
                bug_cre_bug_level.ForeColor = Color.Red;
                table_bug.Bug_level = 3;
            }
        }

        private void Search_Grid(int s_id,string s_name)
        {
            
            for (int i = 0; i < this.bug_cre_dev_gridView.Rows.Count; i++)
            {
                string name =bug_cre_dev_gridView.Rows[i].Cells[1].Value.ToString().Trim();
                string id_str = bug_cre_dev_gridView.Rows[i].Cells[0].Value.ToString();
                
                int id = int.Parse(id_str);
                if (id == s_id || name == s_name)
                {
                    this.bug_cre_dev_gridView.CurrentCell = this.bug_cre_dev_gridView.Rows[i].Cells[0];
                    bug_cre_search_result.Text = name;
                    this.table_bug.Manager_id = id;
                    this.table_bug.Bug_manager = name;
                    bug_cre_search_result.Text = name;
                    is_ok[3] = true;
                    is_ok[4] = true;
                    break;
                }

            }
        }
        private void bug_cre_btn_search_Click(object sender, EventArgs e)
        {
            string search_name = bug_cre_search_name.Text;
            string search_id = bug_cre_search_id.Text;
            if (search_id.Length != 0)
            {
                Search_Grid(int.Parse(search_id), "");
            }
            else if(search_name.Length!=0)
            {
                Search_Grid(-1, search_name);
            }
        }

        private void bug_cre_dev_gridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int row_idx = bug_cre_dev_gridView.CurrentCell.RowIndex;
            int manager_id= int.Parse(bug_cre_dev_gridView.Rows[row_idx].Cells[0].Value.ToString());
            string manager_name = bug_cre_dev_gridView.Rows[row_idx].Cells[1].Value.ToString();
            this.table_bug.Manager_id = manager_id;
            this.table_bug.Bug_manager = manager_name;
            bug_cre_search_result.Text = manager_name;
            is_ok[3] = true;
            is_ok[4] = true;
            

        }

        private void bug_cre_dev_gridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row_idx = bug_cre_dev_gridView.CurrentCell.RowIndex;
            int manager_id = int.Parse(bug_cre_dev_gridView.Rows[row_idx].Cells[0].Value.ToString());
            string manager_name = bug_cre_dev_gridView.Rows[row_idx].Cells[1].Value.ToString();
            this.table_bug.Manager_id = manager_id;
            this.table_bug.Bug_manager = manager_name;
            bug_cre_search_result.Text = manager_name;
            is_ok[3] = true;
            is_ok[4] = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (is_ok[3] && is_ok[4])
            {
                bug_cre_tabControl.SelectedIndex = 2;
                bug_cre_tabControl_SelectedIndexChanged(sender, e);

            }
            else
            {
                MessageBox.Show("请选择负责人");
            }
        }

        private void bug_cre_fresh_dev_Click(object sender, EventArgs e)
        {
            init_developer_gridView();
        }

        private void BugCreater_FormClosed(object sender, FormClosedEventArgs e)
        {
           
        }

        private void bug_cre_confirm_info_refresh_Click(object sender, EventArgs e)
        {
            write_labels();
           
        }

        private int Child_Id()
        {

            return ret_id;

        }

        private void bug_cre_btn_eport_bug_Click(object sender, EventArgs e)
        {
            if (!insert_ok())
            {
                MessageBox.Show("请完善信息");
                return;
            }
            if (table_bug.Prior_bug_id != -1)
            {

                ret_id= TableBug.Add_Bug_To_Table(table_bug, true);
                this.DialogResult = DialogResult.OK;
                this.Close();
                return;
            }

            if (TableBug.Add_Bug_To_Table(table_bug, false)==-1)
            {
                MessageBox.Show("Bug报告成功");
                init_is_ok();
                bug_cre_text_bug_name.Clear();
                bug_cre_description.Clear();
                bug_cre_tabControl.SelectedIndex = 0;
                bug_cre_tabControl_SelectedIndexChanged(sender, e);
            }
            else
            {
                MessageBox.Show("系统维护，请联系管理员");
            }

            
        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private List<int> next_id_list = new List<int>();
        private void init_next_id_list(int id)
        {
            next_id_list.Add(id);
            int next_id= TableBug.Get_Next_Id(id);
            if (next_id != -1)
            {
                init_next_id_list(next_id);
            }

        }
        private TableBug lastTable = new TableBug();
        private TableBug tableAuditBug = new TableBug();
        private void waiting_audit_grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row_idx = waiting_audit_grid.CurrentCell.RowIndex;
            int selected_id = int.Parse(waiting_audit_grid.Rows[row_idx].Cells[0].Value.ToString());
            tableAuditBug.Bug_id = selected_id;
            

            int reason=0;
            string bug_analysis="";
            string description = (string)tableBug.Rows[row_idx][4];    
            int status = int.Parse(tableBug.Rows[row_idx][0].ToString().Trim());
            tableAuditBug.Bug_status = status;


            if (status != 1)
            {
               
                reason = int.Parse(tableBug.Rows[row_idx][8].ToString().Trim());
                bug_analysis = (string)tableBug.Rows[row_idx][12];
                bug_cre_audit_reason.SelectedIndex = reason - 1;
                bug_cre_audit_analysis.Text = bug_analysis;


                //初始化bug版本控制
                next_id_list.Clear();
                next_id_list.Add(tableAuditBug.Bug_id);
                if (tableBug.Rows[row_idx][10].ToString().Length != 0)
                {
                    int next_id = int.Parse(tableBug.Rows[row_idx][10].ToString().Trim());
                    init_next_id_list(next_id);
                   
                    
                }
                if (next_id_list.Count > 1)
                {
                    bug_audit_btn_accompanished.Enabled = false;
                    
                }
                else
                {
                  if(status==2)
                    bug_audit_btn_accompanished.Enabled = true;
                }

                int tail_id = next_id_list[next_id_list.Count - 1];
                lastTable.Bug_id = tail_id;
                lastTable.Bug_status = TableBug.Select_From_Table_Bug(tail_id);

                Console.WriteLine(String.Format("Bug_status={0}", lastTable.Bug_status.ToString()));
                bug_audit_vision_combo.Items.Clear();

                for (int i = 0; i < next_id_list.Count; i++)
                {
                    bug_audit_vision_combo.Items.Add(next_id_list[i]);
                }

                bug_audit_vision_combo.Enabled = true;
                bug_audit_vision_combo.SelectedIndex = 0;




            }
            else
            {
                //next_id_list.Clear();
                bug_audit_vision_combo.Enabled = false;
                bug_audit_vision_combo.Items.Clear();
               
            
            }

            int case_id=int.Parse(tableBug.Rows[row_idx][9].ToString().Trim());
            tableAuditBug.Case_id = case_id;
            bug_cre_audit_lbl_id.Text = selected_id.ToString();
            bug_audit_auditing_id.Text = selected_id.ToString();
            bug_cre_audit_desc.Text = description;
            bug_cre_audit_status.SelectedIndex = status-1;


            if (status == 3)
            {
                bug_cre_audit_status.Enabled = false;
                bug_audit_btn_accompanished.Enabled = false;
            }
            else if (status == 2)
            {
                tableAuditBug.Bug_status = 2;
                bug_cre_audit_status.Enabled = true;
            //    bug_audit_btn_accompanished.Enabled = true;
            }
            else
            {
                tableAuditBug.Bug_status = 1;
                bug_cre_audit_status.Enabled = false;
                bug_audit_btn_accompanished.Enabled = true;
            }
           
        }

        private void bug_bug_analysis_refresh_Click(object sender, EventArgs e)
        {
            bug_cre_audit_status_filter.SelectedIndex = -1;
            init_grid_waiting_audit(0,-1);
        }

        private void bug_audit_btn_accompanished_Click(object sender, EventArgs e)
        {
            if (!is_enable)
            {
                MessageBox.Show("若要更新缺陷，请添加新的缺陷版本");
                return;
            }


            tableAuditBug.Bug_status = bug_cre_audit_status.SelectedIndex + 1;
            tableAuditBug.Bug_description = bug_cre_audit_desc.Text;

            if (tableAuditBug.Bug_status == 3)
            {
                tableAuditBug.Bug_id = next_id_list[0];
                for (int i = 1; i < next_id_list.Count; i++)
                    TableBug.Update_status_comp(next_id_list[i]);
                
            }

            int result = TableBug.Update_Bug(tableAuditBug, TableBug.TESTER);

            if (result == 1)
            {
                MessageBox.Show("Bug审核完毕");
            }
            else if (result == 2)
            {
                MessageBox.Show("一个用例已经完成");
            }
            else if (result == 3)
            {
                MessageBox.Show("一个计划已经完成");
            }
            else if (result == 4)
            {
                MessageBox.Show("一个项目已经完成");
            }
            else
            {
                MessageBox.Show("系统维护中");
            }

            bug_cre_audit_desc.Clear();
            bug_cre_audit_analysis.Clear();
            bug_cre_audit_lbl_id.Text = "";
            bug_audit_auditing_id.Text = "";
        }

        private void bug_cre_audit_btn_filter_Click(object sender, EventArgs e)
        {
            int status = bug_cre_audit_status_filter.SelectedIndex ;
            string str_case_id = bug_cre_audit_case_filter.Text;
            if (str_case_id.Length == 0)
            {
                init_grid_waiting_audit(status, -1);
            }
            else
            {
                int tmp_case_id = int.Parse(str_case_id);
                init_grid_waiting_audit(status, tmp_case_id);
            }

            
        }

        private void bug_cre_audit_case_filter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar)||e.KeyChar=='\b')
            {
                e.Handled = false;
            }
            else
                e.Handled = true;
        }

        private void bug_audit_lbl_update_vision_Click(object sender, EventArgs e)
        {

            if (tableAuditBug.Bug_id != -1&&tableAuditBug.Bug_status==2)
            {
                int tail_id = lastTable.Bug_id ;
                int tail_status = lastTable.Bug_status;
                if(tail_status!=2)
                {
                    MessageBox.Show("开发工程师正在修复此版本");
                    return;
                }
                
                BugCreater bugCreater_child = new BugCreater(tail_id, tableAuditBug.Case_id);

                if (bugCreater_child.ShowDialog() == DialogResult.OK)
                {
                    int next_id = bugCreater_child.Child_Id();

                    TableBug update_next_id_tablebug = new TableBug();
                    update_next_id_tablebug.Bug_id = next_id_list[next_id_list.Count - 1];
                    update_next_id_tablebug.Next_bug_id = next_id;
                    if (TableBug.Update_Next_Id(update_next_id_tablebug))
                    {
                        MessageBox.Show("版本更新成功");
                    }
                    else
                    {
                        MessageBox.Show("系统维护中");
                    }
                }
                else 
                {
                   
                }
              
                

            }
            else if (tableAuditBug.Bug_status == 2)
            {
                MessageBox.Show("请先选择前驱缺陷");
            }
            else
           {
                MessageBox.Show("必须是待确认修复bug才能更新版本");
            }



        }

        private void bug_cre_audit_desc_TextChanged(object sender, EventArgs e)
        {
            tableAuditBug.Bug_description = bug_cre_audit_desc.Text;
        }

        private void bug_audit_vision_combo_SelectedIndexChanged(object sender, EventArgs e)
        {

            int tmp_id = int.Parse(bug_audit_vision_combo.SelectedItem.ToString());
            TableBug tmp_tableBug = TableBug.Select_From_Table_Bug2(tmp_id);
            init_audit_GUI(tmp_tableBug);
        }

        private void init_audit_GUI(TableBug para_tableBug)
        {
            bug_audit_auditing_id.Text = para_tableBug.Bug_id.ToString();
            bug_cre_audit_desc.Text = para_tableBug.Bug_description;
            bug_cre_audit_status.SelectedIndex = para_tableBug.Bug_status - 1;
            if (para_tableBug.Bug_reason != 1)
            {
                bug_cre_audit_reason.SelectedIndex = para_tableBug.Bug_reason - 1;
                bug_cre_audit_analysis.Text = para_tableBug.Bug_analysis;

            }
            switch (para_tableBug.Bug_status)
            {
                case 1:
                    bug_audit_btn_accompanished.Enabled = false;
                    bug_cre_audit_status.Enabled = false;
                    bug_cre_audit_analysis.Clear();
                    bug_cre_audit_reason.SelectedIndex = 0;
                    break;
                case 2:
                    if (para_tableBug.Next_bug_id == -1)
                    {
                        bug_audit_btn_accompanished.Enabled = true;
                        bug_cre_audit_status.Enabled = true;
                    }
                    else
                    {
                        bug_audit_btn_accompanished.Enabled = false;
                        bug_cre_audit_status.Enabled = false;
                    }

                    
                    break;
                case 3:
                    bug_audit_btn_accompanished.Enabled = false;
                    bug_cre_audit_status.Enabled = false;
                    break;
            }

            
            
           
        }

        private bool is_enable = true;
        private void bug_cre_audit_status_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (bug_cre_audit_status.SelectedIndex == 0)
                is_enable = false;
            else
            {
                is_enable = true;
            }
            
        }
    }
}
