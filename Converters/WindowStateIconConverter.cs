using FontAwesome6;
using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace KabulTalk.Converters
{
  internal class WindowStateIconConverter : IValueConverter
  {
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
      WindowState state = (WindowState)value;
      if (state == WindowState.Normal)
      {
        return EFontAwesomeIcon.Regular_Square;
      }else
      {
        return EFontAwesomeIcon.Solid_DownLeftAndUpRightToCenter;
      }
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
      throw new NotImplementedException();
    }
  }
}
