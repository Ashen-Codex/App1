using System;
using System.Collections.Generic;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;

namespace App1
{
    public sealed partial class Page30 : Page
    {
        
        
        

        public Page30()
        {
            InitializeComponent();

            foreach (var path in new[] { "Assets/Fin.png" })
            {
                ImageGrid.Items.Add(new Image
                {
                    Source = new BitmapImage(new Uri("ms-appx:///" + path)),
                    Width = 150,
                    Height = 150,
                    Stretch = Stretch.UniformToFill
                });
            }
        }
    }
}

