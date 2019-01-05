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
    public partial class ReleaseProject_2 : Form
    {
        Form preForm;
        List<plan> plans = new List<plan>();
        public ReleaseProject_2(Form pref)
        {
            InitializeComponent();
            dataGridView1.DataSource = 
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
    }
    public class plan
    {
        public string name;
        public string description;
        public string manager_id;
        public string manager_name;

        public plan(string name,string description,string manager_name,string manager_id)
        {
            this.name = name;
            this.description = description;
            this.manager_id = manager_id;
            this.manager_name = manager_name;
        }
    }
}
