using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms.DataVisualization.Charting;
using Microsoft.WindowsAPICodePack.Dialogs;
namespace TestCode
{
    public partial class Form1 : Form
    {
        DataClass[] data;
        FileClass FC = new FileClass();
        public string ReadFile { get; private set; }

        public string FileRead { get; private set; }

        private Point mousePoint { get; set; }

        public Form1()
        {
            InitializeComponent();
        }
        public string[] ChartType { get; set; }
        public string[] ChoiceType { get; set; }
       
        private void Form1_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.None;

            ChartType = new string[] { "Point", "FastPoint", "Line", "StepLine", "FastLine", "Bar", "StackedBar", "Column", "StackedColumn", "Area", "Stock", "Candlestick", "Range", "SplineRange", "RangeBar", "RangeColumn" };

            ChoiceType = new string[] { "air", "refrig", "tv", "dry", "vacuum" };

            Box1.Items.AddRange(ChoiceType);
            Box2.Items.AddRange(ChoiceType);
            Box3.Items.AddRange(ChoiceType);
            Box4.Items.AddRange(ChoiceType);
            Box5.Items.AddRange(ChoiceType);
            chart1.Series.Add("IE2");
            chart2.Series.Add("PE2");
            comboBox1.Items.AddRange(ChartType);
            comboBox2.Items.AddRange(ChoiceType);
            comboBox1.SelectedIndex = 2;

            chart1.ChartAreas[0].AxisX.ScaleView.Zoomable = true;
            chart1.ChartAreas[0].AxisY.ScaleView.Zoomable = true;
            chart1.MouseWheel += chart1_MouseWheel;
        }
        private void ChoiceChart()
        {
            
            switch (comboBox1.Text)
            {
                case "Point":
                    chart1.Series["IE2"].ChartType =SeriesChartType.Point;
                    chart2.Series["PE2"].ChartType =SeriesChartType.Point;
                    break;
                case "FastPoint":
                    chart2.Series["PE2"].ChartType =SeriesChartType.FastPoint;
                    chart1.Series["IE2"].ChartType =SeriesChartType.FastPoint;
                    break;
                case "Line":
                    chart2.Series["PE2"].ChartType =SeriesChartType.Line;
                    chart1.Series["IE2"].ChartType =SeriesChartType.Line;
                    break;
                case "StepLine":
                    chart2.Series["PE2"].ChartType =SeriesChartType.StepLine;
                    chart1.Series["IE2"].ChartType =SeriesChartType.StepLine;
                    break;
                case "FastLine":
                    chart2.Series["PE2"].ChartType =SeriesChartType.FastLine;
                    chart1.Series["IE2"].ChartType =SeriesChartType.FastLine;
                    break;
                case "Bar":
                    chart1.Series["IE2"].ChartType =SeriesChartType.Bar;
                    chart2.Series["PE2"].ChartType =SeriesChartType.Bar;
                    break;
                case "StackedBar":
                    chart1.Series["IE2"].ChartType =SeriesChartType.StackedBar;
                    chart2.Series["PE2"].ChartType =SeriesChartType.StackedBar;
                    break;
                case "Column":
                    chart1.Series["IE2"].ChartType =SeriesChartType.Column;
                    chart2.Series["PE2"].ChartType =SeriesChartType.Column;
                    break;
                case "StackedColumn":
                    chart1.Series["IE2"].ChartType =SeriesChartType.StackedColumn;
                    chart2.Series["PE2"].ChartType =SeriesChartType.StackedColumn;
                    break;
                case "Area":
                    chart1.Series["IE2"].ChartType =SeriesChartType.Area;
                    chart2.Series["PE2"].ChartType =SeriesChartType.Area;
                    break;
                case "Stock":
                    chart1.Series["IE2"].ChartType =SeriesChartType.Stock;
                    chart2.Series["PE2"].ChartType =SeriesChartType.Stock;
                    break;
                case "Candlestick":
                    chart1.Series["IE2"].ChartType =SeriesChartType.Candlestick;
                    chart2.Series["PE2"].ChartType =SeriesChartType.Candlestick;
                    break;
                case "Range":
                    chart1.Series["IE2"].ChartType =SeriesChartType.Range;
                    chart2.Series["PE2"].ChartType =SeriesChartType.Range;
                    break;
                case "SplineRange":
                    chart1.Series["IE2"].ChartType =SeriesChartType.SplineRange;
                    chart2.Series["PE2"].ChartType =SeriesChartType.SplineRange;
                    break;
                case "RangeBar":
                    chart1.Series["IE2"].ChartType =SeriesChartType.RangeBar;
                    chart2.Series["PE2"].ChartType =SeriesChartType.RangeBar;
                    break;
                case "RangeColumn":
                    chart1.Series["IE2"].ChartType =SeriesChartType.RangeColumn;
                    chart2.Series["PE2"].ChartType =SeriesChartType.RangeColumn;
                    break;
            }
        }

