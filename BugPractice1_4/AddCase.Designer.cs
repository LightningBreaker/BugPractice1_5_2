namespace BugPractice1_4
{
    partial class AddCase
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
            this.comboBox_priority = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button_giveUp = new System.Windows.Forms.Button();
            this.button_nextPage = new System.Windows.Forms.Button();
            this.label_descriptionError = new System.Windows.Forms.Label();
            this.label_nameError = new System.Windows.Forms.Label();
            this.textBox_description = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_caseName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_step = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBox_priority
            // 
            this.comboBox_priority.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_priority.FormattingEnabled = true;
            this.comboBox_priority.Items.AddRange(new object[] {
            "次要",
            "一般",
            "紧急"});
            this.comboBox_priority.Location = new System.Drawing.Point(428, 62);
            this.comboBox_priority.MaxDropDownItems = 15;
            this.comboBox_priority.Name = "comboBox_priority";
            this.comboBox_priority.Size = new System.Drawing.Size(235, 23);
            this.comboBox_priority.TabIndex = 61;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(425, 36);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 15);
            this.label7.TabIndex = 60;
            this.label7.Text = "测试优先级(*)：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(143, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 15);
            this.label5.TabIndex = 58;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(128, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 15);
            this.label6.TabIndex = 57;
            // 
            // button_giveUp
            // 
            this.button_giveUp.Location = new System.Drawing.Point(428, 458);
            this.button_giveUp.Name = "button_giveUp";
            this.button_giveUp.Size = new System.Drawing.Size(235, 33);
            this.button_giveUp.TabIndex = 55;
            this.button_giveUp.Text = "放弃添加";
            this.button_giveUp.UseVisualStyleBackColor = true;
            this.button_giveUp.Click += new System.EventHandler(this.button_giveUp_Click);
            // 
            // button_nextPage
            // 
            this.button_nextPage.Location = new System.Drawing.Point(38, 458);
            this.button_nextPage.Name = "button_nextPage";
            this.button_nextPage.Size = new System.Drawing.Size(235, 33);
            this.button_nextPage.TabIndex = 54;
            this.button_nextPage.Text = "确认添加";
            this.button_nextPage.UseVisualStyleBackColor = true;
            this.button_nextPage.Click += new System.EventHandler(this.button_nextPage_Click);
            // 
            // label_descriptionError
            // 
            this.label_descriptionError.AutoSize = true;
            this.label_descriptionError.ForeColor = System.Drawing.Color.Red;
            this.label_descriptionError.Location = new System.Drawing.Point(137, 115);
            this.label_descriptionError.Name = "label_descriptionError";
            this.label_descriptionError.Size = new System.Drawing.Size(0, 15);
            this.label_descriptionError.TabIndex = 51;
            // 
            // label_nameError
            // 
            this.label_nameError.AutoSize = true;
            this.label_nameError.ForeColor = System.Drawing.Color.Red;
            this.label_nameError.Location = new System.Drawing.Point(122, 36);
            this.label_nameError.Name = "label_nameError";
            this.label_nameError.Size = new System.Drawing.Size(0, 15);
            this.label_nameError.TabIndex = 50;
            // 
            // textBox_description
            // 
            this.textBox_description.Location = new System.Drawing.Point(38, 138);
            this.textBox_description.Multiline = true;
            this.textBox_description.Name = "textBox_description";
            this.textBox_description.Size = new System.Drawing.Size(625, 108);
            this.textBox_description.TabIndex = 48;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 15);
            this.label2.TabIndex = 47;
            this.label2.Text = "用例描述(*)：";
            // 
            // textBox_caseName
            // 
            this.textBox_caseName.Location = new System.Drawing.Point(38, 60);
            this.textBox_caseName.Name = "textBox_caseName";
            this.textBox_caseName.Size = new System.Drawing.Size(235, 25);
            this.textBox_caseName.TabIndex = 46;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 15);
            this.label1.TabIndex = 45;
            this.label1.Text = "用例名(*)：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(143, 249);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 15);
            this.label3.TabIndex = 65;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(137, 249);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 15);
            this.label4.TabIndex = 64;
            // 
            // textBox_step
            // 
            this.textBox_step.Location = new System.Drawing.Point(38, 287);
            this.textBox_step.Multiline = true;
            this.textBox_step.Name = "textBox_step";
            this.textBox_step.Size = new System.Drawing.Size(625, 138);
            this.textBox_step.TabIndex = 63;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(37, 262);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 15);
            this.label8.TabIndex = 62;
            this.label8.Text = "测试步骤(*)：";
            // 
            // AddCase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 525);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_step);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.comboBox_priority);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button_giveUp);
            this.Controls.Add(this.button_nextPage);
            this.Controls.Add(this.label_descriptionError);
            this.Controls.Add(this.label_nameError);
            this.Controls.Add(this.textBox_description);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_caseName);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddCase";
            this.Text = "添加用例";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_priority;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button_giveUp;
        private System.Windows.Forms.Button button_nextPage;
        private System.Windows.Forms.Label label_descriptionError;
        private System.Windows.Forms.Label label_nameError;
        private System.Windows.Forms.TextBox textBox_description;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_caseName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_step;
        private System.Windows.Forms.Label label8;
    }
}