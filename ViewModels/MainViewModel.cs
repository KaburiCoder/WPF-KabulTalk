using CommunityToolkit.Mvvm.ComponentModel;
using KabulTalk.Stores;
using System.ComponentModel;
using WpfLib.Controls;

namespace KabulTalk.ViewModels
{
  [ObservableObject]
  public partial class MainViewModel
  {
    [ObservableProperty]
    private INotifyPropertyChanged _currentViewModel = default!;

    [ObservableProperty]
    private SlideType _slideType = default!;

    private void CurrentViewModelChanged(INotifyPropertyChanged viewModel)
    {
      CurrentViewModel = viewModel;
    }

    public MainViewModel(MainNavigationStore mainNavigationStore)
    {
      mainNavigationStore.CurrentViewModelChanged += CurrentViewModelChanged;
      mainNavigationStore.SlideTypeChanged += SlideTypeChanged;
      mainNavigationStore.CurrentViewModel = (INotifyPropertyChanged)App.Current.Services.GetService(typeof(LoginControlViewModel))!;
    }

    private void SlideTypeChanged(SlideType slideType)
    {
      SlideType = slideType;
    }
  }
}
