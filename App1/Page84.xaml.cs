using System;
using System.Collections.Generic;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media;

namespace App1
{
    public sealed partial class Page84 : Page
    {
        public Page84()
        {
            this.InitializeComponent();
        }

        private async void SubmitAnswers_Click(object sender, RoutedEventArgs e)
        {
            var selectedColor = "";
            if (FindRadioButton("ColorGroup", "Красный").IsChecked == true)
                selectedColor = "Красный";
            else if (FindRadioButton("ColorGroup", "Синий").IsChecked == true)
                selectedColor = "Синий";
            else if (FindRadioButton("ColorGroup", "Зелёный").IsChecked == true)
                selectedColor = "Зелёный";
            else if (FindRadioButton("ColorGroup", "Жёлтый").IsChecked == true)
                selectedColor = "Жёлтый";

            var selectedFruits = "";
            if (FindCheckBox("Яблоко").IsChecked == true)
                selectedFruits += "Яблоко, ";
            if (FindCheckBox("Банан").IsChecked == true)
                selectedFruits += "Банан, ";
            if (FindCheckBox("Апельсин").IsChecked == true)
                selectedFruits += "Апельсин, ";
            if (FindCheckBox("Груша").IsChecked == true)
                selectedFruits += "Груша, ";

            var openAnswer = FindTextBox().Text;

            Progressbar.Value = 100;

            var dialog = new ContentDialog
            {
                Title = "Результат",
                Content = $"Вы выбрали цвет: {selectedColor}\nЛюбимые фрукты: {selectedFruits}\nОтвет на открытый вопрос: {openAnswer}",
                PrimaryButtonText = "OK"
            };

            await dialog.ShowAsync();
        }

        private RadioButton FindRadioButton(string groupName, string content)
        {
            foreach (var child in this.FindChildren<RadioButton>())
            {
                if (child.GroupName == groupName && child.Content.ToString() == content)
                    return child;
            }
            return null;
        }

        private CheckBox FindCheckBox(string content)
        {
            foreach (var child in this.FindChildren<CheckBox>())
            {
                if (child.Content.ToString() == content)
                    return child;
            }
            return null;
        }

        private TextBox FindTextBox()
        {
            foreach (var child in this.FindChildren<TextBox>())
            {
                if (child.PlaceholderText == "Введите ваш ответ")
                    return child;
            }
            return null;
        }
    }

    public static class Extensions
    {
        public static IEnumerable<T> FindChildren<T>(this DependencyObject parent) where T : DependencyObject
        {
            if (parent == null) yield break;

            for (int i = 0; i < VisualTreeHelper.GetChildrenCount(parent); i++)
            {
                var child = VisualTreeHelper.GetChild(parent, i);
                if (child is T t)
                    yield return t;

                foreach (var descendant in FindChildren<T>(child))
                    yield return descendant;
            }
        }
    }
}
