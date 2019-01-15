namespace BugPractice1_4
{
    partial class BugAnalysisForm
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
            this.dataGrid_waiting_bug = new System.Windows.Forms.DataGridView();
            this.bug_ays_lbl_sel_id = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.bug_analysis_main_text = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.bug_analysis_desc = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.bug_analysis_btn_update = new System.Windows.Forms.Button();
            this.bug_analysis_status = new System.Windows.Forms.ComboBox();
            this.label23 = new System.Windows.Forms.Label();
            this.bug_analysis_bugReason = new System.Windows.Forms.ComboBox();
            this.bug_bug_analysis_refresh = new System.Windows.Forms.Label();
            this.bug_analysis_status_select = new System.Windows.Forms.ComboBox();
            this.bug_ays_version_combo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button_exit = new System.Windows.Forms.Button();
            this.button_logOut = new System.Windows.Forms.Button();
            this.label_userType = new System.Windows.Forms.Label();
            this.label_username = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.bug_ays_change_user_info = new System.Windows.Forms.Button();
            this.text_change_user_email = new System.Windows.Forms.TextBox();
            this.text_change_user_id = new System.Windows.Forms.TextBox();
            this.text_change_phoneNums = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.text_change_user_type = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.text_change_user_password = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.text_change_user_name = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_waiting_bug)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGrid_waiting_bug
            // 
            this.dataGrid_waiting_bug.AllowUserToAddRows = false;
            this.dataGrid_waiting_bug.BackgroundColor = System.Drawing.Color.White;
            this.dataGrid_waiting_bug.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_waiting_bug.Location = new System.Drawing.Point(6, 35);
            this.dataGrid_waiting_bug.Name = "dataGrid_waiting_bug";
            this.dataGrid_waiting_bug.ReadOnly = true;
            this.dataGrid_waiting_bug.RowTemplate.Height = 27;
            this.dataGrid_waiting_bug.Size = new System.Drawing.Size(715, 135);
            this.dataGrid_waiting_bug.TabIndex = 33;
            this.dataGrid_waiting_bug.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_waiting_bug_CellClick);
            // 
            // bug_ays_lbl_sel_id
            // 
            this.bug_ays_lbl_sel_id.AutoSize = true;
            this.bug_ays_lbl_sel_id.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bug_ays_lbl_sel_id.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bug_ays_lbl_sel_id.ForeColor = System.Drawing.Color.Blue;
            this.bug_ays_lbl_sel_id.Location = new System.Drawing.Point(158, 182);
            this.bug_ays_lbl_sel_id.Name = "bug_ays_lbl_sel_id";
            this.bug_ays_lbl_sel_id.Size = new System.Drawing.Size(0, 20);
            this.bug_ays_lbl_sel_id.TabIndex = 35;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(6, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 20);
            this.label2.TabIndex = 36;
            this.label2.Text = "选定bug id:";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.ForeColor = System.Drawing.Color.Red;
            this.label22.Location = new System.Drawing.Point(121, 329);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(0, 15);
            this.label22.TabIndex = 46;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.ForeColor = System.Drawing.Color.Red;
            this.label20.Location = new System.Drawing.Point(119, 303);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(0, 15);
            this.label20.TabIndex = 45;
            // 
            // bug_analysis_main_text
            // 
            this.bug_analysis_main_text.BackColor = System.Drawing.Color.White;
            this.bug_analysis_main_text.Location = new System.Drawing.Point(20, 341);
            this.bug_analysis_main_text.Multiline = true;
            this.bug_analysis_main_text.Name = "bug_analysis_main_text";
            this.bug_analysis_main_text.Size = new System.Drawing.Size(333, 132);
            this.bug_analysis_main_text.TabIndex = 44;
            this.bug_analysis_main_text.TextChanged += new System.EventHandler(this.bug_analysis_main_text_TextChanged);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(17, 303);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(151, 15);
            this.label21.TabIndex = 43;
            this.label21.Text = "Bug分析（请填写）：";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.ForeColor = System.Drawing.Color.Red;
            this.label17.Location = new System.Drawing.Point(458, 197);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(0, 15);
            this.label17.TabIndex = 42;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(17, 242);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(137, 15);
            this.label19.TabIndex = 40;
            this.label19.Text = "Bug原因(请选择)：";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.Red;
            this.label13.Location = new System.Drawing.Point(458, 6);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(0, 15);
            this.label13.TabIndex = 39;
            // 
            // bug_analysis_desc
            // 
            this.bug_analysis_desc.BackColor = System.Drawing.Color.White;
            this.bug_analysis_desc.Location = new System.Drawing.Point(374, 338);
            this.bug_analysis_desc.Multiline = true;
            this.bug_analysis_desc.Name = "bug_analysis_desc";
            this.bug_analysis_desc.ReadOnly = true;
            this.bug_analysis_desc.Size = new System.Drawing.Size(347, 135);
            this.bug_analysis_desc.TabIndex = 38;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(371, 303);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(76, 15);
            this.label15.TabIndex = 37;
            this.label15.Text = "Bug描述：";
            // 
            // bug_analysis_btn_update
            // 
            this.bug_analysis_btn_update.BackColor = System.Drawing.Color.Red;
            this.bug_analysis_btn_update.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bug_analysis_btn_update.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bug_analysis_btn_update.Font = new System.Drawing.Font("幼圆", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bug_analysis_btn_update.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.bug_analysis_btn_update.Location = new System.Drawing.Point(374, 501);
            this.bug_analysis_btn_update.Name = "bug_analysis_btn_update";
            this.bug_analysis_btn_update.Size = new System.Drawing.Size(347, 56);
            this.bug_analysis_btn_update.TabIndex = 49;
            this.bug_analysis_btn_update.Text = "提交修复报告";
            this.bug_analysis_btn_update.UseVisualStyleBackColor = false;
            this.bug_analysis_btn_update.Click += new System.EventHandler(this.bug_analysis_btn_update_Click);
            // 
            // bug_analysis_status
            // 
            this.bug_analysis_status.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.bug_analysis_status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.bug_analysis_status.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bug_analysis_status.ForeColor = System.Drawing.Color.Black;
            this.bug_analysis_status.FormattingEnabled = true;
            this.bug_analysis_status.Items.AddRange(new object[] {
            "待修复",
            "待确认修复"});
            this.bug_analysis_status.Location = new System.Drawing.Point(148, 501);
            this.bug_analysis_status.Name = "bug_analysis_status";
            this.bug_analysis_status.Size = new System.Drawing.Size(121, 33);
            this.bug_analysis_status.TabIndex = 48;
            this.bug_analysis_status.SelectedIndexChanged += new System.EventHandler(this.bug_analysis_status_SelectedIndexChanged);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(25, 519);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(106, 15);
            this.label23.TabIndex = 47;
            this.label23.Text = "更改bug状态：";
            // 
            // bug_analysis_bugReason
            // 
            this.bug_analysis_bugReason.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.bug_analysis_bugReason.FormattingEnabled = true;
            this.bug_analysis_bugReason.Items.AddRange(new object[] {
            "功能问题",
            "接口问题",
            "逻辑问题",
            "计算问题",
            "数据问题",
            "用户界面问题",
            "文档问题",
            "性能问题",
            "兼容问题",
            "其他问题"});
            this.bug_analysis_bugReason.Location = new System.Drawing.Point(160, 235);
            this.bug_analysis_bugReason.Name = "bug_analysis_bugReason";
            this.bug_analysis_bugReason.Size = new System.Drawing.Size(193, 23);
            this.bug_analysis_bugReason.TabIndex = 50;
            this.bug_analysis_bugReason.SelectedIndexChanged += new System.EventHandler(this.bug_analysis_bugReason_SelectedIndexChanged);
            // 
            // bug_bug_analysis_refresh
            // 
            this.bug_bug_analysis_refresh.AutoSize = true;
            this.bug_bug_analysis_refresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bug_bug_analysis_refresh.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bug_bug_analysis_refresh.ForeColor = System.Drawing.Color.Blue;
            this.bug_bug_analysis_refresh.Location = new System.Drawing.Point(657, 6);
            this.bug_bug_analysis_refresh.Name = "bug_bug_analysis_refresh";
            this.bug_bug_analysis_refresh.Size = new System.Drawing.Size(49, 20);
            this.bug_bug_analysis_refresh.TabIndex = 51;
            this.bug_bug_analysis_refresh.Text = "刷新";
            this.bug_bug_analysis_refresh.Click += new System.EventHandler(this.bug_bug_analysis_refresh_Click);
            // 
            // bug_analysis_status_select
            // 
            this.bug_analysis_status_select.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.bug_analysis_status_select.FormattingEnabled = true;
            this.bug_analysis_status_select.Items.AddRange(new object[] {
            "查看待修复缺陷:",
            "查看待确认修复缺陷:",
            "查看已修复缺陷"});
            this.bug_analysis_status_select.Location = new System.Drawing.Point(6, 6);
            this.bug_analysis_status_select.Name = "bug_analysis_status_select";
            this.bug_analysis_status_select.Size = new System.Drawing.Size(148, 23);
            this.bug_analysis_status_select.TabIndex = 52;
            this.bug_analysis_status_select.SelectedIndexChanged += new System.EventHandler(this.bug_analysis_status_select_SelectedIndexChanged);
            // 
            // bug_ays_version_combo
            // 
            this.bug_ays_version_combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.bug_ays_version_combo.FormattingEnabled = true;
            this.bug_ays_version_combo.Location = new System.Drawing.Point(461, 235);
            this.bug_ays_version_combo.Name = "bug_ays_version_combo";
            this.bug_ays_version_combo.Size = new System.Drawing.Size(121, 23);
            this.bug_ays_version_combo.TabIndex = 53;
            this.bug_ays_version_combo.SelectedIndexChanged += new System.EventHandler(this.bug_ays_version_combo_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(371, 242);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 54;
            this.label1.Text = "版本选择：";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(15, 14);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(763, 452);
            this.tabControl1.TabIndex = 55;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button_exit);
            this.tabPage1.Controls.Add(this.button_logOut);
            this.tabPage1.Controls.Add(this.label_userType);
            this.tabPage1.Controls.Add(this.label_username);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(755, 423);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "首页";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button_exit
            // 
            this.button_exit.Location = new System.Drawing.Point(391, 311);
            this.button_exit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(108, 39);
            this.button_exit.TabIndex = 11;
            this.button_exit.Text = "退出";
            this.button_exit.UseVisualStyleBackColor = true;
            this.button_exit.Click += new System.EventHandler(this.button_exit_Click);
            // 
            // button_logOut
            // 
            this.button_logOut.Location = new System.Drawing.Point(229, 311);
            this.button_logOut.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_logOut.Name = "button_logOut";
            this.button_logOut.Size = new System.Drawing.Size(108, 39);
            this.button_logOut.TabIndex = 10;
            this.button_logOut.Text = "注销登录";
            this.button_logOut.UseVisualStyleBackColor = true;
            this.button_logOut.Click += new System.EventHandler(this.button_logOut_Click_1);
            // 
            // label_userType
            // 
            this.label_userType.AutoSize = true;
            this.label_userType.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_userType.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label_userType.Location = new System.Drawing.Point(405, 238);
            this.label_userType.Name = "label_userType";
            this.label_userType.Size = new System.Drawing.Size(67, 25);
            this.label_userType.TabIndex = 9;
            this.label_userType.Text = "label5";
            // 
            // label_username
            // 
            this.label_username.AutoSize = true;
            this.label_username.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_username.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label_username.Location = new System.Drawing.Point(405, 190);
            this.label_username.Name = "label_username";
            this.label_username.Size = new System.Drawing.Size(67, 25);
            this.label_username.TabIndex = 8;
            this.label_username.Text = "label4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(258, 238);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "您的用户类型：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(273, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "您的用户名：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(214, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(323, 36);
            this.label5.TabIndex = 5;
            this.label5.Text = "欢迎进入缺陷管理系统！";
            // 
            // tabPage2
            // 
            this.tabPage2.AutoScroll = true;
            this.tabPage2.Controls.Add(this.dataGrid_waiting_bug);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.bug_ays_lbl_sel_id);
            this.tabPage2.Controls.Add(this.bug_ays_version_combo);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.bug_analysis_status_select);
            this.tabPage2.Controls.Add(this.label15);
            this.tabPage2.Controls.Add(this.bug_bug_analysis_refresh);
            this.tabPage2.Controls.Add(this.bug_analysis_desc);
            this.tabPage2.Controls.Add(this.bug_analysis_bugReason);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.bug_analysis_btn_update);
            this.tabPage2.Controls.Add(this.label19);
            this.tabPage2.Controls.Add(this.bug_analysis_status);
            this.tabPage2.Controls.Add(this.label17);
            this.tabPage2.Controls.Add(this.label23);
            this.tabPage2.Controls.Add(this.label21);
            this.tabPage2.Controls.Add(this.label22);
            this.tabPage2.Controls.Add(this.bug_analysis_main_text);
            this.tabPage2.Controls.Add(this.label20);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(755, 423);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "我的工作";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.bug_ays_change_user_info);
            this.tabPage3.Controls.Add(this.text_change_user_email);
            this.tabPage3.Controls.Add(this.text_change_user_id);
            this.tabPage3.Controls.Add(this.text_change_phoneNums);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Controls.Add(this.text_change_user_type);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.text_change_user_password);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.text_change_user_name);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(755, 423);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "个人资料";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // bug_ays_change_user_info
            // 
            this.bug_ays_change_user_info.Location = new System.Drawing.Point(496, 165);
            this.bug_ays_change_user_info.Margin = new System.Windows.Forms.Padding(4);
            this.bug_ays_change_user_info.Name = "bug_ays_change_user_info";
            this.bug_ays_change_user_info.Size = new System.Drawing.Size(107, 51);
            this.bug_ays_change_user_info.TabIndex = 37;
            this.bug_ays_change_user_info.Text = "修改";
            this.bug_ays_change_user_info.UseVisualStyleBackColor = true;
            this.bug_ays_change_user_info.Click += new System.EventHandler(this.bug_ays_change_user_info_Click);
            // 
            // text_change_user_email
            // 
            this.text_change_user_email.Location = new System.Drawing.Point(171, 340);
            this.text_change_user_email.Margin = new System.Windows.Forms.Padding(4);
            this.text_change_user_email.Name = "text_change_user_email";
            this.text_change_user_email.Size = new System.Drawing.Size(171, 25);
            this.text_change_user_email.TabIndex = 36;
            // 
            // text_change_user_id
            // 
            this.text_change_user_id.Location = new System.Drawing.Point(171, 49);
            this.text_change_user_id.Margin = new System.Windows.Forms.Padding(4);
            this.text_change_user_id.Name = "text_change_user_id";
            this.text_change_user_id.ReadOnly = true;
            this.text_change_user_id.Size = new System.Drawing.Size(132, 25);
            this.text_change_user_id.TabIndex = 30;
            // 
            // text_change_phoneNums
            // 
            this.text_change_phoneNums.Location = new System.Drawing.Point(171, 279);
            this.text_change_phoneNums.Margin = new System.Windows.Forms.Padding(4);
            this.text_change_phoneNums.Name = "text_change_phoneNums";
            this.text_change_phoneNums.Size = new System.Drawing.Size(132, 25);
            this.text_change_phoneNums.TabIndex = 35;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(85, 52);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(23, 15);
            this.label10.TabIndex = 25;
            this.label10.Text = "ID";
            // 
            // text_change_user_type
            // 
            this.text_change_user_type.Location = new System.Drawing.Point(171, 215);
            this.text_change_user_type.Margin = new System.Windows.Forms.Padding(4);
            this.text_change_user_type.Name = "text_change_user_type";
            this.text_change_user_type.ReadOnly = true;
            this.text_change_user_type.Size = new System.Drawing.Size(132, 25);
            this.text_change_user_type.TabIndex = 34;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(85, 165);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 15);
            this.label9.TabIndex = 26;
            this.label9.Text = "密码";
            // 
            // text_change_user_password
            // 
            this.text_change_user_password.Location = new System.Drawing.Point(171, 165);
            this.text_change_user_password.Margin = new System.Windows.Forms.Padding(4);
            this.text_change_user_password.Name = "text_change_user_password";
            this.text_change_user_password.Size = new System.Drawing.Size(132, 25);
            this.text_change_user_password.TabIndex = 33;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(85, 106);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 15);
            this.label8.TabIndex = 27;
            this.label8.Text = "用户名";
            // 
            // text_change_user_name
            // 
            this.text_change_user_name.Location = new System.Drawing.Point(171, 106);
            this.text_change_user_name.Margin = new System.Windows.Forms.Padding(4);
            this.text_change_user_name.Name = "text_change_user_name";
            this.text_change_user_name.Size = new System.Drawing.Size(132, 25);
            this.text_change_user_name.TabIndex = 32;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(85, 226);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 15);
            this.label7.TabIndex = 28;
            this.label7.Text = "类型";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(85, 344);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 15);
            this.label6.TabIndex = 31;
            this.label6.Text = "Email";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(85, 282);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(37, 15);
            this.label11.TabIndex = 29;
            this.label11.Text = "电话";
            // 
            // BugAnalysisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(948, 498);
            this.Controls.Add(this.tabControl1);
            this.Name = "BugAnalysisForm";
            this.Text = "BugAnalysisForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.BugAnalysisForm_FormClosed);
            this.Load += new System.EventHandler(this.BugAnalysisForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_waiting_bug)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGrid_waiting_bug;
        private System.Windows.Forms.Label bug_ays_lbl_sel_id;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox bug_analysis_main_text;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox bug_analysis_desc;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button bug_analysis_btn_update;
        private System.Windows.Forms.ComboBox bug_analysis_status;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.ComboBox bug_analysis_bugReason;
        private System.Windows.Forms.Label bug_bug_analysis_refresh;
        private System.Windows.Forms.ComboBox bug_analysis_status_select;
        private System.Windows.Forms.ComboBox bug_ays_version_combo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label_userType;
        private System.Windows.Forms.Label label_username;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button_logOut;
        private System.Windows.Forms.Button button_exit;
        private System.Windows.Forms.Button bug_ays_change_user_info;
        private System.Windows.Forms.TextBox text_change_user_email;
        private System.Windows.Forms.TextBox text_change_user_id;
        private System.Windows.Forms.TextBox text_change_phoneNums;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox text_change_user_type;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox text_change_user_password;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox text_change_user_name;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label11;
    }
}