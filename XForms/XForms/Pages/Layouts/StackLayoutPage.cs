using System.Linq;
using Extensions;
using Xamarin.Forms;

namespace XForms.Pages.Layouts
{
    public class StackLayoutPage : ContentPage
    {
        public StackLayoutPage()
        {
            Padding = new Thickness(5, Device.OnPlatform(20, 5, 5), 5, 5);

            var layout = new StackLayout { Spacing = 0 };
            layout.AddRange(Colors.All.Select(c => new Label { Text = c.ToString(), BackgroundColor = c, FontSize = XForms.Sizes.Large, TextColor = Color.Accent }));

            Content = layout;
        }
    }
}