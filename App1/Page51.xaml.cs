using Windows.UI.Xaml.Controls;

namespace App1
{
    public sealed partial class Page51 : Page
    {
        public Page51()
        {
            this.InitializeComponent();

            // Просто добавляем строки в список
            TaskList.Items.Add("Купить молоко");
            TaskList.Items.Add("Сделать задание по UWP");
            TaskList.Items.Add("Погулять с собакой");
        }
    }
}