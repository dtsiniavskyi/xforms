using Xamarin.Forms;

namespace XForms.Pages
{
    public class HelloPage : ContentPage
    {
        public HelloPage()
        {
            var label = new Label();
            label.Text = "Hello from " + Device.OS + " " + Device.Idiom + "!";

            label.HorizontalOptions = LayoutOptions.Center;
            label.VerticalOptions = new LayoutOptions
            {
                Alignment = LayoutAlignment.Center
            };

            Device.OnPlatform(iOS: () => { Padding = new Thickness(0, 20, 0, 0); });

            Content = label;
        }
    }
}