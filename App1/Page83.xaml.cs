using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media;

namespace App1
{
    public sealed partial class Page83 : Page
    {
        private ScrollViewer scrollViewer;

        public Page83()
        {
            this.InitializeComponent();
            scrollViewer = NotesPanel.Parent as ScrollViewer;
            LoadNotes();
        }

        private void LoadNotes()
        {
            // Добавляем тестовые заметки
            AddNote("Первая заметка");
            AddNote("Вторая заметка");
            AddNote("Третья заметка");
        }

        private void SaveNote_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(NoteTextBox.Text))
            {
                AddNote(NoteTextBox.Text);

                NoteTextBox.Text = string.Empty;

                if (scrollViewer != null)
                {
                    scrollViewer.ChangeView(null, scrollViewer.ExtentHeight, null);
                }
            }
        }

        private void AddNote(string text)
        {
            var noteCard = new Border
            {
                Background = new Windows.UI.Xaml.Media.SolidColorBrush(Windows.UI.Colors.LightGray),
                CornerRadius = new Windows.UI.Xaml.CornerRadius(8),
                Padding = new Windows.UI.Xaml.Thickness(10),
                Margin = new Windows.UI.Xaml.Thickness(0, 5, 0, 5)
            };

            var noteContent = new StackPanel { Spacing = 5 };
            
            var noteText = new TextBlock
            {
                Text = text,
                FontSize = 16,
                Foreground = new SolidColorBrush(Colors.Black)
            };
            noteContent.Children.Add(noteText);

            noteCard.Child = noteContent;

            NotesPanel.Children.Add(noteCard);
        }
    }
}
