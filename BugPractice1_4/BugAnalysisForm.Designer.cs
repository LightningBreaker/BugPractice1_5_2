namespace BugPractice1_4
{
    partial class BugAnalysisForm
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
            this.dataGrid_waiting_bug = new System.Windows.Forms.DataGridView();
            this.bug_ays_lbl_sel_id = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.bug_analysis_main_text = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.bug_analysis_desc = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.bug_analysis_btn_update = new System.Windows.Forms.Button();
            this.bug_analysis_status = new System.Windows.Forms.ComboBox();
            this.label23 = new System.Windows.Forms.Label();
            this.bug_analysis_bugReason = new System.Windows.Forms.ComboBox();
            this.bug_bug_analysis_refresh = new System.Windows.Forms.Label();
            this.bug_analysis_status_select = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_waiting_bug)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGrid_waiting_bug
            // 
            this.dataGrid_waiting_bug.BackgroundColor = System.Drawing.Color.White;
            this.dataGrid_waiting_bug.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_waiting_bug.Location = new System.Drawing.Point(39, 39);
            this.dataGrid_waiting_bug.Name = "dataGrid_waiting_bug";
            this.dataGrid_waiting_bug.ReadOnly = true;
            this.dataGrid_waiting_bug.RowTemplate.Height = 27;
            this.dataGrid_waiting_bug.Size = new System.Drawing.Size(347, 150);
            this.dataGrid_waiting_bug.TabIndex = 33;
            this.dataGrid_waiting_bug.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_waiting_bug_CellClick);
            // 
            // bug_ays_lbl_sel_id
            // 
            this.bug_ays_lbl_sel_id.AutoSize = true;
            this.bug_ays_lbl_sel_id.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bug_ays_lbl_sel_id.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bug_ays_lbl_sel_id.ForeColor = System.Drawing.Color.Blue;
            this.bug_ays_lbl_sel_id.Location = new System.Drawing.Point(187, 208);
            this.bug_ays_lbl_sel_id.Name = "bug_ays_lbl_sel_id";
            this.bug_ays_lbl_sel_id.Size = new System.Drawing.Size(0, 20);
            this.bug_ays_lbl_sel_id.TabIndex = 35;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(35, 208);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 20);
            this.label2.TabIndex = 36;
            this.label2.Text = "选定bug id:";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.ForeColor = System.Drawing.Color.Red;
            this.label22.Location = new System.Drawing.Point(140, 529);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(0, 15);
            this.label22.TabIndex = 46;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.ForeColor = System.Drawing.Color.Red;
            this.label20.Location = new System.Drawing.Point(138, 503);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(0, 15);
            this.label20.TabIndex = 45;
            // 
            // bug_analysis_main_text
            // 
            this.bug_analysis_main_text.BackColor = System.Drawing.Color.White;
            this.bug_analysis_main_text.Location = new System.Drawing.Point(39, 526);
            this.bug_analysis_main_text.Multiline = true;
            this.bug_analysis_main_text.Name = "bug_analysis_main_text";
            this.bug_analysis_main_text.Size = new System.Drawing.Size(347, 147);
            this.bug_analysis_main_text.TabIndex = 44;
            this.bug_analysis_main_text.TextChanged += new System.EventHandler(this.bug_analysis_main_text_TextChanged);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(36, 503);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(151, 15);
            this.label21.TabIndex = 43;
            this.label21.Text = "Bug分析（请填写）：";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.ForeColor = System.Drawing.Color.Red;
            this.label17.Location = new System.Drawing.Point(138, 432);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(0, 15);
            this.label17.TabIndex = 42;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(36, 452);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(137, 15);
            this.label19.TabIndex = 40;
            this.label19.Text = "Bug原因(请选择)：";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.Red;
            this.label13.Location = new System.Drawing.Point(138, 245);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(0, 15);
            this.label13.TabIndex = 39;
            // 
            // bug_analysis_desc
            // 
            this.bug_analysis_desc.BackColor = System.Drawing.Color.White;
            this.bug_analysis_desc.Location = new System.Drawing.Point(39, 270);
            this.bug_analysis_desc.Multiline = true;
            this.bug_analysis_desc.Name = "bug_analysis_desc";
            this.bug_analysis_desc.ReadOnly = true;
            this.bug_analysis_desc.Size = new System.Drawing.Size(347, 147);
            this.bug_analysis_desc.TabIndex = 38;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(36, 245);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(76, 15);
            this.label15.TabIndex = 37;
            this.label15.Text = "Bug描述：";
            // 
            // bug_analysis_btn_update
            // 
            this.bug_analysis_btn_update.BackColor = System.Drawing.Color.Red;
            this.bug_analysis_btn_update.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bug_analysis_btn_update.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bug_analysis_btn_update.Font = new System.Drawing.Font("幼圆", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bug_analysis_btn_update.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.bug_analysis_btn_update.Location = new System.Drawing.Point(39, 785);
            this.bug_analysis_btn_update.Name = "bug_analysis_btn_update";
            this.bug_analysis_btn_update.Size = new System.Drawing.Size(347, 71);
            this.bug_analysis_btn_update.TabIndex = 49;
            this.bug_analysis_btn_update.Text = "提交修复报告";
            this.bug_analysis_btn_update.UseVisualStyleBackColor = false;
            this.bug_analysis_btn_update.Click += new System.EventHandler(this.bug_analysis_btn_update_Click);
            // 
            // bug_analysis_status
            // 
            this.bug_analysis_status.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.bug_analysis_status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.bug_analysis_status.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bug_analysis_status.ForeColor = System.Drawing.Color.Black;
            this.bug_analysis_status.FormattingEnabled = true;
            this.bug_analysis_status.Items.AddRange(new object[] {
            "待修复",
            "待确认修复"});
            this.bug_analysis_status.Location = new System.Drawing.Point(39, 721);
            this.bug_analysis_status.Name = "bug_analysis_status";
            this.bug_analysis_status.Size = new System.Drawing.Size(121, 33);
            this.bug_analysis_status.TabIndex = 48;
            this.bug_analysis_status.SelectedIndexChanged += new System.EventHandler(this.bug_analysis_status_SelectedIndexChanged);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(36, 690);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(106, 15);
            this.label23.TabIndex = 47;
            this.label23.Text = "更改bug状态：";
            // 
            // bug_analysis_bugReason
            // 
            this.bug_analysis_bugReason.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.bug_analysis_bugReason.FormattingEnabled = true;
            this.bug_analysis_bugReason.Items.AddRange(new object[] {
            "功能问题",
            "接口问题",
            "逻辑问题",
            "计算问题",
            "数据问题",
            "用户界面问题",
            "文档问题",
            "性能问题",
            "兼容问题",
            "其他问题"});
            this.bug_analysis_bugReason.Location = new System.Drawing.Point(179, 449);
            this.bug_analysis_bugReason.Name = "bug_analysis_bugReason";
            this.bug_analysis_bugReason.Size = new System.Drawing.Size(207, 23);
            this.bug_analysis_bugReason.TabIndex = 50;
            this.bug_analysis_bugReason.SelectedIndexChanged += new System.EventHandler(this.bug_analysis_bugReason_SelectedIndexChanged);
            // 
            // bug_bug_analysis_refresh
            // 
            this.bug_bug_analysis_refresh.AutoSize = true;
            this.bug_bug_analysis_refresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bug_bug_analysis_refresh.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bug_bug_analysis_refresh.ForeColor = System.Drawing.Color.Blue;
            this.bug_bug_analysis_refresh.Location = new System.Drawing.Point(337, 208);
            this.bug_bug_analysis_refresh.Name = "bug_bug_analysis_refresh";
            this.bug_bug_analysis_refresh.Size = new System.Drawing.Size(49, 20);
            this.bug_bug_analysis_refresh.TabIndex = 51;
            this.bug_bug_analysis_refresh.Text = "刷新";
            this.bug_bug_analysis_refresh.Click += new System.EventHandler(this.bug_bug_analysis_refresh_Click);
            // 
            // bug_analysis_status_select
            // 
            this.bug_analysis_status_select.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.bug_analysis_status_select.FormattingEnabled = true;
            this.bug_analysis_status_select.Items.AddRange(new object[] {
            "查看待修复bug:",
            "查看待确认修复bug:",
            "查看已修复bug"});
            this.bug_analysis_status_select.Location = new System.Drawing.Point(39, 13);
            this.bug_analysis_status_select.Name = "bug_analysis_status_select";
            this.bug_analysis_status_select.Size = new System.Drawing.Size(148, 23);
            this.bug_analysis_status_select.TabIndex = 52;
            this.bug_analysis_status_select.SelectedIndexChanged += new System.EventHandler(this.bug_analysis_status_select_SelectedIndexChanged);
            // 
            // BugAnalysisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(478, 547);
            this.Controls.Add(this.bug_analysis_status_select);
            this.Controls.Add(this.bug_bug_analysis_refresh);
            this.Controls.Add(this.bug_analysis_bugReason);
            this.Controls.Add(this.bug_analysis_btn_update);
            this.Controls.Add(this.bug_analysis_status);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.bug_analysis_main_text);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.bug_analysis_desc);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bug_ays_lbl_sel_id);
            this.Controls.Add(this.dataGrid_waiting_bug);
            this.Name = "BugAnalysisForm";
            this.Text = "BugAnalysisForm";
            this.Load += new System.EventHandler(this.BugAnalysisForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_waiting_bug)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGrid_waiting_bug;
        private System.Windows.Forms.Label bug_ays_lbl_sel_id;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox bug_analysis_main_text;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox bug_analysis_desc;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button bug_analysis_btn_update;
        private System.Windows.Forms.ComboBox bug_analysis_status;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.ComboBox bug_analysis_bugReason;
        private System.Windows.Forms.Label bug_bug_analysis_refresh;
        private System.Windows.Forms.ComboBox bug_analysis_status_select;
    }
}