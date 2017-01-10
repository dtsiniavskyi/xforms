using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Xamarin.Forms;

namespace XForms
{
    public class Colors
    {
        public static IEnumerable<Color> All
        {
            get
            {
                return new[]
                {
                    Color.White,
                    Color.Silver,
                    Color.Gray,
                    Color.Black,
                    Color.Red,
                    Color.Maroon,
                    Color.Yellow,
                    Color.Olive,
                    Color.Lime,
                    Color.Green,
                    Color.Aqua,
                    Color.Teal,
                    Color.Blue,
                    Color.Navy,
                    Color.Pink,
                    Color.Fuchsia,
                    Color.Purple
                };
            }
        }

        public static IEnumerable<Color> AllReflected
        {
            get
            {
                foreach (FieldInfo info in typeof(Color).GetRuntimeFields())
                {
                    // Skip the obsolete (i.e. misspelled) colors. 
                    if (info.GetCustomAttribute<ObsoleteAttribute>() != null) continue;

                    if (info.IsPublic && info.IsStatic && info.FieldType == typeof (Color))
                        yield return (Color) info.GetValue(null);
                }

                // Loop through the Color structure properties. 
                foreach (PropertyInfo info in typeof(Color).GetRuntimeProperties())
                {
                    MethodInfo methodInfo = info.GetMethod;

                    if (methodInfo.IsPublic && methodInfo.IsStatic && methodInfo.ReturnType == typeof(Color))
                        yield return (Color)info.GetValue(null);

                }
            }
        }
    }
}
