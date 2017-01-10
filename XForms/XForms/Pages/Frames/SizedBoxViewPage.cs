using Xamarin.Forms;

namespace XForms.Pages.Frames
{
    public class SizedBoxViewPage : ContentPage
    {
        public SizedBoxViewPage()
        {
            Content = new BoxView
            {
                Color = Color.Accent,
                HorizontalOptions = LayoutOptions.Fill,
                VerticalOptions = LayoutOptions.Fill
            };
        }
    }
}
