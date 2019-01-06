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
        public ViewPlan_Tester_2(string planID)
        {
            InitializeComponent();
            this.planID = planID;
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

            MySqlCommand command = new MySqlCommand(sql, conn);
            MySqlDataAdapter da = new MySqlDataAdapter(command);
            DataSet ds = new DataSet();
            da.Fill(ds, "table_case");
            dataGridView1.DataSource = ds.Tables["table_case"];
            for(int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                switch ((int)dataGridView1.Rows[i].Cells["case_status"].Value)
                {
                    case 1:
                        dataGridView1.Rows[i].Cells["case_status"].Value = "待测试";
                        break;
                    case 2:
                        dataGridView1.Rows[i].Cells["case_status"].Value = "待修复缺陷";
                        break;
                    case 3:
                        dataGridView1.Rows[i].Cells["case_status"].Value = "已完成";
                        break;
                }
                
            }
            conn.Close();
            dataGridView1.Refresh();
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
            MessageBox.Show("删除成功");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 4)
            {
                
            }
        }
    }
}
