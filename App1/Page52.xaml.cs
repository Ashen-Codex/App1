using Windows.UI.Xaml.Controls;

namespace App1
{
    public sealed partial class Page52 : Page
    {
        public Page52()
        {
            this.InitializeComponent();
            ShowAllItems();
        }

        private void ShowAllItems()
        {
            ItemsListView.Items.Clear();
            ItemsListView.Items.Add("Элемент A (Категория 1)");
            ItemsListView.Items.Add("Элемент B (Категория 1)");
            ItemsListView.Items.Add("Элемент C (Категория 2)");
            ItemsListView.Items.Add("Элемент D (Категория 2)");
            ItemsListView.Items.Add("Элемент E (Категория 3)");
            ItemsListView.Items.Add("Элемент F (Категория 3)");
        }

        private void ShowCategory1()
        {
            ItemsListView.Items.Clear();
            ItemsListView.Items.Add("Элемент A (Категория 1)");
            ItemsListView.Items.Add("Элемент B (Категория 1)");
        }

        private void ShowCategory2()
        {
            ItemsListView.Items.Clear();
            ItemsListView.Items.Add("Элемент C (Категория 2)");
            ItemsListView.Items.Add("Элемент D (Категория 2)");
        }

        private void ShowCategory3()
        {
            ItemsListView.Items.Clear();
            ItemsListView.Items.Add("Элемент E (Категория 3)");
            ItemsListView.Items.Add("Элемент F (Категория 3)");
        }

        private void Category_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string selectedCategory = CategoryComboBox.SelectedItem as string;

            if (selectedCategory == "Категория 1")
                ShowCategory1();
            else if (selectedCategory == "Категория 2")
                ShowCategory2();
            else if (selectedCategory == "Категория 3")
                ShowCategory3();
            else
                ShowAllItems();
        }
    }
}
