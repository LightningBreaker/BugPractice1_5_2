namespace BugPractice1_4
{
    partial class ProjectManagerMenu
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
            this.page_projectManage = new System.Windows.Forms.TabPage();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.project_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.plan_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button_viewProject = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column_plan = new System.Windows.Forms.DataGridViewButtonColumn();
            this.page_viewChart = new System.Windows.Forms.TabPage();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.comboBox_projectName = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.page_personalInformation = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.text_pro_email = new System.Windows.Forms.TextBox();
            this.text_pro_id = new System.Windows.Forms.TextBox();
            this.text_pro_phone = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.text_pro_type = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.text_pro_pass = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.text_pro_user = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.page_homePage.SuspendLayout();
            this.page_projectManage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.page_viewChart.SuspendLayout();
            this.page_personalInformation.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.page_homePage);
            this.tabControl1.Controls.Add(this.page_projectManage);
            this.tabControl1.Controls.Add(this.page_viewChart);
            this.tabControl1.Controls.Add(this.page_personalInformation);
            this.tabControl1.Location = new System.Drawing.Point(15, 14);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(763, 452);
            this.tabControl1.TabIndex = 1;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
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
            // page_projectManage
            // 
            this.page_projectManage.Controls.Add(this.comboBox1);
            this.page_projectManage.Controls.Add(this.button1);
            this.page_projectManage.Controls.Add(this.label4);
            this.page_projectManage.Controls.Add(this.dataGridView1);
            this.page_projectManage.Location = new System.Drawing.Point(4, 25);
            this.page_projectManage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.page_projectManage.Name = "page_projectManage";
            this.page_projectManage.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.page_projectManage.Size = new System.Drawing.Size(755, 423);
            this.page_projectManage.TabIndex = 1;
            this.page_projectManage.Text = "项目管理";
            this.page_projectManage.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "未完成项目",
            "已完成项目"});
            this.comboBox1.Location = new System.Drawing.Point(435, 26);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(159, 23);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(626, 72);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 38);
            this.button1.TabIndex = 3;
            this.button1.Text = "添加项目";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(15, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "项目管理";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.project_ID,
            this.plan_Name,
            this.button_viewProject,
            this.Column_plan});
            this.dataGridView1.Location = new System.Drawing.Point(20, 72);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(573, 312);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // project_ID
            // 
            this.project_ID.DataPropertyName = "project_id";
            this.project_ID.Frozen = true;
            this.project_ID.HeaderText = "项目ID";
            this.project_ID.Name = "project_ID";
            this.project_ID.ReadOnly = true;
            // 
            // plan_Name
            // 
            this.plan_Name.DataPropertyName = "project_name";
            this.plan_Name.Frozen = true;
            this.plan_Name.HeaderText = "项目名称";
            this.plan_Name.Name = "plan_Name";
            this.plan_Name.ReadOnly = true;
            // 
            // button_viewProject
            // 
            this.button_viewProject.Frozen = true;
            this.button_viewProject.HeaderText = "查看项目";
            this.button_viewProject.Name = "button_viewProject";
            this.button_viewProject.ReadOnly = true;
            this.button_viewProject.Text = "查看项目";
            this.button_viewProject.UseColumnTextForButtonValue = true;
            // 
            // Column_plan
            // 
            this.Column_plan.Frozen = true;
            this.Column_plan.HeaderText = "查看计划";
            this.Column_plan.Name = "Column_plan";
            this.Column_plan.ReadOnly = true;
            this.Column_plan.Text = "查看计划";
            this.Column_plan.UseColumnTextForButtonValue = true;
            // 
            // page_viewChart
            // 
            this.page_viewChart.Controls.Add(this.label13);
            this.page_viewChart.Controls.Add(this.label12);
            this.page_viewChart.Controls.Add(this.comboBox_projectName);
            this.page_viewChart.Controls.Add(this.button2);
            this.page_viewChart.Controls.Add(this.label5);
            this.page_viewChart.Location = new System.Drawing.Point(4, 25);
            this.page_viewChart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.page_viewChart.Name = "page_viewChart";
            this.page_viewChart.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.page_viewChart.Size = new System.Drawing.Size(755, 423);
            this.page_viewChart.TabIndex = 3;
            this.page_viewChart.Text = "查看报表";
            this.page_viewChart.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label13.Location = new System.Drawing.Point(196, 183);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(69, 20);
            this.label13.TabIndex = 10;
            this.label13.Text = "报表类型";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label12.Location = new System.Drawing.Point(196, 122);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(69, 20);
            this.label12.TabIndex = 9;
            this.label12.Text = "项目名称";
            // 
            // comboBox_projectName
            // 
            this.comboBox_projectName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_projectName.FormattingEnabled = true;
            this.comboBox_projectName.Location = new System.Drawing.Point(286, 122);
            this.comboBox_projectName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox_projectName.Name = "comboBox_projectName";
            this.comboBox_projectName.Size = new System.Drawing.Size(258, 23);
            this.comboBox_projectName.TabIndex = 8;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(286, 183);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(97, 29);
            this.button2.TabIndex = 7;
            this.button2.Text = "报表";
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
            this.label5.Text = "查看报表";
            // 
            // page_personalInformation
            // 
            this.page_personalInformation.Controls.Add(this.button3);
            this.page_personalInformation.Controls.Add(this.text_pro_email);
            this.page_personalInformation.Controls.Add(this.text_pro_id);
            this.page_personalInformation.Controls.Add(this.text_pro_phone);
            this.page_personalInformation.Controls.Add(this.label10);
            this.page_personalInformation.Controls.Add(this.text_pro_type);
            this.page_personalInformation.Controls.Add(this.label9);
            this.page_personalInformation.Controls.Add(this.text_pro_pass);
            this.page_personalInformation.Controls.Add(this.label8);
            this.page_personalInformation.Controls.Add(this.text_pro_user);
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
            // text_pro_email
            // 
            this.text_pro_email.Location = new System.Drawing.Point(203, 342);
            this.text_pro_email.Margin = new System.Windows.Forms.Padding(4);
            this.text_pro_email.Name = "text_pro_email";
            this.text_pro_email.Size = new System.Drawing.Size(199, 25);
            this.text_pro_email.TabIndex = 36;
            // 
            // text_pro_id
            // 
            this.text_pro_id.Location = new System.Drawing.Point(203, 51);
            this.text_pro_id.Margin = new System.Windows.Forms.Padding(4);
            this.text_pro_id.Name = "text_pro_id";
            this.text_pro_id.ReadOnly = true;
            this.text_pro_id.Size = new System.Drawing.Size(132, 25);
            this.text_pro_id.TabIndex = 30;
            // 
            // text_pro_phone
            // 
            this.text_pro_phone.Location = new System.Drawing.Point(203, 281);
            this.text_pro_phone.Margin = new System.Windows.Forms.Padding(4);
            this.text_pro_phone.Name = "text_pro_phone";
            this.text_pro_phone.Size = new System.Drawing.Size(132, 25);
            this.text_pro_phone.TabIndex = 35;
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
            // text_pro_type
            // 
            this.text_pro_type.Location = new System.Drawing.Point(203, 226);
            this.text_pro_type.Margin = new System.Windows.Forms.Padding(4);
            this.text_pro_type.Name = "text_pro_type";
            this.text_pro_type.ReadOnly = true;
            this.text_pro_type.Size = new System.Drawing.Size(132, 25);
            this.text_pro_type.TabIndex = 34;
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
            // text_pro_pass
            // 
            this.text_pro_pass.Location = new System.Drawing.Point(203, 165);
            this.text_pro_pass.Margin = new System.Windows.Forms.Padding(4);
            this.text_pro_pass.Name = "text_pro_pass";
            this.text_pro_pass.Size = new System.Drawing.Size(132, 25);
            this.text_pro_pass.TabIndex = 33;
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
            // text_pro_user
            // 
            this.text_pro_user.Location = new System.Drawing.Point(203, 109);
            this.text_pro_user.Margin = new System.Windows.Forms.Padding(4);
            this.text_pro_user.Name = "text_pro_user";
            this.text_pro_user.ReadOnly = true;
            this.text_pro_user.Size = new System.Drawing.Size(132, 25);
            this.text_pro_user.TabIndex = 32;
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
            // ProjectManagerMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 498);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ProjectManagerMenu";
            this.Text = "缺陷管理系统";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ProjectManagerMenu_FormClosed);
            this.Load += new System.EventHandler(this.ProjectManagerMenu_Load);
            this.tabControl1.ResumeLayout(false);
            this.page_homePage.ResumeLayout(false);
            this.page_homePage.PerformLayout();
            this.page_projectManage.ResumeLayout(false);
            this.page_projectManage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.page_viewChart.ResumeLayout(false);
            this.page_viewChart.PerformLayout();
            this.page_personalInformation.ResumeLayout(false);
            this.page_personalInformation.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage page_homePage;
        private System.Windows.Forms.Button button_exit;
        private System.Windows.Forms.Button button_logOut;
        private System.Windows.Forms.Label label_userType;
        private System.Windows.Forms.Label label_username;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage page_projectManage;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage page_viewChart;
        private System.Windows.Forms.ComboBox comboBox_projectName;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabPage page_personalInformation;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox text_pro_email;
        private System.Windows.Forms.TextBox text_pro_id;
        private System.Windows.Forms.TextBox text_pro_phone;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox text_pro_type;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox text_pro_pass;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox text_pro_user;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridViewTextBoxColumn project_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn plan_Name;
        private System.Windows.Forms.DataGridViewButtonColumn button_viewProject;
        private System.Windows.Forms.DataGridViewButtonColumn Column_plan;
    }
}