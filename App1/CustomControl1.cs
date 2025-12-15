using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace App1
{
    public sealed class CustomControl1 : Control
    {
        public CustomControl1()
        {
            // Ключ для поиска стиля по умолчанию в Generic.xaml
            this.DefaultStyleKey = typeof(CustomControl1);
        }
    }
}