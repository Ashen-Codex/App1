using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media;

namespace App1
{
    public sealed partial class Page100 : Page
    {
        public Page100()
        {
            this.InitializeComponent();
        }

        private void PublishPost_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(PostTextBox.Text))
            {
                var postCard = new Border
                {
                    Background = new SolidColorBrush(Windows.UI.Colors.LightGray),
                    CornerRadius = new CornerRadius(8),
                    Padding = new Thickness(10),
                    Margin = new Thickness(0, 0, 0, 10)
                };

                var postContent = new StackPanel { Spacing = 5 };

                var avatar = new Image
                {
                    Source = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new System.Uri("ms-appx:///Assets/USSR.png")),
                    Width = 50,
                    Height = 50,
                    Stretch = Stretch.UniformToFill
                };
                postContent.Children.Add(avatar);

                var postText = new TextBlock
                {
                    Text = PostTextBox.Text,
                    FontSize = 16,
                    Foreground = new SolidColorBrush(Windows.UI.Colors.Black)
                };
                postContent.Children.Add(postText);

                postCard.Child = postContent;

                PostsPanel.Children.Add(postCard);

                PostTextBox.Text = string.Empty;
            }
        }
    }
}
