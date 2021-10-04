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
namespace TestCode
{
    public partial class Form1 : Form
    {
        public string ReadFile { get; private set; }

        public string FileRead { get; private set; }

        private Point mousePoint { get; set; }

        public Form1()
        {
            InitializeComponent();
        }
        public string[] ChartType { get; set; }
        public string[] ChoiceType { get; set; }

        Axis ax,ay;
        private void Form1_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.None;

            ChartType = new string[] { "Point", "FastPoint", "Line", "StepLine", "FastLine", "Bar", "StackedBar", "Column", "StackedColumn", "Area", "Stock", "Candlestick", "Range", "SplineRange", "RangeBar", "RangeColumn" };

            ChoiceType = new string[] { "Air", "Refrig", "TV", "Dry", "Vacuum" };

            Box1.Items.AddRange(ChoiceType);
            Box2.Items.AddRange(ChoiceType);
            Box3.Items.AddRange(ChoiceType);
            Box4.Items.AddRange(ChoiceType);
            Box5.Items.AddRange(ChoiceType);
            chart1.Series.Add("IE2");
            chart2.Series.Add("PE2");
            comboBox1.Items.AddRange(ChartType);

            comboBox1.SelectedIndex = 2;

            ax = chart1.ChartAreas[0].AxisX;
            ay = chart1.ChartAreas[0].AxisY;
            

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

