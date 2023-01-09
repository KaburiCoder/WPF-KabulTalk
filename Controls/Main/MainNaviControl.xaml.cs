using KabulTalk.Services;
using KabulTalk.ViewModels;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;

namespace KabulTalk.Controls
{
  /// <summary>
  /// MainNaviControl.xaml에 대한 상호 작용 논리
  /// </summary>
  public partial class MainNaviControl : UserControl
  {
    public MainNaviControl()
    {
      InitializeComponent();
      if (DesignerProperties.GetIsInDesignMode(this)) return;

      DataContext = App.Current.Services.GetService(typeof(MainNaviControlViewModel));
    }

    public NaviType HideButton
    {
      get { return (NaviType)GetValue(HideButtonProperty); }
      set { SetValue(HideButtonProperty, value); }
    }

    // Using a DependencyProperty as the backing store for HideButton.  This enables animation, styling, binding, etc...
    public static readonly DependencyProperty HideButtonProperty =
        DependencyProperty.Register("HideButton", typeof(NaviType), typeof(MainNaviControl), new UIPropertyMetadata(NaviType.None, HideButtonChanged));

    private static void HideButtonChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
    {
      MainNaviControl? control = (MainNaviControl)d;
      if (control == null) return;

      // 초기화
      control.accountColumn.Width = new GridLength(1, GridUnitType.Star);
      control.accPwdSepColumn.Width = new GridLength(0, GridUnitType.Auto);
      control.passwordColumn.Width = new GridLength(1, GridUnitType.Star);
      control.pwdLoginSepColumn.Width = new GridLength(0, GridUnitType.Auto);
      control.LoginColumn.Width = new GridLength(1, GridUnitType.Star);
      control.loginSignupSepColumn.Width = new GridLength(0, GridUnitType.Auto);
      control.signupColumn.Width = new GridLength(1, GridUnitType.Star);

      // 설정 세팅
      switch (control.HideButton)
      {
        case NaviType.FindAccount:
          control.accountColumn.Width = new GridLength(0);
          control.accPwdSepColumn.Width = new GridLength(0);
          break;
        case NaviType.ChangePwd:
          control.passwordColumn.Width = new GridLength(0);
          control.pwdLoginSepColumn.Width = new GridLength(0);
          break;
        case NaviType.Login:
          control.LoginColumn.Width = new GridLength(0);
          control.loginSignupSepColumn.Width = new GridLength(0);
          break;
        case NaviType.Signup:
          control.loginSignupSepColumn.Width = new GridLength(0);
          control.signupColumn.Width = new GridLength(0);
          break;
      }
    }
  }
}
