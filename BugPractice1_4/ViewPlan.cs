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
    public partial class ViewPlan : Form
    {
        Dictionary<string, string> dict = new Dictionary<string, string>();
        public BindingList<plan> planlist;
        public int index;
        public ViewPlan(BindingList<plan> PLANS,int index)
        {
            InitializeComponent();
            planlist = PLANS;
            InitiateInfo();
            InitiateComponentInfos();
           
        }

        private void button_nextPage_Click(object sender, EventArgs e)
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

            planlist[index].name= textBox_planName.Text  ;
            planlist[index].description=textBox_description.Text  ;
            planlist[index].manager_name=comboBox_managerName.Text ;
            planlist[index].manager_id= textBox_managerID.Text ;
            planlist[index].priority = comboBox_priority.SelectedIndex;
            planlist.Add(new plan("", "", "", "",2));
            planlist.RemoveAt(planlist.Count - 1);
            MessageBox.Show("修改成功！");
            this.Close();
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
            comboBox_managerName.Text = planlist[index].manager_name;
            textBox_managerID.Text = planlist[index].manager_id;
            comboBox_priority.SelectedIndex = planlist[index].priority;
        }
    }
}
