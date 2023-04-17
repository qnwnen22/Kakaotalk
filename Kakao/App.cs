using Jamesnet.Wpf.Controls;
using KaKao.Forms.UI.Views;
using System.Windows;

namespace Kakao
{
    internal class App : JamesApplication
    {
        protected override Window CreateShell()
        {
            return new KakaoWindow();
        }
    }
}
