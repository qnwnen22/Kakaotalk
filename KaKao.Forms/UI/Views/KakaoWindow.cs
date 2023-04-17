using System.Windows;
using System.Windows.Controls;

namespace KaKao.Forms.UI.Views
{
    public class KakaoWindow : Control
    {
        static KakaoWindow()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(KakaoWindow), new FrameworkPropertyMetadata(typeof(KakaoWindow)));
        }
    }
}
