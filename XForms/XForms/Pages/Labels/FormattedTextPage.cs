using Extensions;
using Xamarin.Forms;

namespace XForms.Pages.Labels
{
    public class FormattedTextPage : ContentPage
    {
        public FormattedTextPage()
        {
            var formattedString = new FormattedString();
            formattedString.Spans.Add(new Span
            {
                Text = "I "
            });

            formattedString.Spans.Add(new Span
            {
                Text = "love",
                FontSize = Device.GetNamedSize(NamedSize.Micro, typeof(Label)),
                FontAttributes = FontAttributes.Bold,
                ForegroundColor = Color.Red
            });

            formattedString.Add(new Span
            {
                Text = " Xamarin.Forms!"
            });

            Content = new Label
            {
                FormattedText = formattedString,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center,

                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label))
            };
        }
    }
}
