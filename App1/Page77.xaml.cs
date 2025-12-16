using System;
using System.Collections.ObjectModel;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace App1
{
    public sealed partial class Page77 : Page
    {
        double firstNumber = 0;
        double secondNumber = 0;
        string operation = "";
        bool isNewNum = true;
        ObservableCollection<string> history = new ObservableCollection<string>();

        public Page77()
        {
            this.InitializeComponent();
        }

        private void NumBtn_Click(object sender, RoutedEventArgs e)
        {
            var btn = sender as Button;
            if (btn == null) return;

            if (isNewNum)
            {
                ResultBox.Text = "";
                isNewNum = false;
            }

            if (btn.Content.ToString() == "." && ResultBox.Text.Contains(".")) return;

            ResultBox.Text += btn.Content.ToString();
        }

        private void OpBtn_Click(object sender, RoutedEventArgs e)
        {
            var btn = sender as Button;
            if (btn == null) return;

            if (!double.TryParse(ResultBox.Text, out firstNumber))
            {
                ResultBox.Text = "Ошибка";
                return;
            }

            operation = btn.Content.ToString();
            isNewNum = true;
        }

        private void EqualBtn_Click(object sender, RoutedEventArgs e)
        {
            if (!double.TryParse(ResultBox.Text, out secondNumber))
            {
                ResultBox.Text = "Ошибка";
                return;
            }

            double result = 0;
            string opSign = operation;
            try
            {
                switch (operation)
                {
                    case "+": result = firstNumber + secondNumber; break;
                    case "-": result = firstNumber - secondNumber; break;
                    case "×": result = firstNumber * secondNumber; break;
                    case "÷":
                        if (secondNumber == 0) throw new DivideByZeroException();
                        result = firstNumber / secondNumber;
                        break;
                    default: return;
                }

                var line = $"{firstNumber} {opSign} {secondNumber} = {result}";
                TextBlock tb = new TextBlock { Text = line };
                HistoryPanel.Children.Insert(0, tb);

                ResultBox.Text = result.ToString();
                isNewNum = true;
            }
            catch
            {
                ResultBox.Text = "Ошибка";
            }
        }

        private void ClearBtn_Click(object sender, RoutedEventArgs e)
        {
            ResultBox.Text = "";
            firstNumber = 0;
            secondNumber = 0;
            operation = "";
            isNewNum = true;
        }
    }
}

