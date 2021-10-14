namespace TestCode
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.panel12 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.START = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Box5 = new System.Windows.Forms.ComboBox();
            this.Box4 = new System.Windows.Forms.ComboBox();
            this.Box3 = new System.Windows.Forms.ComboBox();
            this.Box2 = new System.Windows.Forms.ComboBox();
            this.Box1 = new System.Windows.Forms.ComboBox();
            this.Closebtn = new System.Windows.Forms.Button();
            this.MinSizebtn = new System.Windows.Forms.Button();
            this.MaxSizebtn = new System.Windows.Forms.Button();
            this.LoadFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.panel9 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LoadFileText = new System.Windows.Forms.TextBox();
            this.OpenLoad = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.MaskedTextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.MaskedTextBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.panel12.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel12.Controls.Add(this.panel7);
            this.panel12.Controls.Add(this.START);
            this.panel12.Controls.Add(this.panel3);
            this.panel12.Location = new System.Drawing.Point(27, 93);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(977, 46);
            this.panel12.TabIndex = 90;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.White;
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Controls.Add(this.comboBox2);
            this.panel7.Controls.Add(this.button3);
            this.panel7.Controls.Add(this.textBox7);
            this.panel7.Controls.Add(this.textBox6);
            this.panel7.Location = new System.Drawing.Point(3, 3);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(382, 37);
            this.panel7.TabIndex = 73;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(302, 5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Labeling";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(196, 7);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(100, 21);
            this.textBox7.TabIndex = 1;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(90, 7);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 21);
            this.textBox6.TabIndex = 0;
            // 
            // START
            // 
            this.START.BackColor = System.Drawing.Color.Teal;
            this.START.FlatAppearance.BorderSize = 0;
            this.START.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.START.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.START.ForeColor = System.Drawing.Color.White;
            this.START.Location = new System.Drawing.Point(825, 3);
            this.START.Name = "START";
            this.START.Size = new System.Drawing.Size(147, 37);
            this.START.TabIndex = 11;
            this.START.Text = "오류값 처리";
            this.START.UseVisualStyleBackColor = false;
            this.START.Click += new System.EventHandler(this.START_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.Box5);
            this.panel3.Controls.Add(this.Box4);
            this.panel3.Controls.Add(this.Box3);
            this.panel3.Controls.Add(this.Box2);
            this.panel3.Controls.Add(this.Box1);
            this.panel3.Location = new System.Drawing.Point(411, 6);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(399, 28);
            this.panel3.TabIndex = 102;
            // 
            // Box5
            // 
            this.Box5.FormattingEnabled = true;
            this.Box5.Location = new System.Drawing.Point(326, 3);
            this.Box5.Name = "Box5";
            this.Box5.Size = new System.Drawing.Size(72, 20);
            this.Box5.TabIndex = 0;
            // 
            // Box4
            // 
            this.Box4.FormattingEnabled = true;
            this.Box4.Location = new System.Drawing.Point(248, 3);
            this.Box4.Name = "Box4";
            this.Box4.Size = new System.Drawing.Size(72, 20);
            this.Box4.TabIndex = 0;
            // 
            // Box3
            // 
            this.Box3.FormattingEnabled = true;
            this.Box3.Location = new System.Drawing.Point(170, 3);
            this.Box3.Name = "Box3";
            this.Box3.Size = new System.Drawing.Size(72, 20);
            this.Box3.TabIndex = 0;
            // 
            // Box2
            // 
            this.Box2.FormattingEnabled = true;
            this.Box2.Location = new System.Drawing.Point(87, 3);
            this.Box2.Name = "Box2";
            this.Box2.Size = new System.Drawing.Size(78, 20);
            this.Box2.TabIndex = 0;
            // 
            // Box1
            // 
            this.Box1.FormattingEnabled = true;
            this.Box1.Location = new System.Drawing.Point(6, 3);
            this.Box1.Name = "Box1";
            this.Box1.Size = new System.Drawing.Size(75, 20);
            this.Box1.TabIndex = 0;
            // 
            // Closebtn
            // 
            this.Closebtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Closebtn.BackColor = System.Drawing.Color.Transparent;
            this.Closebtn.FlatAppearance.BorderSize = 0;
            this.Closebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Closebtn.ForeColor = System.Drawing.Color.White;
            this.Closebtn.Location = new System.Drawing.Point(1006, 0);
            this.Closebtn.Name = "Closebtn";
            this.Closebtn.Size = new System.Drawing.Size(30, 30);
            this.Closebtn.TabIndex = 64;
            this.Closebtn.Text = "X";
            this.Closebtn.UseVisualStyleBackColor = false;
            this.Closebtn.Click += new System.EventHandler(this.Closebtn_Click);
            // 
            // MinSizebtn
            // 
            this.MinSizebtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MinSizebtn.BackColor = System.Drawing.Color.Transparent;
            this.MinSizebtn.FlatAppearance.BorderSize = 0;
            this.MinSizebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinSizebtn.ForeColor = System.Drawing.Color.White;
            this.MinSizebtn.Location = new System.Drawing.Point(946, 0);
            this.MinSizebtn.Name = "MinSizebtn";
            this.MinSizebtn.Size = new System.Drawing.Size(30, 30);
            this.MinSizebtn.TabIndex = 66;
            this.MinSizebtn.Text = "―";
            this.MinSizebtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.MinSizebtn.UseVisualStyleBackColor = false;
            this.MinSizebtn.Click += new System.EventHandler(this.MinSizebtn_Click);
            // 
            // MaxSizebtn
            // 
            this.MaxSizebtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MaxSizebtn.BackColor = System.Drawing.Color.Transparent;
            this.MaxSizebtn.FlatAppearance.BorderSize = 0;
            this.MaxSizebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MaxSizebtn.ForeColor = System.Drawing.Color.White;
            this.MaxSizebtn.Location = new System.Drawing.Point(976, 0);
            this.MaxSizebtn.Name = "MaxSizebtn";
            this.MaxSizebtn.Size = new System.Drawing.Size(30, 30);
            this.MaxSizebtn.TabIndex = 65;
            this.MaxSizebtn.Text = "□";
            this.MaxSizebtn.UseVisualStyleBackColor = false;
            this.MaxSizebtn.Click += new System.EventHandler(this.MaxSizebtn_Click);
            // 
            // LoadFileDialog
            // 
            this.LoadFileDialog.FileName = "openFileDialog1";
            // 
            // panel9
            // 
            this.panel9.AllowDrop = true;
            this.panel9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel9.BackColor = System.Drawing.Color.Teal;
            this.panel9.Controls.Add(this.label6);
            this.panel9.Controls.Add(this.Closebtn);
            this.panel9.Controls.Add(this.MinSizebtn);
            this.panel9.Controls.Add(this.MaxSizebtn);
            this.panel9.Location = new System.Drawing.Point(-1, 0);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(1038, 30);
            this.panel9.TabIndex = 89;
            this.panel9.Paint += new System.Windows.Forms.PaintEventHandler(this.panel9_Paint);
            this.panel9.DoubleClick += new System.EventHandler(this.panel9_DoubleClick);
            this.panel9.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel9_MouseDown);
            this.panel9.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel9_MouseMove);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(12, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 12);
            this.label6.TabIndex = 67;
            this.label6.Text = "Data Labeling Helper";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Location = new System.Drawing.Point(26, 86);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(980, 1);
            this.panel1.TabIndex = 88;
            // 
            // LoadFileText
            // 
            this.LoadFileText.AllowDrop = true;
            this.LoadFileText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LoadFileText.CausesValidation = false;
            this.LoadFileText.Location = new System.Drawing.Point(27, 56);
            this.LoadFileText.Name = "LoadFileText";
            this.LoadFileText.ReadOnly = true;
            this.LoadFileText.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LoadFileText.Size = new System.Drawing.Size(875, 21);
            this.LoadFileText.TabIndex = 85;
            this.LoadFileText.DragDrop += new System.Windows.Forms.DragEventHandler(this.LoadFileText_DragDrop);
            this.LoadFileText.DragEnter += new System.Windows.Forms.DragEventHandler(this.LoadFileText_DragEnter);
            // 
            // OpenLoad
            // 
            this.OpenLoad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.OpenLoad.BackColor = System.Drawing.Color.Teal;
            this.OpenLoad.FlatAppearance.BorderSize = 0;
            this.OpenLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OpenLoad.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.OpenLoad.ForeColor = System.Drawing.Color.White;
            this.OpenLoad.Location = new System.Drawing.Point(908, 56);
            this.OpenLoad.Name = "OpenLoad";
            this.OpenLoad.Size = new System.Drawing.Size(99, 21);
            this.OpenLoad.TabIndex = 86;
            this.OpenLoad.Text = "Open";
            this.OpenLoad.UseVisualStyleBackColor = false;
            this.OpenLoad.Click += new System.EventHandler(this.OpenLoad_Click);
            // 
            // chart1
            // 
            this.chart1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea3.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart1.Legends.Add(legend3);
            this.chart1.Location = new System.Drawing.Point(26, 190);
            this.chart1.Name = "chart1";
            this.chart1.Size = new System.Drawing.Size(484, 254);
            this.chart1.TabIndex = 99;
            this.chart1.Text = "chart1";
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            this.chart1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.chart1_MouseClick);
            this.chart1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.chart1_MouseMove);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(908, 164);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(96, 20);
            this.comboBox1.TabIndex = 100;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 12);
            this.label1.TabIndex = 105;
            this.label1.Text = "시작 시간";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(95, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 12);
            this.label2.TabIndex = 105;
            this.label2.Text = "종료 시간";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(96, 161);
            this.textBox2.Mask = "00:00:00";
            this.textBox2.Name = "textBox2";
            this.textBox2.ResetOnSpace = false;
            this.textBox2.Size = new System.Drawing.Size(64, 21);
            this.textBox2.TabIndex = 106;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button2.Location = new System.Drawing.Point(166, 450);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 49);
            this.button2.TabIndex = 107;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox3
            // 
            this.textBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox3.Location = new System.Drawing.Point(105, 450);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(54, 21);
            this.textBox3.TabIndex = 108;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 453);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 12);
            this.label3.TabIndex = 109;
            this.label3.Text = "몇 번 째";
            // 
            // chart2
            // 
            this.chart2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea4.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chart2.Legends.Add(legend4);
            this.chart2.Location = new System.Drawing.Point(521, 190);
            this.chart2.Name = "chart2";
            this.chart2.Size = new System.Drawing.Size(484, 254);
            this.chart2.TabIndex = 99;
            this.chart2.Text = "chart1";
            this.chart2.Click += new System.EventHandler(this.chart1_Click);
            this.chart2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.chart2_MouseClick);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(185, 161);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 21);
            this.textBox4.TabIndex = 0;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(292, 161);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 21);
            this.textBox5.TabIndex = 1;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(409, 161);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 2;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(26, 161);
            this.textBox1.Mask = "00:00:00";
            this.textBox1.Name = "textBox1";
            this.textBox1.ResetOnSpace = false;
            this.textBox1.Size = new System.Drawing.Size(64, 21);
            this.textBox1.TabIndex = 106;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(3, 9);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(80, 20);
            this.comboBox2.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1036, 511);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.panel12);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.LoadFileText);
            this.Controls.Add(this.OpenLoad);
            this.Name = "Form1";
            this.Text = "1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.Form1_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.Form1_DragEnter);
            this.panel12.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button START;
        private System.Windows.Forms.Button Closebtn;
        private System.Windows.Forms.Button MinSizebtn;
        private System.Windows.Forms.Button MaxSizebtn;
        private System.Windows.Forms.OpenFileDialog LoadFileDialog;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox LoadFileText;
        private System.Windows.Forms.Button OpenLoad;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox Box5;
        private System.Windows.Forms.ComboBox Box4;
        private System.Windows.Forms.ComboBox Box3;
        private System.Windows.Forms.ComboBox Box2;
        private System.Windows.Forms.ComboBox Box1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox textBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.MaskedTextBox textBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox comboBox2;
    }
}

