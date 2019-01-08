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
    public partial class ViewPlan_Tester : Form
    {
        string planID;
        
        public ViewPlan_Tester(string planID)
        {
            InitializeComponent();
            this.planID = planID;
            InitiateInfos();
        }

        private void button_giveUp_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void InitiateInfos()
        {
            plan p = new plan("","","","",0);
            string projectID="";
            int plan_status = 0;

            Global_Database.SearchPlanInfo(planID, out p, out plan_status,out projectID);

            MessageBox.Show(p.description);
            textBox_planName.Text = p.name;
            comboBox_priority.SelectedIndex = p.priority;
            textBox_manageName.Text = p.manager_name;
            textBox_manageName.ReadOnly = true;
            textBox_managerID.Text = p.manager_id;
            textBox_description.Text = p.description;
            comboBox_priority.Enabled = false;
        }

        private void button_nextPage_Click(object sender, EventArgs e)
        {
            new ViewPlan_Tester_2(planID).ShowDialog();
            
        }
    }
}
