using MySql.Data.MySqlClient;
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
   
    public partial class Form1 : Form
    {
        private static string CONSTR = "server=localhost;" +
           "User Id=root;password=TheFirstDon;" +
           "Database=practice_in_school";
        public Form1()
        {
            InitializeComponent();//ssss
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = user_name.Text.Trim();
            string password = user_password.Text.ToString();
            MySqlConnection mycon = new MySqlConnection(CONSTR);
            mycon.Open();
            MySqlCommand mycmd = new MySqlCommand("select * from table_user_info " +
                "where user_name = '" + username + "' and password = '"
                + password + "'", mycon);
            //mda.SelectCommand = mycmd;
            //DataSet my_data = new DataSet();
            //mda.Fill(my_data);
            //my_data.Tables[0]
            MySqlDataReader dr = mycmd.ExecuteReader();
            if (dr.Read())
            {
                dr.Close();
                mycon.Close();
                MessageBox.Show("登录成功");
                

            }
            else
            {
                MessageBox.Show("账号或密码错误");
            }


            mycon.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label_register_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            registerForm.Show();
            this.Hide();


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
