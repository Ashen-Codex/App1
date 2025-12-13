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
    public sealed partial class Page14 : Page
    {
        public Page14()
        {
            this.InitializeComponent();
        }
        private void ConfirmButton_Click(object sender, RoutedEventArgs e)
        {
            // Получаем выбранное время
            var selectedTime = MeetingTimePicker.Time;

            // Форматируем как строку (например: "14:30")
            string timeString = selectedTime.ToString(@"hh\:mm");
            // Или для 24-часового формата без ведущего нуля — можно использовать форматирование вручную:
            // string timeString = $"{selectedTime.Hours:D2}:{selectedTime.Minutes:D2}";

            // Показываем сообщение
            var dialog = new ContentDialog
            {
                Title = "Выбранное время",
                Content = $"Вы выбрали: {timeString}",
                CloseButtonText = "OK"
            };
            _ = dialog.ShowAsync();
        }
    }
}
