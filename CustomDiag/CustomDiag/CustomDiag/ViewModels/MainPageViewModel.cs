using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using Prism.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomDiag.ViewModels
{
    public class MainPageViewModel : BindableBase, INavigationAware
    {
        #region DI
        INavigationService _navigationService;
        IPageDialogService _dialogService;
        #endregion

        #region ICommand
        public DelegateCommand 客製化對話窗Command { get; set; }
        public DelegateCommand 處理中遮罩Command { get; set; }
        public DelegateCommand 點選遮罩Command { get; set; }
        public DelegateCommand 客製化對話窗確定Command { get; set; }
        public DelegateCommand 客製化對話窗取消Command { get; set; }
        #endregion

        #region ViewModel
        #region 顯示客製化對話窗
        private bool _顯示客製化對話窗 = false;

        public bool 顯示客製化對話窗
        {
            get { return _顯示客製化對話窗; }
            set { SetProperty(ref _顯示客製化對話窗, value); }
        }
        #endregion

        #region 對話窗主題
        private string _對話窗主題 = "";

        public string 對話窗主題
        {
            get { return _對話窗主題; }
            set { SetProperty(ref _對話窗主題, value); }
        }
        #endregion

        #region 對話窗內容
        private string _對話窗內容 = "";

        public string 對話窗內容
        {
            get { return _對話窗內容; }
            set { SetProperty(ref _對話窗內容, value); }
        }
        #endregion

        #region 使用者輸入內容
        private string _使用者輸入內容 = "";

        public string 使用者輸入內容
        {
            get { return _使用者輸入內容; }
            set { SetProperty(ref _使用者輸入內容, value); }
        }
        #endregion
        public ProcessingUserControlViewModel 處理中ViewModel { get; set; } = new ProcessingUserControlViewModel();
        public CustDialogUserControlViewModel 客製化使用者對話窗ViewModel { get; set; } = new CustDialogUserControlViewModel();
        #endregion

        public MainPageViewModel(INavigationService navigationService, IPageDialogService dialogService)
        {
            _navigationService = navigationService;
            _dialogService = dialogService;

            客製化對話窗Command = new DelegateCommand(客製化對話窗);
            處理中遮罩Command = new DelegateCommand(處理中遮罩);
            點選遮罩Command = new DelegateCommand(點選遮罩);
            客製化對話窗確定Command = new DelegateCommand(客製化對話窗確定);
            客製化對話窗取消Command = new DelegateCommand(客製化對話窗取消);
        }

        private void 客製化對話窗取消()
        {
            使用者輸入內容 = "";
            客製化使用者對話窗ViewModel.關閉客製化使用者對話窗控制項();
        }

        private async void 客製化對話窗確定()
        {
            if (string.IsNullOrEmpty(客製化使用者對話窗ViewModel.對話窗使用者帳號) || 客製化使用者對話窗ViewModel.對話窗使用者帳號.Length < 6)
            {
                await _dialogService.DisplayAlertAsync("警告", "帳號不可為空值或者小於6個字元", "確定");
            }
            else if (string.IsNullOrEmpty(客製化使用者對話窗ViewModel.對話窗使使用者密碼) || 客製化使用者對話窗ViewModel.對話窗使使用者密碼.Length < 8)
            {
                await _dialogService.DisplayAlertAsync("警告", "密碼不可為空值或者小於8個字元", "確定");
            }
            else
            {
                使用者輸入內容 = $"帳號:{客製化使用者對話窗ViewModel.對話窗使用者帳號} / 密碼: {客製化使用者對話窗ViewModel.對話窗使使用者密碼}";
                客製化使用者對話窗ViewModel.關閉客製化使用者對話窗控制項();
            }
        }

        private void 點選遮罩()
        {
            處理中ViewModel.關閉忙碌中使用者控制項();
        }

        private async void 處理中遮罩()
        {
            處理中ViewModel.顯示忙碌中使用者控制項("正在更新資料", "正在更新資料，需要2秒鐘");
            await Task.Delay(2000);
            處理中ViewModel.關閉忙碌中使用者控制項();
        }

        private void 客製化對話窗()
        {
            客製化使用者對話窗ViewModel.顯示客製化使用者對話窗控制項("請進行身分驗證", "請輸入您的帳號與密碼，並且點選確定按鈕");
        }

        public void OnNavigatedFrom(NavigationParameters parameters)
        {

        }

        public void OnNavigatedTo(NavigationParameters parameters)
        {
        }
    }
}
