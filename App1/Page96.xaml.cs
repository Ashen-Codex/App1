using System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;

namespace App1
{
    public sealed partial class Page96 : Page
    {
        public Page96()
        {
            this.InitializeComponent();
            InterestRateSlider.ValueChanged += InterestRateSlider_ValueChanged;
        }

        private void InterestRateSlider_ValueChanged(object sender, RangeBaseValueChangedEventArgs e)
        {
            InterestRateTextBlock.Text = $"{e.NewValue:F1}%";
        }

        private void Calculate_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(LoanAmountTextBox.Text, out double loanAmount) &&
                double.TryParse(LoanTermTextBox.Text, out double loanTerm))
            {
                double interestRate = InterestRateSlider.Value / 100.0;

                double monthlyRate = interestRate / 12.0;
                int months = (int)(loanTerm * 12);

                if (monthlyRate == 0)
                {
                    ResultTextBlock.Text = $"{loanAmount / months:F2} руб.";
                }
                else
                {
                    double numerator = loanAmount * monthlyRate * Math.Pow(1 + monthlyRate, months);
                    double denominator = Math.Pow(1 + monthlyRate, months) - 1;
                    double monthlyPayment = numerator / denominator;

                    ResultTextBlock.Text = $"{monthlyPayment:F2} руб.";
                }
            }
            else
            {
                ResultTextBlock.Text = "Пожалуйста, введите корректные данные.";
            }
        }
    }
}
