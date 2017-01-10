using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace XForms.Pages.Buttons
{
    public class ButtonLoggerPage : ContentPage
    {
        private readonly Button _addButton;
        private readonly Button _removeButton;

        private readonly ScrollView _logsScrollView;
        private readonly StackLayout _logsLayout;

        private void OnButtobClicked(object sender, EventArgs e)
        {
            var button = sender as Button;

            if (button == _addButton)
            {
                _logsLayout.Children.Add(new Label
                {
                    Text = "Button clicked at " + DateTime.Now.ToString("T")
                });
            }
            else
            {
                _logsLayout.Children.RemoveAt(0);
            }

            _removeButton.IsEnabled = _logsLayout.Children.Count > 0;
        }

        public ButtonLoggerPage()
        {
            _addButton = new Button { Text = "Add", HorizontalOptions = LayoutOptions.CenterAndExpand };
            _removeButton = new Button {Text = "Remove", HorizontalOptions = LayoutOptions.CenterAndExpand, IsEnabled = false };

            _addButton.Clicked += OnButtobClicked;
            _removeButton.Clicked += OnButtobClicked;

            _logsLayout = new StackLayout();

            _logsScrollView = new ScrollView
            {
                Content = _logsLayout,
                VerticalOptions = LayoutOptions.FillAndExpand
            };

            Content = new StackLayout
            {
                Children = {
                    new StackLayout
                    {
                        Orientation = StackOrientation.Horizontal,
                        Children =
                        {
                            _addButton,
                            _removeButton
                        }
                    },
                    _logsScrollView
                }
            };
        }
    }
}
