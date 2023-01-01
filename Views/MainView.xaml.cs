using KabulTalk.ViewModels;
using System.Windows;

namespace KabulTalk.Views
{
  /// <summary>
  /// MainView.xaml에 대한 상호 작용 논리
  /// </summary>
  public partial class MainView : Window
  {
    public MainView()
    {
      InitializeComponent();
      DataContext = App.Current.Services.GetService(typeof(MainViewModel));
    }
  } 
}
