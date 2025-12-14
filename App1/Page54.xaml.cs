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
    public sealed partial class Page54 : Page
    {
        public Page54()
        {
            this.InitializeComponent();
        }

        private bool ValidateForm()
        {
            if (string.IsNullOrEmpty(NameTextBox.Text))
            {
                NameErrorTextBlock.Text = "Имя обязательно";
                return false;
            }

            if (string.IsNullOrEmpty(EmailTextBox.Text) || !EmailTextBox.Text.Contains("@"))
            {
                EmailErrorTextBlock.Text = "Неверный email";
                return false;
            }

            return true;
        }

        private void Submit_Click(object sender, RoutedEventArgs e)
        {
            if (ValidateForm())
            {
                if (ValidateForm())
                {
                    NameErrorTextBlock.Text = "✅ Форма отправлена!";
                    EmailErrorTextBlock.Text = "";
                }
            }
        }
    }
}
