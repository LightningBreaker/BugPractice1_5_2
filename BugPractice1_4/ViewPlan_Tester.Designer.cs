namespace BugPractice1_4
{
    partial class ViewPlan_Tester
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
            this.label7 = new System.Windows.Forms.Label();
            this.label_managerError = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
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
            this.comboBox_priority = new System.Windows.Forms.ComboBox();
            this.textBox_manageName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(320, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 15);
            this.label7.TabIndex = 58;
            this.label7.Text = "计划优先级(*)：";
            // 
            // label_managerError
            // 
            this.label_managerError.AutoSize = true;
            this.label_managerError.ForeColor = System.Drawing.Color.Red;
            this.label_managerError.Location = new System.Drawing.Point(178, 279);
            this.label_managerError.Name = "label_managerError";
            this.label_managerError.Size = new System.Drawing.Size(0, 15);
            this.label_managerError.TabIndex = 57;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(144, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 15);
            this.label5.TabIndex = 56;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(129, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 15);
            this.label6.TabIndex = 55;
            // 
            // button_giveUp
            // 
            this.button_giveUp.Location = new System.Drawing.Point(323, 374);
            this.button_giveUp.Name = "button_giveUp";
            this.button_giveUp.Size = new System.Drawing.Size(235, 33);
            this.button_giveUp.TabIndex = 53;
            this.button_giveUp.Text = "返回";
            this.button_giveUp.UseVisualStyleBackColor = true;
            this.button_giveUp.Click += new System.EventHandler(this.button_giveUp_Click);
            // 
            // button_nextPage
            // 
            this.button_nextPage.Location = new System.Drawing.Point(39, 374);
            this.button_nextPage.Name = "button_nextPage";
            this.button_nextPage.Size = new System.Drawing.Size(235, 33);
            this.button_nextPage.TabIndex = 52;
            this.button_nextPage.Text = "添加用例";
            this.button_nextPage.UseVisualStyleBackColor = true;
            this.button_nextPage.Click += new System.EventHandler(this.button_nextPage_Click);
            // 
            // textBox_managerID
            // 
            this.textBox_managerID.Enabled = false;
            this.textBox_managerID.Location = new System.Drawing.Point(323, 306);
            this.textBox_managerID.Name = "textBox_managerID";
            this.textBox_managerID.ReadOnly = true;
            this.textBox_managerID.Size = new System.Drawing.Size(235, 25);
            this.textBox_managerID.TabIndex = 51;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(320, 279);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 15);
            this.label4.TabIndex = 50;
            this.label4.Text = "计划负责人ID：";
            // 
            // label_descriptionError
            // 
            this.label_descriptionError.AutoSize = true;
            this.label_descriptionError.ForeColor = System.Drawing.Color.Red;
            this.label_descriptionError.Location = new System.Drawing.Point(138, 106);
            this.label_descriptionError.Name = "label_descriptionError";
            this.label_descriptionError.Size = new System.Drawing.Size(0, 15);
            this.label_descriptionError.TabIndex = 49;
            // 
            // label_nameError
            // 
            this.label_nameError.AutoSize = true;
            this.label_nameError.ForeColor = System.Drawing.Color.Red;
            this.label_nameError.Location = new System.Drawing.Point(123, 27);
            this.label_nameError.Name = "label_nameError";
            this.label_nameError.Size = new System.Drawing.Size(0, 15);
            this.label_nameError.TabIndex = 48;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 279);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 15);
            this.label3.TabIndex = 47;
            this.label3.Text = "计划负责人姓名(*)：";
            // 
            // textBox_description
            // 
            this.textBox_description.Location = new System.Drawing.Point(39, 129);
            this.textBox_description.Multiline = true;
            this.textBox_description.Name = "textBox_description";
            this.textBox_description.ReadOnly = true;
            this.textBox_description.Size = new System.Drawing.Size(519, 126);
            this.textBox_description.TabIndex = 46;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 15);
            this.label2.TabIndex = 45;
            this.label2.Text = "计划描述(*)：";
            // 
            // textBox_planName
            // 
            this.textBox_planName.Location = new System.Drawing.Point(39, 51);
            this.textBox_planName.Name = "textBox_planName";
            this.textBox_planName.ReadOnly = true;
            this.textBox_planName.Size = new System.Drawing.Size(235, 25);
            this.textBox_planName.TabIndex = 44;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 15);
            this.label1.TabIndex = 43;
            this.label1.Text = "计划名(*)：";
            // 
            // comboBox_priority
            // 
            this.comboBox_priority.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_priority.FormattingEnabled = true;
            this.comboBox_priority.Items.AddRange(new object[] {
            "次要",
            "一般",
            "紧急"});
            this.comboBox_priority.Location = new System.Drawing.Point(323, 53);
            this.comboBox_priority.MaxDropDownItems = 15;
            this.comboBox_priority.Name = "comboBox_priority";
            this.comboBox_priority.Size = new System.Drawing.Size(235, 23);
            this.comboBox_priority.TabIndex = 59;
            // 
            // textBox_manageName
            // 
            this.textBox_manageName.Location = new System.Drawing.Point(39, 305);
            this.textBox_manageName.Name = "textBox_manageName";
            this.textBox_manageName.Size = new System.Drawing.Size(235, 25);
            this.textBox_manageName.TabIndex = 60;
            // 
            // ViewPlan_Tester
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 450);
            this.Controls.Add(this.textBox_manageName);
            this.Controls.Add(this.comboBox_priority);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label_managerError);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
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
            this.Name = "ViewPlan_Tester";
            this.Text = "查看计划";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label_managerError;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
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
        private System.Windows.Forms.ComboBox comboBox_priority;
        private System.Windows.Forms.TextBox textBox_manageName;
    }
}