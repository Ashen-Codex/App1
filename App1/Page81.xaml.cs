using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;

namespace App1
{
    public class PhotoInfo
    {
        public string Category { get; set; }
        public string ImagePath { get; set; }
    }

    public sealed partial class Page81 : Page
    {
        private ScrollViewer scrollViewer;

        public Page81()
        {
            this.InitializeComponent();
            scrollViewer = PhotosPanel.Parent as ScrollViewer;
            LoadPhotos();
        }

        private void LoadPhotos()
        {
            AddPhoto("Пейзаж", "ms-appx:///Assets/Peyzasgh.jpg");
            AddPhoto("Портрет", "ms-appx:///Assets/Portret.jpg");
            AddPhoto("Город", "ms-appx:///Assets/Gorod.jpg");
        }

        private void AddPhoto(string category, string imagePath)
        {
            var photoCard = new Border
            {
                Background = new SolidColorBrush(Colors.LightGray),
                CornerRadius = new CornerRadius(8),
                Padding = new Thickness(5),
                Margin = new Thickness(0, 5, 0, 5),
                Tag = new PhotoInfo { Category = category, ImagePath = imagePath }
            };

            photoCard.Tapped += PhotoCard_Tapped;

            var photoContent = new StackPanel { Spacing = 5 };

            var image = new Image
            {
                Source = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new System.Uri(imagePath)),
                Width = 100,
                Height = 100,
                Stretch = Stretch.UniformToFill
            };
            photoContent.Children.Add(image);

            var categoryText = new TextBlock
            {
                Text = category,
                FontSize = 12,
                Foreground = new SolidColorBrush(Colors.Black)
            };
            photoContent.Children.Add(categoryText);

            photoCard.Child = photoContent;
            PhotosPanel.Children.Add(photoCard);
        }

        private void PhotoCard_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (sender is Border photoCard && photoCard.Tag is PhotoInfo photo)
            {
                FullViewImage.Source = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new System.Uri(photo.ImagePath));
            }
        }

        private void SearchTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            var searchText = SearchTextBox.Text.ToLower();

            foreach (var child in PhotosPanel.Children)
            {
                if (child is Border photoCard && photoCard.Tag is PhotoInfo photo)
                {
                    photoCard.Visibility = photo.Category.ToLower().Contains(searchText) ? Visibility.Visible : Visibility.Collapsed;
                }
            }

            PhotosPanel.UpdateLayout();
        }

        private void FilterComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var selectedFilter = FilterComboBox.SelectedItem as ComboBoxItem;

            if (selectedFilter != null)
            {
                var filterText = selectedFilter.Content.ToString();

                foreach (var child in PhotosPanel.Children)
                {
                    if (child is Border photoCard && photoCard.Tag is PhotoInfo photo)
                    {
                        photoCard.Visibility = filterText == "Все" || photo.Category == filterText ? Visibility.Visible : Visibility.Collapsed;
                    }
                }

                PhotosPanel.UpdateLayout();
            }
        }
    }
}
