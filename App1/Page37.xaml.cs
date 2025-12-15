using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace App1
{
    public sealed partial class Page37 : Page
    {
        // Счётчик элементов (вручную)
        private int _counter = 0;

        public Page37()
        {
            InitializeComponent();
            // Начальный список пуст — как в оригинале
        }

        private void AddItem_Click(object sender, RoutedEventArgs e)
        {
            _counter++;
            // Вручную добавляем элемент в ListView
            MyListView.Items.Add("Новый элемент " + _counter);
        }
    }
}