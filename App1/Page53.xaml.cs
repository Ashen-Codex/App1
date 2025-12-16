using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace App1
{
    public sealed partial class Page53 : Page
    {
        public Page53()
        {
            this.InitializeComponent();
        }

        private async void LoadButton_Click(object sender, RoutedEventArgs e)
        {
            // Показываем загрузку
            LoadingRing.IsActive = true;
            LoadButton.IsEnabled = false;

            // Ждём 2 секунды (имитация загрузки)
            await Task.Delay(2000);

            // Готовим данные — просто список строк
            var dataList = new List<string>
            {
                "Пойти в изгание",
                "Сделать задание по UWP",
                "Жениться на эльфийке"
            };

            // Отображаем в ListView
            DataListView.ItemsSource = dataList;

            // Скрываем загрузку
            LoadingRing.IsActive = false;
            LoadButton.IsEnabled = true;
        }
    }
}