        private void OpenLoad_Click(object sender, EventArgs e)
        {
            FileRead = ReadCSVFile();
            
            LoadFileText.Text = FileRead;


        }

        public string ReadCSVFile()
        {
            LoadFileDialog.Title = "csv 파일 선택";
            LoadFileDialog.FileName = "";
            LoadFileDialog.Filter = "csv 파일(*.csv) | *.csv; | 모든파일(*.*)| *.*";
            DialogResult dr = LoadFileDialog.ShowDialog();

            if (dr == DialogResult.OK)
            {
                string fileReadName = LoadFileDialog.FileName;
                ReadFile = Path.GetFileNameWithoutExtension(LoadFileDialog.FileName);
                return fileReadName;
            }
            else
            {
                return "";
            }
            
        }
        private void LoadFileText_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] file = (string[])e.Data.GetData(DataFormats.FileDrop);
                {
                    foreach (string str in file)
                    {
                        LoadFileText.Text = str;
                        FileRead = str;
                        ReadFile = Path.GetFileNameWithoutExtension(FileRead);
                    }

                }
            }
        }

        private void LoadFileText_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
        }

        private void MinSizebtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panel9_DoubleClick(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void MaxSizebtn_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void Closebtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void panel9_MouseMove(object sender, MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
            {
                Location = new Point(this.Left - (mousePoint.X - e.X), this.Top - (mousePoint.Y - e.Y));
            }
        }

        private void Form1_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] file = (string[])e.Data.GetData(DataFormats.FileDrop);
                {
                    foreach (string str in file)
                    {
                        LoadFileText.Text = str;
                        FileRead = str;
                        ReadFile = Path.GetFileNameWithoutExtension(FileRead);
                    }

                }
            }
        }

        private void Form1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
        }

        private void START_Click(object sender, EventArgs e)
        {
            Run();
        }

       
        private void Run()
        {
            if (Box1.Text == "air")
            {
                FC.Choice = ChoiceBtn.AIR;
            }
            else if (Box1.Text == "tv")
            {
                if (Box2.Text == "vacuum")
                {
                    FC.Choice = ChoiceBtn.TVVaccum;
                    ThingText = "tv+vacuum";
                }
                else
                {
                    FC.Choice = ChoiceBtn.TV;
                }
            }
            else if (Box1.Text == "vacuum")
            {
                FC.Choice = ChoiceBtn.VACUUM;
            }
            else if (Box1.Text == "refrig")
            {
                if (Box2.Text == "vacuum")
                {
                    FC.Choice = ChoiceBtn.RefrigVaccum;
                    ThingText = "refrig+vacuum";
                }
                else if (Box2.Text == "tv")
                {
                    FC.Choice = ChoiceBtn.RefrigTv;
                    ThingText = "refrig+tv";
                }
                else
                {
                    FC.Choice = ChoiceBtn.REFRIG;
                }
            }
            else if (Box1.Text == "dry")
            {
                if (Box2.Text == "tv")
                {
                    FC.Choice = ChoiceBtn.DryTV;
                    ThingText = "dry+tv";
                }
                else if (Box2.Text == "refrig")
                {
                    FC.Choice = ChoiceBtn.DryRefrig;
                    ThingText = "dry+refrig";
                }
                else if (Box2.Text == "vacuum")
                {
                    FC.Choice = ChoiceBtn.DryVaccum;
                    ThingText = "dry+vacuum";
                }
                else
                {
                    FC.Choice = ChoiceBtn.DRY;
                    ThingText = "dry";
                }
            }
            else
            {

            }
            data = FC.ReadFile(FileRead);
            MadeChart(data);   
            
        }
        private void MadeChart(DataClass[] data)
        {
            ChoiceChart();
            
            chart1.Series["IE2"].Points.Clear();
            chart2.Series["PE2"].Points.Clear();
            string trima;
            foreach (var a in data)
            {
                trima = a.Time.Trim();
                if (double.TryParse(a.IE2, out double doubleI))
                {
                    chart1.Series["IE2"].Points.AddXY(a.Time, doubleI);
                }
                else
                {
                    chart1.Series["IE2"].Points.AddXY(a.Time, 0);

                }
                if (double.TryParse(a.PE2, out double doubleP))
                {
                    chart2.Series["PE2"].Points.AddXY(a.Time, doubleP);
                }
                else
                {
                    chart2.Series["PE2"].Points.AddXY(a.Time, 0);
                }
            }
        }
        private void Export(string filepath)
        {
            FC.Export(filepath);           
        }
        private void InfoExport(string filepath)
        {
            FC.InfoExport(filepath);
        }


        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (data != null)
            {
                MadeChart(data);
            }
        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }
        private void panel9_MouseDown(object sender, MouseEventArgs e)
        {
                mousePoint = new Point(e.X, e.Y);
        }

        private void chart1_Click(object sender, EventArgs e)
        {
        }
        string ThingText;
        private void button2_Click(object sender, EventArgs e)
        {
            //var sfd = new SaveFileDialog();
            //sfd.Filter = "csv 파일(*.csv) | *.csv; | 모든파일(*.*)| *.*";
            //sfd.OverwritePrompt = true;
            //sfd.FileName = ""
            //if (sfd.ShowDialog() != DialogResult.OK)
            //    return;
            CommonOpenFileDialog fvd = new CommonOpenFileDialog(); 
            fvd.IsFolderPicker = true;
            if (fvd.ShowDialog() != CommonFileDialogResult.Ok)
            {
                return;
            }


            string datetime = DateTime.Now.ToString("yyMMdd");
            string NumText;



            if (textBox3.Text == "1")
            {
                NumText = textBox3.Text + "st";
            }
            else if(textBox3.Text=="2")
            {
                NumText = textBox3.Text + "nd";
            }
            else if(textBox3.Text =="3")
            {
                NumText = textBox3.Text + "rd";
            }
            else
                NumText= textBox3.Text + "th";
            string csv = ".csv";

            string Nametest = fvd.FileName + "\\" + datetime + "_grida_" + ThingText + "_" + NumText;
            string Name1 = Nametest + csv;
            string Name2 = Nametest + "_info"+csv;
            if (MessageBox.Show("저장합니다", "저장", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Export(Name1);
                InfoExport(Name2);
            }
            else
            {

            }
        }





        private void button3_Click(object sender, EventArgs e)
        {
            FC.Labeling(data,comboBox2.Text, startnum, stopnum);
            MessageBox.Show("라벨링 ㄴ완료");
        }
        string startnum, stopnum;
        private void chart1_MouseClick(object sender, MouseEventArgs e)
        {
            EventMouseClick(chart1, e);
        }
        //Point? prevPosition = null;
        //ToolTip tooltip = new ToolTip();
        private void chart1_MouseMove(object sender, MouseEventArgs e)
        {
            //var pos = e.Location;
            //if (prevPosition.HasValue && pos == prevPosition.Value)
            //    return;
            //tooltip.RemoveAll();
            //prevPosition = pos;
            //var results = chart1.HitTest(pos.X, pos.Y, false,
            //                             ChartElementType.PlottingArea);
            //foreach (var result in results)
            //{
            //    if (result.ChartElementType == ChartElementType.PlottingArea)
            //    {
            //        var xVal = result.ChartArea.AxisX.PixelPositionToValue(pos.X);
            //        var yVal = result.ChartArea.AxisY.PixelPositionToValue(pos.Y);

            //        tooltip.Show("X=" + xVal + ", Y=" + yVal, this.chart1,
            //                     pos.X, pos.Y - 15);
            //    }
            //}
        }
        double time1;
        double time2;
        private void button4_Click(object sender, EventArgs e)
        {


            foreach (var a in data)
            {
                if(textBox4.Text==a.Time)
                {
                    //time1 = DateTime.Parse(a.Time).ToOADate();
                    time1 = double.Parse(a.Number);
                }
                if (textBox5.Text == a.Time)
                {
                    //time2 = DateTime.Parse(a.Time).ToOADate();
                    time2 = double.Parse(a.Number);
                }

            }
            //ax.ScaleView.Zoom(double.Parse(textBox4.Text), double.Parse(textBox5.Text));

            chart1.Series["IE2"].XValueType = ChartValueType.DateTime;
            chart2.Series["PE2"].XValueType = ChartValueType.DateTime;
            //chart1.ChartAreas[0].AxisX.LabelStyle.Format = "HH:mm:ss";
            //chart1.ChartAreas[0].AxisX.

            //DateTime mindt = DateTime.Parse(textBox4.Text);
            //DateTime maxdt = DateTime.Parse(textBox5.Text);
            ////DateTime maxdt = DateTime.ParseExact(textBox5.Text, timeformat, null);
            ////chart1.ChartAreas[0].AxisX.Interval = 1;
            //chart1.ChartAreas[0].AxisX.Minimum = mindt.ToOADate();
            //chart1.ChartAreas[0].AxisX.Maximum = maxdt.ToOADate();

            //chart1.ChartAreas[0].AxisX.Minimum = DateTime.Parse(time1).ToOADate();
            //chart1.ChartAreas[0].AxisX.Maximum = DateTime.Parse(time2).ToOADate();
            chart1.ChartAreas[0].AxisX.LabelStyle.Format = "hh:mm:ss";
            chart2.ChartAreas[0].AxisX.LabelStyle.Format = "hh:mm:ss";
            //chart1.ChartAreas[0].AxisX.Minimum = time1;
            //chart1.ChartAreas[0].AxisX.Maximum = time2;
            chart1.ChartAreas[0].AxisX.ScaleView.Zoom(time1, time2);
            chart2.ChartAreas[0].AxisX.ScaleView.Zoom(time1, time2);



        }
        int count = 0;
        public void EventMouseClick(Chart chart, MouseEventArgs e)
        {
            try
            {
                int a, b;
                
                a = (int)chart.ChartAreas[0].AxisX.PixelPositionToValue(e.X);
                b = (int)chart.ChartAreas[0].AxisY.PixelPositionToValue(e.Y);


                foreach (var d in data)
                {
                    if (a.ToString() == d.Number.Trim())
                    {
                        if (count == 0)
                        {
                            if (MessageBox.Show("시작 시간 " + d.Time +
                                                "\r\n전류 " + d.IE2 + "전력 " + d.PE2 + "가 맞으십니까", "선택", MessageBoxButtons.YesNo) == DialogResult.Yes)
                            {
                                textBox6.Text = d.Time;
                                startnum = d.Number;
                                count++;
                                break;
                            }
                            else
                            {
                                break;
                            }
                        }
                        else
                        {
                            if (MessageBox.Show("종료 시간 " + a.ToString() + "가 맞으십니까", "선택", MessageBoxButtons.YesNo) == DialogResult.Yes)
                            {
                                textBox7.Text = d.Time;
                                stopnum = d.Number;
                                count = 0;
                                break;
                            }
                            else
                            {
                                break;
                            }
                        }

                    }
                }
            }
            catch
            {

            }
        }
        private void chart2_MouseClick(object sender, MouseEventArgs e)
        {
            EventMouseClick(chart2, e);
        }

        private void chart1_MouseWheel(object sender, MouseEventArgs e)
        {
            var chart = (Chart)sender;
            var xAxis = chart.ChartAreas[0].AxisX;
            var yAxis = chart.ChartAreas[0].AxisY;


            var xMin = xAxis.ScaleView.ViewMinimum;
            var xMax = xAxis.ScaleView.ViewMaximum;
            var yMin = yAxis.ScaleView.ViewMinimum;
            var yMax = yAxis.ScaleView.ViewMaximum;
            try
            {
                if (e.Delta < 0) // Scrolled down.
                {
                    xAxis.ScaleView.ZoomReset();
                    yAxis.ScaleView.ZoomReset();
                }
                else if (e.Delta > 0) // Scrolled up.
                {


                    var posXStart = xAxis.PixelPositionToValue(e.Location.X) - (xMax - xMin) / 2;
                    var posXFinish = xAxis.PixelPositionToValue(e.Location.X) + (xMax - xMin) / 2;
                    var posYStart = yAxis.PixelPositionToValue(e.Location.Y) - (yMax - yMin) / 2;
                    var posYFinish = yAxis.PixelPositionToValue(e.Location.Y) + (yMax - yMin) / 2;

                    xAxis.ScaleView.Zoom(posXStart, posXFinish);
                    yAxis.ScaleView.Zoom(posYStart, posYFinish);
                }
            }
            catch { }
        }
    }
}
