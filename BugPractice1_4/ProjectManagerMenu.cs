﻿using System;
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
    public partial class ProjectManagerMenu : Form
    {
        Form1 LoginForm;
        bool logOut = false;
        DataSet ds;
        DataSet ds2;
        public ProjectManagerMenu(Form1 loginForm)
        {
            LoginForm = loginForm;
            InitializeComponent();
            label_username.Text = Global_Userinfo.username;
            string type;
            dataGridView1.AutoGenerateColumns = false;
            
            comboBox1.SelectedIndex = 0;
            switch (Global_Userinfo.type)
            {
                case Global_Userinfo.ADMINISTRATOR: type = "管理员"; break;
                case Global_Userinfo.PROJECT_MANAGER: type = "项目管理者"; break;
                case Global_Userinfo.TESTER: type = "测试工程师"; break;
                case Global_Userinfo.DEVELOPER: type = "开发工程师"; break;
                default: type = "未知用户"; break;
            }
            label_userType.Text = type;
            initiateDataGridView(comboBox1.SelectedIndex + 1);
        }

        private void button_logOut_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定要注销登录吗?", "注销", MessageBoxButtons.OKCancel) == DialogResult.Cancel) return;
            else
            {
                logOut = true;
                this.Close();
                LoginForm.user_name.Text = "";
                LoginForm.user_password.Text = "";
                LoginForm.Show();
            }
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("确认要退出缺陷管理系统吗？", "退出", MessageBoxButtons.OKCancel);
            if (result == DialogResult.Cancel) return;
            this.Close();
        }

        public void initiateDataGridView(int status)
        {
            // 1: 未完成 2:已完成

            MySqlConnection conn = new MySqlConnection(Global_Database.Conn);
            string sql = String.Format("select project_name, project_id from table_project where manager_id={0} and project_status = {1}", Global_Userinfo.userid, status);
            conn.Open();
            dataGridView1.AutoGenerateColumns = false;
            MySqlCommand command = new MySqlCommand(sql, conn);
            MySqlDataAdapter da = new MySqlDataAdapter(command);
            ds = new DataSet();
            da.Fill(ds, "table_project");
            dataGridView1.DataSource = ds.Tables["table_project"];
            dataGridView1.Refresh();

            conn.Close();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int columnIndex = e.ColumnIndex, rowIndex = e.RowIndex;
            if (rowIndex == -1) return;
            if (columnIndex == 2)
            {
                new ReleaseProject(1, ds.Tables["table_project"].Rows[rowIndex]["project_id"].ToString()).ShowDialog();
            }
            if(columnIndex == 3)
            {
                new ReleaseProject_2(1, ds.Tables["table_project"].Rows[rowIndex]["project_id"].ToString()).ShowDialog();
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new ReleaseProject().ShowDialog();
            this.initiateDataGridView(comboBox1.SelectedIndex + 1);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.initiateDataGridView(comboBox1.SelectedIndex + 1);
        }

        private void initComboBox()
        {
            MySqlConnection conn = new MySqlConnection(Global_Database.Conn);
            string sql = String.Format("select project_name, project_id from table_project where manager_id={0}", Global_Userinfo.userid);
            conn.Open();
            MySqlCommand command = new MySqlCommand(sql, conn);
            MySqlDataAdapter da = new MySqlDataAdapter(command);
            ds2 = new DataSet();
            da.Fill(ds, "table_project_combobox");
            conn.Close();

            int count = ds2.Tables["table_project_combobox"].Rows.Count;
            for(int i = 0; i < count; i++)
            {
                comboBox_projectName.Items.Add(ds2.Tables["table_project_combobox"].Rows[i]["project_name"].ToString());
            }
        }

        private void ProjectManagerMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (logOut == true) return;
            else LoginForm.Close();
        }
    }
}
