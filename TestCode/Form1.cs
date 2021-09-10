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

        private void Form1_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.None;
        }

        private void OpenLoad_Click(object sender, EventArgs e)
        {
            FileRead = ReadCSVFile();
            LoadFileText.Text = FileRead;
            if (!string.IsNullOrEmpty(BasicDataText.Text))
            {
                BasicDataText.Text = "";
                DataLogText.Text = "";
            }
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
        Data[] data;
        FileClass FC = new FileClass();
        private void Run()
        {
            if (Air.Checked)
            {
                FC.Choice = ChoiceBtn.AIR;
            }
            else if (TV.Checked)
            {
                FC.Choice = ChoiceBtn.TV;
            }
            else if (Vaccum.Checked)
            {
                FC.Choice = ChoiceBtn.VACCUM;
            }
            else if (Refrig.Checked)
            {
                FC.Choice = ChoiceBtn.REFRIG;
            }
            else if (Dry.Checked)
            {
                FC.Choice = ChoiceBtn.DRY;
            }
            data = FC.ReadFile(FileRead);

            //foreach (var a in data)
            //{
            //    DataLogText.AppendText(a.Number + "\t" + a.Date + "\t" + a.Time + "\t" + a.UE2 + "\t" + a.IE2 + "\t" + a.PE2 + "\t" + a.SE2 + "\t" + a.QE2 + "\t" + a.PFE2 + "\t" + a.DEGE2 + "\t" + a.FUE2 + "\t" + a.FIE2 + "\t" + a.UPlustpkE2 + "\t" + a.UMinuspkE2 + "\t" +a.UMinuspkE2 + "\t" + a.UMinuspkE2);
            //}
        }
        private void button1_Click(object sender, EventArgs e)
        {
            var sfd = new SaveFileDialog();
            sfd.Filter = "csv 파일(*.csv) | *.csv; | 모든파일(*.*)| *.*";
            sfd.OverwritePrompt = true;

            if (sfd.ShowDialog() != DialogResult.OK)
                return;
            Export(sfd.FileName);
        }
        private void Export(string filepath)
        {
            FC.Export(filepath);
           
        }
        private void InfoExport(string filepath)
        {
            FC.InfoExport(filepath);
        }
    }
}
