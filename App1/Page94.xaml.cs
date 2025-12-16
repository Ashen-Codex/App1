using System;
using System.Threading.Tasks;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;


namespace App1
{
    public sealed partial class Page94 : Page
    {
        private readonly System.Collections.Generic.Dictionary<string, double> routeDistances =
            new System.Collections.Generic.Dictionary<string, double>
            {
                { "Москва → Санкт-Петербург", 700 },
                { "Москва → Новосибирск", 3300 },
                { "Москва → Владивосток", 9300 }
            };

        private readonly System.Collections.Generic.Dictionary<string, string> routeImages =
            new System.Collections.Generic.Dictionary<string, string>
            {
                { "Москва → Санкт-Петербург", "ms-appx:///Assets/photo_2025-12-16_01-08-14.jpg" },
                { "Москва → Новосибирск", "ms-appx:///Assets/photo_2025-12-16_01-12-22.jpg" },
                { "Москва → Владивосток", "ms-appx:///Assets/photo_2025-12-16_01-13-46.jpg" }
            };

        public Page94()
        {
            this.InitializeComponent();
        }

        private void Route_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string route = RouteComboBox.SelectedItem as string;

            if (string.IsNullOrEmpty(route))
            {
                DistanceTextBlock.Text = "";
                MapImage.Visibility = Visibility.Collapsed;
                return;
            }

            if (routeDistances.TryGetValue(route, out double distance))
            {
                DistanceTextBlock.Text = $"Расстояние: {distance} км";
            }

            if (routeImages.TryGetValue(route, out string imagePath))
            {
                MapImage.Source = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri(imagePath));
                MapImage.Visibility = Visibility.Visible;
            }
        }

        private async void StartRoute_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(RouteComboBox.SelectedItem as string))
            {
                DistanceTextBlock.Text = "Выберите маршрут!";
                return;
            }

            ProgressRing.IsActive = true;
            MapImage.Visibility = Visibility.Collapsed;

            await Task.Delay(2000);

            ProgressRing.IsActive = false;
            MapImage.Visibility = Visibility.Visible;
            DistanceTextBlock.Text += " ✅ Маршрут начат!";
        }

        private void ResetRoute_Click(object sender, RoutedEventArgs e)
        {
            RouteComboBox.SelectedIndex = -1;
            DistanceTextBlock.Text = "";
            MapImage.Visibility = Visibility.Collapsed;
        }
    }
}
