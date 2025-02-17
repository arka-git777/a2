using System.Globalization;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace a2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadImages();
            ShowCurrentImage();
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
                int hours = 24 - now.Hour;
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
        private List<string> imagePaths;
        private int currentImageIndex = 0;
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
                pictureBox1.Image = Image.FromFile(imagePaths[currentImageIndex]);
            }
        }


        private void btnNext_Click_1(object sender, EventArgs e)
        {
            currentImageIndex++;
            if (currentImageIndex > imagePaths.Count-1)
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
    }

}

