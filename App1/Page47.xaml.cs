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
    public sealed partial class Page47 : Page
    {
        public Page47()
        {
            this.InitializeComponent();
        }


        private void Add_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("Добавить");
        }

        private void Edit_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("Изменить");
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("Удалить");
        }

        private void Settings_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("Настройки");
        }

        private void About_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("О приложении");
        }
    }
}
