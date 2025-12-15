using System.Collections.Generic;
using System.Linq;
using Windows.UI.Xaml.Controls;

namespace App1
{
    public sealed partial class Page36 : Page
    {
        // 1. Исходные данные — просто массив строк
        private string[] allFruits = {
            "Яблоко", "Банан", "Апельсин", "Груша", "Киви",
            "Манго", "Ананас", "Вишня", "Слива", "Персик",
            "Арбуз", "Дыня", "Лимон", "Грейпфрут", "Мандарин"
        };

        public Page36()
        {
            InitializeComponent();
            // 2. При запуске — показываем всё
            ShowItems(allFruits);
        }

        private void SearchBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            string query = SearchBox.Text?.ToLower() ?? "";

            if (string.IsNullOrWhiteSpace(query))
            {
                // Если поле пустое — показываем всё
                ShowItems(allFruits);
            }
            else
            {
                // 3. Вручную фильтруем
                var filtered = new System.Collections.Generic.List<string>();
                foreach (string fruit in allFruits)
                {
                    if (fruit.ToLower().Contains(query))
                    {
                        filtered.Add(fruit);
                    }
                }
                ShowItems(filtered.ToArray());
            }
        }

        // 4. Вручную обновляем содержимое ListView
        private void ShowItems(string[] items)
        {
            ResultsList.Items.Clear(); // Очищаем
            foreach (string item in items)
            {
                ResultsList.Items.Add(item); // Добавляем по одному
            }
        }
    }
}