using System;
using System.Globalization;
using Xamarin.Forms;

namespace CarouselViewTest.Converters
{
    public class AgeToColorConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (!(value is int age))
                return Color.LightGreen;

            if (age < 20)
                return Color.ForestGreen;
            if (age < 40)
                return Color.DarkOliveGreen;
            if (age < 60)
                return Color.BurlyWood;

            return Color.DarkOliveGreen;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
