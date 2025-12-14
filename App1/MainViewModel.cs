using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace App1
{
    public class MainViewModel : INotifyPropertyChanged
    {
        private string _title = "Изначальный заголовок";
        private List<object> _items;

        public string Title
        {
            get => _title;
            set => SetProperty(ref _title, value);
        }

        public List<object> Items
        {
            get => _items;
            set => SetProperty(ref _items, value);
        }

        public MainViewModel()
        {
            LoadData();
        }

        private void LoadData()
        {
            Items = new List<object>
            {
                "Элемент A",
                "Элемент B",
                "Элемент C"
            };
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetProperty<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (Equals(field, value)) return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
    }
}
