using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace BodyIndexMass.ViewModels
{
    public class ColorConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            string myValue = value.ToString();
            if (myValue.Equals(AppResources.Overweight))
                return Color.Yellow;

            if (myValue.Equals(AppResources.Underweight))
                return Color.Orange;

            if (myValue.Equals(AppResources.NormalWeight))
                return Color.Green;

            return Color.Red;
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            // You probably don't need this, this is used to convert the other way around
            // so from color to yes no or maybe
            throw new NotImplementedException();
        }
    }
}
