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
        }
        private int pre_id=-1;
        private int case_id;
        public BugCreater(int _pre_id,int case_id)
        {
            InitializeComponent();
            this.pre_id = _pre_id;

        }

        public BugCreater(int _case_id)
        {
            InitializeComponent();
            this.case_id = _case_id;
        }
        private const int OK_LEN = 20;
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
            confirm_labels[7] = bug_cre_lbl_bug_id;

        }
        private void init_is_ok()
        {
            for (int i = 0; i < OK_LEN; i++)
                is_ok[i] = false;
            is_ok[2] = true;
        }
        private void bug_cre_btn_next1_Click(object sender, EventArgs e)
        {
            int len_desc = bug_cre_description.Text.Length;
            int len_name = bug_cre_text_bug_name.Text.Length;
            string name = bug_cre_text_bug_name.Text;
            string desc = bug_cre_description.Text;
            if (len_desc < 5 || len_name < 1)
            {
                MessageBox.Show("请完善信息");
                is_ok[0] =false;
                is_ok[1] = false;
            }
            else
            {
                bug_cre_tabControl.SelectedIndex = 1;
                table_bug.Bug_name = name;
                table_bug.Bug_description = desc;
                is_ok[0] = true;
                is_ok[1] = true;
                bug_cre_tabControl_SelectedIndexChanged(sender, e);
            }

        }

        
        
        private TableBug table_bug=new TableBug();
      
      
        private void bug_cre_tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (bug_cre_tabControl.SelectedIndex == 2)
            {
                write_labels();
            }
        }

        private void write_labels()
        {
            confirm_labels[0].Text = table_bug.Bug_name;
            confirm_labels[1].Text = Global_Userinfo.username;
            confirm_labels[2].Text = table_bug.Bug_manager;
            confirm_labels[3].Text = TableBug.Str_level[table_bug.Bug_level-1];
            confirm_labels[4].Text = TableBug.Str_status[table_bug.Bug_status-1];
            confirm_labels[5].Text =(table_bug.Case_id).ToString();
            confirm_labels[6].Text = (table_bug.Prior_bug_id).ToString();
            confirm_labels[7].Text = (table_bug.Bug_id).ToString();
        }

        private void BugCreater_Load(object sender, EventArgs e)
        {
            bug_cre_bug_level.SelectedIndex = 0;
            table_bug.Bug_level = 1;
            init_is_ok();
            init_developer_gridView();
            init_labels();
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
    }
}
