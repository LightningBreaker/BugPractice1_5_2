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
    public partial class UploadResult : Form
    {
        string caseID;
        string caseName;
        bool haveBugs = false;
        public UploadResult(string caseID,string caseName)
        {
            InitializeComponent();
            comboBox_result.SelectedIndex = 0;
            this.caseID = caseID;
            this.caseName = caseName;
            textBox_ID.Text = caseID;
            textBox_name.Text = caseName;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox_result.SelectedIndex == 0)
            {
                button_uploadBug.Enabled = false;
                if (!haveBugs) button_uploadResult.Enabled = true;
            }
            else if(comboBox_result.SelectedIndex == 1)
            {
                button_uploadBug.Enabled = true;
                //bug point: 如果在后续的窗口中上传了缺陷，在这里却直接退出而未上传用例结果，可能会引入bug。
                if (!haveBugs) button_uploadResult.Enabled = false;
            }
        }

        private void Initiate()
        {
            haveBugs = Global_Database.WhetherHaveBug(caseID);
            if (haveBugs)
            {
                comboBox_result.SelectedIndex = 1;
                comboBox_result.Enabled = false;
                button_uploadBug.Enabled = true;
            }
            if (!haveBugs)
            {
                if(comboBox_result.SelectedIndex == 1) button_uploadResult.Enabled = false;
            }
        }

        private void button_uploadBug_Click(object sender, EventArgs e)
        {
            new BugCreater(int.Parse(caseID)).ShowDialog();
            //创建提交bug窗口
            Initiate();
        }

        private void button_uploadResult_Click(object sender, EventArgs e)
        {
            int status = 3 - comboBox_result.SelectedIndex;
            Global_Database.UploadTestResult(caseID, status);
            //case 完成情况1 情况2为审核缺陷通过。在那里要先通过bug确定case是否完成。
            //case 完成 更新plan状态.
            //plan 完成 更新project状态.
            string planID = "";
            MessageBox.Show("提交成功！");
            bool planCompleted = Global_Database.UpdatePlanStatus(caseID, out planID);
            if (planCompleted)
            {
                MessageBox.Show("所属计划已完成！");
                if(Global_Database.UpdatePojectStatus(planID)) MessageBox.Show("所属项目已完成!");
            }
           
            this.Close();
            
        }
    }
}
