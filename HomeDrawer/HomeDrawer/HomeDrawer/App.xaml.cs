using Prism.Unity;
using HomeDrawer.Views;

namespace HomeDrawer
{
    public partial class App : PrismApplication
    {
        public App(IPlatformInitializer initializer = null) : base(initializer) { }

        protected override void OnInitialized()
        {
            InitializeComponent();

            NavigationService.NavigateAsync(new System.Uri("http://vulcan.net/MainPage/NaviPage/AboutPage", System.UriKind.Absolute));
        }

        protected override void RegisterTypes()
        {
            Container.RegisterTypeForNavigation<MainPage>();
            Container.RegisterTypeForNavigation<AboutPage>();
            Container.RegisterTypeForNavigation<NaviPage>();
            Container.RegisterTypeForNavigation<Leave1Page>();
            Container.RegisterTypeForNavigation<Leave2Page>();
            Container.RegisterTypeForNavigation<LogbookAppPage>();
            Container.RegisterTypeForNavigation<LogbookQuery>();
            Container.RegisterTypeForNavigation<OvertimePage>();
            Container.RegisterTypeForNavigation<PreferencePage>();
        }
    }
}
