   M S B A M L   `   `   `  ????D  @KabulTalk, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:KabulTalk.ControlsKabulTalk.Controls  5      O Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem 5      A =WpfLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA-clr-namespace:WpfLib.Controls;assembly=WpfLibWpfLib.Controls 5	      %    KabulTalk.Controls.LoginControl   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      2local clr-namespace:KabulTalk.Controls     5      [ WFontAwesome6.Svg.Net, Version=2.5.1.0, Culture=neutral, PublicKeyToken=150287d219411f042fa6(http://schemas.fontawesome.com/icons/svg  5      3system&clr-namespace:System;assembly=mscorlib  5      <controls-clr-namespace:WpfLib.Controls;assembly=WpfLib  5	         ColorPrimary#??[  5      .??5      ? $??20 40 20 20q?6	     ? RowDefinitions  5      ?? 5      $
??1.3* ?6   ?? 5      $??3* ?6   ?? 5      $??30 ?6   .+?5      !  FontAwesome6.Svg.SvgAwesome     Icon$ Brands_Rocketchat=?6   $??20q?5        	ColorGray   PrimaryColor# [ 5      ?? 5      $??1??6   $??30 10q?5      .+?5      %  WpfLib.Controls.ComboBoxControl  -   5          Name$ email??5   !   
???????$??35??5   !      WaterMarkText$# 이메일을 입력하세요.??5   !      BorderThickness$ 1 1 1 0q?5   !      
IsEditable$
 True??5    !      ItemsSource 5!   !   ?? *Emails+(  "WpfLib.Controls.PasswordBoxControl  5"      
???????   WaterMarkText$&  비밀번호를 입력하세요.??5$   	     MainElementHeight#??[ 5%   	   ?? 5&      $??	로그인??6   #??[ 5(      $??0 10 0 0q?5)      ??5'      ?? *LoginCommand+5)      ? 5+      #??[ 6   	 ? ColumnDefinitions	 5,   
   ?? 5-      ?? 5.      $
??auto ?6   ?? 5/      .+?52   
   ?? $??0??6   ?? 53   
   $??1??6   $??Center=?54      $??또는??55      $	??8 0q?56      ?? 57   
   $??2??6   58   	   ?? 59      $??QR코드 로그인??6   #??[ 5:      ?? 5<      
 ?? Orientation$
 
Horizontal=?6   #??[ 5=      .+?5>   
   ?? $??자동로그인??6   $??Center=?5?      ?? 5@   
   $??2q?6   ???	#FFEDD607???	#FFA99900$??17??5C      $??17??5D      $	??5 0q?5E       ? 	Resources 5F       ?? 
TargetType ?? Property ?? Value??%_   '??       ?? 5G      " ??6   .?5H      ??  ?@??CornerRadius$ 30??6/   5I      5J      .??5K        $ 
Solid_Info=?6    ?	#FFA999006-   5L      5M   	   5N      (   "KabulTalk.Controls.MainNaviControl  5Q      $??2??6      
HideButton$ Login=?6)   5R      5S      