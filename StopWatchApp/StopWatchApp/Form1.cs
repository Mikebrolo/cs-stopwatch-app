using System.Diagnostics;
using System.Timers;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;

namespace StopWatchApp
{
    public partial class Form1 : Form
    {
        private System.Windows.Forms.Timer _timer;
        private Stopwatch _stopwatch = new Stopwatch();
        private Stopwatch _lapWatch = new Stopwatch();
        private TimeSpan _elapsedTime;
        private TimeSpan _lapElapsedTime;

        public int _lapAmount = 1;

        public List<Label> _labels = new List<Label>();
        public List<string> lapText = new List<string>();
        public List<float> times = new List<float>();

        string scriptDirectory = AppDomain.CurrentDomain.BaseDirectory;
        string filePath;

        public Form1()
        {
            InitializeComponent();

            _timer = new System.Windows.Forms.Timer();
            _timer.Interval = 1; // Every Millisecond
            _timer.Tick += Timer_Tick!;

            filePath = Path.Combine(scriptDirectory, "saveFile.json");
        }

        private void Form1_Load(object sender, EventArgs e) { }

        private void Timer_Tick(object sender, EventArgs e)
        {
            _elapsedTime = _stopwatch.Elapsed;
            _lapElapsedTime = _lapWatch.Elapsed;
            CurrentLap.Text = _lapElapsedTime.ToString(@"mm\:ss\.ff");
            label2.Text = _elapsedTime.ToString(@"mm\:ss\.ff");
        }

        private void label1_Click(object sender, EventArgs e) { }

        private void button2_Click(object sender, EventArgs e) // Start Button
        {
            _stopwatch.Start();
            _lapWatch.Start();
            _timer.Start();
            label2.ForeColor = Color.Green;
        }

        private void button1_Click(object sender, EventArgs e) // Stop Button
        {
            stopTimer();
        }

        private void ResetBtn_Click(object sender, EventArgs e)
        {
            stopTimer();
            _stopwatch.Reset();
            _lapWatch.Reset();
            label2.Text = "00:00.00";
            clearLabels();
            LapLabel.Text = "Lap 1: 00:00.00";
        }

        private void LapBtn_Click(object sender, EventArgs e)
        {
            CreateLap();
        }

        public void stopTimer()
        {
            label2.ForeColor = Color.Black;
            _timer.Stop();
            _lapWatch.Stop();
            _stopwatch.Stop();
        }

        public void CreateLap()
        {
            //Checks if there are more than 5 labels
            if (_labels.Count >= 4)
            {
                //Clears the labels if so
                clearLabels();
            }

            // Gets the elapsed time from the stopwatch and convets it to a string.
            TimeSpan _lapedtime;
            _lapedtime = _lapWatch.Elapsed;
            string _elapsedString = _lapedtime.ToString(@"mm\:ss\.ff");

            if (_lapAmount == 1)
                LapLabel.Text = ($"Lap {_lapAmount}: {_elapsedString}");
            else
            {
                CreateLabel(_lapAmount, _elapsedString);
            }

            _lapAmount++;
        }

        public void CreateLabel(int lapAmount, string time, bool loading = false)
        {
            //Creates a new instance of a label
            Label newLapLabel = new Label();

            // If this was called from the loading, itll get rid of the extra Lap string
            if (!loading)
                newLapLabel.Text = ($"Lap {lapAmount}: {time}");
            else
                newLapLabel.Text = time;

            newLapLabel.Location = new Point(459, 100 + (lapAmount * 30));
            newLapLabel.Size = LapLabel.Size;
            newLapLabel.Font = LapLabel.Font;
            this.Controls.Add(newLapLabel);

            //Remove extra string bits, then converts to decimal
            string cleanedText = newLapLabel.Text.Remove(0, 11) // Starting from the first char, remove 9 after
                                                 .Trim(); // Gets rid of white space
            // Convert cleanedText to float and add to a list
            if (float.TryParse(cleanedText, out float num))
            {
                times.Add(num);
            }

            SetTimeColor(num, newLapLabel);

            _labels.Add(newLapLabel);

            _lapWatch.Restart();
        }

        // the lowest time will be green, highest will be red
        public void SetTimeColor(float _lapTime, Label _label)
        {
            if (IsGreaterThanRest(_lapTime))
            {
                _label.ForeColor = Color.Red;
            }
            else
            {
                _label.ForeColor = Color.Green;
            }
        }

        // Returns true if number is greatest in the list, 
        public bool IsGreaterThanRest(float num)
        {
            foreach (float time in times)
            {
                if (time > num) return false;
            }
            return true;
        }

        public void clearLabels()
        {
            foreach (Label label in _labels)
            {
                this.Controls.Remove(label);
            }
            _labels.Clear();
            lapText.Clear();
            times.Clear();
            _lapAmount = 1;
        }

        private void LapLabel_Click(object sender, EventArgs e) { }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            List<string> _TextLabels = new List<string>();

            _TextLabels.Add(LapLabel.Text);

            foreach (Label label in _labels)
            {
                _TextLabels.Add(label.Text);
            }

            string json = JsonConvert.SerializeObject(_TextLabels, Formatting.Indented);



            File.WriteAllText(filePath, json);
        }

        private void LoadBtn_Click(object sender, EventArgs e)
        {
            GetJsonLines();

            if(lapText.Count > 0)
            {
                LapLabel.Text = lapText[0];
            }

            for (int i = 0; i < _lapAmount; i++)
            {
                CreateLabel(i + 1, lapText[i], true);
            }
        }

        public void GetJsonLines()
        {
            lapText.Clear();
            // Reads all the lines and puts it into a list to be used later on
            try
            {
                string json = File.ReadAllText(filePath);

                lapText = JsonConvert.DeserializeObject<List<string>>(json)!;

                _lapAmount = lapText.Count;
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("The file does not exist.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        private void label3_Click(object sender, EventArgs e) { }
    }
}