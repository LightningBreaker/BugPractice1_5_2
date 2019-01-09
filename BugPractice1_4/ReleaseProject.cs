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
    public partial class ReleaseProject : Form
    {
        
        public ReleaseProject()
        {
            InitializeComponent();
            textBox_managerName.Text = Global_Userinfo.username;
            textBox_managerID.Text = Global_Userinfo.userid;
            button3.Visible = false;
            
        }

        public ReleaseProject(int mode, string ID)
        {
            InitializeComponent();
            button_giveUp.Visible = false;
            button_nextPage.Visible = false;
            textBox_description.ReadOnly = true;
            textBox_projectName.ReadOnly = true;
            this.Text = "查看项目信息";
            initiateInfos(ID);
        }

        private void ReleaseProject_Load(object sender, EventArgs e)
        {

        }

        private void textBox_projectName_TextChanged(object sender, EventArgs e)
        {
            label_nameError.Text = "";
        }

        private void button_nextPage_Click(object sender, EventArgs e)
        {
            bool noProblem = true;
            if (textBox_projectName.TextLength == 0)
            {
                label_nameError.Text = "项目名不能为空！";
                noProblem = false;
            }
            if(textBox_description.Text.Length == 0)
            {
                label_descriptionError.Text = "项目描述不能为空！";
                noProblem = false;
            }
            if (!noProblem) return;
            Form nextForm = new ReleaseProject_2(this);
            nextForm.Show();
            this.Hide();
        }

        private void textBox_description_TextChanged(object sender, EventArgs e)
        {
            label_nameError.Text = "";
        }

        private void button_giveUp_Click(object sender, EventArgs e)
        {
        
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection(Global_Database.Conn);
            try
            {
                conn.Open();
                MessageBox.Show("连接成功");

            }
            catch(MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new ViewPlan_Tester("2").ShowDialog();
        }

        private void textBox_managerID_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_managerName_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void initiateInfos(string projectID)
        {
            MySqlConnection conn = new MySqlConnection(Global_Database.Conn);
            string sql = String.Format("select * from table_project where project_id = {0}", projectID);
            conn.Open();
            MySqlCommand command = new MySqlCommand(sql, conn);

            var reader = command.ExecuteReader();
            reader.Read();

            textBox_description.Text = reader["project_description"].ToString();
            textBox_projectName.Text = reader["project_name"].ToString();
            textBox_managerName.Text = reader["project_manager"].ToString();
            textBox_managerID.Text = reader["manager_id"].ToString();

            conn.Close();
            
        }
    }
}
