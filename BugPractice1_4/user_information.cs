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
using System.Data.SqlClient;
namespace BugPractice1_4
{
    public partial class User_information : Form
    {
        public static int current_id;
        
        public User_information()
        {
            InitializeComponent();
        }
        public User_information (int num,bool is_checked)
        {        
             InitializeComponent();
              current_id = num;//这句必须放在InitializeComponent();的后面，否则会引起“空引用异常”
            if(!is_checked)
            {
                this.button3.Visible = false;
                this.button4.Visible = false;

            }
            else
            {
                this.button1.Visible = false;
                this.button2.Visible = false;
            }
         }

    private void user_information_Load(object sender, EventArgs e)
        {
            try {
                MySqlConnection myconn = new MySqlConnection(Global_Database.Conn);
                myconn.Open();
                string sql = "select * from table_user_info where user_id=" + current_id + "";
                MySqlCommand com = new MySqlCommand(sql, myconn);
                MySqlDataReader read = com.ExecuteReader();
                while (read.Read())
                {
                    textBox1.Text = read["user_id"].ToString();
                    textBox2.Text = read["user_name"].ToString();
                    textBox3.Text = read["password"].ToString();
                    switch ( char.Parse(read["type"].ToString()))
                    {
                        case '1': textBox4.Text = "软件测试工程师";break;
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

        private void button1_Click(object sender, EventArgs e)//审核通过
        {
          
            try
            {
                MySqlConnection myconn = new MySqlConnection(Global_Database.Conn);
                myconn.Open();
                string sql = "update table_user_info set is_verified = 1 where user_id='"+current_id+"' ";//添加标志位
                MySqlCommand mysqlupdate = new MySqlCommand(sql, myconn);
                mysqlupdate.ExecuteNonQuery();
                MessageBox.Show("审核成功");
                this.Close();
            }
            catch (MySqlException ex)
            {
                string message = ex.Message;
                Console.WriteLine("数据错误! " + message);
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)//修改按钮
        {
            try
            {
                string user_id = textBox1.Text;
                string user_name = textBox2.Text;
               string password = textBox3.Text;
               string type= textBox4.Text;
                string teilephone =textBox5.Text ;
                 string email =textBox6.Text;
                MySqlConnection myconn = new MySqlConnection(Global_Database.Conn);
                myconn.Open();
                string sql = 
                    "update table_user_info set user_name='"+user_name+"',password='"+password+ "'where user_id='" + current_id + "'";
                   
               
                MySqlCommand mysqlupdate = new MySqlCommand(sql, myconn);
                mysqlupdate.ExecuteNonQuery();
                myconn.Close();
                this.DialogResult = DialogResult.OK;
                MessageBox.Show("修改成功");
                this.Close();
            }
            catch (MySqlException ex)
            {
                string message = ex.Message;
                Console.WriteLine("修改数据失败! " + message);
            }
        }

        private void button2_Click(object sender, EventArgs e)///审核未通过
        {

            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)///删除按钮
        {
            try
            {
               
               
                MySqlConnection myconn = new MySqlConnection(Global_Database.Conn);
                myconn.Open();

                string sql = "update table_user_info set is_verified = 0 where user_id='" + current_id + "' ";
                MySqlCommand mysqlupdate = new MySqlCommand(sql, myconn);
                //MessageBox.Show("测试");
                if (mysqlupdate.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("删除成功");
                    myconn.Close();
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("删除失败");
                }
                
            }
            catch (MySqlException ex)
            {
                string message = ex.Message;
                MessageBox.Show("删除失败" + message);
               // Console.WriteLine("删除数据失败! " + message);
            }
        }
    }
}
