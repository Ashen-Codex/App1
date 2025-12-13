using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI;
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
    public sealed partial class Page4 : Page
    {
        public Page4()
        {
            this.InitializeComponent();
        }
        private void CheckPassword_Click(object sender, RoutedEventArgs e)
        {
            string password = PasswordInput.Password;
            if (password == "12345")
            {
                ResultTextBlock.Text = "Пароль верный!";
                ResultTextBlock.Foreground = new SolidColorBrush(Colors.Green);
            }
            else
            {
                ResultTextBlock.Text = "Пароль неверный!";
            }
        }
    }
}
