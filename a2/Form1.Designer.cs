namespace a2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            textBox1 = new TextBox();
            button1 = new Button();
            dateoutput = new Label();
            dateTimePicker1 = new DateTimePicker();
            button2 = new Button();
            pictureBox1 = new PictureBox();
            btnNext = new Button();
            btnPrevious = new Button();
            openFileDialog1 = new OpenFileDialog();
            btnOpenFile = new Button();
            btnAddURL = new Button();
            textBox2 = new TextBox();
            timer1 = new System.Windows.Forms.Timer(components);
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            lblQuestion = new Label();
            btnSumbit = new Button();
            btnRestart = new Button();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            toolStripProgressBar1 = new ToolStripProgressBar();
            toolStripDropDownButton1 = new ToolStripDropDownButton();
            toolStripSplitButton1 = new ToolStripSplitButton();
            stopToolStripMenuItem = new ToolStripMenuItem();
            stsrtToolStripMenuItem = new ToolStripMenuItem();
            btnShow = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(483, 94);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(211, 23);
            textBox1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(713, 94);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 1;
            button1.Text = "submit";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dateoutput
            // 
            dateoutput.AutoSize = true;
            dateoutput.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dateoutput.Location = new Point(103, 43);
            dateoutput.Name = "dateoutput";
            dateoutput.Size = new Size(0, 25);
            dateoutput.TabIndex = 2;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(12, 94);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 3;
            // 
            // button2
            // 
            button2.Location = new Point(232, 93);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 4;
            button2.Text = "submit";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(254, 210);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(221, 111);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // btnNext
            // 
            btnNext.Location = new Point(540, 254);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(75, 23);
            btnNext.TabIndex = 6;
            btnNext.Text = "next";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click_1;
            // 
            // btnPrevious
            // 
            btnPrevious.Location = new Point(124, 254);
            btnPrevious.Name = "btnPrevious";
            btnPrevious.Size = new Size(75, 23);
            btnPrevious.TabIndex = 7;
            btnPrevious.Text = "previous";
            btnPrevious.UseVisualStyleBackColor = true;
            btnPrevious.Click += btnPrevious_Click_1;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            openFileDialog1.FileOk += openFileDialog1_FileOk;
            // 
            // btnOpenFile
            // 
            btnOpenFile.Location = new Point(625, 353);
            btnOpenFile.Name = "btnOpenFile";
            btnOpenFile.Size = new Size(106, 67);
            btnOpenFile.TabIndex = 8;
            btnOpenFile.Text = "Add";
            btnOpenFile.UseVisualStyleBackColor = true;
            btnOpenFile.Click += btnOpenFile_Click;
            // 
            // btnAddURL
            // 
            btnAddURL.Location = new Point(460, 156);
            btnAddURL.Name = "btnAddURL";
            btnAddURL.Size = new Size(75, 23);
            btnAddURL.TabIndex = 9;
            btnAddURL.Text = "Add";
            btnAddURL.UseVisualStyleBackColor = true;
            btnAddURL.Click += btnAddURL_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(205, 156);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(249, 23);
            textBox2.TabIndex = 10;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(103, 466);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(14, 13);
            radioButton1.TabIndex = 11;
            radioButton1.TabStop = true;
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(103, 491);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(14, 13);
            radioButton2.TabIndex = 12;
            radioButton2.TabStop = true;
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(103, 517);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(14, 13);
            radioButton3.TabIndex = 13;
            radioButton3.TabStop = true;
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // lblQuestion
            // 
            lblQuestion.AutoSize = true;
            lblQuestion.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblQuestion.Location = new Point(103, 438);
            lblQuestion.Name = "lblQuestion";
            lblQuestion.Size = new Size(0, 19);
            lblQuestion.TabIndex = 14;
            // 
            // btnSumbit
            // 
            btnSumbit.Location = new Point(124, 538);
            btnSumbit.Name = "btnSumbit";
            btnSumbit.Size = new Size(75, 23);
            btnSumbit.TabIndex = 15;
            btnSumbit.Text = "submit";
            btnSumbit.UseVisualStyleBackColor = true;
            btnSumbit.Click += btnSumbit_Click;
            // 
            // btnRestart
            // 
            btnRestart.Location = new Point(205, 538);
            btnRestart.Name = "btnRestart";
            btnRestart.Size = new Size(75, 23);
            btnRestart.TabIndex = 16;
            btnRestart.Text = "restart";
            btnRestart.UseVisualStyleBackColor = true;
            btnRestart.Click += btnRestart_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1, toolStripProgressBar1, toolStripDropDownButton1, toolStripSplitButton1 });
            statusStrip1.Location = new Point(0, 634);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(791, 22);
            statusStrip1.TabIndex = 17;
            statusStrip1.Text = "statusStrip1";
            statusStrip1.Visible = false;
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(52, 17);
            toolStripStatusLabel1.Text = "progress";
            // 
            // toolStripProgressBar1
            // 
            toolStripProgressBar1.Name = "toolStripProgressBar1";
            toolStripProgressBar1.Size = new Size(100, 16);
            // 
            // toolStripDropDownButton1
            // 
            toolStripDropDownButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripDropDownButton1.Image = (Image)resources.GetObject("toolStripDropDownButton1.Image");
            toolStripDropDownButton1.ImageTransparentColor = Color.Magenta;
            toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            toolStripDropDownButton1.Size = new Size(29, 20);
            toolStripDropDownButton1.Text = "toolStripDropDownButton1";
            toolStripDropDownButton1.Click += toolStripDropDownButton1_Click;
            // 
            // toolStripSplitButton1
            // 
            toolStripSplitButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripSplitButton1.DropDownItems.AddRange(new ToolStripItem[] { stopToolStripMenuItem, stsrtToolStripMenuItem });
            toolStripSplitButton1.Image = (Image)resources.GetObject("toolStripSplitButton1.Image");
            toolStripSplitButton1.ImageTransparentColor = Color.Magenta;
            toolStripSplitButton1.Name = "toolStripSplitButton1";
            toolStripSplitButton1.Size = new Size(32, 20);
            toolStripSplitButton1.Text = "toolStripSplitButton1";
            // 
            // stopToolStripMenuItem
            // 
            stopToolStripMenuItem.Name = "stopToolStripMenuItem";
            stopToolStripMenuItem.Size = new Size(180, 22);
            stopToolStripMenuItem.Text = "stop";
            stopToolStripMenuItem.Click += stopToolStripMenuItem_Click;
            // 
            // stsrtToolStripMenuItem
            // 
            stsrtToolStripMenuItem.Name = "stsrtToolStripMenuItem";
            stsrtToolStripMenuItem.Size = new Size(180, 22);
            stsrtToolStripMenuItem.Text = "continue";
            stsrtToolStripMenuItem.Click += stsrtToolStripMenuItem_Click;
            // 
            // btnShow
            // 
            btnShow.Location = new Point(628, 586);
            btnShow.Name = "btnShow";
            btnShow.Size = new Size(75, 23);
            btnShow.TabIndex = 18;
            btnShow.Text = "show";
            btnShow.UseVisualStyleBackColor = true;
            btnShow.Click += btnShow_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(791, 656);
            Controls.Add(btnShow);
            Controls.Add(statusStrip1);
            Controls.Add(btnRestart);
            Controls.Add(btnSumbit);
            Controls.Add(lblQuestion);
            Controls.Add(radioButton3);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(textBox2);
            Controls.Add(btnAddURL);
            Controls.Add(btnOpenFile);
            Controls.Add(btnPrevious);
            Controls.Add(btnNext);
            Controls.Add(pictureBox1);
            Controls.Add(button2);
            Controls.Add(dateTimePicker1);
            Controls.Add(dateoutput);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button button1;
        private Label dateoutput;
        private DateTimePicker dateTimePicker1;
        private Button button2;
        private PictureBox pictureBox1;
        private Button btnNext;
        private Button btnPrevious;
        private OpenFileDialog openFileDialog1;
        private Button btnOpenFile;
        private Button btnAddURL;
        private TextBox textBox2;
        private System.Windows.Forms.Timer timer1;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private Label lblQuestion;
        private Button btnSumbit;
        private Button btnRestart;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripProgressBar toolStripProgressBar1;
        private ToolStripDropDownButton toolStripDropDownButton1;
        private Button btnShow;
        private ToolStripSplitButton toolStripSplitButton1;
        private ToolStripMenuItem stopToolStripMenuItem;
        private ToolStripMenuItem stsrtToolStripMenuItem;
    }
}
