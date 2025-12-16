using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media;

namespace App1
{
    public sealed partial class Page86 : Page
    {
        private ScrollViewer scrollViewer; // 👈 Добавляем переменную

        public Page86()
        {
            this.InitializeComponent();
            scrollViewer = MessagesPanel.Parent as ScrollViewer; // 👈 Получаем ScrollViewer
            LoadMessages();
        }

        private void LoadMessages()
        {
            // Добавляем тестовые сообщения
            AddMessage("Иван", "Привет!", false);
            AddMessage("Анна", "Привет! Как дела?", false);
            AddMessage("Я", "Всё хорошо, спасибо!", true);
        }

        private void SendMessage_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(MessageTextBox.Text))
            {
                // Добавляем новое сообщение
                AddMessage("Я", MessageTextBox.Text, true);

                // Очищаем поле ввода
                MessageTextBox.Text = string.Empty;

                // Прокручиваем вниз
                if (scrollViewer != null)
                {
                    scrollViewer.ChangeView(null, scrollViewer.ExtentHeight, null);
                }
            }
        }

        private void AddMessage(string sender, string text, bool isOwn)
        {
            var messageCard = new Border
            {
                Background = isOwn ? new Windows.UI.Xaml.Media.SolidColorBrush(Windows.UI.Colors.LightBlue) : new Windows.UI.Xaml.Media.SolidColorBrush(Windows.UI.Colors.LightGray),
                CornerRadius = new Windows.UI.Xaml.CornerRadius(8),
                Padding = new Windows.UI.Xaml.Thickness(10),
                Margin = new Windows.UI.Xaml.Thickness(0, 5, 0, 5)
            };

            var messageContent = new StackPanel { Spacing = 5 };

            var senderText = new TextBlock
            {
                Text = $"{sender}:",
                FontSize = 14,
                FontWeight = Windows.UI.Text.FontWeights.Bold,
                Foreground = new SolidColorBrush(Colors.Black)
            };
            messageContent.Children.Add(senderText);

            var messageText = new TextBlock
            {
                Text = text,
                FontSize = 16,
                Foreground = new SolidColorBrush(Colors.Black)
            };
            messageContent.Children.Add(messageText);

            messageCard.Child = messageContent;

            MessagesPanel.Children.Add(messageCard);
        }
    }
}
