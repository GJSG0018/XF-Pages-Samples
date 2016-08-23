using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using Prism.Services;
using System;
using System.Collections.Generic;
using System.Linq;

namespace HomeDrawer.ViewModels
{
    public class OvertimePageViewModel : BindableBase
    {
        #region DI
        INavigationService _navigationService;
        IPageDialogService _dialogService;
        #endregion

        #region ICommand
        public DelegateCommand 加班申請送出Command { get; set; }
        #endregion

        #region ViewModel
        #region 加班日期
        private DateTime _加班日期 = DateTime.Now;

        public DateTime 加班日期
        {
            get { return _加班日期; }
            set { SetProperty(ref _加班日期, value); }
        }

        #endregion

        #region 加班時間
        private TimeSpan _加班時間 = DateTime.Now.TimeOfDay;

        public TimeSpan 加班時間
        {
            get { return _加班時間; }
            set { SetProperty(ref _加班時間, value); }
        }

        #endregion

        #region 加班時數
        private string _加班時數 = "4";
        
        public string 加班時數
        {
            get { return _加班時數; }
            set { SetProperty(ref _加班時數, value); }
        }

        #endregion
        #endregion

        public OvertimePageViewModel(INavigationService navigationService, IPageDialogService dialogService)
        {
            _navigationService = navigationService;
            _dialogService = dialogService;


            加班申請送出Command = new DelegateCommand(加班申請送出);
        }

        private void 加班申請送出()
        {
        }
    }
}
