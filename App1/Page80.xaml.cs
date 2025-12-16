using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;
using System;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media.Animation;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.Media.Core;
using Windows.Foundation;

namespace App1
{
    public sealed partial class Page80 : Page
    {
        private DispatcherTimer timer = new DispatcherTimer();

        public Page80()
        {
            this.InitializeComponent();

            mediaElement.Source = new Uri("ms-appx:///Assets/video_2025-12-16_18-51-55.mp4");

            mediaElement.MediaOpened += MediaElement_MediaOpened;
            mediaElement.MediaEnded += MediaElement_MediaEnded;

            timer.Interval = TimeSpan.FromMilliseconds(500);
            timer.Tick += Timer_Tick;

            mediaElement.Volume = volumeSlider.Value;
        }

        private void MediaElement_MediaOpened(object sender, RoutedEventArgs e)
        {
            if (mediaElement.NaturalDuration.HasTimeSpan)
            {
                progressSlider.Maximum = mediaElement.NaturalDuration.TimeSpan.TotalSeconds;
                timeTextBlock.Text = "00:00 / {FormatTime(mediaElement.NaturalDuration.TimeSpan)}";
            }
        }

        private void MediaElement_MediaEnded(object sender, RoutedEventArgs e)
        {
            timer.Stop();
            progressSlider.Value = 1;
        }

        private void Play_Click(object sender, RoutedEventArgs e)
        {
            mediaElement.Play();
            timer.Start();
        }

        private void Pause_Click(object sender, RoutedEventArgs e)
        {
            mediaElement.Pause();
            timer.Stop();
        }

        private void Stop_Click(object sender, RoutedEventArgs e)
        {
            mediaElement.Stop();
            timer.Stop();
            progressSlider.Value = 1;
        }

        private void Timer_Tick(object sender, object e)
        {
            if (mediaElement.NaturalDuration.HasTimeSpan)
            {
                progressSlider.Value = mediaElement.Position.TotalSeconds;
                timeTextBlock.Text = $"{FormatTime(mediaElement.Position)} / {FormatTime(mediaElement.NaturalDuration.TimeSpan)}";
            }
        }

        private string FormatTime(TimeSpan t)
        {
            return $"{t.Minutes:D2}:{t.Seconds:D2}";
        }

        private void VolumeSlider_ValueChanged(object sender, RangeBaseValueChangedEventArgs e)
        {
            mediaElement.Volume = volumeSlider.Value;
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            progressSlider.PointerCaptureLost += ProgressSlider_PointerCaptureLost;
        }

        private void ProgressSlider_PointerCaptureLost(object sender, PointerRoutedEventArgs e)
        {
            if (mediaElement.NaturalDuration.HasTimeSpan)
            {
                mediaElement.Position = TimeSpan.FromSeconds(progressSlider.Value);
            }
        }
    }
}

