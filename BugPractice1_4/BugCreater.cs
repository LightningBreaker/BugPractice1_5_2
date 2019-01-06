using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BugPractice1_4
{
    public partial class BugCreater : Form
    {
        public BugCreater()
        {
            InitializeComponent();
        }
        private const int OK_LEN = 20;
        private bool[] is_ok = new bool[OK_LEN];
        private void bug_cre_btn_next1_Click(object sender, EventArgs e)
        {
            int len_desc = bug_cre_description.Text.Length;
            int len_name = bug_cre_text_bug_name.Text.Length;
            if (len_desc < 5 || len_name < 5)
            {
                MessageBox.Show("请完善信息");
            }

        }

        private TableBug table_bug;
        private void bug_cre_tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void BugCreater_Load(object sender, EventArgs e)
        {
            bug_cre_bug_level.SelectedIndex = 0;

        }

        private void bug_cre_bug_level_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (bug_cre_bug_level.SelectedIndex == 0)
            {
                bug_cre_bug_level.ForeColor = Color.LimeGreen;
            }
            else if (bug_cre_bug_level.SelectedIndex == 1)
            {
                bug_cre_bug_level.ForeColor = Color.Blue;
            }
            else
            {
                bug_cre_bug_level.ForeColor = Color.Red;
            }
        }
    }
}
