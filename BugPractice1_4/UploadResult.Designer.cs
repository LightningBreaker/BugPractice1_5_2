namespace BugPractice1_4
{
    partial class UploadResult
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
            this.button_uploadBug = new System.Windows.Forms.Button();
            this.comboBox_result = new System.Windows.Forms.ComboBox();
            this.textBox_ID = new System.Windows.Forms.TextBox();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.label_caseID = new System.Windows.Forms.Label();
            this.label_CaseName = new System.Windows.Forms.Label();
            this.label_result = new System.Windows.Forms.Label();
            this.button_uploadResult = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_uploadBug
            // 
            this.button_uploadBug.Location = new System.Drawing.Point(301, 252);
            this.button_uploadBug.Name = "button_uploadBug";
            this.button_uploadBug.Size = new System.Drawing.Size(121, 38);
            this.button_uploadBug.TabIndex = 0;
            this.button_uploadBug.Text = "提交缺陷...";
            this.button_uploadBug.UseVisualStyleBackColor = true;
            this.button_uploadBug.Click += new System.EventHandler(this.button_uploadBug_Click);
            // 
            // comboBox_result
            // 
            this.comboBox_result.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_result.FormattingEnabled = true;
            this.comboBox_result.Items.AddRange(new object[] {
            "测试通过",
            "存在缺陷"});
            this.comboBox_result.Location = new System.Drawing.Point(161, 167);
            this.comboBox_result.Name = "comboBox_result";
            this.comboBox_result.Size = new System.Drawing.Size(261, 23);
            this.comboBox_result.TabIndex = 2;
            this.comboBox_result.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // textBox_ID
            // 
            this.textBox_ID.Location = new System.Drawing.Point(161, 43);
            this.textBox_ID.Name = "textBox_ID";
            this.textBox_ID.ReadOnly = true;
            this.textBox_ID.Size = new System.Drawing.Size(261, 25);
            this.textBox_ID.TabIndex = 3;
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(161, 106);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.ReadOnly = true;
            this.textBox_name.Size = new System.Drawing.Size(261, 25);
            this.textBox_name.TabIndex = 4;
            // 
            // label_caseID
            // 
            this.label_caseID.AutoSize = true;
            this.label_caseID.Location = new System.Drawing.Point(67, 53);
            this.label_caseID.Name = "label_caseID";
            this.label_caseID.Size = new System.Drawing.Size(61, 15);
            this.label_caseID.TabIndex = 5;
            this.label_caseID.Text = "用例ID:";
            // 
            // label_CaseName
            // 
            this.label_CaseName.AutoSize = true;
            this.label_CaseName.Location = new System.Drawing.Point(70, 109);
            this.label_CaseName.Name = "label_CaseName";
            this.label_CaseName.Size = new System.Drawing.Size(60, 15);
            this.label_CaseName.TabIndex = 6;
            this.label_CaseName.Text = "用例名:";
            // 
            // label_result
            // 
            this.label_result.AutoSize = true;
            this.label_result.Location = new System.Drawing.Point(67, 170);
            this.label_result.Name = "label_result";
            this.label_result.Size = new System.Drawing.Size(75, 15);
            this.label_result.TabIndex = 7;
            this.label_result.Text = "测试结果:";
            // 
            // button_uploadResult
            // 
            this.button_uploadResult.Location = new System.Drawing.Point(73, 252);
            this.button_uploadResult.Name = "button_uploadResult";
            this.button_uploadResult.Size = new System.Drawing.Size(121, 38);
            this.button_uploadResult.TabIndex = 8;
            this.button_uploadResult.Text = "提交结果";
            this.button_uploadResult.UseVisualStyleBackColor = true;
            this.button_uploadResult.Click += new System.EventHandler(this.button_uploadResult_Click);
            // 
            // UploadResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 342);
            this.Controls.Add(this.button_uploadResult);
            this.Controls.Add(this.label_result);
            this.Controls.Add(this.label_CaseName);
            this.Controls.Add(this.label_caseID);
            this.Controls.Add(this.textBox_name);
            this.Controls.Add(this.textBox_ID);
            this.Controls.Add(this.comboBox_result);
            this.Controls.Add(this.button_uploadBug);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UploadResult";
            this.Text = "提交测试结果";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_uploadBug;
        private System.Windows.Forms.ComboBox comboBox_result;
        private System.Windows.Forms.TextBox textBox_ID;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.Label label_caseID;
        private System.Windows.Forms.Label label_CaseName;
        private System.Windows.Forms.Label label_result;
        private System.Windows.Forms.Button button_uploadResult;
    }
}