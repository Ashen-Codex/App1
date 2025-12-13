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
    public sealed partial class Page7 : Page
    {
        public Page7()
        {
            this.InitializeComponent();
        }
        private void ShowGender_Click(object sender, RoutedEventArgs e)
        {
            string selected = "Пол не выбран";
            if (RadioMale.IsChecked == true) selected = "Выбран: Мужской";
            else if (RadioFemale.IsChecked == true) selected = "Выбран: Женский";
            else if (RadioOther.IsChecked == true) selected = "Выбран: Другое";
            GenderTextBlock.Text = selected;
        }
    }
}
