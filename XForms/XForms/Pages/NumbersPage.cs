using Xamarin.Forms;

namespace XForms.Pages
{
    public class NumbersPage : ContentPage
    {
        public NumbersPage()
        {
            Content = new StackLayout
            {
                Children = {
                    new Button { Text = "1", VerticalOptions = LayoutOptions.Start, HorizontalOptions = LayoutOptions.Start },
                    new Button { Text = "2", VerticalOptions = LayoutOptions.Start, HorizontalOptions = LayoutOptions.Center },
                    new Button { Text = "3", VerticalOptions = LayoutOptions.Start, HorizontalOptions = LayoutOptions.End },
                    new Button { Text = "4", VerticalOptions = LayoutOptions.Center, HorizontalOptions = LayoutOptions.Start },
                    new Button { Text = "5", VerticalOptions = LayoutOptions.Center, HorizontalOptions = LayoutOptions.Center },
                    new Button { Text = "6", VerticalOptions = LayoutOptions.Center, HorizontalOptions = LayoutOptions.End },
                    new Button { Text = "7", VerticalOptions = LayoutOptions.End, HorizontalOptions = LayoutOptions.Start },
                    new Button { Text = "8", VerticalOptions = LayoutOptions.End, HorizontalOptions = LayoutOptions.Center },
                    new Button { Text = "9", VerticalOptions = LayoutOptions.End, HorizontalOptions = LayoutOptions.End },
                }
            };
        }
    }
}