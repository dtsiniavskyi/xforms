using Xamarin.Forms;

namespace XForms.Pages.Frames
{
    public class FramedTextPage : ContentPage
    {
        public FramedTextPage()
        {
            Padding = new Thickness(20);
            BackgroundColor = Color.Aqua;

            Content = new Frame
            {
                OutlineColor = Color.Red,
                BackgroundColor = Color.Yellow,
                
                Content = new Frame
                {
                    OutlineColor = Color.Accent,
                    HorizontalOptions = LayoutOptions.Center,
                    VerticalOptions = LayoutOptions.Center,

                    BackgroundColor = Color.Fuchsia,

                    Content = new Label
                    {
                        Text = "I've been framed!",
                        FontSize = Device.GetNamedSize(NamedSize.Large, typeof (Label)),
                        TextColor = Color.Red
                    }
                }
            };
        }
    }
}