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
            textBox1 = new TextBox();
            button1 = new Button();
            dateoutput = new Label();
            dateTimePicker1 = new DateTimePicker();
            button2 = new Button();
            pictureBox1 = new PictureBox();
            btnNext = new Button();
            btnPrevious = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
    }
}
