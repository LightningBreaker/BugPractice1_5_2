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
    public partial class ReleaseProject_2 : Form
    {
        ReleaseProject preForm;
        BindingList<plan> plans = new BindingList<plan>();
        public ReleaseProject_2(ReleaseProject pref)
        {
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = plans;
            
            preForm = pref;
        }

        private void button_giveup_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show( "您真的要放弃发布吗？已填写的信息将会丢失！", "放弃发布", MessageBoxButtons.OKCancel);
            if(result == DialogResult.OK)
            {
                preForm.Close();
                this.Close();
                //releaseproject 也应该close掉
            }
            
        }

        private void button_release_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show( "是否确认发布测试项目？所有测试计划涉及到的人员将会被通知！", "发布测试项目", MessageBoxButtons.OKCancel);
            if (result == DialogResult.Cancel)
            {
                return;
            }
            //添加计划信息到数据库，通知相关人员
            string project_name = preForm.textBox_projectName.Text;
            string project_description = preForm.textBox_description.Text;
            string project_managerID = preForm.textBox_managerID.Text;
            string project_managerName = preForm.textBox_managerName.Text;
            int plan_nums = plans.Count;

            try
            {
                string projectID = Global_Database.AddProjectToDatabase(project_name, project_description, project_managerID, project_managerName, plan_nums);
                Global_Database.AddPlanToDatabase(plans, projectID);
            }
            catch(MySqlException ex)
            {
                MessageBox.Show("数据库连接异常！");
                MessageBox.Show(ex.Message);
            }
        }

        private void ReleaseProject_2_Load(object sender, EventArgs e)
        {

        }

        private void ReleaseProject_2_FormClosed(object sender, FormClosedEventArgs e)
        {
            
            preForm.Close();
        }

        private void button_addPlan_Click(object sender, EventArgs e)
        {
            new AddPlan(plans).ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 2)
            {
                int index = e.RowIndex;
               // MessageBox.Show(index.ToString()+plans[0].name);
                
                new ViewPlan(plans, index).ShowDialog();
            }
        }

        private void button_deletePLan_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("是否要删除选中的计划？", "删除计划", MessageBoxButtons.OKCancel);
            if (result == DialogResult.Cancel) return;
            int index = dataGridView1.SelectedCells[0].RowIndex;
            plans.RemoveAt(index);
            MessageBox.Show("删除成功");
        }
    }
    public class plan
    {
        public string name { get; set; }
        public string description { get; set; }
        public string manager_id { get; set; }
        public string manager_name { get; set; }
        public int priority { get; set; }

        public plan(string name,string description,string manager_name,string manager_id,int priority)
        {
            this.name = name;
            this.description = description;
            this.manager_id = manager_id;
            this.manager_name = manager_name;
            this.priority = priority;
        }
    }
}
