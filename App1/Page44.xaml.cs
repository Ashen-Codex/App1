using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Popups;
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
    public sealed partial class Page44 : Page
    {
        public Page44()
        {
            this.InitializeComponent();
        }

        private async void TextBlock_RightTapped(object sender, RightTappedRoutedEventArgs e)
        {
            PopupMenu menu = new PopupMenu();
            menu.Commands.Add(new UICommand("Копировать"));
            menu.Commands.Add(new UICommand("Вставить"));

            await menu.ShowAsync(e.GetPosition(sender as UIElement));
        }
    }
}
