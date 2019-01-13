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
using MySql.Data.MySqlClient;



namespace BugPractice1_4
{
    public partial class Data_Visualization_Analysis : Form
    {
        
        public static DataTable dtb;
        public Data_Visualization_Analysis()
        {
            InitializeComponent();
        }

        private void Data_Visualization_Analysis_Load(object sender, EventArgs e)
        {
            this.panel1.Visible = false;
            this.panel2.Visible = false;
            this.Pie_Load();
            this.Bar_Load();
            this.Line_Load();
            this.chart2.Visible = true;
            this.chart1.Visible = false;
            this.chart3.Visible = false;
        }
        public void Bar_Load()
        {
            try
            {
               /* MySqlConnection myconn = null;
                myconn = new MySqlConnection(Conn);
                myconn.Open();
                MessageBox.Show("连接成功");
                string sql = "SELECT * FROM table_user_info where is_verified =0";
                MySqlCommand command = new MySqlCommand(sql, myconn);
                MySqlDataAdapter adap = new MySqlDataAdapter(command);
                DataSet ds = new DataSet();
                adap.Fill(ds);              
                DataTable dtb = ds.Tables[0];*/
              

            
            //清除默认的series
            chart1.Series.Clear();
            chart1.GetToolTipText += new EventHandler<ToolTipEventArgs>(chart1_GetToolTipText);
            //new 一个叫做【Strength】的系列
            this.chart1.Titles.Add("用例数量报表");
            Series Strength = new Series("用例数量");
            //设置chart的类型，这里为柱状图
            Strength.ChartType = SeriesChartType.Column;
                //给系列上的点进行赋值，分别对应横坐标和纵坐标的值
                int k = 6, number = 1;
                Random rd = new Random();
                while (k != 0)
                {
                    Strength.Points.AddXY("用例" + number.ToString(), rd.Next(1, 100));
                    k--;number++;
                }
          /* Strength.Points.AddXY("用例1",  rd.Next(1, 100));
            Strength.Points.AddXY("用例2", rd.Next(1, 100));
            Strength.Points.AddXY("用例3", rd.Next(1, 100));
            Strength.Points.AddXY("用例4", rd.Next(1, 100));
            Strength.Points.AddXY("用例5", rd.Next(1, 100));
            Strength.Points.AddXY("用例6", rd.Next(1, 100));*/
            //把series添加到chart上
            chart1.Series.Add(Strength);

            }

            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        void chart1_GetToolTipText(object sender, ToolTipEventArgs e)
        {

            //判断鼠标是否移动到数据标记点，是则显示提示信息
            if (e.HitTestResult.ChartElementType == ChartElementType.DataPoint)
            {
                int i = e.HitTestResult.PointIndex;
                DataPoint dp = e.HitTestResult.Series.Points[i];
                //分别显示x轴和y轴的数值，其中{1:F3},表示显示的是float类型，精确到小数点后3位。                     
                string r = string.Format("用例数量:{0} ", dp.YValues[0] );

                //鼠标相对于窗体左上角的坐标
                Point formPoint = this.PointToClient(Control.MousePosition);
                int x = formPoint.X;
                int y = formPoint.Y;
                //显示提示信息
                this.panel2.Visible = true;
                this.panel2.Location = new Point(x, y);
                this.label7.Text = r;
                Random rd = new Random();
                switch (rd.Next(1, 4))
                {
                    case 1: this.label6.Text = "测试功能：用户登录";break;
                    case 2: this.label6.Text = "测试功能：上传数据"; break;
                    case 3: this.label6.Text = "测试功能：缺陷修复"; break;
                }
                
            }

            //鼠标离开数据标记点，则隐藏提示信息
            else
            {
                this.panel2.Visible = false;
            }
        }
        public void Pie_Load()
        {
            List<string> xData = new List<string>() { "功能缺陷", "设计缺陷", "性能缺陷", "配置缺陷" };
            List<int> yData = new List<int>() { 10, 20, 30, 40 };
            this.chart2.Titles.Add("缺陷数量报表");
            chart2.Series["Series1"].Label = "#PERCENT{P}";
            chart2.Series["Series1"].LegendText = "#VALX";
            chart2.Series[0].Points.DataBindXY(xData, yData);
        }
        public void Line_Load()
        {
            try
            {
                MySqlConnection myconn = null;
                myconn = new MySqlConnection(Global_Database.Conn);
                myconn.Open();
                MessageBox.Show("连接成功");
                string sql = "SELECT * FROM table_bug";
                MySqlCommand command = new MySqlCommand(sql, myconn);
                MySqlDataAdapter adap = new MySqlDataAdapter(command);
                DataSet ds = new DataSet();
                adap.Fill(ds);
                 dtb = ds.Tables[0];
                int k = dtb.Rows.Count, i = 0;
                Random rd = new Random();
                List<int> xData1 = new List<int>();
                List<int> yData1 = new List<int>();

                while ((k--) != 0)
                {
                    xData1.Add((int)dtb.Rows[i]["bug_id"]);
                    yData1.Add(rd.Next(1, 10) * 10);
                    i++;
                }
                chart3.GetToolTipText += new EventHandler<ToolTipEventArgs>(chart3_GetToolTipText);
               // List<string> xData = new List<string>() { "缺陷1", "缺陷2", "缺陷3", "缺陷4" };
                //List<int> yData = new List<int>() { 10, 60, 30, 70 };
                this.chart3.Titles.Add("缺陷严重程度报表");
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
                chart3.Series[0].Points.DataBindXY(xData1, yData1);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        void chart3_GetToolTipText(object sender, ToolTipEventArgs e)
        {

            
                
                //判断鼠标是否移动到数据标记点，是则显示提示信息
                if (e.HitTestResult.ChartElementType == ChartElementType.DataPoint)
                {
                    int i = e.HitTestResult.PointIndex;
                    DataPoint dp = e.HitTestResult.Series.Points[i];
                    //分别显示x轴和y轴的数值，其中{1:F3},表示显示的是float类型，精确到小数点后3位。                     
                    string r = string.Format("等级:{0} ",  dp.YValues[0]/10);
                  
                    //鼠标相对于窗体左上角的坐标
                    Point formPoint = this.PointToClient(Control.MousePosition);
                    int x = formPoint.X;
                    int y = formPoint.Y;
                    //显示提示信息 
                    this.panel1.Visible = true;
                    this.panel1.Location = new Point(x, y);
                int k = dtb.Rows.Count,num= 0;
                while ((k--) != 0)
                {
                    if (dtb.Rows[num]["bug_id"].ToString() == dp.XValue.ToString())
                    {
                        
                        switch (dtb.Rows[num]["bug_reason"])
                        {
                            case 1: this.label2.Text = "原因:功能问题"; break;
                            case 2: this.label2.Text = "原因:接口问题"; break;
                            case 3: this.label2.Text = "原因:逻辑问题"; break;
                            case 4: this.label2.Text = "原因:计算问题"; break;
                            case 5: this.label2.Text = "原因:数据问题"; break;
                            case 6: this.label2.Text = "原因:用户界面问题"; break;
                            case 7: this.label2.Text = "原因:文档问题"; break;
                            case 8: this.label2.Text = "原因:性能问题"; break;
                            case 9: this.label2.Text = "原因:兼容问题"; break;
                            case 10: this.label2.Text = "原因:其他问题"; break;
                        }
                    }
                    num++;
                }
                 
                 this.label3.Text = "名称"+ dtb.Rows[i]["bug_name"]+"  "+r;
                    
                   // this.label4.Text = "所属功能：登录";
                Random rd = new Random();
                switch (rd.Next(1, 4))
                {
                    case 1: this.label4.Text = "所属功能：用户登录"; break;
                    case 2: this.label4.Text = "所属功能：上传数据"; break;
                    case 3: this.label4.Text = "所属功能：缺陷修复"; break;
                }
            }

                //鼠标离开数据标记点，则隐藏提示信息
                else
                {
                    this.panel1.Visible = false;
                }
         
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
            this.chart1.Visible = false;
            this.chart3.Visible = true;
        }

        private void chart3_Click(object sender, EventArgs e)
        {

        }
    }
}
