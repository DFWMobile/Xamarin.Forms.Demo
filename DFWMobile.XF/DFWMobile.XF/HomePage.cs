using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DFWMobile.XF
{
    public class HomePage
        : ContentPage
    {
        public HomePage()
        {
            Content = new Label
            {
                Text = "Hello, Again!",
                VerticalOptions = LayoutOptions.CenterAndExpand,
                HorizontalOptions = LayoutOptions.CenterAndExpand,
            };
        }
    }
}
