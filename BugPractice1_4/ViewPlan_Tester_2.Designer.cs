namespace BugPractice1_4
{
    partial class ViewPlan_Tester_2
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
            this.button_giveup = new System.Windows.Forms.Button();
            this.button_release = new System.Windows.Forms.Button();
            this.button_addPlan = new System.Windows.Forms.Button();
            this.button_deletePLan = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column_number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.case_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.case_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.case_status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ButtonColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.button_uploadResult = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button_giveup
            // 
            this.button_giveup.Location = new System.Drawing.Point(762, 372);
            this.button_giveup.Name = "button_giveup";
            this.button_giveup.Size = new System.Drawing.Size(136, 33);
            this.button_giveup.TabIndex = 12;
            this.button_giveup.Text = "返回";
            this.button_giveup.UseVisualStyleBackColor = true;
            this.button_giveup.Click += new System.EventHandler(this.button_giveup_Click);
            // 
            // button_release
            // 
            this.button_release.Location = new System.Drawing.Point(578, 372);
            this.button_release.Name = "button_release";
            this.button_release.Size = new System.Drawing.Size(136, 33);
            this.button_release.TabIndex = 11;
            this.button_release.Text = "添加完毕";
            this.button_release.UseVisualStyleBackColor = true;
            this.button_release.Click += new System.EventHandler(this.button_release_Click);
            // 
            // button_addPlan
            // 
            this.button_addPlan.Location = new System.Drawing.Point(762, 80);
            this.button_addPlan.Name = "button_addPlan";
            this.button_addPlan.Size = new System.Drawing.Size(136, 33);
            this.button_addPlan.TabIndex = 10;
            this.button_addPlan.Text = "添加用例";
            this.button_addPlan.UseVisualStyleBackColor = true;
            this.button_addPlan.Click += new System.EventHandler(this.button_addPlan_Click);
            // 
            // button_deletePLan
            // 
            this.button_deletePLan.Location = new System.Drawing.Point(762, 142);
            this.button_deletePLan.Name = "button_deletePLan";
            this.button_deletePLan.Size = new System.Drawing.Size(136, 33);
            this.button_deletePLan.TabIndex = 9;
            this.button_deletePLan.Text = "删除用例";
            this.button_deletePLan.UseVisualStyleBackColor = true;
            this.button_deletePLan.Click += new System.EventHandler(this.button_deletePLan_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_number,
            this.case_name,
            this.case_id,
            this.case_status,
            this.ButtonColumn});
            this.dataGridView1.Location = new System.Drawing.Point(40, 80);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(674, 256);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
            this.dataGridView1.CurrentCellChanged += new System.EventHandler(this.dataGridView1_CurrentCellChanged);
            // 
            // Column_number
            // 
            this.Column_number.HeaderText = "序号";
            this.Column_number.Name = "Column_number";
            this.Column_number.ReadOnly = true;
            this.Column_number.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column_number.Width = 70;
            // 
            // case_name
            // 
            this.case_name.DataPropertyName = "case_name";
            this.case_name.HeaderText = "用例名称";
            this.case_name.Name = "case_name";
            this.case_name.ReadOnly = true;
            this.case_name.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.case_name.Width = 170;
            // 
            // case_id
            // 
            this.case_id.DataPropertyName = "case_id";
            this.case_id.HeaderText = "ID";
            this.case_id.Name = "case_id";
            this.case_id.ReadOnly = true;
            this.case_id.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.case_id.Width = 60;
            // 
            // case_status
            // 
            this.case_status.DataPropertyName = "case_status";
            this.case_status.HeaderText = "完成情况";
            this.case_status.Name = "case_status";
            this.case_status.ReadOnly = true;
            this.case_status.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.case_status.Width = 95;
            // 
            // ButtonColumn
            // 
            this.ButtonColumn.HeaderText = "";
            this.ButtonColumn.Name = "ButtonColumn";
            this.ButtonColumn.ReadOnly = true;
            this.ButtonColumn.Text = "查看";
            this.ButtonColumn.ToolTipText = "查看";
            this.ButtonColumn.UseColumnTextForButtonValue = true;
            this.ButtonColumn.Width = 70;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 13;
            this.label1.Text = "测试用例";
            // 
            // button_uploadResult
            // 
            this.button_uploadResult.Enabled = false;
            this.button_uploadResult.Location = new System.Drawing.Point(762, 204);
            this.button_uploadResult.Name = "button_uploadResult";
            this.button_uploadResult.Size = new System.Drawing.Size(136, 33);
            this.button_uploadResult.TabIndex = 14;
            this.button_uploadResult.Text = "测试结果";
            this.button_uploadResult.UseVisualStyleBackColor = true;
            this.button_uploadResult.Click += new System.EventHandler(this.button_uploadResult_Click);
            // 
            // ViewPlan_Tester_2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 452);
            this.Controls.Add(this.button_uploadResult);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_giveup);
            this.Controls.Add(this.button_release);
            this.Controls.Add(this.button_addPlan);
            this.Controls.Add(this.button_deletePLan);
            this.Controls.Add(this.dataGridView1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ViewPlan_Tester_2";
            this.Text = "测试用例";
            this.Load += new System.EventHandler(this.ViewPlan_Tester_2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_giveup;
        private System.Windows.Forms.Button button_release;
        private System.Windows.Forms.Button button_addPlan;
        private System.Windows.Forms.Button button_deletePLan;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_number;
        private System.Windows.Forms.DataGridViewTextBoxColumn case_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn case_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn case_status;
        private System.Windows.Forms.DataGridViewButtonColumn ButtonColumn;
        private System.Windows.Forms.Button button_uploadResult;
    }
}