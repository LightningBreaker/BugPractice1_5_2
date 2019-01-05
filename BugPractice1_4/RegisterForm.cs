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
    public partial class RegisterForm : Form
    {

        private UserInfo reg_userInfo=new UserInfo();
        private Form1 form1=null;
        public RegisterForm()
        {

            InitializeComponent();
        }
        public RegisterForm(Form1 _form1)
        {
            this.form1 = _form1;
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        
        private void RegisterForm_Load(object sender, EventArgs e)
        {
            reg_combo_type.SelectedIndex = 0;
            for (int i = 0; i < is_ok.Length; i++)
            {
                is_ok[i] = false;
            }
        }
        private bool[] is_ok = new bool[4];
        private void reg_password1_TextChanged(object sender, EventArgs e)
        {
            if (reg_password1.TextLength <=5)
            {
                is_ok[3] = false;
                reg_lable_pass1.ForeColor = Color.Red;
               
                reg_lable_pass1.Text = "密码长度必须大于6";
                is_ok[0] = false;
            }
            else
            {
                reg_lable_pass1.ForeColor = Color.Green;
                reg_lable_pass1.Text = "密码合法";
                reg_userInfo.Password = reg_password1.Text;
                is_ok[0] = true;
                if (reg_password1.Text != reg_password2.Text)
                {
                    is_ok[1] = false;
                    reg_label_pass2.Text = "两次输入密码不一致";
                }
            }
        }
        private int page_index = 0;
        private void reg_btn_next1_Click(object sender, EventArgs e)
        {
            
            
            if (!user_name_ok)
            {
                MessageBox.Show("请先填写合法用户名");
                return;
            }
            reg_userInfo.Type= reg_combo_type.SelectedIndex+1;
            this.reg_tab_page.SelectedIndex = 1;
            page_index = 1;
            reg_tab_page.SelectTab(1);
            reg_tab_page_SelectedIndexChanged(sender, e);
            
        }

        private void reg_btn_next2_Click(object sender, EventArgs e)
        {
            if (!is_next2())
            {
                MessageBox.Show("请先完善用户信息");
                return;

            }
            this.reg_tab_page.SelectedIndex = 2;
            reg_tab_page.SelectTab(2);
            page_index = 2;
            reg_tab_page_SelectedIndexChanged(sender, e);
        }

        private void reg_tab_page_SelectedIndexChanged(object sender, EventArgs e)
        {
            reg_tab_page.SelectedIndex = page_index;
        }

        private void RegisterForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        bool user_name_ok = false;
        private void reg_user_name_TextChanged(object sender, EventArgs e)
        {
           MySqlConnection conn = new MySqlConnection(Global_Database.Conn);
        string tmp_name = reg_user_name.Text.ToString();
            int len = tmp_name.Length;
            conn.Open();
            MySqlCommand mycmd = new MySqlCommand("select * from table_user_info " +
              "where user_name = '" + tmp_name + "'", conn);
            MySqlDataReader  dataReader= mycmd.ExecuteReader();

            if (len <= 5 || IsDigitOrNumber(tmp_name) == 0)
            {
                label_reg_user.ForeColor = Color.Red;
                label_reg_user.Text = "账号长度必须大于等于6，且仅能包含数字或字母";
                user_name_ok = false;
            }
            else if (dataReader.Read())
            {
                label_reg_user.ForeColor = Color.Red;
                label_reg_user.Text = "该账号名字已经存在";
                user_name_ok = false;
            }
            else
            {
                label_reg_user.ForeColor = Color.Green;
                label_reg_user.Text = "账号合法";
                reg_userInfo.User_name = tmp_name;

                user_name_ok = true;
            }
            conn.Close();
        }
        private int IsDigitOrNumber(string str)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(str, @"(?i)^[0-9a-z]+$"))
                return 1;
            else return 0;
        }

        private int IsNumber(string str)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(str, @"(?i)^[0-9]+$"))
                return 1;
            else return 0;
        }
        private void list_type_SelectedIndexChanged(object sender, EventArgs e)
        {

           
        }

        private void list_type_TabIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void reg_waiting_Click(object sender, EventArgs e)
        {
            MySqlConnection mycon = new MySqlConnection(Global_Database.Conn);
            mycon.Open();
         //   insert into table_user_info(user_name, password, type, telephone, email) values('vladimir', 'vladimir', 2, '12323232323'
       //-> , '213123123@gmail.com');
            MySqlCommand mycmd = 
                new MySqlCommand(" insert into" +
                " table_user_info" +
                "(user_name, password, type, telephone, email)" +
                " values(" +
                "'" + reg_userInfo.User_name + "'," +
                "'" + reg_userInfo.Password + "'," +
                    + reg_userInfo.Type + "," +
                "'" + reg_userInfo.Telephone + "'," +
                "'" + reg_userInfo.Email + "');"
                , mycon);

            if (mycmd.ExecuteNonQuery() > 0)
            {
                this.Hide();
                this.form1.Show();
            }
            else
            {
                MessageBox.Show("系统维护中，请改日再创建");
            }
            mycon.Close();
        }

        private void reg_password2_TextChanged(object sender, EventArgs e)
        {
            if (reg_userInfo.Password == reg_password2.Text)
            {
                is_ok[1] = true;
                reg_label_pass2.ForeColor = Color.Green;
                reg_label_pass2.Text = "输入一致";
            }
            else
            {
                is_ok[1] = false;
                reg_label_pass2.ForeColor = Color.Red;
                reg_label_pass2.Text = "两次输入密码不一致";

            }
        }

        bool is_next2()
        {
            
            for(int i=0;i<is_ok.Length;i++)
            {
                if (is_ok[i] == false)
                {
                    return false;
                }

            }
            return true;


        }

        private void reg_email_TextChanged(object sender, EventArgs e)
        {
            if (reg_email.Text.Length < 6)
            {
                is_ok[2] = false;
                reg_label_email.Text = "请输入合法邮箱";
                reg_label_email.ForeColor = Color.Red;
                
            }
            else
            {
                is_ok[2] = true;
                reg_label_email.Text = "邮箱合法";
                reg_label_email.ForeColor = Color.Green;
                reg_userInfo.Email = reg_email.Text;

            }
        }

        private void reg_telephone_TextChanged(object sender, EventArgs e)
        {
            if (reg_telephone.Text.Length != 11||IsNumber(reg_telephone.Text)==0)
            {
                is_ok[3] = false;
                reg_label_phone.ForeColor = Color.Red;
                reg_label_phone.Text = "手机号码不合法";
            }
            else
            {
                is_ok[3] = true;
                reg_label_phone.ForeColor = Color.Green;
                reg_label_phone.Text = "手机号码合法";
                reg_userInfo.Telephone = reg_telephone.Text;
            }
        }
    }
}
