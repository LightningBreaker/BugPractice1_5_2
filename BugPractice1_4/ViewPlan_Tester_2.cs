using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace BugPractice1_4
{
    public partial class ViewPlan_Tester_2 : Form
    {
        int mode=0;
        string planID;
        DataSet ds;
        int lockStatus; // 1: locked 2:unlocked
        int button_upload_status;
        public ViewPlan_Tester_2(string planID)
        {
            InitializeComponent();
            this.planID = planID;
            
            lockStatus = Global_Database.SearchPlanLock(planID);
            if (lockStatus == 1) mode = 1;
            
            InititateDataGridView();
        }

        public ViewPlan_Tester_2(string planID, int mode)
        {
            InitializeComponent();
            this.planID = planID;
            InititateDataGridView();
            // mode == 1: 不能编辑
            if (mode == 1)
            {
                button_addPlan.Enabled = false;
                button_deletePLan.Enabled = false;
                button_release.Visible = false;
            }
        }

        private void button_giveup_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void InititateDataGridView()
        {
            MySqlConnection conn = new MySqlConnection(Global_Database.Conn);
            string sql = String.Format("select * from table_case where plan_id = {0}", planID);
            conn.Open();
            dataGridView1.AutoGenerateColumns = false;
            MySqlCommand command = new MySqlCommand(sql, conn);
            MySqlDataAdapter da = new MySqlDataAdapter(command);
            ds = new DataSet();
            da.Fill(ds, "table_case");
            dataGridView1.DataSource = ds.Tables["table_case"];
            dataGridView1.Refresh();
           // MessageBox.Show(dataGridView1.Rows[0].Cells["case_status"].Value.ToString());
            
            /*for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                string num = (dataGridView1.Rows[i].Cells["case_status"].Value.ToString());
                //dataGridView1.Rows[i].Cells["case_status"].ValueType = typeof(string);
                if (num == "1")
                {
                    dataGridView1.Rows[i].Cells["case_status"].Value = "待测试";
                    
                }
                else if (num == "2")
                    dataGridView1.Rows[i].Cells["case_status"].Value = "待修复缺陷";

                else
                    dataGridView1.Rows[i].Cells["case_status"].Value = "已完成";

            }*/
            conn.Close();
            
            if(lockStatus == 1)
            {
                button_addPlan.Enabled = false;
                button_deletePLan.Enabled = false;
                button_uploadResult.Enabled = true;
                button_release.Enabled = false;
                mode = 1;
            }
        } 
            
            
        

        private void button_addPlan_Click(object sender, EventArgs e)
        {
            new AddCase(planID, this).ShowDialog();
        }

        private void button_deletePLan_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("确认要删除选中的用例吗？", "删除用例", MessageBoxButtons.OKCancel);
            if (result == DialogResult.Cancel) return;
            int index = dataGridView1.SelectedCells[0].RowIndex;
            string case_id = dataGridView1.Rows[index].Cells["case_id"].Value.ToString();
            Global_Database.DeleteCaseFromDatabase(case_id);
            this.InititateDataGridView();
            MessageBox.Show("删除成功");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 4)
            {
                int rowIndex = e.RowIndex;
                string description = ds.Tables["table_case"].Rows[rowIndex]["case_description"].ToString();
                string case_name = ds.Tables["table_case"].Rows[rowIndex]["case_name"].ToString();
                string case_step = ds.Tables["table_case"].Rows[rowIndex]["case_step"].ToString();
                int status = int.Parse(ds.Tables["table_case"].Rows[rowIndex]["case_status"].ToString())-1;
                string case_id = ds.Tables["table_case"].Rows[rowIndex]["case_id"].ToString();
                if( mode == 0)new AddCase(planID, this, case_id, case_name, description, case_step, status).ShowDialog();
                else if( mode == 1) new AddCase(1,planID, this, case_id, case_name, description, case_step, status).ShowDialog();
            }
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if(e.ColumnIndex == 3)
            {
                if (e.Value.ToString() == "1") e.Value = "待测试";
                if (e.Value.ToString() == "2") e.Value = "待修复缺陷";
                if (e.Value.ToString() == "3") e.Value = "已完成";
                
            }
            if(e.ColumnIndex == 0)
            {
                e.Value = e.RowIndex+1;
            }
            if(e.ColumnIndex == 4)
            {
                if (lockStatus == 1) e.Value = "详细";
                
            }
        }

        private void button_release_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("确认用例已编辑完毕吗？确认后用例将不能再被编辑！", "添加完毕", MessageBoxButtons.OKCancel);
            if (result == DialogResult.Cancel) return;

            Global_Database.AddPlanLock(planID);
            lockStatus = 1;
            InititateDataGridView();
            MessageBox.Show("用例信息已确认！");
        }

        private void button_uploadResult_Click(object sender, EventArgs e)
        {
            if (button_upload_status == 1)
            {
                int rowIndex = dataGridView1.CurrentCell.RowIndex;
                string case_id = ds.Tables["table_case"].Rows[rowIndex]["case_id"].ToString();
                string case_name = ds.Tables["table_case"].Rows[rowIndex]["case_name"].ToString();
                //打开确认测试结果窗口
                new UploadResult(case_id, case_name).ShowDialog();
                InititateDataGridView();
            }
            else if(button_upload_status == 2) {
                int rowIndex = dataGridView1.CurrentCell.RowIndex;
                string case_id = ds.Tables["table_case"].Rows[rowIndex]["case_id"].ToString();
                new BugCreater(BugCreater.OPEN_FOR_LOOK,int.Parse(case_id) , 0).ShowDialog();


            }
                //打开查看缺陷窗口
        }

        private void dataGridView1_CurrentCellChanged(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0) return;
            if (dataGridView1.CurrentCell == null) return;
            int rowIndex = dataGridView1.CurrentCell.RowIndex;
            int status = (int)ds.Tables["table_case"].Rows[rowIndex]["case_status"];
            if (status == 1) { button_upload_status = 1; button_uploadResult.Text = "测试结果"; button_uploadResult.Enabled = true; }
            else if (status == 2) { button_upload_status = 2; button_uploadResult.Text = "查看缺陷"; button_uploadResult.Enabled = true; }
            else
            {
                button_uploadResult.Enabled = false;
                button_uploadResult.Text = "已完成";
            }
        }

        private void ViewPlan_Tester_2_Load(object sender, EventArgs e)
        {

        }
    }
}
