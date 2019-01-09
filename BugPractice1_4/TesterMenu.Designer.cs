namespace BugPractice1_4
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
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.page_personalInformation = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tabPage_auditBug = new System.Windows.Forms.TabPage();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
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
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.page_homePage);
            this.tabControl1.Controls.Add(this.page_myPlan);
            this.tabControl1.Controls.Add(this.tabPage_auditBug);
            this.tabControl1.Controls.Add(this.page_personalInformation);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(762, 453);
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
            this.page_homePage.Name = "page_homePage";
            this.page_homePage.Padding = new System.Windows.Forms.Padding(3);
            this.page_homePage.Size = new System.Drawing.Size(754, 424);
            this.page_homePage.TabIndex = 0;
            this.page_homePage.Tag = "";
            this.page_homePage.Text = "首页";
            this.page_homePage.UseVisualStyleBackColor = true;
            // 
            // button_exit
            // 
            this.button_exit.Location = new System.Drawing.Point(399, 288);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(108, 39);
            this.button_exit.TabIndex = 6;
            this.button_exit.Text = "退出";
            this.button_exit.UseVisualStyleBackColor = true;
            this.button_exit.Click += new System.EventHandler(this.button_exit_Click);
            // 
            // button_logOut
            // 
            this.button_logOut.Location = new System.Drawing.Point(190, 288);
            this.button_logOut.Name = "button_logOut";
            this.button_logOut.Size = new System.Drawing.Size(108, 39);
            this.button_logOut.TabIndex = 5;
            this.button_logOut.Text = "注销登录";
            this.button_logOut.UseVisualStyleBackColor = true;
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
            this.label_username.Location = new System.Drawing.Point(375, 167);
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
            this.label2.Location = new System.Drawing.Point(243, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "您的用户名：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(184, 87);
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
            this.page_myPlan.Name = "page_myPlan";
            this.page_myPlan.Padding = new System.Windows.Forms.Padding(3);
            this.page_myPlan.Size = new System.Drawing.Size(754, 424);
            this.page_myPlan.TabIndex = 1;
            this.page_myPlan.Text = "测试任务";
            this.page_myPlan.UseVisualStyleBackColor = true;
            this.page_myPlan.Click += new System.EventHandler(this.page_myPlan_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(15, 23);
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
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.plan_ID,
            this.plan_Name,
            this.ProjectName,
            this.button_viewProject,
            this.button_viewPlan});
            this.dataGridView1.Location = new System.Drawing.Point(20, 73);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(573, 313);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // page_personalInformation
            // 
            this.page_personalInformation.Location = new System.Drawing.Point(4, 25);
            this.page_personalInformation.Name = "page_personalInformation";
            this.page_personalInformation.Padding = new System.Windows.Forms.Padding(3);
            this.page_personalInformation.Size = new System.Drawing.Size(754, 424);
            this.page_personalInformation.TabIndex = 2;
            this.page_personalInformation.Text = "个人资料";
            this.page_personalInformation.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(622, 73);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 38);
            this.button1.TabIndex = 3;
            this.button1.Text = "管理用例";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "未完成任务",
            "已完成任务"});
            this.comboBox1.Location = new System.Drawing.Point(435, 26);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(158, 23);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // tabPage_auditBug
            // 
            this.tabPage_auditBug.Controls.Add(this.comboBox2);
            this.tabPage_auditBug.Controls.Add(this.button2);
            this.tabPage_auditBug.Controls.Add(this.label5);
            this.tabPage_auditBug.Controls.Add(this.dataGridView2);
            this.tabPage_auditBug.Location = new System.Drawing.Point(4, 25);
            this.tabPage_auditBug.Name = "tabPage_auditBug";
            this.tabPage_auditBug.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_auditBug.Size = new System.Drawing.Size(754, 424);
            this.tabPage_auditBug.TabIndex = 3;
            this.tabPage_auditBug.Text = "审核修复缺陷";
            this.tabPage_auditBug.UseVisualStyleBackColor = true;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "待修复缺陷",
            "待审核缺陷",
            "已修复缺陷"});
            this.comboBox2.Location = new System.Drawing.Point(433, 27);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(162, 23);
            this.comboBox2.TabIndex = 8;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(624, 74);
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
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.Column_bugLevel,
            this.dataGridViewButtonColumn2});
            this.dataGridView2.Location = new System.Drawing.Point(22, 74);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 27;
            this.dataGridView2.Size = new System.Drawing.Size(573, 313);
            this.dataGridView2.TabIndex = 5;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            this.dataGridView2.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView2_CellFormatting);
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
            this.button_viewProject.HeaderText = "";
            this.button_viewProject.Name = "button_viewProject";
            this.button_viewProject.ReadOnly = true;
            this.button_viewProject.Text = "查看项目";
            // 
            // button_viewPlan
            // 
            this.button_viewPlan.HeaderText = "";
            this.button_viewPlan.Name = "button_viewPlan";
            this.button_viewPlan.ReadOnly = true;
            this.button_viewPlan.Text = "查看计划";
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
            this.dataGridViewButtonColumn2.HeaderText = "";
            this.dataGridViewButtonColumn2.Name = "dataGridViewButtonColumn2";
            this.dataGridViewButtonColumn2.ReadOnly = true;
            this.dataGridViewButtonColumn2.Text = "查看用例";
            // 
            // TesterMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 498);
            this.Controls.Add(this.tabControl1);
            this.Name = "TesterMenu";
            this.Text = "缺陷管理系统";
            this.tabControl1.ResumeLayout(false);
            this.page_homePage.ResumeLayout(false);
            this.page_homePage.PerformLayout();
            this.page_myPlan.ResumeLayout(false);
            this.page_myPlan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage_auditBug.ResumeLayout(false);
            this.tabPage_auditBug.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
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