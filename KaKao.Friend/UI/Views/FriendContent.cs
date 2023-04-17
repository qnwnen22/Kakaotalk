using Jamesnet.Wpf.Controls;
using System.Windows;

namespace KaKao.Friend.UI.Views
{
    public class FriendContent : JamesContent
    {
        static FriendContent()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(FriendContent), new FrameworkPropertyMetadata(typeof(FriendContent)));
        }

        public FriendContent()
        {

        }
    }
}
