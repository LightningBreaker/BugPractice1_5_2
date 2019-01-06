namespace BugPractice1_4
{
    partial class ReleaseProject_2
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
            this.label = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button_deletePLan = new System.Windows.Forms.Button();
            this.button_addPlan = new System.Windows.Forms.Button();
            this.button_release = new System.Windows.Forms.Button();
            this.button_giveup = new System.Windows.Forms.Button();
            this.plan_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.plan_manager = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ButtonColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(54, 52);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(157, 15);
            this.label.TabIndex = 0;
            this.label.Text = "添加测试计划（可选）";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.plan_name,
            this.plan_manager,
            this.ButtonColumn});
            this.dataGridView1.Location = new System.Drawing.Point(57, 88);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(594, 243);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button_deletePLan
            // 
            this.button_deletePLan.Location = new System.Drawing.Point(688, 150);
            this.button_deletePLan.Name = "button_deletePLan";
            this.button_deletePLan.Size = new System.Drawing.Size(136, 33);
            this.button_deletePLan.TabIndex = 3;
            this.button_deletePLan.Text = "删除计划";
            this.button_deletePLan.UseVisualStyleBackColor = true;
            this.button_deletePLan.Click += new System.EventHandler(this.button_deletePLan_Click);
            // 
            // button_addPlan
            // 
            this.button_addPlan.Location = new System.Drawing.Point(688, 88);
            this.button_addPlan.Name = "button_addPlan";
            this.button_addPlan.Size = new System.Drawing.Size(136, 33);
            this.button_addPlan.TabIndex = 4;
            this.button_addPlan.Text = "添加计划";
            this.button_addPlan.UseVisualStyleBackColor = true;
            this.button_addPlan.Click += new System.EventHandler(this.button_addPlan_Click);
            // 
            // button_release
            // 
            this.button_release.Location = new System.Drawing.Point(515, 380);
            this.button_release.Name = "button_release";
            this.button_release.Size = new System.Drawing.Size(136, 33);
            this.button_release.TabIndex = 5;
            this.button_release.Text = "发布项目";
            this.button_release.UseVisualStyleBackColor = true;
            this.button_release.Click += new System.EventHandler(this.button_release_Click);
            // 
            // button_giveup
            // 
            this.button_giveup.Location = new System.Drawing.Point(688, 380);
            this.button_giveup.Name = "button_giveup";
            this.button_giveup.Size = new System.Drawing.Size(136, 33);
            this.button_giveup.TabIndex = 6;
            this.button_giveup.Text = "放弃发布";
            this.button_giveup.UseVisualStyleBackColor = true;
            this.button_giveup.Click += new System.EventHandler(this.button_giveup_Click);
            // 
            // plan_name
            // 
            this.plan_name.DataPropertyName = "name";
            this.plan_name.HeaderText = "计划名称";
            this.plan_name.Name = "plan_name";
            this.plan_name.ReadOnly = true;
            this.plan_name.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.plan_name.Width = 150;
            // 
            // plan_manager
            // 
            this.plan_manager.DataPropertyName = "manager_name";
            this.plan_manager.HeaderText = "计划负责人";
            this.plan_manager.Name = "plan_manager";
            this.plan_manager.ReadOnly = true;
            this.plan_manager.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.plan_manager.Width = 180;
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
            // ReleaseProject_2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 449);
            this.Controls.Add(this.button_giveup);
            this.Controls.Add(this.button_release);
            this.Controls.Add(this.button_addPlan);
            this.Controls.Add(this.button_deletePLan);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ReleaseProject_2";
            this.Text = "发布测试项目";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ReleaseProject_2_FormClosed);
            this.Load += new System.EventHandler(this.ReleaseProject_2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Button button_deletePLan;
        private System.Windows.Forms.Button button_addPlan;
        private System.Windows.Forms.Button button_release;
        private System.Windows.Forms.Button button_giveup;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn plan_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn plan_manager;
        private System.Windows.Forms.DataGridViewButtonColumn ButtonColumn;
    }
}