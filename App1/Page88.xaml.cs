using System;
using System.Collections.Generic;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media;

namespace App1
{
    public sealed partial class Page88 : Page
    {
        private List<Event> events;

        public Page88()
        {
            this.InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            events = new List<Event>
            {
                new Event { Date = "15.12.2025", Time = "10:00", Description = "Встреча с клиентом" },
                new Event { Date = "16.12.2025", Time = "14:30", Description = "Обед" },
                new Event { Date = "17.12.2025", Time = "09:00", Description = "Совещание" }
            };

            DisplayEvents();
        }

        private void DisplayEvents()
        {
            EventsPanel.Children.Clear();

            foreach (var eventItem in events)
            {
                var eventCard = new Border
                {
                    Background = new SolidColorBrush(Colors.LightGray),
                    CornerRadius = new CornerRadius(8),
                    Padding = new Thickness(10),
                    Margin = new Thickness(0, 0, 0, 10)
                };

                var eventContent = new StackPanel { Spacing = 5 };

                var date = new TextBlock
                {
                    Text = $"Дата: {eventItem.Date}",
                    FontSize = 16,
                    FontWeight = Windows.UI.Text.FontWeights.Bold,
                    Foreground = new SolidColorBrush(Colors.Black)
                };
                eventContent.Children.Add(date);

                var time = new TextBlock
                {
                    Text = $"Время: {eventItem.Time}",
                    FontSize = 14,
                    Foreground = new SolidColorBrush(Colors.DarkBlue)
                };
                eventContent.Children.Add(time);

                var description = new TextBlock
                {
                    Text = $"Описание: {eventItem.Description}",
                    FontSize = 14,
                    Foreground = new SolidColorBrush(Colors.DarkBlue)
                };
                eventContent.Children.Add(description);

                eventCard.Child = eventContent;
                EventsPanel.Children.Add(eventCard);
            }
        }

        private void AddEvent_Click(object sender, RoutedEventArgs e)
        {
            string description = EventTimeTextBox.Text;
            string date = DatePicker.SelectedDate?.ToString("dd.MM.yyyy") ?? System.DateTime.Now.ToString("dd.MM.yyyy");
            string time = TimePicker.Time.ToString("hh\\:mm");

            if (!string.IsNullOrEmpty(description))
            {
                events.Add(new Event { Date = date, Time = time, Description = description });
                DisplayEvents();
                EventTimeTextBox.Text = string.Empty;
            }
        }

        private void DatePicker_DateChanged(object sender, DatePickerValueChangedEventArgs e)
        {
            ClearDayHighlights();

            if (DatePicker.SelectedDate.HasValue)
            {
                // Преобразуем в DateTime
                var selectedDate = DatePicker.SelectedDate.Value.DateTime;

                // Получаем день недели
                var dayOfWeek = selectedDate.DayOfWeek;

                // Подсвечиваем нужный день
                switch (dayOfWeek)
                {
                    case DayOfWeek.Monday:
                        MondayBorder.BorderBrush = new SolidColorBrush(Colors.Blue);
                        break;
                    case DayOfWeek.Tuesday:
                        TuesdayBorder.BorderBrush = new SolidColorBrush(Colors.Blue);
                        break;
                    case DayOfWeek.Wednesday:
                        WednesdayBorder.BorderBrush = new SolidColorBrush(Colors.Blue);
                        break;
                    case DayOfWeek.Thursday:
                        ThursdayBorder.BorderBrush = new SolidColorBrush(Colors.Blue);
                        break;
                    case DayOfWeek.Friday:
                        FridayBorder.BorderBrush = new SolidColorBrush(Colors.Blue);
                        break;
                    case DayOfWeek.Saturday:
                        SaturdayBorder.BorderBrush = new SolidColorBrush(Colors.Blue);
                        break;
                    case DayOfWeek.Sunday:
                        SundayBorder.BorderBrush = new SolidColorBrush(Colors.Blue);
                        break;
                }
            }
        }

        private void ClearDayHighlights()
        {
            MondayBorder.BorderBrush = new SolidColorBrush(Colors.Transparent);
            TuesdayBorder.BorderBrush = new SolidColorBrush(Colors.Transparent);
            WednesdayBorder.BorderBrush = new SolidColorBrush(Colors.Transparent);
            ThursdayBorder.BorderBrush = new SolidColorBrush(Colors.Transparent);
            FridayBorder.BorderBrush = new SolidColorBrush(Colors.Transparent);
            SaturdayBorder.BorderBrush = new SolidColorBrush(Colors.Transparent);
            SundayBorder.BorderBrush = new SolidColorBrush(Colors.Transparent);
        }
    }

    public class Event
    {
        public string Date { get; set; }
        public string Time { get; set; }
        public string Description { get; set; }
    }
}