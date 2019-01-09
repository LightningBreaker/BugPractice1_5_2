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
    public partial class ViewPlan : Form
    {
        Dictionary<string, string> dict = new Dictionary<string, string>();
        public BindingList<plan> planlist;
        public int index;
        int mode;
        string planid;
        public ViewPlan(BindingList<plan> PLANS,int index)
        {
            InitializeComponent();
            planlist = PLANS;
            InitiateInfo();
            InitiateComponentInfos();
            mode = 1;
        }

        public ViewPlan(string planID)
        {
            planid = planID;
            initiateInfos(planID);
            button_nextPage.Text = "用例管理 >>";
            mode = 2;
        }

        private void button_nextPage_Click(object sender, EventArgs e)
        {
            if (mode == 1)
            {
                bool noProblem = true;
                if (textBox_planName.TextLength == 0)
                {
                    label_nameError.Text = "计划名不能为空！";
                    noProblem = false;
                }
                if (textBox_description.Text.Length == 0)
                {
                    label_descriptionError.Text = "计划描述不能为空！";
                    noProblem = false;
                }
                if (comboBox_managerName.SelectedItem.ToString().Length == 0)
                {
                    label_managerError.Text = "必须选择计划负责人！";
                }
                if (!noProblem) return;

                planlist[index].name = textBox_planName.Text;
                planlist[index].description = textBox_description.Text;
                planlist[index].manager_name = comboBox_managerName.Text;
                planlist[index].manager_id = textBox_managerID.Text;
                planlist[index].priority = comboBox_priority.SelectedIndex;
                planlist.Add(new plan("", "", "", "", 2));
                planlist.RemoveAt(planlist.Count - 1);
                MessageBox.Show("修改成功！");
                this.Close();
            }
            else if (mode == 2)
            {
                new ViewPlan_Tester_2(planid).ShowDialog();
            }
        }

        public void InitiateInfo()
        {
            dict = Global_Database.SearchTesterInfo();
            foreach (var item in dict)
            {
                comboBox_managerName.Items.Add(item.Key);
            }
        }

        private void comboBox_managerName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (label_managerError.Text.Length > 0)
            {
                label_managerError.Text = "";
            }
            string id = "", name = comboBox_managerName.SelectedItem.ToString();
            // MessageBox.Show(name);
            if (name.Length == 0)
            {
                textBox_managerID.Text = ""; return;
            }

            dict.TryGetValue(name, out id);
            // MessageBox.Show(id);
            textBox_managerID.Text = id;

        }

        private void button_giveUp_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void InitiateComponentInfos()
        {
            textBox_planName.Text = planlist[index].name;
            textBox_description.Text = planlist[index].description;
            MessageBox.Show(planlist[index].manager_name + planlist[index].manager_id);
            comboBox_managerName.Text = planlist[index].manager_name;
            textBox_managerID.Text = planlist[index].manager_id;
            comboBox_priority.SelectedIndex = planlist[index].priority;
        }
        public void initiateInfos(string planID)
        {
            MySqlConnection conn = new MySqlConnection(Global_Database.Conn);
            string sql = String.Format("select * from table_plan and table_user_info where plan_id = {0} and user_id = plan_manager", planID);
            conn.Open();
            MySqlCommand command = new MySqlCommand(sql, conn);

            var reader = command.ExecuteReader();
            reader.Read();

            textBox_description.Text = reader["description"].ToString();
            textBox_managerID.Text = reader["plan_manager"].ToString();
            textBox_planName.Text = reader["plan_name"].ToString();
            comboBox_priority.SelectedIndex = (int)reader["plan_priority"] - 1;
            comboBox_managerName.Items.Add(reader["user_name"].ToString());
            comboBox_managerName.SelectedIndex = 0;
            conn.Close();


        }
    }
}
