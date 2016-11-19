using Xamarin.Forms;

namespace BBXamarin
{
    public partial class TabbedPageDemoPage : TabbedPage
    {
        public TabbedPageDemoPage()
        {            
            ItemsSource = MonkeyDataModel.All;
        }
    }
}
