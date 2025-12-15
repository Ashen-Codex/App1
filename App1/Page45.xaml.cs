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
    public sealed partial class Page45 : Page
    {
        public Page45()
        {
            this.InitializeComponent();
        }

        private void ShowFlyout_Click(object sender, RoutedEventArgs e)
        {
            var flyout = new Flyout();

            var stackPanel = new StackPanel { Spacing = 10 };

            var textBlock = new TextBlock { Text = "Это всплывающее меню" };
            var button1 = new Button { Content = "Опция 1" };
            var button2 = new Button { Content = "Опция 2" };

            stackPanel.Children.Add(textBlock);
            stackPanel.Children.Add(button1);
            stackPanel.Children.Add(button2);

            flyout.Content = stackPanel;

            flyout.ShowAt(sender as FrameworkElement);
        }
    }
}
