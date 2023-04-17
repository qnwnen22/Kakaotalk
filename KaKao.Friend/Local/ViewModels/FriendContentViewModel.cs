﻿using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Jamesnet.Wpf.Controls;
using Prism.Ioc;
using Prism.Regions;

namespace KaKao.Friend.Local.ViewModels
{
    public partial class FriendContentViewModel : ObservableObject
    {
        private readonly IRegionManager _regionManager;
        private readonly IContainerProvider _containerProvider;

        public FriendContentViewModel(IRegionManager regionManager,IContainerProvider containerProvider)
        {
            _regionManager = regionManager;
            _containerProvider = containerProvider;
        }

        [RelayCommand]
        private void Logout()
        {
            IRegion mainRegion = _regionManager.Regions["MainRegion"];
            IViewable loginContent = _containerProvider.Resolve<IViewable>("LoginContent");

            if (!mainRegion.Views.Contains(loginContent))
            {
                mainRegion.Add(loginContent);
            }
            mainRegion.Activate(loginContent);
        }
    }
}
