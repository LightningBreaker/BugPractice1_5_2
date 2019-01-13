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
    public partial class AddPlan : Form
    {
        Dictionary<string, string> dict = new Dictionary<string, string>();
        public BindingList<plan> planlist;
        public AddPlan(BindingList<plan> PLANS)
        {
            InitializeComponent();
            
            InitiateInfo();
            comboBox_managerName.SelectedIndex = 0;
            comboBox_managerName_SelectedIndexChanged(null, null);
            planlist = PLANS;
           
            
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
           
            if (!noProblem) return;

            planlist.Add(new plan(textBox_planName.Text, textBox_description.Text, comboBox_managerName.SelectedItem.ToString(), textBox_managerID.Text,comboBox_priority.SelectedIndex+1));
            
            MessageBox.Show("添加成功！");
            this.Close();
        }

        public void InitiateInfo()
        {
            dict = Global_Database.SearchTesterInfo();
            foreach(var item in dict)
            {
                comboBox_managerName.Items.Add(item.Key);
            }
            comboBox_priority.SelectedIndex = 1;
        }

        private void comboBox_managerName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (label_managerError.Text.Length > 0)
            {
                label_managerError.Text = "";
            }
            string id="", name = comboBox_managerName.SelectedItem.ToString();
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
            DialogResult result = MessageBox.Show("您真的要放弃发布吗？已填写的信息将会丢失！", "放弃发布", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void AddPlan_Load(object sender, EventArgs e)
        {

        }
    }
}
