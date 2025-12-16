using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace App1
{
    public class MainViewModel : INotifyPropertyChanged
    {
        private string _title;
        private ObservableCollection<Item> _items;

        public string Title
        {
            get => _title;
            set => SetProperty(ref _title, value);
        }

        /// <summary>
        /// Список элементов, отображаемых в ListView
        /// </summary>
        public ObservableCollection<Item> Items
        {
            get => _items;
            set => SetProperty(ref _items, value);
        }

        public MainViewModel()
        {
            Title = "Список задач";
            Items = new ObservableCollection<Item>
            {
                new Item { Name = "Купить молоко" },
                new Item { Name = "Сделать задание по UWP" },
                new Item { Name = "Погулять с собакой" }
            };
        }

        // Вспомогательный метод для безопасного вызова INotifyPropertyChanged
        private void SetProperty<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (!Equals(field, value))
            {
                field = value;
                OnPropertyChanged(propertyName);
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}