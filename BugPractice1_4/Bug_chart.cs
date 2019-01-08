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
    public partial class Bug_chart : Form
    {
        public Bug_chart()
        {
            InitializeComponent();
            List<string> xData = new List<string>() { "功能缺陷", "设计缺陷", "性能缺陷", "配置缺陷" };
            List<int> yData = new List<int>() { 10, 20, 30, 40 };
            chart1.Series["Series1"].Label = "#PERCENT{P}";
            chart1.Series["Series1"].LegendText = "#VALX";
            chart1.Series[0].Points.DataBindXY(xData, yData);
        }

        private void chart1_Click(object sender, EventArgs e)
        {
           
        }
    }
}
