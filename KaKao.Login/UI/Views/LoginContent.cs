using Jamesnet.Wpf.Controls;
using System.Windows;

namespace KaKao.Login.UI.Views
{
    public class LoginContent : JamesContent
    {
        static LoginContent()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(LoginContent), new FrameworkPropertyMetadata(typeof(LoginContent)));
        }

        public LoginContent()
        {

        }
    }
}
