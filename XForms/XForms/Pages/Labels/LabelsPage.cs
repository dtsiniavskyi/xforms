using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace XForms.Pages.Labels
{
    struct Size
    {
        public Size(Type type)
        {
            Default = Device.GetNamedSize(NamedSize.Default, type);
            Micro = Device.GetNamedSize(NamedSize.Micro, type);
            Small = Device.GetNamedSize(NamedSize.Default, type);
            Medium = Device.GetNamedSize(NamedSize.Medium, type);
            Large = Device.GetNamedSize(NamedSize.Large, type);
        }

        public double Default { get; }
        public double Micro { get; }
        public double Small { get; }
        public double Medium { get; }
        public double Large { get; }
    }

    public class LabelsPage : ContentPage
    {
        private Size Size { get; }

        public LabelsPage()
        {
            Size = new Size(typeof(Label));

            var txts = new List<string>
            {
                "espite how sophisticated graphical user",
                "interfaces have become, text remains the backbone",
                "of most applications. Yet text is potentially",
                "one of the most complex visual objects because it carries",
                "baggage of hundreds of years of typography. The primary",
                "This re-quires that text not be too small,"
            };

            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "Default: " + Size.Default, FontSize = Size.Default },
                    new Label { Text = "Micro: " + Size.Micro, FontSize = Size.Micro },
                    new Label { Text = "Small: " + Size.Small, FontSize = Size.Small },
                    new Label { Text = "Medium: " + Size.Medium, FontSize = Size.Medium },
                    new Label { Text = "Large: " + Size.Large, FontSize = Size.Large },

                    new Label { Text = "Default bold: " + Size.Default, FontSize = Size.Default, FontAttributes = FontAttributes.Bold },
                    new Label { Text = "Micro bold: " + Size.Micro, FontSize = Size.Micro, FontAttributes = FontAttributes.Bold },
                    new Label { Text = "Small bold: " + Size.Small, FontSize = Size.Small, FontAttributes = FontAttributes.Bold },
                    new Label { Text = "Medium bold: " + Size.Medium, FontSize = Size.Medium, FontAttributes = FontAttributes.Bold },
                    new Label { Text = "Large bold: " + Size.Large, FontSize = Size.Large, FontAttributes = FontAttributes.Bold },

                    new Label { Text = "Default italic: " + Size.Default, FontSize = Size.Default, FontAttributes = FontAttributes.Italic },
                    new Label { Text = "Micro italic: " + Size.Micro, FontSize = Size.Micro, FontAttributes = FontAttributes.Italic },
                    new Label { Text = "Small italic: " + Size.Small, FontSize = Size.Small, FontAttributes = FontAttributes.Italic },
                    new Label { Text = "Medium italic: " + Size.Medium, FontSize = Size.Medium, FontAttributes = FontAttributes.Italic },
                    new Label { Text = "Large italic: " + Size.Large, FontSize = Size.Large, FontAttributes = FontAttributes.Italic },

                    new Label { Text = "Defaultt bold italic: " + Size.Default, FontSize = Size.Default, FontAttributes = FontAttributes.Bold | FontAttributes.Italic },
                    new Label { Text = "Microt bold italic: " + Size.Micro, FontSize = Size.Micro, FontAttributes = FontAttributes.Bold | FontAttributes.Italic },
                    new Label { Text = "Smallt bold italic: " + Size.Small, FontSize = Size.Small, FontAttributes = FontAttributes.Bold | FontAttributes.Italic },
                    new Label { Text = "Mediumt bold italic: " + Size.Medium, FontSize = Size.Medium, FontAttributes = FontAttributes.Bold | FontAttributes.Italic },
                    new Label { Text = "Larget bold italic: " + Size.Large, FontSize = Size.Large, FontAttributes = FontAttributes.Bold | FontAttributes.Italic }
                }
            };
        }
    }
}