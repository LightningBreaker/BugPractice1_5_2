namespace BugPractice1_4
{
    partial class ReleaseProject
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_projectName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_description = new System.Windows.Forms.TextBox();
            this.textBox_managerID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button_nextPage = new System.Windows.Forms.Button();
            this.label_nameError = new System.Windows.Forms.Label();
            this.label_descriptionError = new System.Windows.Forms.Label();
            this.button_giveUp = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox_managerName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "项目名(*)：";
            // 
            // textBox_projectName
            // 
            this.textBox_projectName.Location = new System.Drawing.Point(43, 85);
            this.textBox_projectName.Name = "textBox_projectName";
            this.textBox_projectName.Size = new System.Drawing.Size(347, 25);
            this.textBox_projectName.TabIndex = 1;
            this.textBox_projectName.TextChanged += new System.EventHandler(this.textBox_projectName_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "项目描述(*)：";
            // 
            // textBox_description
            // 
            this.textBox_description.Location = new System.Drawing.Point(43, 163);
            this.textBox_description.Multiline = true;
            this.textBox_description.Name = "textBox_description";
            this.textBox_description.Size = new System.Drawing.Size(347, 86);
            this.textBox_description.TabIndex = 4;
            this.textBox_description.TextChanged += new System.EventHandler(this.textBox_description_TextChanged);
            // 
            // textBox_managerID
            // 
            this.textBox_managerID.Location = new System.Drawing.Point(43, 298);
            this.textBox_managerID.Name = "textBox_managerID";
            this.textBox_managerID.ReadOnly = true;
            this.textBox_managerID.Size = new System.Drawing.Size(157, 25);
            this.textBox_managerID.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 274);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "项目负责人ID：";
            // 
            // button_nextPage
            // 
            this.button_nextPage.Location = new System.Drawing.Point(43, 366);
            this.button_nextPage.Name = "button_nextPage";
            this.button_nextPage.Size = new System.Drawing.Size(157, 33);
            this.button_nextPage.TabIndex = 7;
            this.button_nextPage.Text = "下一页>>";
            this.button_nextPage.UseVisualStyleBackColor = true;
            this.button_nextPage.Click += new System.EventHandler(this.button_nextPage_Click);
            // 
            // label_nameError
            // 
            this.label_nameError.AutoSize = true;
            this.label_nameError.ForeColor = System.Drawing.Color.Red;
            this.label_nameError.Location = new System.Drawing.Point(127, 61);
            this.label_nameError.Name = "label_nameError";
            this.label_nameError.Size = new System.Drawing.Size(0, 15);
            this.label_nameError.TabIndex = 8;
            // 
            // label_descriptionError
            // 
            this.label_descriptionError.AutoSize = true;
            this.label_descriptionError.ForeColor = System.Drawing.Color.Red;
            this.label_descriptionError.Location = new System.Drawing.Point(142, 140);
            this.label_descriptionError.Name = "label_descriptionError";
            this.label_descriptionError.Size = new System.Drawing.Size(0, 15);
            this.label_descriptionError.TabIndex = 9;
            // 
            // button_giveUp
            // 
            this.button_giveUp.Location = new System.Drawing.Point(240, 366);
            this.button_giveUp.Name = "button_giveUp";
            this.button_giveUp.Size = new System.Drawing.Size(150, 33);
            this.button_giveUp.TabIndex = 10;
            this.button_giveUp.Text = "放弃发布";
            this.button_giveUp.UseVisualStyleBackColor = true;
            this.button_giveUp.Click += new System.EventHandler(this.button_giveUp_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(43, 419);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "测试连接";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox_managerName
            // 
            this.textBox_managerName.Location = new System.Drawing.Point(240, 298);
            this.textBox_managerName.Name = "textBox_managerName";
            this.textBox_managerName.ReadOnly = true;
            this.textBox_managerName.Size = new System.Drawing.Size(150, 25);
            this.textBox_managerName.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(237, 274);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "项目负责人姓名：";
            // 
            // ReleaseProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 466);
            this.Controls.Add(this.textBox_managerName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button_giveUp);
            this.Controls.Add(this.label_descriptionError);
            this.Controls.Add(this.label_nameError);
            this.Controls.Add(this.button_nextPage);
            this.Controls.Add(this.textBox_managerID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_description);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_projectName);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ReleaseProject";
            this.Text = "发布测试项目";
            this.Load += new System.EventHandler(this.ReleaseProject_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox textBox_projectName;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox textBox_description;
        public System.Windows.Forms.TextBox textBox_managerID;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Button button_nextPage;
        public System.Windows.Forms.Label label_nameError;
        public System.Windows.Forms.Label label_descriptionError;
        public System.Windows.Forms.Button button_giveUp;
        public System.Windows.Forms.Button button1;
        public System.Windows.Forms.TextBox textBox_managerName;
        public System.Windows.Forms.Label label4;
    }
}