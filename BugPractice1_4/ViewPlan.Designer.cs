namespace BugPractice1_4
{
    partial class ViewPlan
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
            this.label_managerError = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox_managerName = new System.Windows.Forms.ComboBox();
            this.button_giveUp = new System.Windows.Forms.Button();
            this.button_nextPage = new System.Windows.Forms.Button();
            this.textBox_managerID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label_descriptionError = new System.Windows.Forms.Label();
            this.label_nameError = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_description = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_planName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox_priority = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label_managerError
            // 
            this.label_managerError.AutoSize = true;
            this.label_managerError.ForeColor = System.Drawing.Color.Red;
            this.label_managerError.Location = new System.Drawing.Point(176, 280);
            this.label_managerError.Name = "label_managerError";
            this.label_managerError.Size = new System.Drawing.Size(0, 15);
            this.label_managerError.TabIndex = 40;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(142, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 15);
            this.label5.TabIndex = 39;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(127, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 15);
            this.label6.TabIndex = 38;
            // 
            // comboBox_managerName
            // 
            this.comboBox_managerName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_managerName.FormattingEnabled = true;
            this.comboBox_managerName.Location = new System.Drawing.Point(37, 308);
            this.comboBox_managerName.MaxDropDownItems = 15;
            this.comboBox_managerName.Name = "comboBox_managerName";
            this.comboBox_managerName.Size = new System.Drawing.Size(235, 23);
            this.comboBox_managerName.TabIndex = 37;
            this.comboBox_managerName.SelectedIndexChanged += new System.EventHandler(this.comboBox_managerName_SelectedIndexChanged);
            // 
            // button_giveUp
            // 
            this.button_giveUp.Location = new System.Drawing.Point(321, 375);
            this.button_giveUp.Name = "button_giveUp";
            this.button_giveUp.Size = new System.Drawing.Size(235, 33);
            this.button_giveUp.TabIndex = 36;
            this.button_giveUp.Text = "返回";
            this.button_giveUp.UseVisualStyleBackColor = true;
            this.button_giveUp.Click += new System.EventHandler(this.button_giveUp_Click);
            // 
            // button_nextPage
            // 
            this.button_nextPage.Location = new System.Drawing.Point(37, 375);
            this.button_nextPage.Name = "button_nextPage";
            this.button_nextPage.Size = new System.Drawing.Size(235, 33);
            this.button_nextPage.TabIndex = 35;
            this.button_nextPage.Text = "确认修改";
            this.button_nextPage.UseVisualStyleBackColor = true;
            this.button_nextPage.Click += new System.EventHandler(this.button_nextPage_Click);
            // 
            // textBox_managerID
            // 
            this.textBox_managerID.Enabled = false;
            this.textBox_managerID.Location = new System.Drawing.Point(321, 307);
            this.textBox_managerID.Name = "textBox_managerID";
            this.textBox_managerID.ReadOnly = true;
            this.textBox_managerID.Size = new System.Drawing.Size(235, 25);
            this.textBox_managerID.TabIndex = 34;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(318, 280);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 15);
            this.label4.TabIndex = 33;
            this.label4.Text = "计划负责人ID：";
            // 
            // label_descriptionError
            // 
            this.label_descriptionError.AutoSize = true;
            this.label_descriptionError.ForeColor = System.Drawing.Color.Red;
            this.label_descriptionError.Location = new System.Drawing.Point(136, 107);
            this.label_descriptionError.Name = "label_descriptionError";
            this.label_descriptionError.Size = new System.Drawing.Size(0, 15);
            this.label_descriptionError.TabIndex = 32;
            // 
            // label_nameError
            // 
            this.label_nameError.AutoSize = true;
            this.label_nameError.ForeColor = System.Drawing.Color.Red;
            this.label_nameError.Location = new System.Drawing.Point(121, 28);
            this.label_nameError.Name = "label_nameError";
            this.label_nameError.Size = new System.Drawing.Size(0, 15);
            this.label_nameError.TabIndex = 31;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 280);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 15);
            this.label3.TabIndex = 30;
            this.label3.Text = "计划负责人姓名(*)：";
            // 
            // textBox_description
            // 
            this.textBox_description.Location = new System.Drawing.Point(37, 130);
            this.textBox_description.Multiline = true;
            this.textBox_description.Name = "textBox_description";
            this.textBox_description.Size = new System.Drawing.Size(519, 126);
            this.textBox_description.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 15);
            this.label2.TabIndex = 28;
            this.label2.Text = "计划描述(*)：";
            // 
            // textBox_planName
            // 
            this.textBox_planName.Location = new System.Drawing.Point(37, 52);
            this.textBox_planName.Name = "textBox_planName";
            this.textBox_planName.Size = new System.Drawing.Size(235, 25);
            this.textBox_planName.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 15);
            this.label1.TabIndex = 26;
            this.label1.Text = "计划名(*)：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(318, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 15);
            this.label7.TabIndex = 41;
            this.label7.Text = "计划优先级(*)：";
            // 
            // comboBox_priority
            // 
            this.comboBox_priority.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_priority.FormattingEnabled = true;
            this.comboBox_priority.Items.AddRange(new object[] {
            "次要",
            "一般",
            "紧急"});
            this.comboBox_priority.Location = new System.Drawing.Point(321, 54);
            this.comboBox_priority.MaxDropDownItems = 15;
            this.comboBox_priority.Name = "comboBox_priority";
            this.comboBox_priority.Size = new System.Drawing.Size(235, 23);
            this.comboBox_priority.TabIndex = 42;
            // 
            // ViewPlan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 450);
            this.Controls.Add(this.comboBox_priority);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label_managerError);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBox_managerName);
            this.Controls.Add(this.button_giveUp);
            this.Controls.Add(this.button_nextPage);
            this.Controls.Add(this.textBox_managerID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label_descriptionError);
            this.Controls.Add(this.label_nameError);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_description);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_planName);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ViewPlan";
            this.Text = "查看计划";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_managerError;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox_managerName;
        private System.Windows.Forms.Button button_giveUp;
        private System.Windows.Forms.Button button_nextPage;
        private System.Windows.Forms.TextBox textBox_managerID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label_descriptionError;
        private System.Windows.Forms.Label label_nameError;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_description;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_planName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBox_priority;
    }
}