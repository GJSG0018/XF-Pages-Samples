using Prism.Unity;
using System;
using XFSplash.Views;

namespace XFSplash
{
    public partial class App : PrismApplication
    {
        public App(IPlatformInitializer initializer = null) : base(initializer) { }

        protected override void OnInitialized()
        {
            InitializeComponent();

            NavigationService.NavigateAsync(new Uri("http://vulcan.net/SplashPage", UriKind.Absolute));
        }

        protected override void RegisterTypes()
        {
            Container.RegisterTypeForNavigation<MainPage>();
            Container.RegisterTypeForNavigation<SplashPage>();
        }
    }
}
