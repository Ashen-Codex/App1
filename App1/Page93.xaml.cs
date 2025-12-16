using System.Collections.Generic;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media;

namespace App1
{
    public sealed partial class Page93 : Page
    {
        private List<Product> products;
        private List<Product> cart = new List<Product>();

        public Page93()
        {
            this.InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            products = new List<Product>
            {
                new Product { Name = "Пиво", Price = 100.0, ImagePath = "Pivo.jpg" },
                new Product { Name = "Корова", Price = 200.0, ImagePath = "korovy.png" },
                new Product { Name = "Сникерс", Price = 300.0, ImagePath = "zezfkj2x.jpg" },
                new Product { Name = "Пудж", Price = 400.0, ImagePath = "pudje.jpg" }
            };

            DisplayProducts();
        }

        private void DisplayProducts()
        {
            ProductsPanel.Children.Clear();

            foreach (var product in products)
            {
                var productCard = new Border
                {
                    Background = new SolidColorBrush(Colors.LightGray),
                    CornerRadius = new CornerRadius(8),
                    Padding = new Thickness(10),
                    Margin = new Thickness(0, 0, 0, 10)
                };

                var productContent = new StackPanel { Spacing = 5 };

                var image = new Windows.UI.Xaml.Controls.Image
                {
                    Source = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new System.Uri("ms-appx:///Assets/" + product.ImagePath)),
                    Width = 50,
                    Height = 50,
                    Stretch = Stretch.UniformToFill
                };
                productContent.Children.Add(image);

                var name = new TextBlock
                {
                    Text = product.Name,
                    FontSize = 16,
                    FontWeight = Windows.UI.Text.FontWeights.Bold,
                    Foreground = new SolidColorBrush(Colors.Black)
                };
                productContent.Children.Add(name);

                var price = new TextBlock
                {
                    Text = $"Цена: {product.Price} руб.",
                    FontSize = 14,
                    Foreground = new SolidColorBrush(Colors.DarkBlue)
                };
                productContent.Children.Add(price);

                var addButton = new Button
                {
                    Content = "Добавить в корзину",
                    Tag = product,
                    Width = 150
                };
                addButton.Click += AddToCart_Click;
                productContent.Children.Add(addButton);

                productCard.Child = productContent;
                ProductsPanel.Children.Add(productCard);
            }
        }

        private void AddToCart_Click(object sender, RoutedEventArgs e)
        {
            var button = sender as Button;
            var product = button.Tag as Product;

            if (product != null)
            {
                cart.Add(product);
                DisplayCart();
            }
        }

        private void DisplayCart()
        {
            CartPanel.Children.Clear();

            if (cart.Count == 0)
            {
                CartPanel.Children.Add(new TextBlock { Text = "Корзина пуста", FontSize = 14 });
                return;
            }

            foreach (var item in cart)
            {
                var cartItem = new StackPanel { Orientation = Orientation.Horizontal, Spacing = 10 };

                var image = new Windows.UI.Xaml.Controls.Image
                {
                    Source = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new System.Uri("ms-appx:///Assets/" + item.ImagePath)),
                    Width = 40,
                    Height = 40,
                    Stretch = Stretch.UniformToFill
                };
                cartItem.Children.Add(image);

                var info = new StackPanel { Spacing = 2 };
                info.Children.Add(new TextBlock { Text = item.Name, FontSize = 14, FontWeight = Windows.UI.Text.FontWeights.Bold });
                info.Children.Add(new TextBlock { Text = $"{item.Price} руб.", FontSize = 12, Foreground = new SolidColorBrush(Colors.Green) });
                cartItem.Children.Add(info);

                CartPanel.Children.Add(cartItem);
            }
        }
    }

    public class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public string ImagePath { get; set; }
    }
}