using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Maps;
using Windows.UI.Xaml.Media;

namespace App1
{
    public sealed partial class Page31 : Page
    {
        public Page31()
        {
            InitializeComponent();

            // Список имён
            string[] names = { "Элемент 1", "Элемент 2", "Элемент 3" };

            foreach (string name in names)
            {
                // Создаём TextBlock
                var textBlock = new TextBlock
                {
                    Text = name,
                    FontSize = 16,
                    Margin = new Thickness(5)
                };

                // Оборачиваем в Border
                var border = new Border
                {
                    BorderBrush = new SolidColorBrush(Windows.UI.Colors.Blue),
                    BorderThickness = new Thickness(1),
                    Padding = new Thickness(10),
                    Child = textBlock
                };

                // Добавляем в ItemsControl
                MyItemsControl.Items.Add(border);
            }
        }
    }
}