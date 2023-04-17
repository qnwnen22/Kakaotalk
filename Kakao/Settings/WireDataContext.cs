using Jamesnet.Wpf.Global.Location;
using KaKao.Forms.Local.ViewModels;
using KaKao.Forms.UI.Views;
using KaKao.Friend.Local.ViewModels;
using KaKao.Friend.UI.Views;
using KaKao.Login.Local.ViewModels;
using KaKao.Login.UI.Views;

namespace Kakao.Settings
{
    internal class WireDataContext : ViewModelLocationScenario // View와 ViewModel을 연결하는 클래스
    {
        protected override void Match(ViewModelLocatorCollection items)
        {
            items.Register<KakaoWindow, KakaoViewModel>();
            items.Register<LoginContent, LoginContentViewModel>();
            items.Register<FriendContent, FriendContentViewModel>();
        }
    }
}
