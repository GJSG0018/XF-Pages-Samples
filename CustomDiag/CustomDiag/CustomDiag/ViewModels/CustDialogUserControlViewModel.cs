using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CustomDiag.ViewModels
{
    public class CustDialogUserControlViewModel : BindableBase
    {
        #region ViewModel
        #region 顯示客製化使用者對話窗
        private bool _顯示客製化使用者對話窗 = false;

        public bool 顯示客製化使用者對話窗
        {
            get { return _顯示客製化使用者對話窗; }
            set { SetProperty(ref _顯示客製化使用者對話窗, value); }
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

        #region 對話窗訊息
        private string _對話窗訊息 = "";

        public string 對話窗訊息
        {
            get { return _對話窗訊息; }
            set { SetProperty(ref _對話窗訊息, value); }
        }
        #endregion

        #region 對話窗使用者帳號
        private string _對話窗使用者帳號 = "";

        public string 對話窗使用者帳號
        {
            get { return _對話窗使用者帳號; }
            set { SetProperty(ref _對話窗使用者帳號, value); }
        }
        #endregion

        #region 對話窗使使用者密碼
        private string _對話窗使使用者密碼 = "";

        public string 對話窗使使用者密碼
        {
            get { return _對話窗使使用者密碼; }
            set { SetProperty(ref _對話窗使使用者密碼, value); }
        }
        #endregion

        #endregion

        public CustDialogUserControlViewModel()
        {

        }

        public void 顯示客製化使用者對話窗控制項(string p對話窗主題, string p對話窗訊息)
        {
            對話窗主題 = p對話窗主題;
            對話窗訊息 = p對話窗訊息;
            對話窗使用者帳號 = "";
            對話窗使使用者密碼 = "";
            顯示客製化使用者對話窗 = true;
        }

        public void 關閉客製化使用者對話窗控制項()
        {
            顯示客製化使用者對話窗 = false;
        }

    }
}
