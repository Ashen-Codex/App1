using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media;

namespace App1
{
    // 👇 Класс для хранения информации о задаче
    public class TaskInfo
    {
        public string Text { get; set; }
        public bool IsCompleted { get; set; }
    }

    public sealed partial class Page76 : Page
    {
        private ScrollViewer scrollViewer; // 👈 Добавляем переменную

        public Page76()
        {
            this.InitializeComponent();
            scrollViewer = TasksPanel.Parent as ScrollViewer; // 👈 Получаем ScrollViewer
            LoadTasks();
        }

        private void LoadTasks()
        {
            // Добавляем тестовые задачи
            AddTask("Купить продукты", false);
            AddTask("Сделать домашку", false);
            AddTask("Позвонить другу", true); // Завершённая задача
        }

        private void AddTask(string text, bool isCompleted)
        {
            var taskCard = new Border
            {
                Background = isCompleted ? new Windows.UI.Xaml.Media.SolidColorBrush(Windows.UI.Colors.LightGreen) : new Windows.UI.Xaml.Media.SolidColorBrush(Windows.UI.Colors.LightGray),
                CornerRadius = new Windows.UI.Xaml.CornerRadius(8),
                Padding = new Windows.UI.Xaml.Thickness(10),
                Margin = new Windows.UI.Xaml.Thickness(0, 5, 0, 5),
                Tag = new TaskInfo { Text = text, IsCompleted = isCompleted } // 👈 Сохраняем данные
            };

            var taskContent = new StackPanel { Spacing = 5 };

            // Добавляем CheckBox для отметки завершённой задачи
            var checkBox = new CheckBox
            {
                IsChecked = isCompleted,
                Margin = new Windows.UI.Xaml.Thickness(0, 0, 10, 0)
            };
            checkBox.Checked += (s, e) => UpdateTaskStatus(taskCard, true);
            checkBox.Unchecked += (s, e) => UpdateTaskStatus(taskCard, false);
            taskContent.Children.Add(checkBox);

            // Добавляем текст задачи
            var taskText = new TextBlock
            {
                Text = text,
                FontSize = 16,
                Foreground = new SolidColorBrush(Colors.Black)
            };
            taskContent.Children.Add(taskText);

            taskCard.Child = taskContent;

            // Добавляем карточку в ленту
            TasksPanel.Children.Add(taskCard);
        }

        private void UpdateTaskStatus(Border taskCard, bool isCompleted)
        {
            taskCard.Background = isCompleted ? new Windows.UI.Xaml.Media.SolidColorBrush(Windows.UI.Colors.LightGreen) : new Windows.UI.Xaml.Media.SolidColorBrush(Windows.UI.Colors.LightGray);

            if (taskCard.Tag is TaskInfo task)
            {
                task.IsCompleted = isCompleted;
            }
        }

        private void AddTask_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(TaskTextBox.Text))
            {
                AddTask(TaskTextBox.Text, false);

                TaskTextBox.Text = string.Empty;

                if (scrollViewer != null)
                {
                    scrollViewer.ChangeView(null, scrollViewer.ExtentHeight, null);
                }
            }
        }
    }
}
