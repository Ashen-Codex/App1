using Windows.UI;
using Windows.UI.Text;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media;

namespace App1
{
    public sealed partial class Page38 : Page
    {
        public Page38()
        {
            InitializeComponent();
            CreateProductCard("Ноутбук", "59 990 ₽");
            CreateProductCard("Смартфон", "34 990 ₽");
            CreateProductCard("Наушники", "8 500 ₽");
        }

        private void CreateProductCard(string name, string price)
        {
            // 1. Создаём Border (рамку)
            var border = new Border
            {
                BorderBrush = new SolidColorBrush(Colors.Gray),
                BorderThickness = new Thickness(1),
                CornerRadius = new CornerRadius(5),
                Padding = new Thickness(10)
            };

            // 2. Создаём TextBlock для названия
            var nameText = new TextBlock
            {
                Text = name,
                FontSize = 18,
                FontWeight = FontWeights.Bold // ✅ Правильное значение
            };

            // 3. Создаём TextBlock для цены
            var priceText = new TextBlock
            {
                Text = price,
                FontSize = 14,
                Foreground = new SolidColorBrush(Colors.Green)
            };

            // 4. Создаём кнопку "Купить"
            var buyButton = new Button
            {
                Content = "Купить",
                Margin = new Thickness(0, 5, 0, 0)
            };

            // 5. Обрабатываем клик
            buyButton.Click += (s, e) =>
            {
                var dialog = new ContentDialog
                {
                    Title = "Покупка",
                    Content = $"Вы выбрали: {name}",
                    CloseButtonText = "ОК"
                };
                _ = dialog.ShowAsync();
            };

            // 6. Собираем StackPanel
            var stackPanel = new StackPanel
            {
                Spacing = 5
            };
            stackPanel.Children.Add(nameText);
            stackPanel.Children.Add(priceText);
            stackPanel.Children.Add(buyButton);

            // 7. Кладём всё в Border
            border.Child = stackPanel;

            // 8. Добавляем карточку на страницу
            CardsContainer.Children.Add(border);
        }
    }
}