        private void SaveFile_Click(object sender, EventArgs e)
        {
            string FolderWrite = WriteCSVFolder();
            InfoExport(FolderWrite);
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
        public string WriteCSVFolder()
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "csv 파일(*.csv) | *.csv; | 모든파일(*.*)| *.*";
            sfd.OverwritePrompt = true;

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                string FolderWriteName = sfd.FileName;
                
                return FolderWriteName;

                
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

        private void FirstText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar)) && e.KeyChar != '.' && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void ReadNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back)))
            {
                e.Handled = true;
            }
        }

        private void PlusText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar)) && e.KeyChar != '.' && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void MinusText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar)) && e.KeyChar != '.' && e.KeyChar != 8)
            {
                e.Handled = true;
            }
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
        DataClass[] data;
        FileClass FC = new FileClass();
        private void Test()
        {
            //if (AirCheck.Checked)
            //{
            //    if (RefrigCheck.Checked)
            //    {                   
            //        if (TVCheck.Checked)
            //        {
            //            if(DryCheck.Checked)
            //            {                            
            //                if(VacuumCheck.Checked)
            //                {
            //                    FC.Choice = ChoiceBtn.AirRefrigTvDryVaccum;
            //                }else
            //                {
            //                    FC.Choice = ChoiceBtn.AirRefrigTvDry;
            //                }
            //            }
            //            else if(VacuumCheck.Checked)
            //            {
            //                FC.Choice = ChoiceBtn.AirRefrigTvVaccum;
            //            }
            //            else
            //            {
            //                FC.Choice = ChoiceBtn.AirRefrigTv;
            //            }
            //        }else if(DryCheck.Checked)
            //        {
                        
            //            if(VacuumCheck.Checked)
            //            {
            //                FC.Choice = ChoiceBtn.AirRefrigDryVaccum;
            //            }else
            //            {
            //                FC.Choice = ChoiceBtn.AirRefrigDry;
            //            }
            //        }else if(VacuumCheck.Checked)
            //        {
            //            FC.Choice = ChoiceBtn.AirRefrigVaccum;
            //        }else
            //        {
            //            FC.Choice = ChoiceBtn.AirRefrig;
            //        }
            //    }
            //    else if(TVCheck.Checked)
            //    {
            //        if (DryCheck.Checked)
            //        {
            //            if (VacuumCheck.Checked)
            //            {
            //                FC.Choice = ChoiceBtn.AirTVDryVacuum;
            //            }
            //            else
            //            {
            //                FC.Choice = ChoiceBtn.AirTVDry;
            //            }
            //        }
            //        else if (VacuumCheck.Checked)
            //        {
            //            FC.Choice = ChoiceBtn.AirTvVaccuum;
            //        }
            //        else
            //        {
            //            FC.Choice = ChoiceBtn.AirTv;
            //        }
            //    }
            //    else if(DryCheck.Checked)
            //    {
            //        if (VacuumCheck.Checked)
            //        {
            //            FC.Choice = ChoiceBtn.AirDryVaccum;
            //        }
            //        else
            //        {
            //            FC.Choice = ChoiceBtn.AirDry;
            //        }
            //    }
            //    else if(VacuumCheck.Checked)
            //    {
            //        FC.Choice = ChoiceBtn.AirVaccum;
            //    }else
            //    {
            //        FC.Choice = ChoiceBtn.AIR;
            //    }
            //}else if(RefrigCheck.Checked)
            //{
            //    if(TVCheck.Checked)
            //    {
            //        if(DryCheck.Checked)
            //        {
            //            if(VacuumCheck.Checked)
            //            {
            //                FC.Choice = ChoiceBtn.RefrigTvDryVaccum;
            //            }
            //            else
            //            {
            //                FC.Choice = ChoiceBtn.RefrigTvDry;
            //            }
            //        }
            //        else if(VacuumCheck.Checked)
            //        {
            //            FC.Choice = ChoiceBtn.RefirgTvVaccum;
            //        }
            //        else
            //        {
            //            FC.Choice = ChoiceBtn.RefrigDry;
            //        }
            //    }else if(DryCheck.Checked)
            //    {
            //        if(VacuumCheck.Checked)
            //        {
            //            FC.Choice = ChoiceBtn.RefrigDryVaccum;
            //        }
            //        else
            //        {
            //            FC.Choice = ChoiceBtn.RefrigDry;
            //        }

            //    }else if(VacuumCheck.Checked)
            //    {
            //        FC.Choice = ChoiceBtn.RefrigVaccum;
            //    }
            //    else
            //    {
            //        FC.Choice = ChoiceBtn.REFRIG;
            //    }
                
            //}else if (TVCheck.Checked)
            //{
            //    if(DryCheck.Checked)
            //    {
            //        if(VacuumCheck.Checked)
            //        {
            //            FC.Choice = ChoiceBtn.TvDryVaccum;
            //        }
            //        else
            //        {
            //            FC.Choice = ChoiceBtn.TvDry;
            //        }
            //    }else if(VacuumCheck.Checked)
            //    {
            //        FC.Choice = ChoiceBtn.TvVaccum;
            //    }
            //    else
            //    {
            //        FC.Choice = ChoiceBtn.TV;
            //    }
            //}else if (DryCheck.Checked)
            //{
            //    if (VacuumCheck.Checked)
            //    {
            //        FC.Choice = ChoiceBtn.DryVaccum;
            //    }
            //    else
            //    {
            //        FC.Choice = ChoiceBtn.DRY;
            //    }

            //}else
            //{
            //    FC.Choice = ChoiceBtn.VACUUM;
            //}

        }
        //private void TestComboBox()
        //{
        //    if (Box1.Text =="air")
        //    {
        //        if (Box2.Text =="refrig")
        //        {
        //            if (Box3.Text =="tv")
        //            {
        //                if (Box4.Text == "dry")
        //                {
        //                    if (Box5.Text == "vaccum")
        //                    {
        //                        FC.Choice = ChoiceBtn.AirRefrigTVDryVaccum;
        //                    }
        //                    else
        //                    {
        //                        FC.Choice = ChoiceBtn.AirRefrigTvDry;
        //                    }
        //                }
        //                else if (box4.text == "vacuum")
        //                {
        //                    fc.choice = choicebtn.airrefrigtvvaccum;
        //                }
        //                else 
        //                {
        //                    fc.choice = choicebtn.airrefrigtv;
        //                }
        //            }
        //            else if (box3.text =="dry")
        //            {
        //                if (vacuumcheck.checked)
        //                {
        //                    fc.choice = choicebtn.airrefrigdryvaccum;
        //                }
        //                else
        //                {
        //                    fc.choice = choicebtn.airrefrigdry;
        //                }
        //            }
        //            else if (box3.text == "vacuum")
        //            {
        //                fc.choice = choicebtn.airrefrigvaccum;
        //            }
        //            else
        //            {
        //                fc.choice = choicebtn.airrefrig;
        //            }
        //        }
        //        else if (box2.text=="tv")
        //        {
        //            if (drycheck.checked)
        //            {
        //                if (vacuumcheck.checked)
        //                {
        //                    fc.choice = choicebtn.airtvdryvacuum;
        //                }
        //                else
        //                {
        //                    fc.choice = choicebtn.airtvdry;
        //                }
        //            }
        //            else if (vacuumcheck.checked)
        //            {
        //                fc.choice = choicebtn.airtvvaccuum;
        //            }
        //            else
        //            {
        //                fc.choice = choicebtn.airtv;
        //            }
        //        }
        //        else if (box2.text=="dry")
        //        {
        //            if (vacuumcheck.checked)
        //            {
        //                fc.choice = choicebtn.airdryvaccum;
        //            }
        //            else
        //            {
        //                fc.choice = choicebtn.airdry;
        //            }
        //        }
        //        else if (box2.text =="vacuum")
        //        {
        //            fc.choice = choicebtn.airvaccum;
        //        }
        //        else
        //        {
        //            fc.choice = choicebtn.air;
        //        }
        //    }
        //    else if (refrigcheck.checked)
        //    {
        //        if (tvcheck.checked)
        //        {
        //            if (drycheck.checked)
        //            {
        //                if (vacuumcheck.checked)
        //                {
        //                    fc.choice = choicebtn.refrigtvdryvaccum;
        //                }
        //                else
        //                {
        //                    fc.choice = choicebtn.refrigtvdry;
        //                }
        //            }
        //            else if (vacuumcheck.checked)
        //            {
        //                fc.choice = choicebtn.refirgtvvaccum;
        //            }
        //            else
        //            {
        //                fc.choice = choicebtn.refrigdry;
        //            }
        //        }
        //        else if (drycheck.checked)
        //        {
        //            if (vacuumcheck.checked)
        //            {
        //                fc.choice = choicebtn.refrigdryvaccum;
        //            }
        //            else
        //            {
        //                fc.choice = choicebtn.refrigdry;
        //            }

        //        }
        //        else if (vacuumcheck.checked)
        //        {
        //            fc.choice = choicebtn.refrigvaccum;
        //        }
        //        else
        //        {
        //            fc.choice = choicebtn.refrig;
        //        }

        //    }
        //    else if (tvcheck.checked)
        //    {
        //        if (drycheck.checked)
        //        {
        //            if (vacuumcheck.checked)
        //            {
        //                fc.choice = choicebtn.tvdryvaccum;
        //            }
        //            else
        //            {
        //                fc.choice = choicebtn.tvdry;
        //            }
        //        }
        //        else if (vacuumcheck.checked)
        //        {
        //            fc.choice = choicebtn.tvvaccum;
        //        }
        //        else
        //        {
        //            fc.choice = choicebtn.tv;
        //        }
        //    }
        //    else if (drycheck.checked)
        //    {
        //        if (vacuumcheck.checked)
        //        {
        //            fc.choice = choicebtn.dryvaccum;
        //        }
        //        else
        //        {
        //            fc.choice = choicebtn.dry;
        //        }

        //    }
        //    else
        //    {
        //        fc.choice = choicebtn.vacuum;
        //    }

        //}
        private void Run()
        {
            if (AirCheck.Checked)
            {
                FC.Choice = ChoiceBtn.AIR;
            }
            else if (TVCheck.Checked)
            {
                FC.Choice = ChoiceBtn.TV;
            }
            else if (VacuumCheck.Checked)
            {
                FC.Choice = ChoiceBtn.VACUUM;
            }
            else if (RefrigCheck.Checked)
            {
                FC.Choice = ChoiceBtn.REFRIG;
            }
            else if (DryCheck.Checked)
            {
                FC.Choice = ChoiceBtn.DRY;
            }
            data = FC.ReadFile(FileRead,textBox1.Text,textBox2.Text);

            //foreach (var a in data)
            //{
            //    DataLogText.AppendText(a.Number + "\t" + a.Date + "\t" + a.Time + "\t" + a.UE2 + "\t" + a.IE2 + "\t" + a.PE2 + "\t" + a.SE2 + "\t" + a.QE2 + "\t" + a.PFE2 + "\t" + a.DEGE2 + "\t" + a.FUE2 + "\t" + a.FIE2 + "\t" + a.UPlustpkE2 + "\t" + a.UMinuspkE2 + "\t" +a.UMinuspkE2 + "\t" + a.UMinuspkE2);
            //}
            MadeChart(data);                       
        }
        private void MadeChart(DataClass[] data)
        {
            //chart1.Series["Data"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            ChoiceChart();
            chart1.Series["IE2"].Points.Clear();
            chart2.Series["PE2"].Points.Clear();
            //chart1.Series.Add("PE2");
            foreach (var a in data)
            {
                
                if (double.TryParse(a.IE2, out double doubleI))
                {
                    chart1.Series["IE2"].Points.AddXY(a.Time,doubleI);
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
        private void button1_Click(object sender, EventArgs e)
        {
            var sfd = new SaveFileDialog();
            sfd.Filter = "csv 파일(*.csv) | *.csv; | 모든파일(*.*)| *.*";
            sfd.OverwritePrompt = true;

            if (sfd.ShowDialog() != DialogResult.OK)
                return;
            if(MessageBox.Show("저장합니다","저장",MessageBoxButtons.YesNo)== DialogResult.Yes)
            {
                Export(sfd.FileName);
            }else
            {

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

        private void Box1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(Box1.Text=="Air")
            {
                Box2.Items.Remove("Air");
                Box3.Items.Remove("Air");
                Box4.Items.Remove("Air");
                Box5.Items.Remove("Air");
            }else if(Box1.Text=="Refrig")
            {
                Box2.Items.Remove("Refrig");
                Box3.Items.Remove("Refrig");
                Box4.Items.Remove("Refrig");
                Box5.Items.Remove("Refrig");
            }else if(Box1.Text=="TV")
            {
                Box2.Items.Remove("TV");
                Box3.Items.Remove("TV");
                Box4.Items.Remove("TV");
                Box5.Items.Remove("TV");
            }else if(Box1.Text=="Dry")
            {
                Box2.Items.Remove("Dry");
                Box3.Items.Remove("Dry");
                Box4.Items.Remove("Dry");
                Box5.Items.Remove("Dry");
            }else if(Box1.Text=="Vacuum")
            {
                Box2.Items.Remove("Vacuum");
                Box3.Items.Remove("Vacuum");
                Box4.Items.Remove("Vacuum");
                Box5.Items.Remove("Vacuum");
            }
        }

        private void Box2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Box2.Text == "Air")
            {
                Box3.Items.Remove("Air");
                Box4.Items.Remove("Air");
                Box5.Items.Remove("Air");
            }
            else if (Box2.Text == "Refrig")
            {
                Box3.Items.Remove("Refrig");
                Box4.Items.Remove("Refrig");
                Box5.Items.Remove("Refrig");
            }
            else if (Box2.Text == "TV")
            {
                Box3.Items.Remove("TV");
                Box4.Items.Remove("TV");
                Box5.Items.Remove("TV");
            }
            else if (Box2.Text == "Dry")
            {
                Box3.Items.Remove("Dry");
                Box4.Items.Remove("Dry");
                Box5.Items.Remove("Dry");
            }
            else if (Box2.Text == "Vacuum")
            {
                Box3.Items.Remove("Vacuum");
                Box4.Items.Remove("Vacuum");
                Box5.Items.Remove("Vacuum");
            }
        }

        private void Box3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Box3.Text == "Air")
            {
                Box4.Items.Remove("Air");
                Box5.Items.Remove("Air");
            }
            else if (Box3.Text == "Refrig")
            {
                Box4.Items.Remove("Refrig");
                Box5.Items.Remove("Refrig");
            }
            else if (Box3.Text == "TV")
            {
                Box4.Items.Remove("TV");
                Box5.Items.Remove("TV");
            }
            else if (Box3.Text == "Dry")
            {
                Box4.Items.Remove("Dry");
                Box5.Items.Remove("Dry");
            }
            else if (Box3.Text == "Vacuum")
            {
                Box4.Items.Remove("Vacuum");
                Box5.Items.Remove("Vacuum");
            }
        }

        private void Box4_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Box4.Text == "Air")
            {
                Box5.Items.Remove("Air");
            }
            else if (Box4.Text == "Refrig")
            {
                Box5.Items.Remove("Refrig");
            }
            else if (Box4.Text == "TV")
            {
                Box5.Items.Remove("TV");
            }
            else if (Box4.Text == "Dry")
            {
                Box5.Items.Remove("Dry");
            }
            else if (Box4.Text == "Vacuum")
            {
                Box5.Items.Remove("Vacuum");
            }
        }

        private void IE2_CheckedChanged(object sender, EventArgs e)
        {
            if (data != null)
            {
                MadeChart(data);
            }
        }

        private void PE2_CheckedChanged(object sender, EventArgs e)
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

            var fvd = new FolderBrowserDialog();
            if (fvd.ShowDialog() != DialogResult.OK)
                return;

            string datetime = DateTime.Now.ToString("yymmdd");
            
            if (AirCheck.Checked)
                ThingText = "air";
            else if (RefrigCheck.Checked)
                ThingText = "refrig";
            else if (TVCheck.Checked)
                ThingText = "tv";
            else if (DryCheck.Checked)
                ThingText = "dry";
            else if (VacuumCheck.Checked)
                ThingText = "vacuum";
            else
                ThingText = "0";
            string NumText = textBox3.Text + "th";
            string csv = ".csv";

            string Nametest = fvd.SelectedPath + "\\" + datetime + "_grida_" + ThingText + "_" + NumText;
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

        private void button4_Click(object sender, EventArgs e)
        {
            
            //ax.ScaleView.Zoom(double.Parse(textBox4.Text), double.Parse(textBox5.Text));

            chart1.Series["IE2"].XValueType = ChartValueType.DateTime;
            chart1.ChartAreas[0].AxisX.LabelStyle.Format = "hh:mm:ss";

            string timeformat = "hh:mm:ss";
            DateTime mindt = DateTime.Parse(textBox4.Text);
            DateTime maxdt = DateTime.Parse(textBox5.Text);
            //DateTime maxdt = DateTime.ParseExact(textBox5.Text, timeformat, null);
            chart1.ChartAreas[0].AxisX.Interval = 1;
            chart1.ChartAreas[0].AxisX.Minimum = mindt.ToOADate();
            chart1.ChartAreas[0].AxisX.Minimum = maxdt.ToOADate();

        }
    }
}
