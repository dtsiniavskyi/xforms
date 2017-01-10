using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace XForms.Pages.Sizes
{
    struct FontCalc
    {
        public FontCalc(Label label, double fontSize, double containerWidth) : this()
        {
            // Save the font size. 
            FontSize = fontSize;
            label.FontSize = fontSize;

            // Recalculate the Label height.
            SizeRequest sizeRequest = label.GetSizeRequest(containerWidth, Double.PositiveInfinity);

            // Save that height. 
            TextHeight = sizeRequest.Request.Height;
        }

        public double FontSize { private set; get; }
        public double TextHeight { private set; get; }
    }
    public class EmpiricalFontSizePage : ContentPage
    {
        Label label;

        public EmpiricalFontSizePage()
        {
            label = new Label();
            Padding = new Thickness(0, Device.OnPlatform(20, 0, 0), 0, 0);

            ContentView contentView = new ContentView { Content = label };
            contentView.SizeChanged += OnContentViewSizeChanged;
            Content = contentView;
        }

        void OnContentViewSizeChanged(object sender, EventArgs args)
        {
            // Get View whose size is changing. 
            View view = (View)sender;
            if (view.Width <= 0 || view.Height <= 0) return;
            label.Text = "This is a paragraph of text displayed with " + "a FontSize value of ?? that is empirically " + "calculated in a loop within the SizeChanged " + "handler of the Label's container. This technique " + "can be tricky: You don't want to get into " + "an infinite loop by triggering a layout pass " + "with every calculation. Does it work?";

            // Calculate the height of the rendered text. 
            FontCalc lowerFontCalc = new FontCalc(label, 10, view.Width);
            FontCalc upperFontCalc = new FontCalc(label, 100, view.Width);

            while (upperFontCalc.FontSize - lowerFontCalc.FontSize > 1)
            {
                // Get the average font size of the upper and lower bounds. 
                double fontSize = (lowerFontCalc.FontSize + upperFontCalc.FontSize) / 2;

                // Check the new text height against the container height. 
                FontCalc newFontCalc = new FontCalc(label, fontSize, view.Width);

                if (newFontCalc.TextHeight > view.Height)
                {
                    upperFontCalc = newFontCalc;
                }
                else
                {
                    lowerFontCalc = newFontCalc;
                }
            }

            // Set the final font size and the text with the embedded value. 
            label.FontSize = lowerFontCalc.FontSize;
            label.Text = label.Text.Replace("??", label.FontSize.ToString("F0"));
        }
    }
}
