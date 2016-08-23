using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace HomeDrawer.ViewModels
{
    public class MainPageViewModel : BindableBase, INavigationAware
    {
        #region DI
        INavigationService _navigationService;
        #endregion

        #region ICommand
        public DelegateCommand 加班申請Command { get; set; }
        public DelegateCommand 請假系統Command { get; set; }
        public DelegateCommand 工作報告填寫Command { get; set; }
        public DelegateCommand 工作報告查詢Command { get; set; }
        public DelegateCommand 關於Command { get; set; }
        #endregion

        private string _title;
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        public MainPageViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;

            加班申請Command = new DelegateCommand(加班申請);
            請假系統Command = new DelegateCommand(請假系統);
            工作報告查詢Command = new DelegateCommand(工作報告查詢);
            工作報告填寫Command = new DelegateCommand(工作報告填寫);
            關於Command = new DelegateCommand(關於);
        }

        private void 請假系統()
        {
            _navigationService.NavigateAsync("/MainPage/NaviPage/Leave1Page");
        }

        private void 工作報告填寫()
        {
            _navigationService.NavigateAsync("/MainPage/NaviPage/LogbookAppPage");
        }

        private void 工作報告查詢()
        {
            _navigationService.NavigateAsync("/MainPage/NaviPage/LogbookQuery");
        }

        private void 加班申請()
        {
            _navigationService.NavigateAsync("/MainPage/NaviPage/OvertimePage");
        }

        private void 關於()
        {
            _navigationService.NavigateAsync("/MainPage/NaviPage/AboutPage");
        }

        public void OnNavigatedFrom(NavigationParameters parameters)
        {

        }

        public void OnNavigatedTo(NavigationParameters parameters)
        {
            if (parameters.ContainsKey("title"))
                Title = (string)parameters["title"] + " and Prism";
        }
    }
}
