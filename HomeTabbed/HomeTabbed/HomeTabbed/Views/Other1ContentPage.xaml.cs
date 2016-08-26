using HomeTabbed.ViewModels;
using Xamarin.Forms;

namespace HomeTabbed.Views
{
    public partial class Other1ContentPage : ContentPage
    {
        public Other1ContentPage()
        {
            InitializeComponent();
        }

        protected override bool OnBackButtonPressed()
        {
            #region 可以註解這段程式碼，簡單停用硬體回上一頁按鍵功能
            // 將要在 UI 執行緒上，執行這個委派方法
            // 因為要回傳 bool，無法修改其函式簽名碼 Signatures，且執行非同步呼叫
            Device.BeginInvokeOnMainThread(async () => {
                var fooViewModel = this.BindingContext as Other1ContentPageViewModel;
                fooViewModel.需要檢查是否可以離開頁面 = true;
                var fooResult = await fooViewModel.CanNavigateAsync(null);
                if (fooResult == true)
                {
                    fooViewModel.需要檢查是否可以離開頁面 = false;
                    fooViewModel.首頁();
                }
            });
            #endregion
            // 停止硬體回上一頁按鍵運作
            return true;
        }
    }
}
