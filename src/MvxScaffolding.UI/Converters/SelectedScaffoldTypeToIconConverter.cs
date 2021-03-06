//---------------------------------------------------------------------------------
// Copyright © 2018, Jonathan Froon, Plac3hold3r+github@outlook.com
// MvxScaffolding is licensed using the MIT License
//---------------------------------------------------------------------------------

using System;
using System.Globalization;
using System.Windows.Data;
using MaterialDesignThemes.Wpf;
using MvxScaffolding.Core.Template;

namespace MvxScaffolding.UI.Converters
{
    public class SelectedScaffoldTypeToIconConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is ScaffoldType selectedScaffoldType && parameter is ScaffoldType controlScaffoldType)
            {
                if (selectedScaffoldType == controlScaffoldType)
                {
                    return PackIconKind.CheckCircleOutline;
                }
                else
                {
                    return PackIconKind.CheckboxBlankCircleOutline;
                }
            }

            throw new ArgumentException($"Invalid type for {nameof(SelectedScaffoldTypeToIconConverter)}", nameof(value));
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotSupportedException();
        }
    }
}
