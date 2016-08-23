using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using Prism.Services;
using System;
using System.Collections.Generic;
using System.Linq;

namespace HomeDrawer.ViewModels
{
    public class Leave2PageViewModel : BindableBase, INavigationAware
    {
        #region DI
        INavigationService _navigationService;
        IPageDialogService _dialogService;
        #endregion

        #region ICommand
        public DelegateCommand 請假送出Command { get; set; }
        #endregion

        #region ViewModel
        #region 開始日期
        private DateTime _開始日期 = DateTime.Now.AddDays(1);

        public DateTime 開始日期
        {
            get { return _開始日期; }
            set { SetProperty(ref _開始日期, value); }
        }

        #endregion
   
        #region 結束日期
        private DateTime _結束日期= DateTime.Now.AddDays(1);

        public DateTime 結束日期
        {
            get { return _結束日期; }
            set { SetProperty(ref _結束日期, value); }
        }

        #endregion
        #endregion

        public Leave2PageViewModel(INavigationService navigationService, IPageDialogService dialogService)
        {
            _navigationService = navigationService;
            _dialogService = dialogService;

            請假送出Command = new DelegateCommand(請假送出);
        }

        private async void 請假送出()
        {
            var d1 = 開始日期.ToString("yyyy-MM-dd");
            var d2 = 結束日期.ToString("yyyy-MM-dd");
            var foo = await _dialogService.DisplayAlertAsync("警告", $"您確定要送出這筆請假申請({d1} ~ {d2})嗎?", "是", "否");
            if (foo == true)
            {
                await _navigationService.GoBackAsync();
            }
        }

        public void OnNavigatedFrom(NavigationParameters parameters)
        {
        }

        public void OnNavigatedTo(NavigationParameters parameters)
        {
        }
    }
}
