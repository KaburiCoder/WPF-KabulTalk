   M S B A M L   `   `   `  ????D  @KabulTalk, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:KabulTalk.ControlsKabulTalk.Controls  5      A =WpfLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA-clr-namespace:WpfLib.Controls;assembly=WpfLibWpfLib.Controls 6r   &     KabulTalk.Controls.SignupControl   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      2local clr-namespace:KabulTalk.Controls     5      [ WFontAwesome6.Svg.Net, Version=2.5.1.0, Culture=neutral, PublicKeyToken=150287d219411f042fa6(http://schemas.fontawesome.com/icons/svg  6=   <controls-clr-namespace:WpfLib.Controls;assembly=WpfLib  6r      ColorPrimary#??[  5
        ? 	Resources  5        ValidationTextStyle ?? 
TargetType ?? Property ?? Value ?? Triggers ?? Binding ?? Value  EmailValidationTextStyle??%?  &	       &	 ?     ?? 5      " ??6(   .?5      ??  ? y?$ Visible=?6%    5      ?? 5   
    6   ?? *ValidationText+  69   .a?5      ??  ? y?$ 	Collapsed=?6)   5      5      ?? 5      " ??6-   .?5      ??  ? y?$ Visible=?6%    5      ?? 5   
    6   ?? *EmailValidationText+  6>   .a?5      ??  ? y?$ 	Collapsed=?6)   5      5      5      .??5      ? $??20 40 20 20q?6	    ? RowDefinitions 5       ?? 5!      $
??1.3* ?6   ?? 5"      $??3* ?6   ?? 5#      $??30 ?6   .+?5'      !  FontAwesome6.Svg.SvgAwesome     Icon$ Brands_Rocketchat=?6   $??20q?5(        	ColorGray	   PrimaryColor#	 [ 5)      ?? 5+      $??1??6   $
??30 5q?5,      .+?5-      $  WpfLib.Controls.TextBoxControl  
   WaterMarkText$
 	이메일??5/   	   
???????  MainElementHeight#??[ 51   	   $??0 0 0 0q?52   	      Text 5.   	   ?? *Email+   
Validating 53   	   ?? *ValidatingDict[Email]+?? 55      #??[ 56      ??55      ?? *EmailValidationText+??57      ?? *EmailValidationTextColor+  58      $
 	닉네임??5:   	   
???????#??[ 5<   	   $??0 5 0 0q?5=   	    59   	   ?? *
Nickname+ ?? UpdateSourceTrigger$ PropertyChanged=? 5>   	   ?? *ValidatingDict[Nickname]+  5A      $
 휴대전화번호??5C   	   
???????#??[ 5E   	   $??0 5 0 0q?5F   	    5B   	   ?? *	CellPhone+ 5G   	   ?? *ValidatingDict[CellPhone]+(  "WpfLib.Controls.PasswordBoxControl  5J      
???????   WaterMarkText$ 비밀번호??5M   	   #??[ 5N   	   $??0 5 0 0q?5O   	      Password 5K   	   ?? *
Password+   
Validating 5P   	   ?? *ValidatingDict[Password]+  5S      
???????$ 비밀번호 재입력??5V   	   #??[ 5W   	   $??0 5 0 0q?5X   	    5T   	   ?? *PasswordConfirm+ 5Y   	   ?? *!ValidatingDict[PasswordConfirm]+?? 5\      #??[ 5]      
???  ??$??0 5 0 0q?5_      ??5\      ?? *ValidationText+5_      ?? 5a      $??회원가입??6   #??[ 5c      $??	0 5 0 100q?5d      ??5b      ?? *SignupCommand+5d      5e      (   "KabulTalk.Controls.MainNaviControl  5h      $??2??6      
HideButton$ Signup=?6)   5i      5j      