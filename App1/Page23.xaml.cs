using Microsoft.UI.Xaml.Controls;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace App1
{
    public sealed partial class Page23 : Page
    {
        public Page23()
        {
            InitializeComponent();
        }

        private void ShowSuccess_Click(object sender, RoutedEventArgs e)
        {
            InfoBar successBar = new InfoBar
            {
                Title = "Успех",
                Message = "Операция выполнена успешно!",
                Severity = InfoBarSeverity.Success,
                IsOpen = true,
                IsClosable = true
            };
            // Добавьте в контейнер
            RootGrid.Children.Add(successBar);
        }

    }
}
