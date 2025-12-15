using System.Collections.Generic;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media;

namespace App1
{
    public sealed partial class Page95 : Page
    {
        private List<NewsItem> allNews;
        private List<NewsItem> filteredNews;

        public Page95()
        {
            this.InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            allNews = new List<NewsItem>
            {
                new NewsItem { Title = "Новость 1", Content = "Президент Замбии крутой?!", Category = "Политика", ImageSource = "ms-appx:///Assets/smile1.jpg" },
                new NewsItem { Title = "Новость 2", Content = "Получить 32 копейки.", Category = "Экономика", ImageSource = "ms-appx:///Assets/smile2.jpg" },
                new NewsItem { Title = "Новость 3", Content = "Технология `открывавшки бутылок` вышла на новый уровень!", Category = "Технологии", ImageSource = "ms-appx:///Assets/smile3.jpg" },
                new NewsItem { Title = "Новость 4", Content = "Древние Русы против Ящеров", Category = "Политика", ImageSource = "ms-appx:///Assets/smile4.jpg" }
            };

            filteredNews = allNews;
            DisplayNews();
        }

        private void Category_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string selectedCategory = CategoryComboBox.SelectedItem as string;

            if (string.IsNullOrEmpty(selectedCategory) || selectedCategory == "Все")
            {
                filteredNews = allNews;
            }
            else
            {
                filteredNews = allNews.FindAll(item => item.Category == selectedCategory);
            }

            DisplayNews();
        }

        private void DisplayNews()
        {
            NewsPanel.Children.Clear();

            foreach (var news in filteredNews)
            {
                var newsCard = new Border
                {
                    Background = new Windows.UI.Xaml.Media.SolidColorBrush(Windows.UI.Colors.LightGray),
                    CornerRadius = new Windows.UI.Xaml.CornerRadius(8),
                    Padding = new Windows.UI.Xaml.Thickness(10),
                    Margin = new Windows.UI.Xaml.Thickness(0, 0, 0, 10)
                };

                var newsContent = new StackPanel { Spacing = 5 };

                var image = new Image
                {
                    Source = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new System.Uri(news.ImageSource)),
                    Width = 50,
                    Height = 50,
                    Stretch = Windows.UI.Xaml.Media.Stretch.UniformToFill
                };
                newsContent.Children.Add(image);

                var title = new TextBlock
                {
                    Text = news.Title,
                    FontSize = 16,
                    FontWeight = Windows.UI.Text.FontWeights.Bold,
                    Foreground = new Windows.UI.Xaml.Media.SolidColorBrush(Windows.UI.Colors.Black)
                };
                newsContent.Children.Add(title);

                var content = new TextBlock
                {
                    Text = news.Content,
                    FontSize = 14,
                    Foreground = new SolidColorBrush(Windows.UI.Colors.DarkBlue)
                };
                newsContent.Children.Add(content);

                newsCard.Child = newsContent;
                NewsPanel.Children.Add(newsCard);
            }
        }
    }

    public class NewsItem
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public string Category { get; set; }
        public string ImageSource { get; set; }
    }
} 
