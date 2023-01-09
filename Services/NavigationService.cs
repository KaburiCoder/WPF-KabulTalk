using KabulTalk.Stores;
using KabulTalk.ViewModels;
using System;
using System.ComponentModel;
using WpfLib.Controls;

namespace KabulTalk.Services
{
  public class NavigationService : INavigationService
  {
    private readonly MainNavigationStore _mainNavigationStore;

    private void MainNavigate(SlideType slideType, Type type)
    {
      _mainNavigationStore.SlideType = slideType;
      _mainNavigationStore.CurrentViewModel = (INotifyPropertyChanged)App.Current.Services.GetService(type)!;
    }

    public NavigationService(MainNavigationStore mainNavigationStore)
    {
      _mainNavigationStore = mainNavigationStore;
    }

    public void Navigate(NaviType naviType)
    {
      switch (naviType)
      {
        case NaviType.Signup:
          MainNavigate(SlideType.LeftToRight, typeof(SignupControlViewModel));
          break;
        case NaviType.Login:
          MainNavigate(SlideType.TopToBottom, typeof(LoginControlViewModel));
          break;
        case NaviType.FindAccount:
          MainNavigate(SlideType.BottomToTop, typeof(FindAccountControlViewModel));
          break;
        case NaviType.ChangePwd:
          MainNavigate(SlideType.RightToLeft, typeof(ChangePwdControlViewModel));
          break;
      }
    }
  }
}
