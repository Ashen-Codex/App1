using System.Threading.Tasks;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;

namespace App1
{
    // 👇 Класс для хранения информации о городе
    public class CityInfo
    {
        public string Name { get; set; }
        public string Temperature { get; set; }
        public string Description { get; set; }
    }

    public sealed partial class Page79 : Page
    {
        private ScrollViewer scrollViewer; // 👈 Добавляем переменную

        public Page79()
        {
            this.InitializeComponent();
            scrollViewer = CitiesPanel.Parent as ScrollViewer; // 👈 Получаем ScrollViewer
            LoadCities();
        }

        private void LoadCities()
        {
            // Добавляем тестовые города
            AddCity("Москва", "15°C", "Ясно");
            AddCity("Санкт-Петербург", "10°C", "Облачно");
            AddCity("Новосибирск", "5°C", "Снег");
        }

        private void AddCity(string name, string temperature, string description)
        {
            var cityCard = new Border
            {
                Background = new Windows.UI.Xaml.Media.SolidColorBrush(Windows.UI.Colors.LightGray),
                CornerRadius = new Windows.UI.Xaml.CornerRadius(8),
                Padding = new Windows.UI.Xaml.Thickness(10),
                Margin = new Windows.UI.Xaml.Thickness(0, 5, 0, 5),
                Tag = new CityInfo { Name = name, Temperature = temperature, Description = description } // 👈 Сохраняем данные
            };

            // Добавляем обработчик нажатия
            cityCard.Tapped += CityCard_Tapped;

            var cityContent = new StackPanel { Spacing = 5 };

            // Добавляем имя города
            var nameText = new TextBlock
            {
                Text = name,
                FontSize = 16,
                FontWeight = Windows.UI.Text.FontWeights.Bold,
                Foreground = new SolidColorBrush(Colors.Black)
            };
            cityContent.Children.Add(nameText);

            // Добавляем температуру
            var tempText = new TextBlock
            {
                Text = temperature,
                FontSize = 14,
                Foreground = new SolidColorBrush(Colors.DarkGray)
            };
            cityContent.Children.Add(tempText);

            // Добавляем описание
            var descText = new TextBlock
            {
                Text = description,
                FontSize = 14,
                Foreground = new SolidColorBrush(Colors.DarkGray)
            };
            cityContent.Children.Add(descText);

            cityCard.Child = cityContent;

            CitiesPanel.Children.Add(cityCard);
        }

        private void CityCard_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (sender is Border cityCard && cityCard.Tag is CityInfo city)
            {
                TemperatureTextBox.Text = city.Temperature;
                DescriptionTextBox.Text = city.Description;

                WeatherImage.Source = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new System.Uri("ms-appx:///Assets/icon228.png"));
            }
        }

        private async void UpdateWeather_Click(object sender, RoutedEventArgs e)
        {
            LoadingRing.IsActive = true;

            await Task.Delay(2000);

            LoadingRing.IsActive = false;

            TemperatureTextBox.Text = "20°C";
            DescriptionTextBox.Text = "Жарко";
            WeatherImage.Source = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new System.Uri("ms-appx:///Assets/icon322.png"));
        }
    }
}

