using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace HomeTabbed.ViewModels
{
    public class JoinUsPageViewModel : BindableBase
    {
        #region DI
        INavigationService _navigationService;
        #endregion

        #region ICommand
        public DelegateCommand 了解更多Command { get; set; }
        #endregion

        public JoinUsPageViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;

            了解更多Command = new DelegateCommand(了解更多);
        }

        private async void 了解更多()
        {
            await _navigationService.NavigateAsync(new Uri("NaviPage/Other1ContentPage", UriKind.Relative));
        }
    }
}
