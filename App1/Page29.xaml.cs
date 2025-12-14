using System;
using System.Collections.ObjectModel;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace App1
{
    public sealed partial class Page29 : Page
    {
        public Page29()
        {
            InitializeComponent();

            ObservableCollection<string> fruits = new ObservableCollection<string>
            {
                "Яблоко",
                "Банан",
                "Апельсин",
                "Груша",
                "Киви"
            };
            FruitsList.ItemsSource = fruits;
        }

        private void Fruit_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (FruitsList.SelectedItem != null)
            {
                string selectedFruit = FruitsList.SelectedItem.ToString();
                SelectionText.Text = $"Вы выбрали: {selectedFruit}";
            }
        }
    }
}