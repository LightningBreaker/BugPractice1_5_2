﻿namespace BugPractice1_4
{
    partial class TesterMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.page_homePage = new System.Windows.Forms.TabPage();
            this.button_exit = new System.Windows.Forms.Button();
            this.button_logOut = new System.Windows.Forms.Button();
            this.label_userType = new System.Windows.Forms.Label();
            this.label_username = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.page_myPlan = new System.Windows.Forms.TabPage();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabPage_auditBug = new System.Windows.Forms.TabPage();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.page_personalInformation = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.plan_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.plan_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProjectName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button_viewProject = new System.Windows.Forms.DataGridViewButtonColumn();
            this.button_viewPlan = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_bugLevel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewButtonColumn2 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tabControl1.SuspendLayout();
            this.page_homePage.SuspendLayout();
            this.page_myPlan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage_auditBug.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.page_personalInformation.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.page_homePage);
            this.tabControl1.Controls.Add(this.page_myPlan);
            this.tabControl1.Controls.Add(this.tabPage_auditBug);
            this.tabControl1.Controls.Add(this.page_personalInformation);
            this.tabControl1.Location = new System.Drawing.Point(15, 14);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(763, 452);
            this.tabControl1.TabIndex = 0;
            // 
            // page_homePage
            // 
            this.page_homePage.Controls.Add(this.button_exit);
            this.page_homePage.Controls.Add(this.button_logOut);
            this.page_homePage.Controls.Add(this.label_userType);
            this.page_homePage.Controls.Add(this.label_username);
            this.page_homePage.Controls.Add(this.label3);
            this.page_homePage.Controls.Add(this.label2);
            this.page_homePage.Controls.Add(this.label1);
            this.page_homePage.Location = new System.Drawing.Point(4, 25);
            this.page_homePage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.page_homePage.Name = "page_homePage";
            this.page_homePage.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.page_homePage.Size = new System.Drawing.Size(755, 423);
            this.page_homePage.TabIndex = 0;
            this.page_homePage.Tag = "";
            this.page_homePage.Text = "首页";
            this.page_homePage.UseVisualStyleBackColor = true;
            // 
            // button_exit
            // 
            this.button_exit.Location = new System.Drawing.Point(399, 288);
            this.button_exit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(108, 39);
            this.button_exit.TabIndex = 6;
            this.button_exit.Text = "退出";
            this.button_exit.UseVisualStyleBackColor = true;
            this.button_exit.Click += new System.EventHandler(this.button_exit_Click);
            // 
            // button_logOut
            // 
            this.button_logOut.Location = new System.Drawing.Point(189, 288);
            this.button_logOut.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_logOut.Name = "button_logOut";
            this.button_logOut.Size = new System.Drawing.Size(108, 39);
            this.button_logOut.TabIndex = 5;
            this.button_logOut.Text = "注销登录";
            this.button_logOut.UseVisualStyleBackColor = true;
            this.button_logOut.Click += new System.EventHandler(this.button_logOut_Click);
            // 
            // label_userType
            // 
            this.label_userType.AutoSize = true;
            this.label_userType.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_userType.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label_userType.Location = new System.Drawing.Point(375, 216);
            this.label_userType.Name = "label_userType";
            this.label_userType.Size = new System.Drawing.Size(67, 25);
            this.label_userType.TabIndex = 4;
            this.label_userType.Text = "label5";
            this.label_userType.Click += new System.EventHandler(this.label_userType_Click);
            // 
            // label_username
            // 
            this.label_username.AutoSize = true;
            this.label_username.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_username.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label_username.Location = new System.Drawing.Point(375, 168);
            this.label_username.Name = "label_username";
            this.label_username.Size = new System.Drawing.Size(67, 25);
            this.label_username.TabIndex = 3;
            this.label_username.Text = "label4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(228, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "您的用户类型：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(243, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "您的用户名：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(184, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(323, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "欢迎进入缺陷管理系统！";
            // 
            // page_myPlan
            // 
            this.page_myPlan.Controls.Add(this.comboBox1);
            this.page_myPlan.Controls.Add(this.button1);
            this.page_myPlan.Controls.Add(this.label4);
            this.page_myPlan.Controls.Add(this.dataGridView1);
            this.page_myPlan.Location = new System.Drawing.Point(4, 25);
            this.page_myPlan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.page_myPlan.Name = "page_myPlan";
            this.page_myPlan.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.page_myPlan.Size = new System.Drawing.Size(755, 423);
            this.page_myPlan.TabIndex = 1;
            this.page_myPlan.Text = "测试任务";
            this.page_myPlan.UseVisualStyleBackColor = true;
            this.page_myPlan.Click += new System.EventHandler(this.page_myPlan_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "未完成任务",
            "已完成任务"});
            this.comboBox1.Location = new System.Drawing.Point(435, 26);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(159, 23);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(621, 72);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 38);
            this.button1.TabIndex = 3;
            this.button1.Text = "管理用例";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(15, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(164, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "被分配的测试任务";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.plan_ID,
            this.plan_Name,
            this.ProjectName,
            this.button_viewProject,
            this.button_viewPlan});
            this.dataGridView1.Location = new System.Drawing.Point(20, 72);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(573, 312);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // tabPage_auditBug
            // 
            this.tabPage_auditBug.Controls.Add(this.comboBox2);
            this.tabPage_auditBug.Controls.Add(this.button2);
            this.tabPage_auditBug.Controls.Add(this.label5);
            this.tabPage_auditBug.Controls.Add(this.dataGridView2);
            this.tabPage_auditBug.Location = new System.Drawing.Point(4, 25);
            this.tabPage_auditBug.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage_auditBug.Name = "tabPage_auditBug";
            this.tabPage_auditBug.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage_auditBug.Size = new System.Drawing.Size(755, 423);
            this.tabPage_auditBug.TabIndex = 3;
            this.tabPage_auditBug.Text = "审核修复缺陷";
            this.tabPage_auditBug.UseVisualStyleBackColor = true;
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "待修复缺陷",
            "待审核缺陷",
            "已修复缺陷"});
            this.comboBox2.Location = new System.Drawing.Point(433, 28);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(161, 23);
            this.comboBox2.TabIndex = 8;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(624, 74);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(103, 38);
            this.button2.TabIndex = 7;
            this.button2.Text = "审核缺陷";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(17, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 25);
            this.label5.TabIndex = 6;
            this.label5.Text = "审核缺陷";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AllowUserToResizeColumns = false;
            this.dataGridView2.AllowUserToResizeRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.Column_bugLevel,
            this.dataGridViewButtonColumn2});
            this.dataGridView2.Location = new System.Drawing.Point(21, 74);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 27;
            this.dataGridView2.Size = new System.Drawing.Size(573, 312);
            this.dataGridView2.TabIndex = 5;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            this.dataGridView2.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView2_CellFormatting);
            // 
            // page_personalInformation
            // 
            this.page_personalInformation.Controls.Add(this.button3);
            this.page_personalInformation.Controls.Add(this.textBox6);
            this.page_personalInformation.Controls.Add(this.textBox7);
            this.page_personalInformation.Controls.Add(this.textBox5);
            this.page_personalInformation.Controls.Add(this.label10);
            this.page_personalInformation.Controls.Add(this.textBox4);
            this.page_personalInformation.Controls.Add(this.label9);
            this.page_personalInformation.Controls.Add(this.textBox3);
            this.page_personalInformation.Controls.Add(this.label8);
            this.page_personalInformation.Controls.Add(this.textBox2);
            this.page_personalInformation.Controls.Add(this.label7);
            this.page_personalInformation.Controls.Add(this.label6);
            this.page_personalInformation.Controls.Add(this.label11);
            this.page_personalInformation.Location = new System.Drawing.Point(4, 25);
            this.page_personalInformation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.page_personalInformation.Name = "page_personalInformation";
            this.page_personalInformation.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.page_personalInformation.Size = new System.Drawing.Size(755, 423);
            this.page_personalInformation.TabIndex = 2;
            this.page_personalInformation.Text = "个人资料";
            this.page_personalInformation.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(528, 168);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(107, 51);
            this.button3.TabIndex = 37;
            this.button3.Text = "修改";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(203, 342);
            this.textBox6.Margin = new System.Windows.Forms.Padding(4);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(199, 25);
            this.textBox6.TabIndex = 36;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(203, 51);
            this.textBox7.Margin = new System.Windows.Forms.Padding(4);
            this.textBox7.Name = "textBox7";
            this.textBox7.ReadOnly = true;
            this.textBox7.Size = new System.Drawing.Size(132, 25);
            this.textBox7.TabIndex = 30;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(203, 281);
            this.textBox5.Margin = new System.Windows.Forms.Padding(4);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(132, 25);
            this.textBox5.TabIndex = 35;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(117, 55);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(23, 15);
            this.label10.TabIndex = 25;
            this.label10.Text = "ID";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(203, 226);
            this.textBox4.Margin = new System.Windows.Forms.Padding(4);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(132, 25);
            this.textBox4.TabIndex = 34;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(117, 168);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 15);
            this.label9.TabIndex = 26;
            this.label9.Text = "密码";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(203, 165);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(132, 25);
            this.textBox3.TabIndex = 33;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(117, 109);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 15);
            this.label8.TabIndex = 27;
            this.label8.Text = "用户名";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(203, 109);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(132, 25);
            this.textBox2.TabIndex = 32;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(117, 229);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 15);
            this.label7.TabIndex = 28;
            this.label7.Text = "类型";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(117, 346);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 15);
            this.label6.TabIndex = 31;
            this.label6.Text = "Email";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(117, 285);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(37, 15);
            this.label11.TabIndex = 29;
            this.label11.Text = "电话";
            // 
            // plan_ID
            // 
            this.plan_ID.DataPropertyName = "plan_id";
            this.plan_ID.HeaderText = "计划ID";
            this.plan_ID.Name = "plan_ID";
            this.plan_ID.ReadOnly = true;
            // 
            // plan_Name
            // 
            this.plan_Name.DataPropertyName = "plan_name";
            this.plan_Name.HeaderText = "计划名称";
            this.plan_Name.Name = "plan_Name";
            this.plan_Name.ReadOnly = true;
            // 
            // ProjectName
            // 
            this.ProjectName.DataPropertyName = "project_name";
            this.ProjectName.HeaderText = "所属项目";
            this.ProjectName.Name = "ProjectName";
            this.ProjectName.ReadOnly = true;
            // 
            // button_viewProject
            // 
            this.button_viewProject.HeaderText = "查看项目";
            this.button_viewProject.Name = "button_viewProject";
            this.button_viewProject.ReadOnly = true;
            this.button_viewProject.Text = "查看项目";
            this.button_viewProject.UseColumnTextForButtonValue = true;
            // 
            // button_viewPlan
            // 
            this.button_viewPlan.HeaderText = "查看计划";
            this.button_viewPlan.Name = "button_viewPlan";
            this.button_viewPlan.ReadOnly = true;
            this.button_viewPlan.Text = "查看计划";
            this.button_viewPlan.UseColumnTextForButtonValue = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "bug_id";
            this.dataGridViewTextBoxColumn1.HeaderText = "缺陷ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "bug_name";
            this.dataGridViewTextBoxColumn2.HeaderText = "缺陷名称";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "project_name";
            this.dataGridViewTextBoxColumn3.HeaderText = "所属项目";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // Column_bugLevel
            // 
            this.Column_bugLevel.DataPropertyName = "bug_level";
            this.Column_bugLevel.HeaderText = "缺陷等级";
            this.Column_bugLevel.Name = "Column_bugLevel";
            // 
            // dataGridViewButtonColumn2
            // 
            this.dataGridViewButtonColumn2.HeaderText = "查看用例";
            this.dataGridViewButtonColumn2.Name = "dataGridViewButtonColumn2";
            this.dataGridViewButtonColumn2.ReadOnly = true;
            this.dataGridViewButtonColumn2.Text = "查看用例";
            this.dataGridViewButtonColumn2.UseColumnTextForButtonValue = true;
            // 
            // TesterMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 498);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TesterMenu";
            this.Text = "缺陷管理系统";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TesterMenu_FormClosed);
            this.Load += new System.EventHandler(this.TesterMenu_Load);
            this.tabControl1.ResumeLayout(false);
            this.page_homePage.ResumeLayout(false);
            this.page_homePage.PerformLayout();
            this.page_myPlan.ResumeLayout(false);
            this.page_myPlan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage_auditBug.ResumeLayout(false);
            this.tabPage_auditBug.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.page_personalInformation.ResumeLayout(false);
            this.page_personalInformation.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage page_homePage;
        private System.Windows.Forms.TabPage page_myPlan;
        private System.Windows.Forms.TabPage page_personalInformation;
        private System.Windows.Forms.Button button_exit;
        private System.Windows.Forms.Button button_logOut;
        private System.Windows.Forms.Label label_userType;
        private System.Windows.Forms.Label label_username;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TabPage tabPage_auditBug;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridViewTextBoxColumn plan_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn plan_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProjectName;
        private System.Windows.Forms.DataGridViewButtonColumn button_viewProject;
        private System.Windows.Forms.DataGridViewButtonColumn button_viewPlan;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_bugLevel;
        private System.Windows.Forms.DataGridViewButtonColumn dataGridViewButtonColumn2;
    }
}