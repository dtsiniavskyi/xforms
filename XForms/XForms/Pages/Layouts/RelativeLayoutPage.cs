using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace XForms.Pages.Layouts
{
    public class RelativeLayoutPage : ContentPage
    {
        public RelativeLayoutPage()
        {
            Content = new RelativeLayout
            {
                //Children = new RelativeList { new Label { Text = "Hello ContentPage" } }
            };
        }
    }
}
