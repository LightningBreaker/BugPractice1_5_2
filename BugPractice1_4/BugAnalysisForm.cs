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
            bug_ays_version_combo.Enabled = false;
        }


        private void init_grid(int status)
        {
            MySqlConnection mycon = new MySqlConnection(Form1.CONSTR);
            mycon.Open();
            string str = "select * from table_bug " +
                "where bug_status =" + status.ToString()
                + "  and" + " manager_id ="
                + Global_Userinfo.userid;
            if(status!=1)
                str=str+ " and head_tag= '1' ";
            
            MySqlCommand mycmd = new MySqlCommand(str, mycon);
            MySqlDataReader dataReader = mycmd.ExecuteReader();
            tableBug = CreateBugAnalysisTable(TableBug.Properties, dataReader, "TableBug");


            DataView ListViewInfo = new DataView(tableBug);
            dataGrid_waiting_bug.Columns.Clear();
            dataGrid_waiting_bug.AutoGenerateColumns = false;
            dataGrid_waiting_bug.DataSource = ListViewInfo;

            dataReader.Close();
            mycon.Close();
            int[] add_list = new int[] { 13, 3, 7, 1,9 ,10 };

            for (int i = 0; i < add_list.Length; i++)
            {

                DataGridViewTextBoxColumn dtcTimeStamp = new DataGridViewTextBoxColumn();
                dtcTimeStamp.DataPropertyName = TableBug.Properties[add_list[i]];//SQL语句得到的列名，可从集合中获得
                dtcTimeStamp.HeaderText = TableBug.Names[i];//列头显示的汉字
                dtcTimeStamp.Width = 110;
                dataGrid_waiting_bug.Columns.Add(dtcTimeStamp);//最后一定要添加进去

            }

            bug_analysis_desc.Clear();
            bug_analysis_main_text.Clear();
            bug_ays_lbl_sel_id.Text = "";

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
            int bug_status = int.Parse(tableBug.Rows[row_idx][0].ToString());

            if (bug_status != 1)
            {
                int bug_reason = int.Parse(tableBug.Rows[row_idx][8].ToString());
                string bug_analysis = tableBug.Rows[row_idx][12].ToString();

                bug_analysis_bugReason.SelectedIndex = bug_reason - 1;
                bug_analysis_main_text.Text = bug_analysis;
                bug_analysis_bugReason.Enabled = false;
                bug_analysis_main_text.Enabled = false;
            }
            else
            {
                bug_analysis_main_text.Clear();
                bug_analysis_bugReason.SelectedIndex = 0;
                bug_analysis_bugReason.Enabled = true;
                bug_analysis_main_text.Enabled = true;
            }
            bug_ays_lbl_sel_id.Text = selected_id.ToString();
            bug_analysis_desc.Text = description;
            bug_update.Bug_id = selected_id;

            if (bug_status == 2)
            {

                init_next_list(row_idx);
            }
            
            
        }

        private List<int> next_id_list = new List<int>();
        private TableBug lastTable = new TableBug();

        private void init_next_id_list(int id)
        {
            next_id_list.Add(id);
            int next_id = TableBug.Get_Next_Id(id);
            if (next_id != -1)
            {
                init_next_id_list(next_id);
            }

        }

        private void init_next_list(int row_idx)
        {
            next_id_list.Clear();
            next_id_list.Add(bug_update.Bug_id);
            if (tableBug.Rows[row_idx][10].ToString().Length != 0)
            {
                int next_id = int.Parse(tableBug.Rows[row_idx][10].ToString().Trim());
                init_next_id_list(next_id);


            }
            int tail_id = next_id_list[next_id_list.Count - 1];
            lastTable.Bug_id = tail_id;
            lastTable.Bug_status = TableBug.Select_From_Table_Bug(tail_id);

            Console.WriteLine(String.Format("Bug_status={0}", lastTable.Bug_status.ToString()));
            bug_ays_version_combo.Items.Clear();

            for (int i = 0; i < next_id_list.Count; i++)
            {
                bug_ays_version_combo.Items.Add(next_id_list[i]);
            }

            bug_ays_version_combo.Enabled = true;
            bug_ays_version_combo.SelectedIndex = 0;

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
                bug_update.Bug_id =int.Parse(bug_ays_lbl_sel_id.Text.Trim());
                bug_update.Bug_reason = bug_ays_version_combo.SelectedIndex + 1;
                bug_update.Bug_analysis = bug_analysis_main_text.Text;
                bug_update.Bug_status = 2;
                if (TableBug.Update_Bug(bug_update, TableBug.DEVOLOPER)==1)
                {
                    MessageBox.Show("提交成功");
                    init_grid(global_status);
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

        private void init_version_grid_view()
        {

        }
        private void bug_analysis_status_select_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (bug_analysis_status.SelectedIndex == 1)
            {
               
                bug_ays_version_combo.Enabled = true;
               
            }
            else
            {
                bug_ays_version_combo.Enabled = false;
            }

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

        private void bug_ays_version_combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            int tmp_id = int.Parse(bug_ays_version_combo.SelectedItem.ToString());
            TableBug tmp_tableBug = TableBug.Select_From_Table_Bug2(tmp_id);
            init_update_bug_GUI(tmp_tableBug);
        }

        private void init_update_bug_GUI(TableBug para_tableBug)
        {
            bug_ays_lbl_sel_id.Text = para_tableBug.Bug_id.ToString();
            bug_analysis_desc.Text = para_tableBug.Bug_description;
            bug_analysis_status.SelectedIndex = para_tableBug.Bug_status - 1;
            if (para_tableBug.Bug_reason != 1)
            {
                bug_analysis_bugReason.SelectedIndex = para_tableBug.Bug_reason - 1;
                bug_analysis_main_text.Text = para_tableBug.Bug_analysis;

            }
            switch (para_tableBug.Bug_status)
            {
                case 1:
                    bug_analysis_btn_update.Enabled = true;
                    bug_analysis_status.Enabled = false;

                    bug_analysis_bugReason.Enabled = true;
                    bug_analysis_main_text.Enabled = true;
                    bug_analysis_main_text.ReadOnly = false;
                    bug_analysis_status.SelectedIndex = 0;
                    bug_analysis_main_text.Clear();
                    bug_analysis_bugReason.SelectedIndex = 0;
                    break;
                case 2:                                      
                        bug_analysis_btn_update.Enabled = false;
                        bug_analysis_status.Enabled = false;
                    bug_analysis_bugReason.Enabled = false;
                    bug_analysis_main_text.Enabled = false;
                    bug_analysis_main_text.ReadOnly = true;
                    break;
                case 3:
                    bug_analysis_bugReason.Enabled = false;
                    bug_analysis_main_text.Enabled = false;
                    bug_analysis_main_text.ReadOnly =true;
                    bug_analysis_btn_update.Enabled = false;
                    bug_analysis_status.Enabled = false;
                    break;
            }

        }
    }
}
