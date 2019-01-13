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
    public partial class User_manager : Form
    {
        public static bool is_checked = false;
        
        public User_manager()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            //将整个窗体作为值传给Form2
            
            var frm2 = new user_information(Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value),is_checked);       
            frm2.ShowDialog();
            if (frm2.DialogResult == DialogResult.OK)
            {
                try
                {
                    MySqlConnection myconn = null;
                    MySqlCommand mycom = null;
                    myconn = new MySqlConnection(Global_Database.Conn);
                    myconn.Open();
                    //  MessageBox.Show("连接成功");
                    mycom = myconn.CreateCommand();
                    string sql = "SELECT * FROM table_user_info where is_verified =1";
                    MySqlCommand command = new MySqlCommand(sql, myconn);
                    MySqlDataAdapter adap = new MySqlDataAdapter(command);
                    DataSet ds = new DataSet();
                    adap.Fill(ds);
                    this.dataGridView1.AutoGenerateColumns = false;
                    this.dataGridView1.AllowUserToAddRows = false;
                    DataTable dtb = ds.Tables[0];
                    this.dataGridView1.DataSource = dtb;
                    myconn.Close();

                }

                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                try
                {
                    MySqlConnection myconn = null;
                    MySqlCommand mycom = null;
                    myconn = new MySqlConnection(Global_Database.Conn);
                    myconn.Open();
                    //  MessageBox.Show("连接成功");
                    mycom = myconn.CreateCommand();
                    string sql = "SELECT * FROM table_user_info where is_verified =0";
                    MySqlCommand command = new MySqlCommand(sql, myconn);
                    MySqlDataAdapter adap = new MySqlDataAdapter(command);
                    DataSet ds = new DataSet();
                    adap.Fill(ds);
                    this.dataGridView1.AutoGenerateColumns = false;
                    this.dataGridView1.AllowUserToAddRows = false;
                    DataTable dtb = ds.Tables[0];
                    this.dataGridView1.DataSource = dtb;
                    myconn.Close();

                }

                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

    

        private void User_manager_Load(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection myconn = null;         
                myconn = new MySqlConnection(Global_Database.Conn);
                myconn.Open();
                MessageBox.Show("连接成功");             
                string sql = "SELECT * FROM table_user_info where is_verified =0";
                MySqlCommand command = new MySqlCommand(sql, myconn);
                MySqlDataAdapter adap = new MySqlDataAdapter(command);
                DataSet ds = new DataSet();
                adap.Fill(ds);
                this.dataGridView1.AutoGenerateColumns = false;
                this.dataGridView1.AllowUserToAddRows = false;
                DataTable dtb = ds.Tables[0];
                 this.dataGridView1.DataSource = dtb;               
               
            }

            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }



        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            var result = MessageBox.Show("确认要退出？", "退出", MessageBoxButtons.OKCancel);
            if (result == DialogResult.Cancel) return;
            this.Close();
        }

        private void 待审核人员ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                is_checked = false;
                MySqlConnection myconn = null;
                MySqlCommand mycom = null;
                myconn = new MySqlConnection(Global_Database.Conn);
                myconn.Open();
               // MessageBox.Show("连接成功");
                mycom = myconn.CreateCommand();
                string sql = "SELECT * FROM table_user_info where is_verified =0";
                MySqlCommand command = new MySqlCommand(sql, myconn);
                MySqlDataAdapter adap = new MySqlDataAdapter(command);
                DataSet ds = new DataSet();
                adap.Fill(ds);
                this.dataGridView1.AutoGenerateColumns = false;
                this.dataGridView1.AllowUserToAddRows = false;
                DataTable dtb = ds.Tables[0];
                this.dataGridView1.DataSource = dtb;

            }

            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void 已审核人员ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                is_checked = true;
                MySqlConnection myconn = null;
                MySqlCommand mycom = null;
                myconn = new MySqlConnection(Global_Database.Conn);
                myconn.Open();
              //  MessageBox.Show("连接成功");
                mycom = myconn.CreateCommand();
                string sql = "SELECT * FROM table_user_info where is_verified =1";
                MySqlCommand command = new MySqlCommand(sql, myconn);
                MySqlDataAdapter adap = new MySqlDataAdapter(command);
                DataSet ds = new DataSet();
                adap.Fill(ds);
                this.dataGridView1.AutoGenerateColumns = false;
                this.dataGridView1.AllowUserToAddRows = false;
                DataTable dtb = ds.Tables[0];
                this.dataGridView1.DataSource = dtb;

            }

            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
