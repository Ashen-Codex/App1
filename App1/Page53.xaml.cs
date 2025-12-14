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
    public sealed partial class Page53 : Page
    {
        public class Item
        {
            public string Name { get; set; }
        }

        public Page53()
        {
            this.InitializeComponent();
        }

        private async void LoadData_Click(object sender, RoutedEventArgs e)
        {
            LoadingRing.IsActive = true;

            try
            {
                var data = await FetchDataAsync();
                DataListView.ItemsSource = data;
            }
            catch (Exception ex)
            {
                var dialog = new ContentDialog
                {
                    Title = "Ошибка",
                    Content = $"Не удалось загрузить данные: {ex.Message}",
                    PrimaryButtonText = "OK"
                };
                await dialog.ShowAsync();
            }
            finally
            {
                LoadingRing.IsActive = false;
            }
        }

        private async Task<List<Item>> FetchDataAsync()
        {
            await Task.Delay(2000);

            return new List<Item>
            {
                new Item { Name = "Элемент 1" },
                new Item { Name = "Элемент 2" },
                new Item { Name = "Элемент 3" },
                new Item { Name = "Элемент 4" },
                new Item { Name = "Элемент 5" }
            };
        }
    }
}
