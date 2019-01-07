﻿using System;
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
        int mode;
        public AddCase(string planID, ViewPlan_Tester_2 preF)
        {
            this.planID = planID;
            preform = preF;
            InitializeComponent();
            comboBox_status.SelectedIndex = 0;
            textBox_ID.Text = "待分配";
           // textBox_ID.ReadOnly = true;
            mode = 1;
            
        }

        public AddCase(string planID, ViewPlan_Tester_2 preF, string case_id, string case_name, string description, string case_step, int status)
        {
            this.planID = planID;
            InitializeComponent();
            textBox_caseName.Text = case_name;
            textBox_description.Text = description;
            textBox_step.Text = case_step;
            comboBox_status.SelectedIndex = status;
            textBox_ID.Text = case_id;
            preform = preF;
            this.Text = "查看用例";
            this.button_confirm.Text = "确认修改";
            this.button_giveUp.Text = "返回";
            mode = 2;
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
            if (mode == 1)
            {
                Global_Database.AddCaseToDatabase(textBox_caseName.Text, comboBox_status.SelectedIndex + 1, textBox_description.Text, textBox_step.Text, planID);
                MessageBox.Show("添加完成！");
                preform.InititateDataGridView();
                this.Close();
            }
            else if (mode == 2)
            {
                Global_Database.AlterCaseFromDatabase(textBox_ID.Text, textBox_caseName.Text, comboBox_status.SelectedIndex + 1, textBox_description.Text, textBox_step.Text);
                preform.InititateDataGridView();
                MessageBox.Show("修改完成");
                this.Close();
            }

        }
    }
}
