using System.Collections.Generic;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;

namespace App1
{
    public sealed partial class Page91 : Page
    {
        private List<Work> allWorks;
        private List<Work> filteredWorks;

        public Page91()
        {
            this.InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            allWorks = new List<Work>
            {
                new Work { Title = "Проект 1", Description = "Обучение на Skratch", Category = "Программирование", ImagePath = "Skratch.jpg" },
                new Work { Title = "Проект 2", Description = "Проектирование недвжимости.", Category = "Дизайн", ImagePath = "DisaynNedvishimosti.jpg" },
                new Work { Title = "Проект 3", Description = "Анализ цифровой сферы России", Category = "Анализ данных", ImagePath = "al8sossnjssx0b4l5gg20slx5ep7qmyc.jpg" },
                new Work { Title = "Проект 4", Description = "Игра", Category = "Программирование", ImagePath = "10618983.png" }
            };

            filteredWorks = allWorks;
            DisplayWorks();
        }

        private void Category_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string selectedCategory = CategoryComboBox.SelectedItem as string;

            if (string.IsNullOrEmpty(selectedCategory) || selectedCategory == "Все")
            {
                filteredWorks = allWorks;
            }
            else
            {
                filteredWorks = allWorks.FindAll(work => work.Category == selectedCategory);
            }

            DisplayWorks();
        }

        private void DisplayWorks()
        {
            WorksPanel.Children.Clear();

            foreach (var work in filteredWorks)
            {
                var workCard = new Border
                {
                    Background = new SolidColorBrush(Colors.LightGray),
                    CornerRadius = new CornerRadius(8),
                    Padding = new Thickness(10),
                    Margin = new Thickness(0, 0, 0, 10)
                };

                var workContent = new StackPanel { Spacing = 5 };

                var image = new Windows.UI.Xaml.Controls.Image
                {
                    Source = new BitmapImage(new System.Uri("ms-appx:///Assets/" + work.ImagePath)),
                    Width = 50,
                    Height = 50,
                    Stretch = Stretch.UniformToFill
                };
                workContent.Children.Add(image);

                var title = new TextBlock
                {
                    Text = work.Title,
                    FontSize = 16,
                    FontWeight = Windows.UI.Text.FontWeights.Bold,
                    Foreground = new SolidColorBrush(Colors.Black)
                };
                workContent.Children.Add(title);

                var description = new TextBlock
                {
                    Text = work.Description,
                    FontSize = 14,
                    Foreground = new SolidColorBrush(Colors.DarkBlue)
                };
                workContent.Children.Add(description);

                var viewButton = new Button
                {
                    Content = "Подробнее",
                    Tag = work,
                    Width = 150
                };
                viewButton.Click += ViewDetails_Click;
                workContent.Children.Add(viewButton);

                workCard.Child = workContent;
                WorksPanel.Children.Add(workCard);
            }
        }

        private void ViewDetails_Click(object sender, RoutedEventArgs e)
        {
            var button = sender as Button;
            var work = button.Tag as Work;

            if (work != null)
            {
                DetailsTextBlock.Text = $"Заголовок: {work.Title}\nОписание: {work.Description}\nКатегория: {work.Category}";
            }
        }
    }

    public class Work
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public string ImagePath { get; set; }
    }
}
