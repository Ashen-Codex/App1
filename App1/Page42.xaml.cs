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
using Windows.UI.Xaml.Media.Animation;
using Windows.UI.Xaml.Navigation;

// Документацию по шаблону элемента "Пустая страница" см. по адресу https://go.microsoft.com/fwlink/?LinkId=234238

namespace App1
{
    /// <summary>
    /// Пустая страница, которую можно использовать саму по себе или для перехода внутри фрейма.
    /// </summary>
    public sealed partial class Page42 : Page
    {
        public Page42()
        {
            this.InitializeComponent();
        }

        private async void AnimateButton_Click(object sender, RoutedEventArgs e)
        {
            var storyboard = new Storyboard();

            var scaleAnimationX = new DoubleAnimation
            {
                From = 1.0,
                To = 1.5,
                Duration = new Duration(TimeSpan.FromSeconds(1))
            };

            var scaleAnimationY = new DoubleAnimation
            {
                From = 1.0,
                To = 1.5,
                Duration = new Duration(TimeSpan.FromSeconds(1))
            };

            Storyboard.SetTarget(scaleAnimationX, MyButton);
            Storyboard.SetTarget(scaleAnimationY, MyButton);

            Storyboard.SetTargetProperty(scaleAnimationX, "(UIElement.RenderTransform).(ScaleTransform.ScaleX)");
            Storyboard.SetTargetProperty(scaleAnimationY, "(UIElement.RenderTransform).(ScaleTransform.ScaleY)");

            storyboard.Children.Add(scaleAnimationX);
            storyboard.Children.Add(scaleAnimationY);
            MyButton.RenderTransform = new ScaleTransform { ScaleX = 1.0, ScaleY = 1.0 };
            storyboard.Begin();

            await Task.Delay(1000);

            MyButton.RenderTransform = new ScaleTransform { ScaleX = 1.0, ScaleY = 1.0 };
        }
    }
}
