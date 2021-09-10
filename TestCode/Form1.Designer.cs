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
            this.Dry = new System.Windows.Forms.RadioButton();
            this.Air = new System.Windows.Forms.RadioButton();
            this.Refrig = new System.Windows.Forms.RadioButton();
            this.TV = new System.Windows.Forms.RadioButton();
            this.panel12 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.Vaccum = new System.Windows.Forms.RadioButton();
            this.START = new System.Windows.Forms.Button();
            this.ProgramName = new System.Windows.Forms.Label();
            this.Closebtn = new System.Windows.Forms.Button();
            this.MinSizebtn = new System.Windows.Forms.Button();
            this.MaxSizebtn = new System.Windows.Forms.Button();
            this.LoadFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.panel14 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel9 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.Version = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LoadFileText = new System.Windows.Forms.TextBox();
            this.SaveFile = new System.Windows.Forms.Button();
            this.OpenLoad = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel12.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel9.SuspendLayout();
            this.SuspendLayout();
            // 
            // Dry
            // 
            this.Dry.AutoSize = true;
            this.Dry.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Dry.Location = new System.Drawing.Point(13, 37);
            this.Dry.Name = "Dry";
            this.Dry.Size = new System.Drawing.Size(42, 19);
            this.Dry.TabIndex = 3;
            this.Dry.TabStop = true;
            this.Dry.Text = "dry";
            this.Dry.UseVisualStyleBackColor = true;
            // 
            // Air
            // 
            this.Air.AutoSize = true;
            this.Air.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Air.Location = new System.Drawing.Point(13, 5);
            this.Air.Name = "Air";
            this.Air.Size = new System.Drawing.Size(38, 19);
            this.Air.TabIndex = 0;
            this.Air.TabStop = true;
            this.Air.Text = "air";
            this.Air.UseVisualStyleBackColor = true;
            // 
            // Refrig
            // 
            this.Refrig.AutoSize = true;
            this.Refrig.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Refrig.Location = new System.Drawing.Point(57, 5);
            this.Refrig.Name = "Refrig";
            this.Refrig.Size = new System.Drawing.Size(53, 19);
            this.Refrig.TabIndex = 1;
            this.Refrig.TabStop = true;
            this.Refrig.Text = "refrig";
            this.Refrig.UseVisualStyleBackColor = true;
            // 
            // TV
            // 
            this.TV.AutoSize = true;
            this.TV.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.TV.Location = new System.Drawing.Point(116, 5);
            this.TV.Name = "TV";
            this.TV.Size = new System.Drawing.Size(39, 19);
            this.TV.TabIndex = 2;
            this.TV.TabStop = true;
            this.TV.Text = "TV";
            this.TV.UseVisualStyleBackColor = true;
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel12.Controls.Add(this.panel7);
            this.panel12.Controls.Add(this.START);
            this.panel12.Location = new System.Drawing.Point(27, 93);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(547, 128);
            this.panel12.TabIndex = 90;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.White;
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Controls.Add(this.TV);
            this.panel7.Controls.Add(this.Vaccum);
            this.panel7.Controls.Add(this.Dry);
            this.panel7.Controls.Add(this.Air);
            this.panel7.Controls.Add(this.Refrig);
            this.panel7.Location = new System.Drawing.Point(3, 3);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(382, 116);
            this.panel7.TabIndex = 73;
            // 
            // Vaccum
            // 
            this.Vaccum.AutoSize = true;
            this.Vaccum.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Vaccum.Location = new System.Drawing.Point(57, 37);
            this.Vaccum.Name = "Vaccum";
            this.Vaccum.Size = new System.Drawing.Size(68, 19);
            this.Vaccum.TabIndex = 3;
            this.Vaccum.TabStop = true;
            this.Vaccum.Text = "vacuum";
            this.Vaccum.UseVisualStyleBackColor = true;
            // 
            // START
            // 
            this.START.BackColor = System.Drawing.Color.Teal;
            this.START.FlatAppearance.BorderSize = 0;
            this.START.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.START.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.START.ForeColor = System.Drawing.Color.White;
            this.START.Location = new System.Drawing.Point(402, 3);
            this.START.Name = "START";
            this.START.Size = new System.Drawing.Size(136, 116);
            this.START.TabIndex = 11;
            this.START.Text = "START";
            this.START.UseVisualStyleBackColor = false;
            this.START.Click += new System.EventHandler(this.START_Click);
            // 
            // ProgramName
            // 
            this.ProgramName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ProgramName.AutoSize = true;
            this.ProgramName.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ProgramName.Location = new System.Drawing.Point(160, 455);
            this.ProgramName.Name = "ProgramName";
            this.ProgramName.Size = new System.Drawing.Size(50, 20);
            this.ProgramName.TabIndex = 93;
            this.ProgramName.Text = "label4";
            // 
            // Closebtn
            // 
            this.Closebtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Closebtn.BackColor = System.Drawing.Color.Transparent;
            this.Closebtn.FlatAppearance.BorderSize = 0;
            this.Closebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Closebtn.ForeColor = System.Drawing.Color.White;
            this.Closebtn.Location = new System.Drawing.Point(573, 0);
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
            this.MinSizebtn.Location = new System.Drawing.Point(513, 0);
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
            this.MaxSizebtn.Location = new System.Drawing.Point(543, 0);
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
            // panel14
            // 
            this.panel14.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel14.Location = new System.Drawing.Point(27, 249);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(547, 185);
            this.panel14.TabIndex = 96;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(11, 231);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 15);
            this.label4.TabIndex = 94;
            this.label4.Text = "기본 값";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox1.Location = new System.Drawing.Point(27, 440);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(121, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 91;
            this.pictureBox1.TabStop = false;
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
            this.panel9.Size = new System.Drawing.Size(605, 30);
            this.panel9.TabIndex = 89;
            this.panel9.DoubleClick += new System.EventHandler(this.panel9_DoubleClick);
            this.panel9.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel9_MouseMove);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(12, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 12);
            this.label6.TabIndex = 67;
            this.label6.Text = "label6";
            // 
            // Version
            // 
            this.Version.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Version.AutoSize = true;
            this.Version.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Version.Location = new System.Drawing.Point(249, 477);
            this.Version.Name = "Version";
            this.Version.Size = new System.Drawing.Size(39, 15);
            this.Version.TabIndex = 92;
            this.Version.Text = "label4";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Location = new System.Drawing.Point(26, 86);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(547, 1);
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
            this.LoadFileText.Size = new System.Drawing.Size(442, 21);
            this.LoadFileText.TabIndex = 85;
            this.LoadFileText.DragDrop += new System.Windows.Forms.DragEventHandler(this.LoadFileText_DragDrop);
            this.LoadFileText.DragEnter += new System.Windows.Forms.DragEventHandler(this.LoadFileText_DragEnter);
            // 
            // SaveFile
            // 
            this.SaveFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveFile.BackColor = System.Drawing.Color.Teal;
            this.SaveFile.FlatAppearance.BorderSize = 0;
            this.SaveFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveFile.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.SaveFile.ForeColor = System.Drawing.Color.White;
            this.SaveFile.Location = new System.Drawing.Point(475, 441);
            this.SaveFile.Name = "SaveFile";
            this.SaveFile.Size = new System.Drawing.Size(99, 46);
            this.SaveFile.TabIndex = 87;
            this.SaveFile.Text = "Info Export";
            this.SaveFile.UseVisualStyleBackColor = false;
            this.SaveFile.Click += new System.EventHandler(this.SaveFile_Click);
            // 
            // OpenLoad
            // 
            this.OpenLoad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.OpenLoad.BackColor = System.Drawing.Color.Teal;
            this.OpenLoad.FlatAppearance.BorderSize = 0;
            this.OpenLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OpenLoad.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.OpenLoad.ForeColor = System.Drawing.Color.White;
            this.OpenLoad.Location = new System.Drawing.Point(475, 56);
            this.OpenLoad.Name = "OpenLoad";
            this.OpenLoad.Size = new System.Drawing.Size(99, 21);
            this.OpenLoad.TabIndex = 86;
            this.OpenLoad.Text = "Open";
            this.OpenLoad.UseVisualStyleBackColor = false;
            this.OpenLoad.Click += new System.EventHandler(this.OpenLoad_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(332, 441);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 49);
            this.button1.TabIndex = 98;
            this.button1.Text = "Data Export";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 497);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel12);
            this.Controls.Add(this.ProgramName);
            this.Controls.Add(this.panel14);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.Version);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.LoadFileText);
            this.Controls.Add(this.SaveFile);
            this.Controls.Add(this.OpenLoad);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.Form1_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.Form1_DragEnter);
            this.panel12.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton Dry;
        private System.Windows.Forms.RadioButton Air;
        private System.Windows.Forms.RadioButton Refrig;
        private System.Windows.Forms.RadioButton TV;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button START;
        private System.Windows.Forms.Label ProgramName;
        private System.Windows.Forms.Button Closebtn;
        private System.Windows.Forms.Button MinSizebtn;
        private System.Windows.Forms.Button MaxSizebtn;
        private System.Windows.Forms.OpenFileDialog LoadFileDialog;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label Version;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox LoadFileText;
        private System.Windows.Forms.Button SaveFile;
        private System.Windows.Forms.Button OpenLoad;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton Vaccum;
    }
}

