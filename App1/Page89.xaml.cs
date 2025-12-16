using System.Collections.Generic;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media;

namespace App1
{
    public sealed partial class Page89 : Page
    {
        private List<Expense> expenses;
        private double totalBudget = 1000.0; // Бюджет на месяц

        public Page89()
        {
            this.InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            expenses = new List<Expense>
            {
                new Expense { Category = "Продукты", Amount = 200.0 },
                new Expense { Category = "Транспорт", Amount = 100.0 },
                new Expense { Category = "Развлечения", Amount = 150.0 },
                new Expense { Category = "Одежда", Amount = 50.0 }
            };

            DisplayExpenses();
        }

        private void DisplayExpenses()
        {
            CategoriesPanel.Children.Clear();

            foreach (var expense in expenses)
            {
                var categoryCard = new Border
                {
                    Background = new SolidColorBrush(Colors.LightGray),
                    CornerRadius = new CornerRadius(8),
                    Padding = new Thickness(10),
                    Margin = new Thickness(0, 0, 0, 10)
                };

                var categoryContent = new StackPanel { Spacing = 5 };

                var category = new TextBlock
                {
                    Text = expense.Category,
                    FontSize = 16,
                    FontWeight = Windows.UI.Text.FontWeights.Bold,
                    Foreground = new SolidColorBrush(Colors.Black)
                };
                categoryContent.Children.Add(category);

                var amount = new TextBlock
                {
                    Text = $"Сумма: {expense.Amount} руб.",
                    FontSize = 14,
                    Foreground = new SolidColorBrush(Colors.DarkBlue)
                };
                categoryContent.Children.Add(amount);

                categoryCard.Child = categoryContent;
                CategoriesPanel.Children.Add(categoryCard);
            }

            UpdateStatistics();
        }

        private void UpdateStatistics()
        {
            double totalSpent = 0.0;
            foreach (var expense in expenses)
            {
                totalSpent += expense.Amount;
            }

            double percentage = (totalSpent / totalBudget) * 100.0;
            BudgetProgressBar.Value = percentage;

            StatisticsTextBlock.Text = $"Всего потрачено: {totalSpent} руб.\nБюджет: {totalBudget} руб.\nПроцент: {percentage:F1}%";
        }

        private void Category_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string selectedCategory = CategoryComboBox.SelectedItem as string;

            if (!string.IsNullOrEmpty(selectedCategory))
            {

            }
        }

        private void AddExpense_Click(object sender, RoutedEventArgs e)
        {
            if (!double.TryParse(AmountTextBox.Text, out double amount) || amount <= 0)
            {
                StatisticsTextBlock.Text = "Введите корректную сумму!";
                return;
            }

            string selectedCategory = CategoryComboBox.SelectedItem as string;
            if (string.IsNullOrEmpty(selectedCategory))
            {
                StatisticsTextBlock.Text = "Выберите категорию!";
                return;
            }

            double totalSpent = 0.0;
            foreach (var expense in expenses)
            {
                totalSpent += expense.Amount;
            }

            if (totalSpent + amount > totalBudget)
            {
                StatisticsTextBlock.Text = $"Бюджет исчерпан! Доступно: {totalBudget - totalSpent:F2} руб.";
                return;
            }

            expenses.Add(new Expense { Category = selectedCategory, Amount = amount });
            DisplayExpenses();
            AmountTextBox.Text = string.Empty;
        }
    }

    public class Expense
    {
        public string Category { get; set; }
        public double Amount { get; set; }
    }
}
