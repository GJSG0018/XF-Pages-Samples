using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace HomeTabbed.ViewModels
{
    public class Other1ContentPageViewModel : BindableBase
    {
        #region DI
        INavigationService _navigationService;
        #endregion

        #region ICommand
        public DelegateCommand 立即加入Command { get; set; }
        public DelegateCommand 首頁Command { get; set; }
        #endregion

        public Other1ContentPageViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;

            立即加入Command = new DelegateCommand(立即加入);
            首頁Command = new DelegateCommand(首頁);
        }

        private async void 首頁()
        {
            await _navigationService.NavigateAsync("/HomePage");
        }

        private async void 立即加入()
        {
            await _navigationService.NavigateAsync("Other2ContentPage");
        }
    }
}
