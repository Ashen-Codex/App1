using System;
using System.Threading.Tasks;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;

namespace App1
{
    public sealed partial class Page97 : Page
    {
        private TimeSpan remainingTime;
        private bool isRunning = false;
        private DispatcherTimer timer;
        private double speed = 1.0;

        public Page97()
        {
            this.InitializeComponent();
            timer = new DispatcherTimer();
            timer.Tick += Timer_Tick;
        }

        private void Timer_Tick(object sender, object e)
        {
            if (remainingTime > TimeSpan.Zero)
            {
                remainingTime -= TimeSpan.FromSeconds(1);
                UpdateTimeDisplay();
            }
            else
            {
                StopTimer();
                TimeTextBlock.Text = "Время вышло!";
            }
        }

        private void UpdateTimeDisplay()
        {
            var hours = (int)remainingTime.TotalHours;
            var minutes = remainingTime.Minutes;
            var seconds = remainingTime.Seconds;
            TimeTextBlock.Text = $"{hours:D2}:{minutes:D2}:{seconds:D2}";
        }

        private void Start_Click(object sender, RoutedEventArgs e)
        {
            if (!isRunning)
            {
                if (int.TryParse(TimeNumberBox.Text, out int seconds))
                {
                    remainingTime = TimeSpan.FromSeconds(seconds);
                    UpdateTimeDisplay();

                    timer.Interval = TimeSpan.FromSeconds(1.0 / speed);
                    timer.Start();
                    isRunning = true;
                    ProgressRing.IsActive = true;
                }
                else
                {
                    TimeTextBlock.Text = "Введите корректное число!";
                }
            }
        }

        private void Pause_Click(object sender, RoutedEventArgs e)
        {
            if (isRunning)
            {
                timer.Stop();
                isRunning = false;
                ProgressRing.IsActive = false;
            }
        }

        private void Stop_Click(object sender, RoutedEventArgs e)
        {
            StopTimer();
        }

        private void StopTimer()
        {
            timer.Stop();
            isRunning = false;
            ProgressRing.IsActive = false;
            TimeTextBlock.Text = "00:00:00";
        }

        private void SpeedSlider_ValueChanged(object sender, RangeBaseValueChangedEventArgs e)
        {
            speed = SpeedSlider.Value;
            if (isRunning)
            {
                timer.Interval = TimeSpan.FromSeconds(1.0 / speed);
            }
        }
    }
}
