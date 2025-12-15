using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace App1
{
    public class ItemTemplateSelector : DataTemplateSelector
    {
        public DataTemplate TextTemplate { get; set; }
        public DataTemplate ImageTemplate { get; set; }

        protected override DataTemplate SelectTemplateCore(object item, DependencyObject container)
        {
            if (item is MyTextItem)
                return TextTemplate;
            else if (item is ImageItem)
                return ImageTemplate;
            else
                return base.SelectTemplateCore(item, container);
        }
    }
}
