using System;
using System.Globalization;
using System.Windows;
using System.Windows.Media;

namespace Fasetto.Word
{
    /// <summary>
    /// A converter that takes in a boolean if a message was sent by me, and the anchor is pointing to right
    /// If not sent by me, the anchor is pointing to left
    /// </summary>
    public class SentByMeToAnchorSVGDataConverter : BaseValueConverter<SentByMeToAnchorSVGDataConverter>
    {
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return (bool)value ? Geometry.Parse("M 10,0 L 25,10 L 20,0 L 10,0") : Geometry.Parse("M 10,0 L 5,10 L 20,0 L 10,0");
        }

        public override object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
