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
        string planID;
        DataSet ds;
        public ViewPlan_Tester_2(string planID)
        {
            InitializeComponent();
            this.planID = planID;
            InititateDataGridView();
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
            MessageBox.Show(dataGridView1.Rows[0].Cells["case_status"].Value.ToString());
            
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
                new AddCase(planID, this, case_id, case_name, description, case_step, status).ShowDialog();
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
        }

        private void button_release_Click(object sender, EventArgs e)
        {

        }
    }
}
