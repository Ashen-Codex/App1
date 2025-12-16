using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml;

namespace App1
{
    public sealed partial class Page78 : Page
    {
        public Page78()
        {
            this.InitializeComponent();
        }

        private void RegisterButton_Click(object sender, RoutedEventArgs e)
        {
            string name = NameTextBox.Text.Trim();
            string email = EmailTextBox.Text.Trim();
            string password = PasswordBox.Password.Trim();
            string country = (CountryComboBox.SelectedItem as ComboBoxItem)?.Content.ToString();
            bool isAgree = AgreeCheckBox.IsChecked == true;

            ResultTextBlock.Text = "";

            if (string.IsNullOrEmpty(name))
            {
                ResultTextBlock.Text = "Введите имя";
                return;
            }
            if (string.IsNullOrEmpty(email) || !email.Contains("@"))
            {
                ResultTextBlock.Text = "Введите корректный email";
                return;
            }
            if (string.IsNullOrEmpty(password) || password.Length < 6)
            {
                ResultTextBlock.Text = "Пароль должен содержать не менее 6 символов";
                return;
            }
            if (string.IsNullOrEmpty(country))
            {
                ResultTextBlock.Text = "Выберите страну";
                return;
            }
            if (!isAgree)
            {
                ResultTextBlock.Text = "Необходимо согласиться с условиями";
                return;
            }

            ResultTextBlock.Foreground = new Windows.UI.Xaml.Media.SolidColorBrush(Windows.UI.Colors.Green);
            ResultTextBlock.Text = "Регистрация успешна!";
        }
    }
}

