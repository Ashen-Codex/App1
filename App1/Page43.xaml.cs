using System;
using System.Collections.Generic;
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
using Windows.UI.Xaml.Navigation;

// Документацию по шаблону элемента "Пустая страница" см. по адресу https://go.microsoft.com/fwlink/?LinkId=234238

namespace App1
{
    /// <summary>
    /// Пустая страница, которую можно использовать саму по себе или для перехода внутри фрейма.
    /// </summary>
    public sealed partial class Page43 : Page
    {
        public Page43()
        {
            this.InitializeComponent();
        }

        private void Element_PointerEntered(object sender, PointerRoutedEventArgs e)
        {
            StatusTextBlock.Text = "Мышь вошла в область элемента";
            TargetElement.Fill = new Windows.UI.Xaml.Media.SolidColorBrush(Windows.UI.Colors.Blue);
        }

        private void Element_PointerExited(object sender, PointerRoutedEventArgs e)
        {
            StatusTextBlock.Text = "Мышь вышла из области элемента";
            TargetElement.Fill = new Windows.UI.Xaml.Media.SolidColorBrush(Windows.UI.Colors.LightBlue);
        }

        private void Element_PointerPressed(object sender, PointerRoutedEventArgs e)
        {
            StatusTextBlock.Text = "Кнопка мыши или палец нажаты";
            TargetElement.Fill = new Windows.UI.Xaml.Media.SolidColorBrush(Windows.UI.Colors.Red);
        }

        private void Element_PointerReleased(object sender, PointerRoutedEventArgs e)
        {
            StatusTextBlock.Text = "Кнопка мыши или палец отпущены";
            TargetElement.Fill = new Windows.UI.Xaml.Media.SolidColorBrush(Windows.UI.Colors.LightBlue);
        }
    }
}
