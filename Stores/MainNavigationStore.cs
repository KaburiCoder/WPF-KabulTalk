using System;
using System.ComponentModel;
using WpfLib.Controls;

namespace KabulTalk.Stores
{
  public class MainNavigationStore
  {
    public INotifyPropertyChanged CurrentViewModel
    {
      set => CurrentViewModelChanged?.Invoke(value);
    }

    public SlideType SlideType
    {
      set => SlideTypeChanged?.Invoke(value);
    }

    public event Action<INotifyPropertyChanged>? CurrentViewModelChanged;
    public event Action<SlideType>? SlideTypeChanged;
  }
}
