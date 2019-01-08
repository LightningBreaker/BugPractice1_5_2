using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace BugPractice1_4
{
    public partial class Data_Visualization_Analysis : Form
    {
        public Data_Visualization_Analysis()
        {
            InitializeComponent();
        }

        private void Data_Visualization_Analysis_Load(object sender, EventArgs e)
        {

            this.Pie_Load();
            this.Bar_Load();
            this.Line_Load();
            this.chart2.Visible = true;
            this.chart1.Visible = false;
            this.chart3.Visible = false;
        }
        public void Bar_Load()
        {
            //清除默认的series
            chart1.Series.Clear();
            //new 一个叫做【Strength】的系列
            Series Strength = new Series("缺陷严重程度");
            //设置chart的类型，这里为柱状图
            Strength.ChartType = SeriesChartType.Column;
            //给系列上的点进行赋值，分别对应横坐标和纵坐标的值
            Strength.Points.AddXY("缺陷1", "90");
            Strength.Points.AddXY("缺陷2", "88");
            Strength.Points.AddXY("缺陷3", "60");
            Strength.Points.AddXY("缺陷4", "93");
            Strength.Points.AddXY("缺陷5", "79");
            Strength.Points.AddXY("缺陷6", "85");
            //把series添加到chart上
            chart1.Series.Add(Strength);
        }
        public void Pie_Load()
        {
            List<string> xData = new List<string>() { "功能缺陷", "设计缺陷", "性能缺陷", "配置缺陷" };
            List<int> yData = new List<int>() { 10, 20, 30, 40 };
            chart2.Series["Series1"].Label = "#PERCENT{P}";
            chart2.Series["Series1"].LegendText = "#VALX";
            chart2.Series[0].Points.DataBindXY(xData, yData);
        }
        public void Line_Load()
        {
            List<string> xData = new List<string>() { "用例1", "用例2", "用例3", "用例4" };
            List<int> yData = new List<int>() { 10, 20, 30, 40 };
            //线条颜色
            chart3.Series[0].Color = Color.Green;
            //线条粗细
            chart3.Series[0].BorderWidth = 3;
            //标记点边框颜色      
            chart3.Series[0].MarkerBorderColor = Color.Black;
            //标记点边框大小
            chart3.Series[0].MarkerBorderWidth = 3;
            //标记点中心颜色
            chart3.Series[0].MarkerColor = Color.Red;
            //标记点大小
            chart3.Series[0].MarkerSize = 8;
            //标记点类型     
            chart3.Series[0].MarkerStyle = MarkerStyle.Circle;
            //将文字移到外侧
            chart3.Series[0]["PieLabelStyle"] = "Outside";
            //绘制黑色的连线
            chart3.Series[0]["PieLineColor"] = "Black";
            chart3.Series[0].Points.DataBindXY(xData, yData);
        }

        private void chart2_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            this.chart2.Visible = true;
            this.chart1.Visible = false;
            this.chart3.Visible = false;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            this.chart2.Visible = false;
            this.chart1.Visible = true;
            this.chart3.Visible = false;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            this.chart2.Visible = false;
            this.chart1.Visible = true;
            this.chart3.Visible = false;
        }
    }
}
