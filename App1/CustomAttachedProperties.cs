using Windows.UI.Xaml;

namespace App1
{
    public static class CustomAttachedProperties
    {

        public static readonly DependencyProperty CustomLabelProperty =
            DependencyProperty.RegisterAttached(
                "CustomLabel",
                typeof(string),
                typeof(CustomAttachedProperties),
                new PropertyMetadata(null));

        public static string GetCustomLabel(DependencyObject obj)
        {
            return (string)obj.GetValue(CustomLabelProperty);
        }

        public static void SetCustomLabel(DependencyObject obj, string value)
        {
            obj.SetValue(CustomLabelProperty, value);
        }
    }
}