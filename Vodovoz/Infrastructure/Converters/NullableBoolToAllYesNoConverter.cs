using System;
using System.Globalization;
using Gamma.Binding;
using Vodovoz.CommonEnums;

namespace Vodovoz.Infrastructure.Converters
{
    public class NullableBoolToAllYesNoConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if(!(value is bool) && value != null) {
                throw new ArgumentException($"Value was not of type Nullable<Bool>");
            }

            switch(value) {
                case null : return AllYesNo.All;
                case true : return AllYesNo.Yes;
                case false : return AllYesNo.No;
            }

            return null;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if(!(value is AllYesNo)) {
                throw new ArgumentException($"Value was not of type {nameof(AllYesNo)}");
            }

            switch((AllYesNo)value) {
                case AllYesNo.All : return null;
                case AllYesNo.Yes : return true;
                case AllYesNo.No : return false;
                default:
                    throw new ArgumentOutOfRangeException(nameof(value), value, @"Unknown enum value");
            }
        }
    }
}
