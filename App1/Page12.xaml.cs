using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace App1
{
    public sealed partial class Page12 : Page
    {
        public Page12()
        {
            this.InitializeComponent();
        }

        private void ConfirmAge_Click(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(AgeTextBox.Text, out int age))
            {
                if (age >= 0 && age <= 120)
                {
                    AgeConfirmTextBlock.Text = $"Ваш возраст: {age} лет";
                }
                else
                {
                    AgeConfirmTextBlock.Text = "Возраст должен быть от 0 до 120 лет.";
                }
            }
            else
            {
                AgeConfirmTextBlock.Text = "Пожалуйста, введите корректное число.";
            }
        }
    }
}