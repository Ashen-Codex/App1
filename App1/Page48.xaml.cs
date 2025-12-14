using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace App1
{
    public sealed partial class Page48 : Page
    {
        public Page48()
        {
            this.InitializeComponent();
        }

        private void MainAction_Click(SplitButton sender, SplitButtonClickEventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("Основное действие выполнено!");
        }
    }
}
