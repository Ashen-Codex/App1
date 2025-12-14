
using Microsoft.UI.Xaml.Controls;

namespace App1
{
    public sealed partial class Page32 : Windows.UI.Xaml.Controls.Page
    {
        public Page32()
        {
            InitializeComponent();
            InitializeTreeView();
        }

        private void InitializeTreeView()
        {
            // Корневые узлы
            var category1 = new TreeViewNode { Content = "Категория 1", IsExpanded = true };
            var category2 = new TreeViewNode { Content = "Категория 2" };

            // Дочерние узлы
            category1.Children.Add(new TreeViewNode { Content = "Подкатегория 1.1" });
            category1.Children.Add(new TreeViewNode { Content = "Подкатегория 1.2" });
            category2.Children.Add(new TreeViewNode { Content = "Подкатегория 2.1" });

            // Добавляем в TreeView
            MyTreeView.RootNodes.Add(category1);
            MyTreeView.RootNodes.Add(category2);
        }
    }
}