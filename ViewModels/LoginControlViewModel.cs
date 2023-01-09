using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;

namespace KabulTalk.ViewModels
{
  [ObservableObject]
  public partial class LoginControlViewModel
  {
    [ObservableProperty]
    private ObservableCollection<string>? _emails;

    public LoginControlViewModel()
    {
      Emails = new ObservableCollection<string>()
      {
        "test1@test.com",
        "test2@test.com"
      };
    }
  }
}
