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
    public partial class AddCase : Form
    {
        string planID;
        ViewPlan_Tester_2 preform;
        public AddCase(string planID, ViewPlan_Tester_2 preF)
        {
            this.planID = planID;
            preform = preF;
            InitializeComponent();
            comboBox_priority.SelectedIndex = 0;
        }

        private void button_giveUp_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("确认放弃添加用例吗？已填写的信息将会丢失！", "返回", MessageBoxButtons.OKCancel);
            if (result == DialogResult.Cancel) return;
            this.Close();
        }

        private void button_nextPage_Click(object sender, EventArgs e)
        {
            if (textBox_description.Text.Length == 0 || textBox_caseName.Text.Length == 0
                || textBox_step.Text.Length == 0)
            {
                MessageBox.Show("带*号的项目必须填写！");
                return;
            }
            Global_Database.AddCaseToDatabase(textBox_caseName.Text, comboBox_priority.SelectedIndex + 1, textBox_description.Text, textBox_step.Text, planID);
            MessageBox.Show("添加完成！");
            preform.InititateDataGridView();
            this.Close();


        }
    }
}
