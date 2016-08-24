using Xamarin.Forms;

namespace HomeTabbed.Views
{
    public partial class NaviPage : NavigationPage
    {
        public NaviPage()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, true);
        }
    }
}
