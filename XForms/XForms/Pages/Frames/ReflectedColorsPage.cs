using System;
using System.Reflection;
using Extensions;
using Xamarin.Forms;

namespace XForms.Pages.Frames
{
    public class ReflectedColorsPage : ContentPage
    {
        Label CreateColorLabel(Color color, string name, int index, string fieldOrProp)
        {
            Color backgroundColor = Color.Default;

            if (color != Color.Default)
            {

                // Standard luminance calculation. 
                double luminance = 0.30 * color.R + 0.59 * color.G + 0.11 * color.B;
                backgroundColor = luminance > 0.5 ? Color.Black : Color.White;
            }

            // Create the Label. 
            return new Label { Text = index + ". " + name + " (" + fieldOrProp + ")", TextColor = color, FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)), BackgroundColor = backgroundColor };
        }


        Frame CreateColorFrame(Color color, string name, int index, string fieldOrProp)
        {
            return new Frame
            {
                OutlineColor = Color.Red,
                Rotation = 5,
                
                Content = new StackLayout
                {
                    Orientation = StackOrientation.Horizontal,
                    Children =
                    {
                        new Label
                        {
                            Text = index + "."
                        },
                        new BoxView
                        {
                            Color = color
                        },
                        new StackLayout
                        {
                            Children =
                            {
                                new Label
                                {
                                    Text = name
                                },
                                new Label
                                {
                                    Text = "(" +  fieldOrProp + ")"
                                }
                            }
                        },
                        new StackLayout
                        {
                            Orientation = StackOrientation.Vertical,
                            Children =
                            {
                                new Label
                                {
                                    Text = color.ToRgbHex()
                                },
                                new Label
                                {
                                    Text = color.ToHsl()
                                }
                            }
                        }
                    }
                }
            };
        }

        public ReflectedColorsPage()
        {
            StackLayout stackLayout = new StackLayout
            {
                Orientation = StackOrientation.Vertical
            };
            int index = 1;

            // Loop through the Color structure fields.
            foreach (FieldInfo info in typeof(Color).GetRuntimeFields())
            {
                // Skip the obsolete (i.e. misspelled) colors. 
                if (info.GetCustomAttribute<ObsoleteAttribute>() != null) continue;

                if (info.IsPublic && info.IsStatic && info.FieldType == typeof(Color))
                    stackLayout.Children.Add(CreateColorFrame((Color)info.GetValue(null), info.Name, index++, "field"));
            }

            // Loop through the Color structure properties. 
            foreach (PropertyInfo info in typeof(Color).GetRuntimeProperties())
            {
                MethodInfo methodInfo = info.GetMethod;

                if (methodInfo.IsPublic && methodInfo.IsStatic && methodInfo.ReturnType == typeof(Color))
                    stackLayout.Children.Add(CreateColorFrame((Color)info.GetValue(null), info.Name, index++, "property"));
                
            }

            Padding = new Thickness(5, Device.OnPlatform(20, 5, 5), 5, 5);

            // Put the StackLayout in a ScrollView.
            Content = new ScrollView
            {
                Orientation = ScrollOrientation.Vertical,
                Content = stackLayout
            };
        }
    }
}
