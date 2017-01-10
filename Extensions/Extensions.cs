using System.Collections.Generic;
using Xamarin.Forms;

namespace Extensions
{
    public static class Extensions
    {
        public static void Add(this FormattedString formattedString, Span span)
        {
            formattedString.Spans.Add(span);
        }

        public static void Add<T>(this Layout<T> layout, T view) where T : View
        {
            layout.Children.Add(view);
        }

        public static void AddRange<T>(this Layout<T> layout, IEnumerable<T> views) where T : View
        {
            foreach(var view in views)
                layout.Children.Add(view);
        }

        public static string ToRgbHex(this Color color)
        {
            var hexR = ((int)(255 * color.R)).ToString("X2");
            var hexG = ((int)(255 * color.G)).ToString("X2");
            var hexB = ((int)(255 * color.B)).ToString("X2");

            return string.Format("#{0}{1}{2}", hexR, hexG, hexB).ToLower();
        }

        public static string ToHsl(this Color color)
        {
            return string.Format("{0:F2}, {1:F2}, {2:F2}", color.Hue, color.Saturation, color.Luminosity);
        }
    }
}