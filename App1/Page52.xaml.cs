using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

        public Item(string name, string category)
        {
            Name = name;
            Category = category;
        }
    }

    public sealed partial class Page52 : Page
    {
        private ObservableCollection<Item> allItems;

        public Page52()
        {
            this.InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            allItems = new ObservableCollection<Item>
            {
                new Item("Элемент A", "Категория 1"),
                new Item("Элемент B", "Категория 1"),
                new Item("Элемент C", "Категория 2"),
                new Item("Элемент D", "Категория 2"),
                new Item("Элемент E", "Категория 3"),
                new Item("Элемент F", "Категория 3")
            };

            ItemsListView.ItemsSource = allItems;
        }

        private void Category_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string selectedCategory = CategoryComboBox.SelectedItem as string;

            if (string.IsNullOrEmpty(selectedCategory))
                return;

            var filtered = allItems.Where(item => item.Category == selectedCategory).ToList();
            ItemsListView.ItemsSource = filtered;
        }
    }
}
