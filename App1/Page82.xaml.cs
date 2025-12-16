using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;

namespace App1
{
    // 👇 Класс для хранения информации о контакте
    public class ContactInfo
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Position { get; set; }
        public string Phone { get; set; }
    }

    public sealed partial class Page82 : Page
    {
        private ScrollViewer scrollViewer; // 👈 Добавляем переменную

        public Page82()
        {
            this.InitializeComponent();
            scrollViewer = ContactsPanel.Parent as ScrollViewer; // 👈 Получаем ScrollViewer
            LoadContacts();
        }

        private void LoadContacts()
        {
            // Добавляем тестовые контакты
            AddContact("Иван Иванов", "ivan@example.com", "Менеджер", "+7 (999) 123-45-67");
            AddContact("Анна Петрова", "anna@example.com", "Дизайнер", "+7 (999) 234-56-78");
            AddContact("Сергей Сидоров", "sergey@example.com", "Разработчик", "+7 (999) 345-67-89");
        }

        private void AddContact(string name, string email, string position, string phone)
        {
            var contactCard = new Border
            {
                Background = new Windows.UI.Xaml.Media.SolidColorBrush(Windows.UI.Colors.LightGray),
                CornerRadius = new Windows.UI.Xaml.CornerRadius(8),
                Padding = new Windows.UI.Xaml.Thickness(10),
                Margin = new Windows.UI.Xaml.Thickness(0, 5, 0, 5),
                Tag = new ContactInfo { Name = name, Email = email, Position = position, Phone = phone } // 👈 Сохраняем данные
            };

            contactCard.Tapped += ContactCard_Tapped;

            var contactContent = new StackPanel { Spacing = 5 };

            var nameText = new TextBlock
            {
                Text = name,
                FontSize = 16,
                FontWeight = Windows.UI.Text.FontWeights.Bold,
                Foreground = new SolidColorBrush(Colors.Black)
            };
            contactContent.Children.Add(nameText);

            var emailText = new TextBlock
            {
                Text = email,
                FontSize = 14,
                Foreground = new SolidColorBrush(Colors.DarkGray)
            };
            contactContent.Children.Add(emailText);

            contactCard.Child = contactContent;

            ContactsPanel.Children.Add(contactCard);
        }

        private void ContactCard_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (sender is Border contactCard && contactCard.Tag is ContactInfo contact)
            {
                ContactDetailsTextBlock.Text = $"Имя: {contact.Name}\nEmail: {contact.Email}\nДолжность: {contact.Position}\nТелефон: {contact.Phone}";
            }
        }

        private void AddContact_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(SearchTextBox.Text))
            {
                var name = SearchTextBox.Text;
                var email = $"{name.ToLower().Replace(" ", ".")}@example.com";
                var position = "Сотрудник";
                var phone = "+7 (999) 000-00-00";

                AddContact(name, email, position, phone);

                SearchTextBox.Text = string.Empty;

                if (scrollViewer != null)
                {
                    scrollViewer.ChangeView(null, scrollViewer.ExtentHeight, null);
                }
            }
        }

        private void DeleteContact_Click(object sender, RoutedEventArgs e)
        {
            if (ContactsPanel.Children.Count > 0)
            {
                ContactsPanel.Children.RemoveAt(ContactsPanel.Children.Count - 1);

                ContactDetailsTextBlock.Text = "";
            }
        }
    }
}
