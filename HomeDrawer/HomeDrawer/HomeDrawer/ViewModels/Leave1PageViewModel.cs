using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace HomeDrawer.ViewModels
{
    public class Leave1PageViewModel : BindableBase, INavigationAware
    {
        #region DI
        INavigationService _navigationService;
        #endregion

        #region ICommand
        public DelegateCommand 請假申請Command { get; set; }
        #endregion
        public Leave1PageViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;

            請假申請Command = new DelegateCommand(請假申請);
        }

        private void 請假申請()
        {
            _navigationService.NavigateAsync("Leave2Page");
        }

        public void OnNavigatedFrom(NavigationParameters parameters)
        {
        }

        public void OnNavigatedTo(NavigationParameters parameters)
        {
        }
    }
}
