namespace BugPractice1_4
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button2 = new System.Windows.Forms.Button();
            this.btn_sign_in = new System.Windows.Forms.Button();
            this.label_user = new System.Windows.Forms.Label();
            this.user_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.user_password = new System.Windows.Forms.TextBox();
            this.label_register = new System.Windows.Forms.Label();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Enabled = false;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(34, 438);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 29);
            this.button2.TabIndex = 1;
            this.button2.Text = "注册";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Visible = false;
            // 
            // btn_sign_in
            // 
            this.btn_sign_in.BackColor = System.Drawing.Color.Red;
            this.btn_sign_in.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_sign_in.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_sign_in.Font = new System.Drawing.Font("幼圆", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_sign_in.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btn_sign_in.Location = new System.Drawing.Point(34, 347);
            this.btn_sign_in.Name = "btn_sign_in";
            this.btn_sign_in.Size = new System.Drawing.Size(358, 71);
            this.btn_sign_in.TabIndex = 0;
            this.btn_sign_in.Text = "登录";
            this.btn_sign_in.UseVisualStyleBackColor = false;
            this.btn_sign_in.Click += new System.EventHandler(this.button1_Click);
            // 
            // label_user
            // 
            this.label_user.AutoSize = true;
            this.label_user.Location = new System.Drawing.Point(31, 44);
            this.label_user.Name = "label_user";
            this.label_user.Size = new System.Drawing.Size(52, 15);
            this.label_user.TabIndex = 2;
            this.label_user.Text = "用户名";
            this.label_user.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // user_name
            // 
            this.user_name.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.user_name.ForeColor = System.Drawing.Color.Black;
            this.user_name.Location = new System.Drawing.Point(34, 73);
            this.user_name.Multiline = true;
            this.user_name.Name = "user_name";
            this.user_name.Size = new System.Drawing.Size(358, 48);
            this.user_name.TabIndex = 3;
            this.user_name.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 190);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "密码";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // user_password
            // 
            this.user_password.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.user_password.ForeColor = System.Drawing.Color.Black;
            this.user_password.Location = new System.Drawing.Point(34, 219);
            this.user_password.Multiline = true;
            this.user_password.Name = "user_password";
            this.user_password.PasswordChar = '*';
            this.user_password.Size = new System.Drawing.Size(358, 48);
            this.user_password.TabIndex = 5;
            // 
            // label_register
            // 
            this.label_register.AutoSize = true;
            this.label_register.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_register.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_register.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label_register.Location = new System.Drawing.Point(334, 443);
            this.label_register.Name = "label_register";
            this.label_register.Size = new System.Drawing.Size(58, 24);
            this.label_register.TabIndex = 6;
            this.label_register.Text = "注册";
            this.label_register.Click += new System.EventHandler(this.label_register_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(457, 547);
            this.Controls.Add(this.label_register);
            this.Controls.Add(this.user_password);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.user_name);
            this.Controls.Add(this.label_user);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_sign_in);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "欢迎登录缺陷管理系统";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn_sign_in;
        private System.Windows.Forms.Label label_user;
        public System.Windows.Forms.TextBox user_name;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox user_password;
        private System.Windows.Forms.Label label_register;
        private System.Windows.Forms.FontDialog fontDialog1;
    }
}

