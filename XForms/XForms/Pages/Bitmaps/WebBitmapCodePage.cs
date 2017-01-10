using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace XForms.Pages.Bitmaps
{
    public class WebBitmapCodePage : ContentPage
    {
        public WebBitmapCodePage()
        {
            string uri = "https://developer.xamarin.com/demo/IMG_1415.JPG";

            Content = new Image
            {
                //Source = ImageSource.FromUri(new Uri(uri))
                Source = "https://developer.xamarin.com/demo/IMG_1415.JPG"
            };
        }
    }
}
