using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Jamesnet.Wpf.Controls;
using Prism.Ioc;
using Prism.Regions;

namespace KaKao.Login.Local.ViewModels
{
    public partial class LoginContentViewModel : ObservableObject
    {
        private readonly IRegionManager _regionManager;
        private readonly IContainerProvider _containerProvider;

        public LoginContentViewModel(IRegionManager regionManager, IContainerProvider containerProvider)
        {
            _regionManager = regionManager;
            _containerProvider = containerProvider;
        }

        [RelayCommand]
        private void Login()
        {
            IRegion mainRegion = _regionManager.Regions["MainRegion"];
            IViewable friendContent = _containerProvider.Resolve<IViewable>("FriendContent");

            if (!mainRegion.Views.Contains(friendContent))
            {
                mainRegion.Add(friendContent);
            }
            mainRegion.Activate(friendContent);
        }
    }
}
