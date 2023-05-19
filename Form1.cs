namespace TimeBeforeNY
{
    public partial class Form1 : Form
    {
        System.Windows.Forms.Timer t = new System.Windows.Forms.Timer();
        int yearNow = DateTime.Now.Year;

        public Form1()
        {
            InitializeComponent();

            Text = "TimeBeforeNewYear";
            StartPosition = FormStartPosition.CenterScreen;

            labalText.Text = $"Осталось до Нового {yearNow + 1} Года:";

            StartTimer();
        }

        private void StartTimer()
        {
            t.Interval = 1000;
            t.Tick += T_Tick;
            T_Tick(t, EventArgs.Empty);
            t.Start();
        }

        private void T_Tick(object? sender, EventArgs e)
        {
            TimeSpan remainderTime = new DateTime(yearNow + 1, 1, 1) - DateTime.Now;

            string h = remainderTime.Hours.ToString();
            if (remainderTime.Hours < 10) h = $"0{h}";

            string m = remainderTime.Minutes.ToString();
            if (remainderTime.Minutes < 10) m = $"0{m}";

            string s = remainderTime.Seconds.ToString();
            if (remainderTime.Seconds < 10) s = $"0{s}";

            labelTime.Text = $"{remainderTime.Days} дней, {h}:{m}:{s}";
        }
    }
}