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
        public sealed partial class Page13 : Page
        {
            public Page13()
            {
                this.InitializeComponent();
            }

            private void Birthdate_Changed(object sender, DatePickerValueChangedEventArgs e)
            {
                // Используем e.NewDate вместо обращения к sender
                if (e.NewDate != null)
                {
                    DateTime date = e.NewDate.DateTime;
                    SelectedDateTextBlock.Text = $"Выбрана дата: {date:dd.MM.yyyy}";
                }
                else
                {
                    SelectedDateTextBlock.Text = "Дата не выбрана";
                }
            }
        }
}


