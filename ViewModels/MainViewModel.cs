using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KabulTalk.ViewModels
{
  [ObservableObject]
  public partial class MainViewModel
  {
    [ObservableProperty]
    private INotifyPropertyChanged _currentViewModel;

    [RelayCommand]
    public void ToLogin()
    {
      CurrentViewModel = (INotifyPropertyChanged)App.Current.Services.GetService(typeof(LoginControlViewModel))!;
    }

    [RelayCommand]
    public void ToChangePwd()
    {
      CurrentViewModel = (INotifyPropertyChanged)App.Current.Services.GetService(typeof(ChangePwdControlViewModel))!;
    }

    [RelayCommand]
    public void ToSignup()
    {
      CurrentViewModel = (INotifyPropertyChanged)App.Current.Services.GetService(typeof(SignupControlViewModel))!;
    }

    public MainViewModel()
    {
      _currentViewModel = (INotifyPropertyChanged)App.Current.Services.GetService(typeof(LoginControlViewModel))!;
    }

   
  }
}
