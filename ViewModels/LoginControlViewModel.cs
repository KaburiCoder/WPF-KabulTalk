using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
