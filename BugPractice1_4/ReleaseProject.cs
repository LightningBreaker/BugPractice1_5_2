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
    }
}
