using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace XForms.Pages.Bitmaps
{
    public partial class EmbededResourceBitmapPage : ContentPage
    {
        public EmbededResourceBitmapPage()
        {
            InitializeComponent();
        }

        private void OnImageSizeChanged(object sender, EventArgs e)
        {
            Image image = (Image)sender;
            label.Text = string.Format("Render size = {0:F0} x {1:F0}", image.Width, image.Height);
        }
    }
}
