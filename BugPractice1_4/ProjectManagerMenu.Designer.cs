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
            this.label12 = new System.Windows.Forms.Label();
            this.comboBox_projectName = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
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
            this.tabControl1.Location = new System.Drawing.Point(11, 11);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(572, 362);
            this.tabControl1.TabIndex = 1;
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
            this.page_homePage.Location = new System.Drawing.Point(4, 22);
            this.page_homePage.Margin = new System.Windows.Forms.Padding(2);
            this.page_homePage.Name = "page_homePage";
            this.page_homePage.Padding = new System.Windows.Forms.Padding(2);
            this.page_homePage.Size = new System.Drawing.Size(564, 336);
            this.page_homePage.TabIndex = 0;
            this.page_homePage.Tag = "";
            this.page_homePage.Text = "首页";
            this.page_homePage.UseVisualStyleBackColor = true;
            // 
            // button_exit
            // 
            this.button_exit.Location = new System.Drawing.Point(299, 230);
            this.button_exit.Margin = new System.Windows.Forms.Padding(2);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(81, 31);
            this.button_exit.TabIndex = 6;
            this.button_exit.Text = "退出";
            this.button_exit.UseVisualStyleBackColor = true;
            this.button_exit.Click += new System.EventHandler(this.button_exit_Click);
            // 
            // button_logOut
            // 
            this.button_logOut.Location = new System.Drawing.Point(142, 230);
            this.button_logOut.Margin = new System.Windows.Forms.Padding(2);
            this.button_logOut.Name = "button_logOut";
            this.button_logOut.Size = new System.Drawing.Size(81, 31);
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
            this.label_userType.Location = new System.Drawing.Point(281, 173);
            this.label_userType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_userType.Name = "label_userType";
            this.label_userType.Size = new System.Drawing.Size(53, 20);
            this.label_userType.TabIndex = 4;
            this.label_userType.Text = "label5";
            // 
            // label_username
            // 
            this.label_username.AutoSize = true;
            this.label_username.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_username.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label_username.Location = new System.Drawing.Point(281, 134);
            this.label_username.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_username.Name = "label_username";
            this.label_username.Size = new System.Drawing.Size(53, 20);
            this.label_username.TabIndex = 3;
            this.label_username.Text = "label4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(171, 173);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "您的用户类型：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(182, 134);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "您的用户名：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(138, 70);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "欢迎进入缺陷管理系统！";
            // 
            // page_projectManage
            // 
            this.page_projectManage.Controls.Add(this.comboBox1);
            this.page_projectManage.Controls.Add(this.button1);
            this.page_projectManage.Controls.Add(this.label4);
            this.page_projectManage.Controls.Add(this.dataGridView1);
            this.page_projectManage.Location = new System.Drawing.Point(4, 22);
            this.page_projectManage.Margin = new System.Windows.Forms.Padding(2);
            this.page_projectManage.Name = "page_projectManage";
            this.page_projectManage.Padding = new System.Windows.Forms.Padding(2);
            this.page_projectManage.Size = new System.Drawing.Size(564, 336);
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
            this.comboBox1.Location = new System.Drawing.Point(326, 21);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(120, 20);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(470, 58);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(77, 30);
            this.button1.TabIndex = 3;
            this.button1.Text = "添加项目";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(11, 18);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 20);
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
            this.dataGridView1.Location = new System.Drawing.Point(15, 58);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(430, 250);
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
            this.page_viewChart.Controls.Add(this.label12);
            this.page_viewChart.Controls.Add(this.comboBox_projectName);
            this.page_viewChart.Controls.Add(this.button2);
            this.page_viewChart.Controls.Add(this.label5);
            this.page_viewChart.Location = new System.Drawing.Point(4, 22);
            this.page_viewChart.Margin = new System.Windows.Forms.Padding(2);
            this.page_viewChart.Name = "page_viewChart";
            this.page_viewChart.Padding = new System.Windows.Forms.Padding(2);
            this.page_viewChart.Size = new System.Drawing.Size(564, 336);
            this.page_viewChart.TabIndex = 3;
            this.page_viewChart.Text = "查看报表";
            this.page_viewChart.UseVisualStyleBackColor = true;
            this.page_viewChart.Click += new System.EventHandler(this.page_viewChart_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label12.Location = new System.Drawing.Point(147, 98);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(56, 17);
            this.label12.TabIndex = 9;
            this.label12.Text = "项目名称";
            // 
            // comboBox_projectName
            // 
            this.comboBox_projectName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_projectName.FormattingEnabled = true;
            this.comboBox_projectName.Location = new System.Drawing.Point(214, 98);
            this.comboBox_projectName.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox_projectName.Name = "comboBox_projectName";
            this.comboBox_projectName.Size = new System.Drawing.Size(194, 20);
            this.comboBox_projectName.TabIndex = 8;
            this.comboBox_projectName.SelectedIndexChanged += new System.EventHandler(this.comboBox_projectName_SelectedIndexChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(214, 146);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(73, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "查看报表";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(13, 19);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "查看报表";
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
            this.page_personalInformation.Location = new System.Drawing.Point(4, 22);
            this.page_personalInformation.Margin = new System.Windows.Forms.Padding(2);
            this.page_personalInformation.Name = "page_personalInformation";
            this.page_personalInformation.Padding = new System.Windows.Forms.Padding(2);
            this.page_personalInformation.Size = new System.Drawing.Size(564, 336);
            this.page_personalInformation.TabIndex = 2;
            this.page_personalInformation.Text = "个人资料";
            this.page_personalInformation.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(396, 134);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(80, 41);
            this.button3.TabIndex = 37;
            this.button3.Text = "修改";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(152, 274);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(150, 21);
            this.textBox6.TabIndex = 36;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(152, 41);
            this.textBox7.Name = "textBox7";
            this.textBox7.ReadOnly = true;
            this.textBox7.Size = new System.Drawing.Size(100, 21);
            this.textBox7.TabIndex = 30;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(152, 225);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 21);
            this.textBox5.TabIndex = 35;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(88, 44);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(17, 12);
            this.label10.TabIndex = 25;
            this.label10.Text = "ID";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(152, 181);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(100, 21);
            this.textBox4.TabIndex = 34;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(88, 134);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 12);
            this.label9.TabIndex = 26;
            this.label9.Text = "密码";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(152, 132);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 21);
            this.textBox3.TabIndex = 33;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(88, 87);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 12);
            this.label8.TabIndex = 27;
            this.label8.Text = "用户名";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(152, 87);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(100, 21);
            this.textBox2.TabIndex = 32;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(88, 183);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 12);
            this.label7.TabIndex = 28;
            this.label7.Text = "类型";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(88, 277);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 12);
            this.label6.TabIndex = 31;
            this.label6.Text = "Email";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(88, 228);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(29, 12);
            this.label11.TabIndex = 29;
            this.label11.Text = "电话";
            // 
            // ProjectManagerMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 398);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
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
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridViewTextBoxColumn project_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn plan_Name;
        private System.Windows.Forms.DataGridViewButtonColumn button_viewProject;
        private System.Windows.Forms.DataGridViewButtonColumn Column_plan;
    }
}