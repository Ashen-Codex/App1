// Page57.xaml.cs
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace App1
{
    public sealed partial class Page57 : Page
    {
        public Page57()
        {
            this.InitializeComponent();
            // Устанавливаем начальный макет в зависимости от текущего размера
            UpdateLayout(ActualWidth);
        }

        private void Page57_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            UpdateLayout(e.NewSize.Width);
        }

        private void UpdateLayout(double width)
        {
            MainGrid.ColumnDefinitions.Clear();
            MainGrid.Children.Clear(); // Очищаем, чтобы пересоздать

            if (width < 600)
            {
                // Мобильный: 1 колонка
                MainGrid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });

                var panel1 = CreatePanel("Панель 1", "LightBlue");
                var panel2 = CreatePanel("Панель 2", "LightGreen");

                // В мобильном — используем RowDefinitions
                MainGrid.RowDefinitions.Clear();
                MainGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
                MainGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });

                Grid.SetRow(panel1, 0);
                Grid.SetRow(panel2, 1);
                Grid.SetColumn(panel1, 0);
                Grid.SetColumn(panel2, 0);

                MainGrid.Children.Add(panel1);
                MainGrid.Children.Add(panel2);
            }
            else
            {
                // Десктоп: 2 колонки
                MainGrid.RowDefinitions.Clear();
                MainGrid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
                MainGrid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });

                var panel1 = CreatePanel("Панель 1", "LightBlue");
                var panel2 = CreatePanel("Панель 2", "LightGreen");

                Grid.SetColumn(panel1, 0);
                Grid.SetColumn(panel2, 1);
                Grid.SetRow(panel1, 0);
                Grid.SetRow(panel2, 0);

                // Отступы
                panel1.Margin = new Thickness(0, 0, 10, 0);
                panel2.Margin = new Thickness(10, 0, 0, 0);

                MainGrid.Children.Add(panel1);
                MainGrid.Children.Add(panel2);
            }
        }

        private Border CreatePanel(string text, string color)
        {
            var brush = color == "LightBlue" ?
                new Windows.UI.Xaml.Media.SolidColorBrush(Windows.UI.Colors.LightBlue) :
                new Windows.UI.Xaml.Media.SolidColorBrush(Windows.UI.Colors.LightGreen);

            var textBlock = new TextBlock
            {
                Text = text,
                FontSize = 24,
                HorizontalAlignment = HorizontalAlignment.Center,
                VerticalAlignment = VerticalAlignment.Center
            };

            return new Border
            {
                Background = brush,
                Child = textBlock
            };
        }
    }
}