using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using Prism.Services;
using System;
using System.Collections.Generic;
using System.Linq;

namespace HomeDrawer.ViewModels
{
    public class LogbookAppViewModel : BindableBase
    {
        #region DI
        INavigationService _navigationService;
        IPageDialogService _dialogService;
        #endregion

        #region ICommand
        public DelegateCommand 工作報告申請送出Command { get; set; }
        #endregion

        #region ViewModel
        #region 工作日期
        private DateTime _工作日期 = DateTime.Now;

        public DateTime 工作日期
        {
            get { return _工作日期; }
            set { SetProperty(ref _工作日期, value); }
        }

        #endregion

        #region 工作項目
        private string _工作項目 = "4";

        public string 工作項目
        {
            get { return _工作項目; }
            set { SetProperty(ref _工作項目, value); }
        }

        #endregion

        #region 工作時數
        private string _工作時數 = "4";

        public string 工作時數
        {
            get { return _工作時數; }
            set { SetProperty(ref _工作時數, value); }
        }

        #endregion
        #endregion

        public LogbookAppViewModel(INavigationService navigationService, IPageDialogService dialogService)
        {
            _navigationService = navigationService;
            _dialogService = dialogService;


            工作報告申請送出Command = new DelegateCommand(工作報告申請送出);
        }

        private void 工作報告申請送出()
        {
        }
    }
}
