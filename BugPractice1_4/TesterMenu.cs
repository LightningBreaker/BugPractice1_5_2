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
    public partial class TesterMenu : Form
    {
        
        DataSet ds,ds2;

        public TesterMenu()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
            label_username.Text = Global_Userinfo.username;
            string type;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView2.AutoGenerateColumns = false;
            switch (Global_Userinfo.type)
            {
                case Global_Userinfo.ADMINISTRATOR: type = "管理员"; break;
                case Global_Userinfo.PROJECT_MANAGER: type = "项目管理者";break;
                case Global_Userinfo.TESTER: type = "测试工程师";break;
                case Global_Userinfo.DEVELOPER: type = "开发工程师";break;
                default: type = "未知用户"; break;
            }
            label_userType.Text = type;
        }

        


        private void label_userType_Click(object sender, EventArgs e)
        {

        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("确认要退出？", "退出", MessageBoxButtons.OKCancel);
            if (result == DialogResult.Cancel) return;
            this.Close();
        }

        private void page_myPlan_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        public void initiateDataGridView(int status)
        {
            // 1: 未完成 2:已完成
           
                MySqlConnection conn = new MySqlConnection(Global_Database.Conn);
                string sql = String.Format("select plan_name, plan_id , project_name, project_id from table_project pr, table_plan pl, where pl.plan_project = pr.project_id and pl.plan_manager = {0} and pl.status = {1}", Global_Userinfo.userid, status);
                conn.Open();
                dataGridView1.AutoGenerateColumns = false;
                MySqlCommand command = new MySqlCommand(sql, conn);
                MySqlDataAdapter da = new MySqlDataAdapter(command);
                ds = new DataSet();
                da.Fill(ds, "table_mytask");
                dataGridView1.DataSource = ds.Tables["table_mytask"];
                dataGridView1.Refresh();
                
                conn.Close();

        }

        public void initiateDataGridView2(int status)
        {
            // 1: 未完成 2:已完成

            MySqlConnection conn = new MySqlConnection(Global_Database.Conn);
            string sql = String.Format("select plan_name, plan_id , project_name, project_id, bug_id, bug_name,bug_level from table_project, table_plan p, table_bug b , table_case c where plan_manager = {0} and project_id = p.plan_id and p.plan_id = c.plan_id and c.case_id = b.case_id",Global_Userinfo.userid);
            conn.Open();
            dataGridView2.AutoGenerateColumns = false;
            MySqlCommand command = new MySqlCommand(sql, conn);
            MySqlDataAdapter da = new MySqlDataAdapter(command);
            ds2 = new DataSet();
            da.Fill(ds, "table_bug");
            dataGridView2.DataSource = ds.Tables["table_bug"];
            dataGridView2.Refresh();

            conn.Close();
           
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            initiateDataGridView(comboBox1.SelectedIndex + 1);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int columnIndex = e.ColumnIndex, rowIndex = e.RowIndex;
            if(columnIndex == 3)
            {
                new ReleaseProject(1,ds.Tables["table_mytask"].Rows[rowIndex]["project_id"].ToString()).ShowDialog();
            }
            else if (columnIndex == 4)
            {
                new ViewPlan(ds.Tables["table_mytask"].Rows[rowIndex]["plan_id"].ToString()).ShowDialog();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentCell == null) { MessageBox.Show("请先选择一个单元格！"); return; }
            int rowIndex = dataGridView1.CurrentCell.RowIndex;
            new ViewPlan_Tester_2(ds.Tables["table_mytask"].Rows[rowIndex]["plan_id"].ToString()).ShowDialog();

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView2.CurrentCell == null) { MessageBox.Show("请先选择一个单元格！"); return; }
            int rowIndex = dataGridView2.CurrentCell.RowIndex;
            string caseID = ds2.Tables["table_bug"].Rows[rowIndex]["case_id"].ToString();
            new AddCase(caseID, 1).ShowDialog();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            initiateDataGridView2(comboBox2.SelectedIndex + 1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //传bugid 
            new BugCreater().ShowDialog();
        }

        private void button_logOut_Click(object sender, EventArgs e)
        {

        }

        private void TesterMenu_Load(object sender, EventArgs e)
        {
            this.get_information();
        }

        private void dataGridView2_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if(e.ColumnIndex == 3)
            {
                if((int)e.Value == 1) { e.Value = "次要"; e.CellStyle.ForeColor = Color.Green; }
                else if((int)e.Value == 2) { e.Value = "一般"; e.CellStyle.ForeColor = Color.Yellow; }
                else { e.Value = "严重"; e.CellStyle.ForeColor = Color.Red; }
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
                MySqlConnection myconn = new MySqlConnection(Conn);
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
    }
}
