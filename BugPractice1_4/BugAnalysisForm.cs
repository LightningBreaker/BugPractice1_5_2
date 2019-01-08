using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BugPractice1_4
{
    public partial class BugAnalysisForm : Form
    {
        private List<int> bug_sequences   = new List<int>();

        private int global_status = 1;

        public BugAnalysisForm()
        {
            InitializeComponent();
            bug_sequences.Clear();

        }
        DataTable tableBug;
        private void BugAnalysisForm_Load(object sender, EventArgs e)
        {

            init_grid(global_status);
            bug_analysis_bugReason.SelectedIndex = 0;
            bug_analysis_status.SelectedIndex = 0;
            bug_analysis_status_select.SelectedIndex = global_status-1;
        }



        private void init_grid(int status)
        {
            MySqlConnection mycon = new MySqlConnection(Form1.CONSTR);
            mycon.Open();
            MySqlCommand mycmd = new MySqlCommand("select * from table_bug " +
                "where bug_status ="+status.ToString() +"  and" + " manager_id =" + Global_Userinfo.userid + " and head_tag= '1' ", mycon);
            MySqlDataReader dataReader = mycmd.ExecuteReader();
            tableBug = CreateBugAnalysisTable(TableBug.Properties, dataReader, "TableBug");


            DataView ListViewInfo = new DataView(tableBug);
            dataGrid_waiting_bug.Columns.Clear();
            dataGrid_waiting_bug.AutoGenerateColumns = false;
            dataGrid_waiting_bug.DataSource = ListViewInfo;

            dataReader.Close();
            mycon.Close();
            int[] add_list = new int[] { 13, 3, 7, 1, 10 };

            for (int i = 0; i < add_list.Length; i++)
            {

                DataGridViewTextBoxColumn dtcTimeStamp = new DataGridViewTextBoxColumn();
                dtcTimeStamp.DataPropertyName = TableBug.Properties[add_list[i]];//SQL语句得到的列名，可从集合中获得
                dtcTimeStamp.HeaderText = TableBug.Names[i];//列头显示的汉字
                dtcTimeStamp.Width = 110;
                dataGrid_waiting_bug.Columns.Add(dtcTimeStamp);//最后一定要添加进去

            }



        }

        DataTable CreateBugAnalysisTable(List<string> arrlist, MySqlDataReader dataReader,string tableName)
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
                
                for (int i = 0; i <arrlist.Count; i++)
                {
                
                    try
                    {
                        if (i == 1||i==3||i==4||i==5||i==11||i==12)
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

        private void dataGrid_waiting_bug_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row_idx = dataGrid_waiting_bug.CurrentCell.RowIndex;
            int selected_id = int.Parse(dataGrid_waiting_bug.Rows[row_idx].Cells[0].Value.ToString());
            string description = (string)tableBug.Rows[row_idx][4];
            bug_ays_lbl_sel_id.Text = selected_id.ToString();
            bug_analysis_desc.Text = description;
            bug_update.Bug_id = selected_id;
            
            
        }

        private void bug_bug_analysis_refresh_Click(object sender, EventArgs e)
        {
            init_grid(global_status);
        }

        private TableBug bug_update=new TableBug();
        private void bug_analysis_bugReason_SelectedIndexChanged(object sender, EventArgs e)
        {
            bug_update.Bug_reason = bug_analysis_bugReason.SelectedIndex + 1;

        }

        private void bug_analysis_status_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (bug_analysis_status.SelectedIndex == 0)
            {
                bug_update.Bug_status =1;
            }
            else
            {
                bug_update.Bug_status = 2;
            }
        }

        private void bug_analysis_main_text_TextChanged(object sender, EventArgs e)
        {
            bug_update.Bug_analysis = bug_analysis_main_text.Text;

        }

        private void bug_analysis_btn_update_Click(object sender, EventArgs e)
        {
            try
            {
                if (TableBug.Update_Bug(bug_update, TableBug.DEVOLOPER))
                {
                    MessageBox.Show("提交成功");

                }
                else
                {
                    MessageBox.Show("提交系统维护中");

                }

            } catch (Exception ee)
            {
                MessageBox.Show("系统维护中");
            }
            


        }

        
        private void bug_analysis_status_select_SelectedIndexChanged(object sender, EventArgs e)
        {
            global_status = bug_analysis_status_select.SelectedIndex + 1;

            init_grid(global_status);

            if (global_status != 1)
            {
                bug_analysis_main_text.ReadOnly = true;
                bug_analysis_bugReason.Enabled = false;
                bug_analysis_status.Enabled = false;
                bug_analysis_btn_update.Enabled = false;


            }
            else
            {
                bug_analysis_main_text.ReadOnly = false;
                bug_analysis_bugReason.Enabled = true;
                bug_analysis_status.Enabled = true;
                bug_analysis_btn_update.Enabled = true;
            }


        }
    }
}
