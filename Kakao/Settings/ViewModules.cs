﻿using Jamesnet.Wpf.Controls;
using Kakao.Core.Names;
using KaKao.Friend.UI.Views;
using KaKao.Login.UI.Views;
using Prism.Ioc;
using Prism.Modularity;

namespace Kakao.Settings
{
    internal class ViewModules : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {

        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterSingleton<IViewable, LoginContent>(ContentNameManager.Login);
            containerRegistry.RegisterSingleton<IViewable, FriendContent>(ContentNameManager.Friends);
        }
    }
}
