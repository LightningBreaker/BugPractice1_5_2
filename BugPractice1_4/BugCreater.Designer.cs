namespace BugPractice1_4
{
    partial class BugCreater
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
            this.bug_cre_tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.bug_cre_bug_level = new System.Windows.Forms.ComboBox();
            this.bug_cre_btn_next1 = new System.Windows.Forms.Button();
            this.label_descriptionError = new System.Windows.Forms.Label();
            this.label_nameError = new System.Windows.Forms.Label();
            this.bug_cre_description = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bug_cre_text_bug_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.user_name = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.bug_cre_tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // bug_cre_tabControl
            // 
            this.bug_cre_tabControl.Controls.Add(this.tabPage1);
            this.bug_cre_tabControl.Controls.Add(this.tabPage2);
            this.bug_cre_tabControl.Location = new System.Drawing.Point(1, 1);
            this.bug_cre_tabControl.Name = "bug_cre_tabControl";
            this.bug_cre_tabControl.SelectedIndex = 0;
            this.bug_cre_tabControl.Size = new System.Drawing.Size(411, 521);
            this.bug_cre_tabControl.TabIndex = 0;
            this.bug_cre_tabControl.SelectedIndexChanged += new System.EventHandler(this.bug_cre_tabControl_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.bug_cre_bug_level);
            this.tabPage1.Controls.Add(this.bug_cre_btn_next1);
            this.tabPage1.Controls.Add(this.label_descriptionError);
            this.tabPage1.Controls.Add(this.label_nameError);
            this.tabPage1.Controls.Add(this.bug_cre_description);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.bug_cre_text_bug_name);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(403, 492);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "bug描述";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 327);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 15);
            this.label3.TabIndex = 18;
            this.label3.Text = "Bug等级：";
            // 
            // bug_cre_bug_level
            // 
            this.bug_cre_bug_level.BackColor = System.Drawing.Color.LemonChiffon;
            this.bug_cre_bug_level.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.bug_cre_bug_level.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bug_cre_bug_level.ForeColor = System.Drawing.Color.White;
            this.bug_cre_bug_level.FormattingEnabled = true;
            this.bug_cre_bug_level.Items.AddRange(new object[] {
            "次要",
            "一般",
            "严重"});
            this.bug_cre_bug_level.Location = new System.Drawing.Point(144, 324);
            this.bug_cre_bug_level.Name = "bug_cre_bug_level";
            this.bug_cre_bug_level.Size = new System.Drawing.Size(121, 33);
            this.bug_cre_bug_level.TabIndex = 17;
            this.bug_cre_bug_level.SelectedIndexChanged += new System.EventHandler(this.bug_cre_bug_level_SelectedIndexChanged);
            // 
            // bug_cre_btn_next1
            // 
            this.bug_cre_btn_next1.BackColor = System.Drawing.Color.Red;
            this.bug_cre_btn_next1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bug_cre_btn_next1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bug_cre_btn_next1.Font = new System.Drawing.Font("幼圆", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bug_cre_btn_next1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.bug_cre_btn_next1.Location = new System.Drawing.Point(12, 380);
            this.bug_cre_btn_next1.Name = "bug_cre_btn_next1";
            this.bug_cre_btn_next1.Size = new System.Drawing.Size(358, 71);
            this.bug_cre_btn_next1.TabIndex = 16;
            this.bug_cre_btn_next1.Text = "下一步";
            this.bug_cre_btn_next1.UseVisualStyleBackColor = false;
            this.bug_cre_btn_next1.Click += new System.EventHandler(this.bug_cre_btn_next1_Click);
            // 
            // label_descriptionError
            // 
            this.label_descriptionError.AutoSize = true;
            this.label_descriptionError.ForeColor = System.Drawing.Color.Red;
            this.label_descriptionError.Location = new System.Drawing.Point(122, 124);
            this.label_descriptionError.Name = "label_descriptionError";
            this.label_descriptionError.Size = new System.Drawing.Size(0, 15);
            this.label_descriptionError.TabIndex = 15;
            // 
            // label_nameError
            // 
            this.label_nameError.AutoSize = true;
            this.label_nameError.ForeColor = System.Drawing.Color.Red;
            this.label_nameError.Location = new System.Drawing.Point(107, 45);
            this.label_nameError.Name = "label_nameError";
            this.label_nameError.Size = new System.Drawing.Size(0, 15);
            this.label_nameError.TabIndex = 14;
            // 
            // bug_cre_description
            // 
            this.bug_cre_description.Location = new System.Drawing.Point(23, 147);
            this.bug_cre_description.Multiline = true;
            this.bug_cre_description.Name = "bug_cre_description";
            this.bug_cre_description.Size = new System.Drawing.Size(347, 147);
            this.bug_cre_description.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 15);
            this.label2.TabIndex = 12;
            this.label2.Text = "Bug描述(*)：";
            // 
            // bug_cre_text_bug_name
            // 
            this.bug_cre_text_bug_name.Location = new System.Drawing.Point(23, 69);
            this.bug_cre_text_bug_name.Name = "bug_cre_text_bug_name";
            this.bug_cre_text_bug_name.Size = new System.Drawing.Size(347, 25);
            this.bug_cre_text_bug_name.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "Bug名(*)：";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.textBox1);
            this.tabPage2.Controls.Add(this.user_name);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(403, 492);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "负责人指派";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("幼圆", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button1.Location = new System.Drawing.Point(7, 396);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(358, 71);
            this.button1.TabIndex = 17;
            this.button1.Text = "下一步";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "开发工程师列表：";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 44);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(399, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // user_name
            // 
            this.user_name.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.user_name.ForeColor = System.Drawing.Color.Black;
            this.user_name.Location = new System.Drawing.Point(0, 248);
            this.user_name.Multiline = true;
            this.user_name.Name = "user_name";
            this.user_name.Size = new System.Drawing.Size(178, 48);
            this.user_name.TabIndex = 18;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox1.ForeColor = System.Drawing.Color.Black;
            this.textBox1.Location = new System.Drawing.Point(202, 248);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(107, 48);
            this.textBox1.TabIndex = 19;
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::BugPractice1_4.Properties.Resources.start;
            this.button2.Location = new System.Drawing.Point(333, 241);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(32, 54);
            this.button2.TabIndex = 20;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // BugCreater
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(409, 522);
            this.Controls.Add(this.bug_cre_tabControl);
            this.Name = "BugCreater";
            this.Text = "缺陷发布界面";
            this.Load += new System.EventHandler(this.BugCreater_Load);
            this.bug_cre_tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl bug_cre_tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label_descriptionError;
        private System.Windows.Forms.Label label_nameError;
        private System.Windows.Forms.TextBox bug_cre_description;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox bug_cre_text_bug_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bug_cre_btn_next1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox bug_cre_bug_level;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox user_name;
    }
}