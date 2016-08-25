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
            // 停止硬體回上一頁按鍵運作
            return true;
        }
    }
}
