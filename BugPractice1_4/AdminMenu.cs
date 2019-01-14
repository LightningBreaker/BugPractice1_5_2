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
    public partial class AdminMenu : Form
    {
        public static int num = 3;
     
        public AdminMenu()
        {
            InitializeComponent();
        }

        private void admin_interface_Load(object sender, EventArgs e)
        {
            this.get_information();
        }

        private void button_logOut_Click(object sender, EventArgs e)
        {

        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("确认要退出？", "退出", MessageBoxButtons.OKCancel);
            if (result == DialogResult.Cancel) return;
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string password = textBox1.Text;
            if(num !=1)
            {
                if (password == "zmy")
                {
                    MessageBox.Show("登录成功！");
                    User_manager nf = new User_manager();
                    nf.ShowDialog();
                    this.textBox1.Text = "";
                    num = 3;

                }
                else
                {
                    num--;
                    MessageBox.Show("密码错误！您还有" + num.ToString() + "次机会", "登录提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                    this.textBox1.Text = "";
                }
            }
            else
            {
                MessageBox.Show("非法入侵,锁定系统", "登录提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                this.Close();
            }
            

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string user_id = textBox7.Text;
                string user_name = textBox2.Text;
                string password = textBox3.Text;
                string type = textBox4.Text;
                string telephone = textBox5.Text;
                string email = textBox6.Text;
                MySqlConnection myconn = new MySqlConnection(Global_Database.Conn);
                myconn.Open();
                string sql =
                    "update table_user_info set user_name='" + user_name + "',password='" + password + "',telephone='" + telephone + "',email='" + email + "'where user_id='" + Global_Userinfo.userid + "'";


                MySqlCommand mysqlupdate = new MySqlCommand(sql, myconn);
                mysqlupdate.ExecuteNonQuery();
                myconn.Close();
               
                MessageBox.Show("修改成功");
                this.get_information();
            }
            catch (MySqlException ex)
            {
                string message = ex.Message;
                Console.WriteLine("修改数据失败! " + message);
            }
        }
        public void get_information()
        {
            try
            {
                MySqlConnection myconn = new MySqlConnection(Global_Database.Conn);
                myconn.Open();
                string sql = "select * from table_user_info where user_id=" + Global_Userinfo.userid + "";
                MySqlCommand com = new MySqlCommand(sql, myconn);
                MySqlDataReader read = com.ExecuteReader();
                while (read.Read())
                {
                    textBox7.Text = read["user_id"].ToString();
                    textBox2.Text = read["user_name"].ToString();
                    textBox3.Text = read["password"].ToString();
                    switch (char.Parse(read["type"].ToString()))
                    {
                        case '1': textBox4.Text = "软件测试工程师"; break;
                        case '2': textBox4.Text = "软件开发工程师"; break;
                        case '3': textBox4.Text = "程序员"; break;
                        default: textBox4.Text = "未知用户"; break;
                    };
                    textBox5.Text = read["telephone"].ToString();
                    textBox6.Text = read["email"].ToString();
                }
                myconn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void page_personalInformation_Click(object sender, EventArgs e)
        {

        }
    }
}
