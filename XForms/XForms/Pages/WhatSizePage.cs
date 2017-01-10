using System;
using Xamarin.Forms;

namespace XForms.Pages
{
    public class WhatSizePage : ContentPage
    {
        readonly Label _labelUnits;
        readonly Label _labelInches;
        readonly Label _labelCms;

        private Label GetLabel()
        {
            return new Label
            {
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center
            };
        }

        public WhatSizePage()
        {
            _labelUnits = GetLabel();
            _labelInches = GetLabel();
            _labelCms = GetLabel();

            Content = new StackLayout
            {
                Children =
                {
                    _labelUnits,
                    _labelInches,
                    _labelCms
                }
            };
            SizeChanged += OnPageSizeChanged;
        }

        void OnPageSizeChanged(object sender, EventArgs args)
        {
            _labelUnits.Text = string.Format("{0} \u00D7 {1}", Width, Height);

            // 160 units to the inch, page 91
            var widthInches = Width/160;
            var heightInches = Height/160;
            _labelInches.Text = string.Format("{0} \u00D7 {1} inches", widthInches, heightInches);

            // 64 units to the centimeter, page 91
            var widthCms = Width/64;
            var heightCms = Height/64;
            _labelCms.Text = string.Format("{0} \u00D7 {1} centimeters", widthCms, heightCms);
        }
    }
}