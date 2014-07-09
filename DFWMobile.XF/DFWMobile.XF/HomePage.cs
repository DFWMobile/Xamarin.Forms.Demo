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
        public Image _logo;
        public HomePage()
        {
            var stackLayout = new StackLayout
            {
                Orientation = StackOrientation.Horizontal,
                HorizontalOptions = LayoutOptions.Center,
                Spacing = 10
            };

            _logo = new Image
            {
                Source = ImageSource.FromFile("dfwmobilenet-small.png"),
                Aspect = Aspect.AspectFit
            };

            var label = new Label
            {
                Text = "Hello, Again!",
                VerticalOptions = LayoutOptions.CenterAndExpand,
                HorizontalOptions = LayoutOptions.CenterAndExpand,
            };

            stackLayout.Children.Add(_logo);
            stackLayout.Children.Add(label);

            Content = stackLayout;
        }
    }
}
