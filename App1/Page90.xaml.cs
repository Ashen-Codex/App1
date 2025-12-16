using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Media;

namespace App1
{
    public sealed partial class Page90 : Page
    {
        public Page90()
        {
            this.InitializeComponent();
        }

        private void FontSizeSlider_ValueChanged(object sender, RangeBaseValueChangedEventArgs e)
        {
            double fontSize = e.NewValue;
            BookTextBlock.FontSize = fontSize;
            ScrollTextBlock.FontSize = fontSize;
        }

        private void DarkModeToggle_Toggled(object sender, RoutedEventArgs e)
        {
            bool isDarkMode = DarkModeToggle.IsOn;

            if (isDarkMode)
            {
                this.Background = new SolidColorBrush(Colors.DarkGray);
                BookTextBlock.Foreground = new SolidColorBrush(Colors.LightGray);
                ScrollTextBlock.Foreground = new SolidColorBrush(Colors.LightGray);

                var darkStyle = this.Resources["DarkThemeButton"] as Style;
                Chapter1Button.Style = darkStyle;
                Chapter2Button.Style = darkStyle;
                Chapter3Button.Style = darkStyle;
            }
            else
            {
                this.Background = new SolidColorBrush(Colors.White);
                BookTextBlock.Foreground = new SolidColorBrush(Colors.Black);
                ScrollTextBlock.Foreground = new SolidColorBrush(Colors.Black);

                Chapter1Button.Style = null;
                Chapter2Button.Style = null;
                Chapter3Button.Style = null;
            }
        }

        private void Chapter1_Click(object sender, RoutedEventArgs e)
        {
            BookTextBlock.Text = "Это текст главы 1.";
            ScrollTextBlock.Text = "Это длинный текст главы 1. Он может содержать много абзацев и параграфов. Это позволяет читателю удобно просматривать книгу на экране устройства.";
        }

        private void Chapter2_Click(object sender, RoutedEventArgs e)
        {
            BookTextBlock.Text = "Это текст главы 2.";
            ScrollTextBlock.Text = "Это длинный текст главы 2. Он может содержать много абзацев и параграфов. Это позволяет читателю удобно просматривать книгу на экране устройства.";
        }

        private void Chapter3_Click(object sender, RoutedEventArgs e)
        {
            BookTextBlock.Text = "Это текст главы 3.";
            ScrollTextBlock.Text = "Это длинный текст главы 3. Он может содержать много абзацев и параграфов. Это позволяет читателю удобно просматривать книгу на экране устройства.";
        }
    }
}
