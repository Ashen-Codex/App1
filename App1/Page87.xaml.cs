using System.Collections.Generic;
using System.Threading.Tasks;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media;

namespace App1
{
    public sealed partial class Page87 : Page
    {
        private List<TodoItem> allTasks;
        private List<TodoItem> filteredTasks;

        public Page87()
        {
            this.InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            allTasks = new List<TodoItem>
            {
                new TodoItem { Title = "Задача 1", Category = "Work", IsCompleted = false },
                new TodoItem { Title = "Задача 2", Category = "Personal", IsCompleted = true },
                new TodoItem { Title = "Задача 3", Category = "Study", IsCompleted = false },
                new TodoItem { Title = "Задача 4", Category = "Work", IsCompleted = true }
            };

            filteredTasks = allTasks;
            DisplayTasks();
        }

        private void NavigationView_SelectionChanged(NavigationView sender, NavigationViewSelectionChangedEventArgs args)
        {
            string selectedCategory = args.SelectedItemContainer?.Tag as string;

            if (string.IsNullOrEmpty(selectedCategory) || selectedCategory == "All")
            {
                filteredTasks = allTasks;
            }
            else
            {
                filteredTasks = allTasks.FindAll(task => task.Category == selectedCategory);
            }

            DisplayTasks();
        }

        private void SearchTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            string searchText = SearchTextBox.Text;

            if (string.IsNullOrEmpty(searchText))
            {
                filteredTasks = allTasks;
            }
            else
            {
                filteredTasks = allTasks.FindAll(task => task.Title.Contains(searchText));
            }

            DisplayTasks();
        }

        private void DisplayTasks()
        {
            TasksListView.Items.Clear();

            foreach (var task in filteredTasks)
            {
                var taskCard = new Border
                {
                    Background = new SolidColorBrush(Colors.LightGray),
                    CornerRadius = new CornerRadius(8),
                    Padding = new Thickness(10),
                    Margin = new Thickness(0, 0, 0, 10)
                };

                var taskContent = new StackPanel { Spacing = 5 };

                var title = new TextBlock
                {
                    Text = task.Title,
                    FontSize = 16,
                    FontWeight = Windows.UI.Text.FontWeights.Bold,
                    Foreground = task.IsCompleted ? new SolidColorBrush(Colors.Gray) : new SolidColorBrush(Colors.Black)
                };
                taskContent.Children.Add(title);

                var category = new TextBlock
                {
                    Text = $"Категория: {task.Category}",
                    FontSize = 14,
                    Foreground = new SolidColorBrush(Colors.DarkBlue)
                };
                taskContent.Children.Add(category);

                var completed = new TextBlock
                {
                    Text = task.IsCompleted ? "✅ Выполнено" : "❌ Не выполнено",
                    FontSize = 14,
                    Foreground = task.IsCompleted ? new SolidColorBrush(Colors.Green) : new SolidColorBrush(Colors.Red)
                };
                taskContent.Children.Add(completed);

                taskCard.Child = taskContent;
                TasksListView.Items.Add(taskCard);
            }
        }

        private void AddTask_Click(object sender, RoutedEventArgs e)
        {
            allTasks.Add(new TodoItem { Title = "Новая задача", Category = "Work", IsCompleted = false });
            DisplayTasks();
        }

        private void DeleteTask_Click(object sender, RoutedEventArgs e)
        {
            if (allTasks.Count > 0)
            {
                allTasks.RemoveAt(0);
                DisplayTasks();
            }
        }

        private void MarkTask_Click(object sender, RoutedEventArgs e)
        {
            foreach (var task in allTasks)
            {
                task.IsCompleted = true;
            }
            DisplayTasks();
        }
    }

    public class TodoItem
    {
        public string Title { get; set; }
        public string Category { get; set; }
        public bool IsCompleted { get; set; }
    }
}
