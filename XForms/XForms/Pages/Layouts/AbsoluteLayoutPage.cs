using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace XForms.Pages.Layouts
{
    public class AbsoluteLayoutPage : ContentPage
    {
        public AbsoluteLayoutPage()
        {
            Content = new AbsoluteLayout
            {
                Children =   { new Label { Text = "Hello ContentPage" } }
            };
        }
    }
}
