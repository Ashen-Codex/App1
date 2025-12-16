using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace App1
{
    public sealed partial class Page92 : Page
    {
        public Page92()
        {
            this.InitializeComponent();
            LoadContacts();
        }

        private void LoadContacts()
        {
            AddContact("Иван Иванов");
            AddContact("Анна Петрова");
            AddContact("Сергей Сидоров");
        }

        private void AddContact(string name)
        {
            var contact = new Button
            {
                Content = name,
                Width = 350,
                Height = 40
            };
            contact.Click += Contact_Click;
            ContactsPanel.Children.Add(contact);
        }

        private void Contact_Click(object sender, RoutedEventArgs e)
        {
            var button = sender as Button;
            MessageTextBlock.Text = $"Выбран контакт: {button.Content}";
        }

        private void Send_Click(object sender, RoutedEventArgs e)
        {
            string message = MessageTextBox.Text;
            var time = TimePicker.Time;

            if (!string.IsNullOrEmpty(message))
            {
                MessageTextBlock.Text = $"Сообщение: {message}\nВремя: {time:hh\\:mm\\:ss}";
                MessageTextBox.Text = string.Empty;
            }
            else
            {
                MessageTextBlock.Text = "Введите сообщение!";
            }
        }
    }
}
