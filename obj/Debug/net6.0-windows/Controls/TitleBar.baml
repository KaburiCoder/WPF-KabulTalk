   M S B A M L   `   `   `  ????D  @KabulTalk, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:KabulTalk.ControlsKabulTalk.Controls  5      ;"clr-namespace:KabulTalk.ConvertersKabulTalk.Converters  6r   !    KabulTalk.Controls.TitleBar   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      2local clr-namespace:KabulTalk.Controls     5      [ WFontAwesome6.Svg.Net, Version=2.5.1.0, Culture=neutral, PublicKeyToken=150287d219411f042fa6(http://schemas.fontawesome.com/icons/svg  6=   3
converters"clr-namespace:KabulTalk.Converters  6r   -   5        $
??root??5
        ? 	Resources  5      5   /KabulTalk.Converters.WindowStateMarginConverter   WindowStateMarginConverter3  -KabulTalk.Converters.WindowStateIconConverter  WindowStateIconConverter ?? 
TargetType ?? Property ?? Value'  !System.Windows.Shell.WindowChrome!  FontAwesome6.Svg.SvgAwesome  	ColorGray??%?  &	        &	      '?? &     '  D    7    5      6,     5      6*   ?? 5      " ??6   .?5      ??  ? ??$ 25??6    ?? 5       ? ??$ 20??6!   ?? 5       ? ??
 ???? 6%   ?? 5       ? ??
 ???? 6&   ?? 5       ? ??$ Right=?6)   ?? 5        ?@ IsHitTestVisibleInChrome$
 True??6@   5      ?? 5      "  6   .?5      ??  ?@ PrimaryColor8   5      5      5      .??5      ]? -   5         ]?Name$ pnlTitle??5        ColorPrimary#??[ 5      $??False??5      .+?5       ?? -   5         ??Name$ btnExit??5       ??5!      ?? *
WinState+ ?? ElementName$
 root?? ?? 	Converter# [   ?? ConverterParameter$
 Exit??.??5%        	   Icon$	 Solid_Xmark=?6   5&      ?? 5'      -   5        $ btnMaximize??5'      ??5(      ?? *
WinState+$
 root??# [  .??5+        $??13??5,      $??13??5-      	 5+      ?? *
WinState+$
 root??# [ 5-      5.      ?? 5/      -   5        $ btnMinimize??5/      ??50      ?? *
WinState+$
 root??# [  .??53        $	 Solid_Minus=?6   54      55      56      