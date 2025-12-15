using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace App1
{
    public sealed partial class Page98 : Page
    {
        private int secretNumber;
        private int attempts = 0;
        private const int maxAttempts = 10;

        public Page98()
        {
            this.InitializeComponent();
            StartNewGame();
        }

        private void StartNewGame()
        {
            var random = new System.Random();
            secretNumber = random.Next(1, 101);

            attempts = 0;
            AttemptsProgressBar.Value = 0;
            HintTextBlock.Text = "Я загадал число от 1 до 100. Попробуйте угадать!";
            GuessTextBox.Text = string.Empty;
        }

        private void CheckGuess_Click(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(GuessTextBox.Text, out int guess))
            {
                attempts++;

                AttemptsProgressBar.Value = (double)attempts / maxAttempts * 100;

                if (guess == secretNumber)
                {
                    HintTextBlock.Text = $"Поздравляю! Вы угадали число {secretNumber} за {attempts} попыток!";
                    GuessTextBox.IsEnabled = false;
                }
                else if (attempts >= maxAttempts)
                {
                    HintTextBlock.Text = $"Вы исчерпали все попытки. Загаданное число было {secretNumber}.";
                    GuessTextBox.IsEnabled = false;
                }
                else if (guess < secretNumber)
                {
                    HintTextBlock.Text = "Загаданное число больше.";
                }
                else
                {
                    HintTextBlock.Text = "Загаданное число меньше.";
                }
            }
            else
            {
                HintTextBlock.Text = "Пожалуйста, введите корректное число.";
            }
        }

        private void NewGame_Click(object sender, RoutedEventArgs e)
        {
            StartNewGame();
            GuessTextBox.IsEnabled = true;
        }
    }
}
