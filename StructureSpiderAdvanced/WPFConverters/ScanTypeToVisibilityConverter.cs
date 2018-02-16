﻿using System;
using System.Windows;
using System.Windows.Data;


namespace StructureSpiderAdvanced
{
    public sealed class ScanTypeToVisibilityConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            var type = (DataType)value;
            if (parameter.Equals("StringLength"))
            {
                if (type == DataType.String || type == DataType.StringU)
                {
                    return Visibility.Visible;
                }
                return Visibility.Collapsed;
            }


            return Visibility.Visible;//temporary?
  

            if (parameter.ToString() == "PointerAlighment")
            {
                if (type == DataType.Pointer)
                {
                    return Visibility.Collapsed;
                }

            }

            return Visibility.Visible;
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            return null;
        }
    }
}
