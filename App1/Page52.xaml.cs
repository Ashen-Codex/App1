using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// Документацию по шаблону элемента "Пустая страница" см. по адресу https://go.microsoft.com/fwlink/?LinkId=234238

namespace App1
{
    public class Item
    {
        public string Name { get; set; }
        public string Category { get; set; }
    }

    public sealed partial class Page52 : Page
    {
        private List<Item> allItems;

        public Page52()
        {
            this.InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {

            allItems = new List<Item>
            {
                new Item { Name = "Элемент A", Category = "Категория 1" },
                new Item { Name = "Элемент B", Category = "Категория 1" },
                new Item { Name = "Элемент C", Category = "Категория 2" },
                new Item { Name = "Элемент D", Category = "Категория 2" },
                new Item { Name = "Элемент E", Category = "Категория 3" },
                new Item { Name = "Элемент F", Category = "Категория 3" }
            };


            var selectedItem = CategoryComboBox.SelectedItem as ComboBoxItem;
            if (selectedItem == null) return;

            string selectedCategory = selectedItem.Content?.ToString();
        }

        private void Category_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string selectedCategory = (string)CategoryComboBox.SelectedItem;

            if (selectedCategory == null)
                return;

            var filtered = allItems.Where(item => item.Category == selectedCategory).ToList();
            ItemsListView.ItemsSource = filtered;
        }
    }
}
