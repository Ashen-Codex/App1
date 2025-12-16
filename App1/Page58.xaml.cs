using System.Linq;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

namespace App1
{
    public sealed partial class Page58 : Page
    {
        public Page58()
        {
            this.InitializeComponent();

            NumberOnlyTextBox.TextChanged += NumberOnlyTextBox_TextChanged;
        }

        private void NumberOnlyTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            var textBox = sender as TextBox;

            int selectionStart = textBox.SelectionStart;
            string filtered = new string(textBox.Text.Where(char.IsDigit).ToArray());
            if (textBox.Text != filtered)
            {
                textBox.Text = filtered;
                textBox.SelectionStart = filtered.Length;
            }
        }
    }
}

