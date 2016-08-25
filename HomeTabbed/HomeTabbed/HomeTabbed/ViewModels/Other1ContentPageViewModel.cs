using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using Prism.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeTabbed.ViewModels
{
    public class Other1ContentPageViewModel : BindableBase, IConfirmNavigationAsync
    {
        #region DI
        INavigationService _navigationService;
        IPageDialogService _dialogService;
        #endregion

        #region ICommand
        public DelegateCommand 立即加入Command { get; set; }
        public DelegateCommand 首頁Command { get; set; }
        #endregion

        #region property
        public bool 需要檢查是否可以離開頁面 { get; set; } = true;
        #endregion

        public Other1ContentPageViewModel(INavigationService navigationService, IPageDialogService dialogService)
        {
            _navigationService = navigationService;
            _dialogService = dialogService;

            立即加入Command = new DelegateCommand(立即加入);
            首頁Command = new DelegateCommand(首頁);
        }

        private async void 首頁()
        {
            await _navigationService.NavigateAsync(new Uri("http://vulcan.net/HomePage/JoinUsPage", UriKind.Absolute));
        }

        private async void 立即加入()
        {
            需要檢查是否可以離開頁面 = false;
            await _navigationService.NavigateAsync(new Uri("Other2ContentPage", UriKind.Relative));
        }

        public void OnNavigatedFrom(NavigationParameters parameters)
        {
        }

        public void OnNavigatedTo(NavigationParameters parameters)
        {
        }

        public async Task<bool> CanNavigateAsync(NavigationParameters parameters)
        {
            if (需要檢查是否可以離開頁面 == true)
            {
                var fooReslut = await _dialogService.DisplayAlertAsync("警告", "您確定要回到首頁嗎?", "是", "否");
                if (fooReslut == true)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                需要檢查是否可以離開頁面 = true;
                return true;
            }
        }
    }
}
