using Xamarin.Forms;

namespace XForms.Pages.Labels
{
    public class LargeTextPage : ContentPage
    {
        public LargeTextPage()
        {
            BackgroundColor = Color.Aqua;

            Content = new Label
            {
                Text = @"Despite how sophisticated graphical user interfaces have become, text remains the backbone of most applications. Yet text is potentially one of the most complex visual objects because it carries baggage of hundreds of years of typography. The primary consideration is that text must be readable. This re-quires that text not be too small, yet text mustn’t be so large that it hogs a lot of space on the screen. For these reasons, the subject of text is continued in several subsequent chapters, most notably Chapter 5, “Dealing with sizes.” Very often, Xamarin.Forms programmers define font characteristics in styles, which are the subject of Chapter 12.",
                TextColor = Color.Green,

                VerticalTextAlignment = TextAlignment.Center,
                HorizontalTextAlignment = TextAlignment.Center,

                Opacity = .75
            };

            Padding = new Thickness(5, Device.OnPlatform(20, 5, 5), 5, 5);
        }
    }
}