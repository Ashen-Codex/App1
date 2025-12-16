using System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace App1
{
    public sealed partial class Page85 : Page
    {
        public Page85()
        {
            this.InitializeComponent();
        }

        private async void SaveSettings_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new ContentDialog
            {
                Title = "Подтверждение",
                Content = "Вы уверены, что хотите сохранить настройки?",
                PrimaryButtonText = "Да",
                SecondaryButtonText = "Нет"
            };

            var result = await dialog.ShowAsync();

            if (result == ContentDialogResult.Primary)
            {
                System.Diagnostics.Debug.WriteLine($"Настройки сохранены: {EnableToggle.IsOn}, {NumericSlider.Value}, {ParameterComboBox.SelectedItem}");
            }
        }
    }
}

