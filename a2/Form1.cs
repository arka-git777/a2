using System.Globalization;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using static System.Formats.Asn1.AsnWriter;

namespace a2
{
    public partial class Form1 : Form
    {
        private List<string> imagePaths;
        private int currentImageIndex = 0;

        private string[] questions;
        private int currentQuestion = 0;
        private int score = 0;
        private string correctAnswer = "";
        public Form1()
        {
            InitializeComponent();
            LoadImages();
            ShowCurrentImage();
            questions = File.ReadAllLines("questions.txt");
            DisplayQuestion();
            timer1.Stop();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string inputDate = textBox1.Text;

            if (DateTime.TryParse(inputDate, out DateTime date))
            {
                string dayOfWeek = date.ToString("dddd", new CultureInfo("en"));
                dateoutput.Text = dayOfWeek;
            }
            else
            {
                dateoutput.Text = "Error!!!";
            }


            if (DateTime.TryParse(textBox1.Text, out DateTime targetDate))
            {
                DateTime now = DateTime.Now;

                if (targetDate > now)
                {
                    int years = targetDate.Year - now.Year;
                    int months = targetDate.Month - now.Month;
                    int days = targetDate.Day - now.Day;
                    int hours = targetDate.Hour - now.Hour;
                    int minutes = targetDate.Minute - now.Minute;
                    int seconds = targetDate.Second - now.Second;

                    if (seconds < 0)
                    {
                        seconds += 60;
                        minutes--;
                    }
                    if (minutes < 0)
                    {
                        minutes += 60;
                        hours--;
                    }
                    if (hours < 0)
                    {
                        hours += 24;
                        days--;
                    }
                    if (days < 0)
                    {
                        days += DateTime.DaysInMonth(now.Year, now.Month);
                        months--;
                    }
                    if (months < 0)
                    {
                        months += 12;
                        years--;
                    }

                    dateoutput.Text = $"{years} years, {months} months, {days} days, {hours} hours, {minutes} minutes, {seconds} seconds";
                }
                else
                {
                    dateoutput.Text = "Date is in the past";
                }
            }
            else
            {
                dateoutput.Text = "Error!!!";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DateTime targetDate = dateTimePicker1.Value;
            DateTime now = DateTime.Now;

            if (targetDate > now)
            {
                int years = targetDate.Year - now.Year;
                int months = targetDate.Month - now.Month;
                int days = targetDate.Day - now.Day - 1;
                int hours = 24 - now.Hour - 1;
                int minutes = 60 - now.Minute;
                int seconds = 60 - now.Second;
                if (seconds < 0)
                {
                    seconds += 60;
                    minutes--;
                }
                if (minutes < 0)
                {
                    minutes += 60;
                    hours--;
                }
                if (hours < 0)
                {
                    hours += 24;
                    days--;
                }
                if (days < 0)
                {
                    days += DateTime.DaysInMonth(now.Year, now.Month);
                    months--;
                }
                if (months < 0)
                {
                    months += 12;
                    years--;
                }

                dateoutput.Text = $"{years} years, {months} months, {days} days, {hours} hours, {minutes} minutes, {seconds} seconds left";
            }
            else
            {
                dateoutput.Text = "Date is in the past";
            }
        }
        private void LoadImages()
        {
            try
            {
                string imageFolder = @"C:\Users\arkad\OneDrive\Рабочий стол\Images";
                imagePaths = new List<string>(Directory.GetFiles(imageFolder, "*.jpg", SearchOption.TopDirectoryOnly));

                if (imagePaths.Count == 0)
                {
                    MessageBox.Show("There is no images with jpg");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void ShowCurrentImage()
        {
            if (imagePaths.Count > 0)
            {
                pictureBox1.ImageLocation = imagePaths[currentImageIndex];
            }
        }


        private void btnNext_Click_1(object sender, EventArgs e)
        {
            currentImageIndex++;
            if (currentImageIndex > imagePaths.Count - 1)
                currentImageIndex = 0;
            ShowCurrentImage();
        }

        private void btnPrevious_Click_1(object sender, EventArgs e)
        {
            currentImageIndex--;
            if (currentImageIndex < 0)
                currentImageIndex = imagePaths.Count - 1;
            ShowCurrentImage();
        }

        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif";
            openFileDialog.Title = "Select an Image";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    imagePaths.Add(openFileDialog.FileName);
                    currentImageIndex = imagePaths.Count - 1;

                    ShowCurrentImage();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading image: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnAddURL_Click(object sender, EventArgs e)
        {
            pictureBox1.Load(textBox2.Text);
            imagePaths.Add(textBox2.Text);
        }



        private void DisplayQuestion()
        {
            if (currentQuestion < questions.Length / 4)
            {
                int index = currentQuestion * 4;

                if (index + 3 <= questions.Length)
                {
                    lblQuestion.Text = questions[index];
                    correctAnswer = questions[index + 2];
                    List<string> answers = new List<string> { questions[index + 1], questions[index + 2], questions[index + 3] };

                    Random rng = new Random();
                    for (int i = answers.Count - 1; i > 0; i--)
                    {
                        int j = rng.Next(i + 1);
                        string temp = answers[i];
                        answers[i] = answers[j];
                        answers[j] = temp;
                    }
                    radioButton1.Text = answers[0];
                    radioButton2.Text = answers[1];
                    radioButton3.Text = answers[2];


                    radioButton1.Checked = false;
                    radioButton2.Checked = false;
                    radioButton3.Checked = false;
                }
                else
                {
                    MessageBox.Show("Error!!!");
                }
            }
            else
                MessageBox.Show($"Quiz completed!\nYour score: {score}/{questions.Length / 4}");

        }

        private void CheckQuestion()
        {
            string selectedAnswer = "";

            if (radioButton1.Checked)
                selectedAnswer = radioButton1.Text;
            else if (radioButton2.Checked)
                selectedAnswer = radioButton2.Text;
            else if (radioButton3.Checked)
                selectedAnswer = radioButton3.Text;

            if (selectedAnswer == correctAnswer)
            {
                score++;
                MessageBox.Show("Correct!");
            }
            else
                MessageBox.Show($"Wrong! Correct answer: {correctAnswer}");
        }

        private void btnSumbit_Click(object sender, EventArgs e)
        {
            CheckQuestion();
            currentQuestion++;
            DisplayQuestion();
            if (currentQuestion == questions.Length / 4)
            {
                currentQuestion = 0;
                DisplayQuestion();
            }
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            currentQuestion = 0;
            DisplayQuestion();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            statusStrip1.Visible = true;
            toolStripProgressBar1.Value = 0;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (toolStripProgressBar1.Value < toolStripProgressBar1.Maximum)
                toolStripProgressBar1.Value++;
            else
            {
                timer1.Stop();
                var a = MessageBox.Show("Loading finshed", " ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (a == DialogResult.OK)
                    statusStrip1.Visible = false;
            }

        }

        private void toolStripDropDownButton1_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled)
                timer1.Stop();
            else
                timer1.Start();
        }

        private void startToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void stopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }
    }

}


