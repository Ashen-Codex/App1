using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
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
    public sealed partial class Page55 : Page
    {
        public Page55()
        {
            this.InitializeComponent();
        }

        private async void ProcessData_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var result = await ProcessAsync();
                StatusTextBlock.Text = "Успешно!";
            }
            catch (Exception ex)
            {
                ContentDialog errorDialog = new ContentDialog
                {
                    Title = "Ошибка",
                    Content = $"Произошла ошибка: {ex.Message}",
                    PrimaryButtonText = "ОК"
                };
                await errorDialog.ShowAsync();
            }
        }
        private async Task<string> ProcessAsync()
        {
            await Task.Delay(1000);

            if (new Random().Next(2) == 0)
                throw new InvalidOperationException("Случайная ошибка!");

            return "Результат обработки";
        }
    }
}
