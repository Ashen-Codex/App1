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
using Windows.UI.Xaml.Controls;

namespace App1
{
    public sealed partial class Page29 : Page
    {
        public Page29()
        {
            InitializeComponent();

            // Вручную добавляем фрукты в ListView
            FruitsList.Items.Add("Яблоко");
            FruitsList.Items.Add("Банан");
            FruitsList.Items.Add("Апельсин");
            FruitsList.Items.Add("Груша");
            FruitsList.Items.Add("Киви");
        }

        private void Fruit_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // Получаем выбранный элемент напрямую
            if (FruitsList.SelectedItem != null)
            {
                string selectedFruit = FruitsList.SelectedItem.ToString();
                ResultText.Text = $"Выбрано: {selectedFruit}";
            }
            else
            {
                ResultText.Text = "";
            }
        }
    }
}