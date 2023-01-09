using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using KabulTalk.Services;

namespace KabulTalk.ViewModels
{
  [ObservableObject]
  public partial class MainNaviControlViewModel
  {
    private readonly INavigationService _navigationService;

    [RelayCommand]
    public void NavigateChangePassword()
    {
      _navigationService.Navigate(NaviType.ChangePwd);
    }

    [RelayCommand]
    public void NavigateSignup()
    {
      _navigationService.Navigate(NaviType.Signup);
    }

    [RelayCommand]
    public void NavigateLogin()
    {
      _navigationService.Navigate(NaviType.Login);
    }

    [RelayCommand]
    public void NavigateFindAccount()
    {
      _navigationService.Navigate(NaviType.FindAccount);
    }

    public MainNaviControlViewModel(INavigationService navigationService)
    {
      _navigationService = navigationService;
    }
  }
}
