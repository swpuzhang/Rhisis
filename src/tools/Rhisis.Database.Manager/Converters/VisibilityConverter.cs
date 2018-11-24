﻿using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace Rhisis.Database.Manager.Converters
{
    public class VisibilityConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is bool visible)
                return visible ? Visibility.Visible : Visibility.Hidden;

            return Visibility.Hidden;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is Visibility visibility)
                return visibility == Visibility.Visible ? true : false;

            return false;
        }
    }
}
