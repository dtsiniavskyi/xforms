using Xamarin.Forms;

namespace XForms
{
    public static class Sizes
    {
        public static double Default { get { return Device.GetNamedSize(NamedSize.Default, typeof(Label)); } }
        public static double Micro { get { return Device.GetNamedSize(NamedSize.Micro, typeof(Label)); } }
        public static double Small { get { return Device.GetNamedSize(NamedSize.Small, typeof(Label)); } }
        public static double Medium { get { return Device.GetNamedSize(NamedSize.Medium, typeof(Label)); } }
        public static double Large { get { return Device.GetNamedSize(NamedSize.Large, typeof(Label)); } }
    }
}
