using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace App1
{
    public sealed partial class Page51 : Page
    {
        public MainViewModel ViewModel { get; private set; }

        public Page51()
        {
            this.InitializeComponent();
            ViewModel = new MainViewModel();
            DataContext = ViewModel;
        }

        private void UpdateTitle_Click(object sender, RoutedEventArgs e)
        {
            ViewModel.Title = "Заголовок обновлён!";
        }
    }
}
