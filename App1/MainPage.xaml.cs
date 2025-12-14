using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace App1
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a <see cref="Frame">.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private void NavigationView_Loaded(object sender, RoutedEventArgs e)
        {
            ContentFrame.Navigate(typeof(HomePage));
        }
        private void NavigationView_SelectionChanged(NavigationView sender, NavigationViewSelectionChangedEventArgs args)
        {
            if (args.IsSettingsSelected)
            {

            }
            else
            {
                NavigationViewItem item = args.SelectedItem as NavigationViewItem;

                switch (item.Tag.ToString())
                {
                    case "HomePage":
                        ContentFrame.Navigate(typeof(HomePage));
                        break;
                    case "Page1":
                        ContentFrame.Navigate(typeof(Page1));
                        break;
                    case "Page2":
                        ContentFrame.Navigate(typeof(Page2));
                        break;
                    case "Page3":
                        ContentFrame.Navigate(typeof(Page3));
                        break;
                    case "Page4":
                        ContentFrame.Navigate(typeof(Page4));
                        break;
                    case "Page5":
                        ContentFrame.Navigate(typeof(Page5));
                        break;
                    case "Page6":
                        ContentFrame.Navigate(typeof(Page6));
                        break;
                    case "Page7":
                        ContentFrame.Navigate(typeof(Page7));
                        break;
                    case "Page8":
                        ContentFrame.Navigate(typeof(Page8));
                        break;
                    case "Page9":
                        ContentFrame.Navigate(typeof(Page9));
                        break;
                    case "Page10":
                        ContentFrame.Navigate(typeof(Page10));
                        break;
                    case "Page11":
                        ContentFrame.Navigate(typeof(Page11));
                        break;
                    case "Page12":
                        ContentFrame.Navigate(typeof(Page12));
                        break;
                    case "Page13":
                        ContentFrame.Navigate(typeof(Page13));
                        break;
                    case "Page14":
                        ContentFrame.Navigate(typeof(Page14));
                        break;
                    case "Page15":
                        ContentFrame.Navigate(typeof(Page15));
                        break;
                    case "Page16":
                        ContentFrame.Navigate(typeof(Page16));
                        break;
                    case "Page17":
                        ContentFrame.Navigate(typeof(Page17));
                        break;
                    case "Page18":
                        ContentFrame.Navigate(typeof(Page18));
                        break;
                    case "Page19":
                        ContentFrame.Navigate(typeof(Page19));
                        break;
                    case "Page20":
                        ContentFrame.Navigate(typeof(Page20));
                        break;
                    case "Page21":
                        ContentFrame.Navigate(typeof(Page21));
                        break;
                    case "Page22":
                        ContentFrame.Navigate(typeof(Page22));
                        break;
                    case "Page23":
                        ContentFrame.Navigate(typeof(Page23));
                        break;
                    case "Page24":
                        ContentFrame.Navigate(typeof(Page24));
                        break;
                    case "Page25":
                        ContentFrame.Navigate(typeof(Page25));
                        break;
                    case "Page26":
                        ContentFrame.Navigate(typeof(Page26));
                        break;
                    case "Page27":
                        ContentFrame.Navigate(typeof(Page27));
                        break;
                    case "Page28":
                        ContentFrame.Navigate(typeof(Page28));
                        break;
                    case "Page29":
                        ContentFrame.Navigate(typeof(Page29));
                        break;
                    case "Page30":
                        ContentFrame.Navigate(typeof(Page30));
                        break;
                    case "Page31":
                        ContentFrame.Navigate(typeof(Page31));
                        break;
                    case "Page32":
                        ContentFrame.Navigate(typeof(Page32));
                        break;
                    case "Page33":
                        ContentFrame.Navigate(typeof(Page33));
                        break;
                    case "Page34":
                        ContentFrame.Navigate(typeof(Page34));
                        break;
                    case "Page35":
                        ContentFrame.Navigate(typeof(Page35));
                        break;
                    case "Page36":
                        ContentFrame.Navigate(typeof(Page36));
                        break;
                    case "Page37":
                        ContentFrame.Navigate(typeof(Page37));
                        break;
                    case "Page38":
                        ContentFrame.Navigate(typeof(Page38));
                        break;
                    case "Page39":
                        ContentFrame.Navigate(typeof(Page39));
                        break;
                    case "Page40":
                        ContentFrame.Navigate(typeof(Page40));
                        break;
                    case "Page41":
                        ContentFrame.Navigate(typeof(Page41));
                        break;
                    case "Page42":
                        ContentFrame.Navigate(typeof(Page42));
                        break;
                    case "Page43":
                        ContentFrame.Navigate(typeof(Page43));
                        break;
                    case "Page44":
                        ContentFrame.Navigate(typeof(Page44));
                        break;
                    case "Page45":
                        ContentFrame.Navigate(typeof(Page45));
                        break;
                    case "Page46":
                        ContentFrame.Navigate(typeof(Page46));
                        break;
                    case "Page47":
                        ContentFrame.Navigate(typeof(Page47));
                        break;
                    case "Page48":
                        ContentFrame.Navigate(typeof(Page48));
                        break;
                    case "Page49":
                        ContentFrame.Navigate(typeof(Page49));
                        break;
                    case "Page50":
                        ContentFrame.Navigate(typeof(Page50));
                        break;
                    case "Page51":
                        ContentFrame.Navigate(typeof(Page51));
                        break;
                    case "Page52":
                        ContentFrame.Navigate(typeof(Page52));
                        break;
                    case "Page53":
                        ContentFrame.Navigate(typeof(Page53));
                        break;
                    case "Page54":
                        ContentFrame.Navigate(typeof(Page54));
                        break;
                    case "Page55":
                        ContentFrame.Navigate(typeof(Page55));
                        break;
                    case "Page56":
                        ContentFrame.Navigate(typeof(Page56));
                        break;
                    case "Page57":
                        ContentFrame.Navigate(typeof(Page57));
                        break;
                    case "Page58":
                        ContentFrame.Navigate(typeof(Page58));
                        break;
                    case "Page59":
                        ContentFrame.Navigate(typeof(Page59));
                        break;
                    case "Page60":
                        ContentFrame.Navigate(typeof(Page60));
                        break;
                    case "Page61":
                        ContentFrame.Navigate(typeof(Page61));
                        break;
                    case "Page62":
                        ContentFrame.Navigate(typeof(Page62));
                        break;
                    case "Page63":
                        ContentFrame.Navigate(typeof(Page63));
                        break;
                    case "Page64":
                        ContentFrame.Navigate(typeof(Page64));
                        break;
                    case "Page65":
                        ContentFrame.Navigate(typeof(Page65));
                        break;
                    case "Page66":
                        ContentFrame.Navigate(typeof(Page66));
                        break;
                    case "Page67":
                        ContentFrame.Navigate(typeof(Page67));
                        break;
                    case "Page68":
                        ContentFrame.Navigate(typeof(Page68));
                        break;
                    case "Page69":
                        ContentFrame.Navigate(typeof(Page69));
                        break;
                    case "Page70":
                        ContentFrame.Navigate(typeof(Page70));
                        break;
                    case "Page71":
                        ContentFrame.Navigate(typeof(Page71));
                        break;
                    case "Page72":
                        ContentFrame.Navigate(typeof(Page72));
                        break;
                    case "Page73":
                        ContentFrame.Navigate(typeof(Page73));
                        break;
                    case "Page74":
                        ContentFrame.Navigate(typeof(Page74));
                        break;
                    case "Page75":
                        ContentFrame.Navigate(typeof(Page75));
                        break;
                    case "Page76":
                        ContentFrame.Navigate(typeof(Page76));
                        break;
                    case "Page77":
                        ContentFrame.Navigate(typeof(Page77));
                        break;
                    case "Page78":
                        ContentFrame.Navigate(typeof(Page78));
                        break;
                    case "Page79":
                        ContentFrame.Navigate(typeof(Page79));
                        break;
                    case "Page80":
                        ContentFrame.Navigate(typeof(Page80));
                        break;
                    case "Page81":
                        ContentFrame.Navigate(typeof(Page81));
                        break;
                    case "Page82":
                        ContentFrame.Navigate(typeof(Page82));
                        break;
                    case "Page83":
                        ContentFrame.Navigate(typeof(Page83));
                        break;
                    case "Page84":
                        ContentFrame.Navigate(typeof(Page84));
                        break;
                    case "Page85":
                        ContentFrame.Navigate(typeof(Page85));
                        break;
                    case "Page86":
                        ContentFrame.Navigate(typeof(Page86));
                        break;
                    case "Page87":
                        ContentFrame.Navigate(typeof(Page87));
                        break;
                    case "Page88":
                        ContentFrame.Navigate(typeof(Page88));
                        break;
                    case "Page89":
                        ContentFrame.Navigate(typeof(Page89));
                        break;
                    case "Page90":
                        ContentFrame.Navigate(typeof(Page90));
                        break;
                    case "Page91":
                        ContentFrame.Navigate(typeof(Page91));
                        break;
                    case "Page92":
                        ContentFrame.Navigate(typeof(Page92));
                        break;
                    case "Page93":
                        ContentFrame.Navigate(typeof(Page93));
                        break;
                    case "Page94":
                        ContentFrame.Navigate(typeof(Page94));
                        break;
                    case "Page95":
                        ContentFrame.Navigate(typeof(Page95));
                        break;
                    case "Page96":
                        ContentFrame.Navigate(typeof(Page96));
                        break;
                    case "Page97":
                        ContentFrame.Navigate(typeof(Page97));
                        break;
                    case "Page98":
                        ContentFrame.Navigate(typeof(Page98));
                        break;
                    case "Page99":
                        ContentFrame.Navigate(typeof(Page99));
                        break;
                    case "Page100":
                        ContentFrame.Navigate(typeof(Page100));
                        break;
                }
            }
        }
    }
}
