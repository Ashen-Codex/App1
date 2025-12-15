using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace App1
{
    public sealed partial class Page99 : Page
    {
        private int currentQuestionIndex = 0;
        private int correctAnswers = 0;

        private readonly string[] questions = {
            "Какой цвет неба?",
            "Сколько будет 2 + 2?",
            "Какая планета ближе всего к Солнцу?"
        };

        private readonly string[][] options = {
            new string[] { "Красный", "Синий", "Зелёный", "Жёлтый" },
            new string[] { "3", "4", "5", "6" },
            new string[] { "Земля", "Марс", "Меркурий", "Венера" }
        };

        private readonly int[] correctAnswersIndices = { 1, 1, 2 };

        public Page99()
        {
            this.InitializeComponent();
            LoadQuestion();
        }

        private void LoadQuestion()
        {
            if (currentQuestionIndex < questions.Length)
            {
                QuestionTextBlock.Text = $"Вопрос {currentQuestionIndex + 1}: {questions[currentQuestionIndex]}";
                Option1.Content = options[currentQuestionIndex][0];
                Option2.Content = options[currentQuestionIndex][1];
                Option3.Content = options[currentQuestionIndex][2];
                Option4.Content = options[currentQuestionIndex][3];

                Option1.IsChecked = false;
                Option2.IsChecked = false;
                Option3.IsChecked = false;
                Option4.IsChecked = false;

                Progressbar.Value = (double)currentQuestionIndex / questions.Length * 100;
                ResultTextBlock.Text = "";

                NextButton.Visibility = Visibility.Visible;
            }
            else
            {
                QuestionTextBlock.Text = "Тест завершён!";
                Option1.Visibility = Visibility.Collapsed;
                Option2.Visibility = Visibility.Collapsed;
                Option3.Visibility = Visibility.Collapsed;
                Option4.Visibility = Visibility.Collapsed;
                Progressbar.Value = 100;
                ResultTextBlock.Text = $"Вы ответили правильно на {correctAnswers} из {questions.Length} вопросов.";

                NextButton.Visibility = Visibility.Collapsed;
            }
        }

        private void NextQuestion_Click(object sender, RoutedEventArgs e)
        {
            if (Option1.IsChecked == true && correctAnswersIndices[currentQuestionIndex] == 0)
                correctAnswers++;
            else if (Option2.IsChecked == true && correctAnswersIndices[currentQuestionIndex] == 1)
                correctAnswers++;
            else if (Option3.IsChecked == true && correctAnswersIndices[currentQuestionIndex] == 2)
                correctAnswers++;
            else if (Option4.IsChecked == true && correctAnswersIndices[currentQuestionIndex] == 3)
                correctAnswers++;

            currentQuestionIndex++;
            LoadQuestion();
        }
    }
}
