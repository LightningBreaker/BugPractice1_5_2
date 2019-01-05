namespace BugPractice1_4
{
    partial class RegisterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.reg_user_name = new System.Windows.Forms.TextBox();
            this.reg_password1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.reg_tab_page = new System.Windows.Forms.TabControl();
            this.reg_account_page = new System.Windows.Forms.TabPage();
            this.label_reg_user = new System.Windows.Forms.Label();
            this.reg_btn_next1 = new System.Windows.Forms.Button();
            this.reg_info_page = new System.Windows.Forms.TabPage();
            this.reg_btn_next2 = new System.Windows.Forms.Button();
            this.reg_telephone = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.reg_password2 = new System.Windows.Forms.TextBox();
            this.reg_email = new System.Windows.Forms.TextBox();
            this.reg_result_page = new System.Windows.Forms.TabPage();
            this.reg_combo_type = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.reg_waiting = new System.Windows.Forms.Button();
            this.reg_lable_pass1 = new System.Windows.Forms.Label();
            this.reg_label_pass2 = new System.Windows.Forms.Label();
            this.reg_label_email = new System.Windows.Forms.Label();
            this.reg_label_phone = new System.Windows.Forms.Label();
            this.reg_tab_page.SuspendLayout();
            this.reg_account_page.SuspendLayout();
            this.reg_info_page.SuspendLayout();
            this.reg_result_page.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "用户名";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "密码";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "确认密码";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // reg_user_name
            // 
            this.reg_user_name.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.reg_user_name.ForeColor = System.Drawing.Color.Black;
            this.reg_user_name.Location = new System.Drawing.Point(37, 109);
            this.reg_user_name.Multiline = true;
            this.reg_user_name.Name = "reg_user_name";
            this.reg_user_name.Size = new System.Drawing.Size(358, 48);
            this.reg_user_name.TabIndex = 4;
            this.reg_user_name.TextChanged += new System.EventHandler(this.reg_user_name_TextChanged);
            // 
            // reg_password1
            // 
            this.reg_password1.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.reg_password1.ForeColor = System.Drawing.Color.Black;
            this.reg_password1.Location = new System.Drawing.Point(25, 35);
            this.reg_password1.Multiline = true;
            this.reg_password1.Name = "reg_password1";
            this.reg_password1.Size = new System.Drawing.Size(358, 48);
            this.reg_password1.TabIndex = 5;
            this.reg_password1.TextChanged += new System.EventHandler(this.reg_password1_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "邮箱";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(34, 208);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "账户类型";
            // 
            // reg_tab_page
            // 
            this.reg_tab_page.Controls.Add(this.reg_account_page);
            this.reg_tab_page.Controls.Add(this.reg_info_page);
            this.reg_tab_page.Controls.Add(this.reg_result_page);
            this.reg_tab_page.Location = new System.Drawing.Point(3, 12);
            this.reg_tab_page.Name = "reg_tab_page";
            this.reg_tab_page.SelectedIndex = 0;
            this.reg_tab_page.Size = new System.Drawing.Size(458, 534);
            this.reg_tab_page.TabIndex = 13;
            this.reg_tab_page.SelectedIndexChanged += new System.EventHandler(this.reg_tab_page_SelectedIndexChanged);
            // 
            // reg_account_page
            // 
            this.reg_account_page.BackColor = System.Drawing.Color.White;
            this.reg_account_page.Controls.Add(this.reg_combo_type);
            this.reg_account_page.Controls.Add(this.label_reg_user);
            this.reg_account_page.Controls.Add(this.reg_btn_next1);
            this.reg_account_page.Controls.Add(this.label1);
            this.reg_account_page.Controls.Add(this.reg_user_name);
            this.reg_account_page.Controls.Add(this.label6);
            this.reg_account_page.Location = new System.Drawing.Point(4, 25);
            this.reg_account_page.Name = "reg_account_page";
            this.reg_account_page.Padding = new System.Windows.Forms.Padding(3);
            this.reg_account_page.Size = new System.Drawing.Size(450, 505);
            this.reg_account_page.TabIndex = 0;
            this.reg_account_page.Text = "创建账号";
            // 
            // label_reg_user
            // 
            this.label_reg_user.AutoSize = true;
            this.label_reg_user.ForeColor = System.Drawing.Color.Blue;
            this.label_reg_user.Location = new System.Drawing.Point(34, 176);
            this.label_reg_user.Name = "label_reg_user";
            this.label_reg_user.Size = new System.Drawing.Size(0, 15);
            this.label_reg_user.TabIndex = 14;
            // 
            // reg_btn_next1
            // 
            this.reg_btn_next1.BackColor = System.Drawing.Color.Red;
            this.reg_btn_next1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.reg_btn_next1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.reg_btn_next1.Font = new System.Drawing.Font("幼圆", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.reg_btn_next1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.reg_btn_next1.Location = new System.Drawing.Point(37, 387);
            this.reg_btn_next1.Name = "reg_btn_next1";
            this.reg_btn_next1.Size = new System.Drawing.Size(358, 71);
            this.reg_btn_next1.TabIndex = 13;
            this.reg_btn_next1.Text = "下一步";
            this.reg_btn_next1.UseVisualStyleBackColor = false;
            this.reg_btn_next1.Click += new System.EventHandler(this.reg_btn_next1_Click);
            // 
            // reg_info_page
            // 
            this.reg_info_page.Controls.Add(this.reg_label_phone);
            this.reg_info_page.Controls.Add(this.reg_label_email);
            this.reg_info_page.Controls.Add(this.reg_label_pass2);
            this.reg_info_page.Controls.Add(this.reg_lable_pass1);
            this.reg_info_page.Controls.Add(this.reg_btn_next2);
            this.reg_info_page.Controls.Add(this.reg_telephone);
            this.reg_info_page.Controls.Add(this.label5);
            this.reg_info_page.Controls.Add(this.reg_password2);
            this.reg_info_page.Controls.Add(this.label2);
            this.reg_info_page.Controls.Add(this.label4);
            this.reg_info_page.Controls.Add(this.reg_email);
            this.reg_info_page.Controls.Add(this.label3);
            this.reg_info_page.Controls.Add(this.reg_password1);
            this.reg_info_page.Location = new System.Drawing.Point(4, 25);
            this.reg_info_page.Name = "reg_info_page";
            this.reg_info_page.Padding = new System.Windows.Forms.Padding(3);
            this.reg_info_page.Size = new System.Drawing.Size(450, 505);
            this.reg_info_page.TabIndex = 1;
            this.reg_info_page.Text = "基本信息";
            this.reg_info_page.UseVisualStyleBackColor = true;
            // 
            // reg_btn_next2
            // 
            this.reg_btn_next2.BackColor = System.Drawing.Color.Red;
            this.reg_btn_next2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.reg_btn_next2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.reg_btn_next2.Font = new System.Drawing.Font("幼圆", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.reg_btn_next2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.reg_btn_next2.Location = new System.Drawing.Point(25, 405);
            this.reg_btn_next2.Name = "reg_btn_next2";
            this.reg_btn_next2.Size = new System.Drawing.Size(358, 71);
            this.reg_btn_next2.TabIndex = 14;
            this.reg_btn_next2.Text = "下一步";
            this.reg_btn_next2.UseVisualStyleBackColor = false;
            this.reg_btn_next2.Click += new System.EventHandler(this.reg_btn_next2_Click);
            // 
            // reg_telephone
            // 
            this.reg_telephone.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.reg_telephone.ForeColor = System.Drawing.Color.Black;
            this.reg_telephone.Location = new System.Drawing.Point(25, 321);
            this.reg_telephone.Multiline = true;
            this.reg_telephone.Name = "reg_telephone";
            this.reg_telephone.Size = new System.Drawing.Size(358, 48);
            this.reg_telephone.TabIndex = 11;
            this.reg_telephone.TextChanged += new System.EventHandler(this.reg_telephone_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 303);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "手机号码";
            // 
            // reg_password2
            // 
            this.reg_password2.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.reg_password2.ForeColor = System.Drawing.Color.Black;
            this.reg_password2.Location = new System.Drawing.Point(25, 131);
            this.reg_password2.Multiline = true;
            this.reg_password2.Name = "reg_password2";
            this.reg_password2.Size = new System.Drawing.Size(358, 48);
            this.reg_password2.TabIndex = 9;
            this.reg_password2.TextChanged += new System.EventHandler(this.reg_password2_TextChanged);
            // 
            // reg_email
            // 
            this.reg_email.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.reg_email.ForeColor = System.Drawing.Color.Black;
            this.reg_email.Location = new System.Drawing.Point(25, 222);
            this.reg_email.Multiline = true;
            this.reg_email.Name = "reg_email";
            this.reg_email.Size = new System.Drawing.Size(358, 48);
            this.reg_email.TabIndex = 8;
            this.reg_email.TextChanged += new System.EventHandler(this.reg_email_TextChanged);
            // 
            // reg_result_page
            // 
            this.reg_result_page.Controls.Add(this.reg_waiting);
            this.reg_result_page.Controls.Add(this.label7);
            this.reg_result_page.Location = new System.Drawing.Point(4, 25);
            this.reg_result_page.Name = "reg_result_page";
            this.reg_result_page.Padding = new System.Windows.Forms.Padding(3);
            this.reg_result_page.Size = new System.Drawing.Size(450, 505);
            this.reg_result_page.TabIndex = 2;
            this.reg_result_page.Text = "注册结果";
            this.reg_result_page.UseVisualStyleBackColor = true;
            // 
            // reg_combo_type
            // 
            this.reg_combo_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.reg_combo_type.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.reg_combo_type.FormattingEnabled = true;
            this.reg_combo_type.Items.AddRange(new object[] {
            "系统管理员",
            "项目管理人员",
            "测试工程师",
            "软件开发工程师"});
            this.reg_combo_type.Location = new System.Drawing.Point(37, 267);
            this.reg_combo_type.Name = "reg_combo_type";
            this.reg_combo_type.Size = new System.Drawing.Size(358, 33);
            this.reg_combo_type.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.ForeColor = System.Drawing.Color.Blue;
            this.label7.Location = new System.Drawing.Point(80, 122);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(264, 28);
            this.label7.TabIndex = 0;
            this.label7.Text = "等待系统管理员审核";
            // 
            // reg_waiting
            // 
            this.reg_waiting.BackColor = System.Drawing.Color.Red;
            this.reg_waiting.Cursor = System.Windows.Forms.Cursors.Hand;
            this.reg_waiting.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.reg_waiting.Font = new System.Drawing.Font("幼圆", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.reg_waiting.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.reg_waiting.Location = new System.Drawing.Point(38, 256);
            this.reg_waiting.Name = "reg_waiting";
            this.reg_waiting.Size = new System.Drawing.Size(358, 71);
            this.reg_waiting.TabIndex = 15;
            this.reg_waiting.Text = "完成";
            this.reg_waiting.UseVisualStyleBackColor = false;
            this.reg_waiting.Click += new System.EventHandler(this.reg_waiting_Click);
            // 
            // reg_lable_pass1
            // 
            this.reg_lable_pass1.AutoSize = true;
            this.reg_lable_pass1.Location = new System.Drawing.Point(22, 86);
            this.reg_lable_pass1.Name = "reg_lable_pass1";
            this.reg_lable_pass1.Size = new System.Drawing.Size(55, 15);
            this.reg_lable_pass1.TabIndex = 15;
            this.reg_lable_pass1.Text = "label8";
            // 
            // reg_label_pass2
            // 
            this.reg_label_pass2.AutoSize = true;
            this.reg_label_pass2.Location = new System.Drawing.Point(22, 182);
            this.reg_label_pass2.Name = "reg_label_pass2";
            this.reg_label_pass2.Size = new System.Drawing.Size(55, 15);
            this.reg_label_pass2.TabIndex = 16;
            this.reg_label_pass2.Text = "label8";
            // 
            // reg_label_email
            // 
            this.reg_label_email.AutoSize = true;
            this.reg_label_email.Location = new System.Drawing.Point(22, 273);
            this.reg_label_email.Name = "reg_label_email";
            this.reg_label_email.Size = new System.Drawing.Size(55, 15);
            this.reg_label_email.TabIndex = 17;
            this.reg_label_email.Text = "label8";
            // 
            // reg_label_phone
            // 
            this.reg_label_phone.AutoSize = true;
            this.reg_label_phone.Location = new System.Drawing.Point(22, 372);
            this.reg_label_phone.Name = "reg_label_phone";
            this.reg_label_phone.Size = new System.Drawing.Size(55, 15);
            this.reg_label_phone.TabIndex = 18;
            this.reg_label_phone.Text = "label8";
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(457, 547);
            this.Controls.Add(this.reg_tab_page);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RegisterForm";
            this.Text = "欢迎注册";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.RegisterForm_FormClosed);
            this.Load += new System.EventHandler(this.RegisterForm_Load);
            this.reg_tab_page.ResumeLayout(false);
            this.reg_account_page.ResumeLayout(false);
            this.reg_account_page.PerformLayout();
            this.reg_info_page.ResumeLayout(false);
            this.reg_info_page.PerformLayout();
            this.reg_result_page.ResumeLayout(false);
            this.reg_result_page.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox reg_user_name;
        private System.Windows.Forms.TextBox reg_password1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TabControl reg_tab_page;
        private System.Windows.Forms.TabPage reg_account_page;
        private System.Windows.Forms.TabPage reg_info_page;
        private System.Windows.Forms.TabPage reg_result_page;
        private System.Windows.Forms.TextBox reg_email;
        private System.Windows.Forms.TextBox reg_password2;
        private System.Windows.Forms.Button reg_btn_next1;
        private System.Windows.Forms.Button reg_btn_next2;
        private System.Windows.Forms.TextBox reg_telephone;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label_reg_user;
        private System.Windows.Forms.ComboBox reg_combo_type;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button reg_waiting;
        private System.Windows.Forms.Label reg_label_phone;
        private System.Windows.Forms.Label reg_label_email;
        private System.Windows.Forms.Label reg_label_pass2;
        private System.Windows.Forms.Label reg_lable_pass1;
    }
}