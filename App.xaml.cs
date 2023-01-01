using KabulTalk.ViewModels;
using KabulTalk.Views;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Windows;

namespace KabulTalk
{
  /// <summary>
  /// Interaction logic for App.xaml
  /// </summary>
  public partial class App : Application
  {
    public App()
    {
      Services = ConfigureServices();
      Startup += App_Startup;
    }

    private void App_Startup(object sender, StartupEventArgs e)
    {
      var mainView = App.Current.Services.GetService<MainView>()!;
      mainView.Show();
    }

    public new static App Current => (App)Application.Current;

    public IServiceProvider Services { get; }

    private static IServiceProvider ConfigureServices()
    {
      var services = new ServiceCollection();

      // ViewModels
      services.AddTransient<MainViewModel>();
      services.AddTransient<LoginControlViewModel>();
      services.AddTransient<SignupControlViewModel>();
      services.AddTransient<ChangePwdControlViewModel>();

      // Services
      //services.AddSingleton<ITestService, TestService>();

      // Views
      services.AddSingleton<MainView>();

      return services.BuildServiceProvider();
    }
  }
}
