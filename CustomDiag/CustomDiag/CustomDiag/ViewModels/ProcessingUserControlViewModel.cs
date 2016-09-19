using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CustomDiag.ViewModels
{
    public class ProcessingUserControlViewModel : BindableBase
    {
        #region ViewModel
        #region 顯示處理中遮罩
        private bool _顯示處理中遮罩 = false;

        public bool 顯示處理中遮罩
        {
            get { return _顯示處理中遮罩; }
            set { SetProperty(ref _顯示處理中遮罩, value); }
        }
        #endregion

        #region 忙碌中控制項使用中
        private bool _忙碌中控制項使用中 = true;

        public bool 忙碌中控制項使用中
        {
            get { return _忙碌中控制項使用中; }
            set { SetProperty(ref _忙碌中控制項使用中, value); }
        }
        #endregion

        #region 處理中訊息
        private string _處理中訊息 = "";

        public string 處理中訊息
        {
            get { return _處理中訊息; }
            set { SetProperty(ref _處理中訊息, value); }
        }
        #endregion

        #region 處理中狀態文字
        private string _處理中狀態文字 = "";

        public string 處理中狀態文字
        {
            get { return _處理中狀態文字; }
            set { SetProperty(ref _處理中狀態文字, value); }
        }
        #endregion

        #endregion

        public ProcessingUserControlViewModel()
        {

        }

        public void 顯示忙碌中使用者控制項(string p處理中訊息, string p處理中狀態文字)
        {
            處理中訊息 = p處理中訊息;
            處理中狀態文字 = p處理中狀態文字;
            顯示處理中遮罩 = true;
            忙碌中控制項使用中 = true;
        }

        public void 關閉忙碌中使用者控制項()
        {
            處理中訊息 = "";
            處理中狀態文字 = "";
            顯示處理中遮罩 = false;
            忙碌中控制項使用中 = false;
        }
    }
}
