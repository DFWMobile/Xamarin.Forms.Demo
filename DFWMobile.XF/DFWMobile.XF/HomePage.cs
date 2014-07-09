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
            Title = "Layouts";
            Icon = "about.png";

            var layout = new AbsoluteLayout();

            _logo = new Image
            {
                Source = ImageSource.FromFile("dfwmobilenet_small.png"),
                Aspect = Aspect.AspectFit
            };

            var label = new Label
            {
                Text = "Hello, Again!",
                VerticalOptions = LayoutOptions.CenterAndExpand,
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                BackgroundColor = Color.Red,
                
                Font = Font.SystemFontOfSize(20),
                WidthRequest = 200,
                HeightRequest = 100,

                XAlign = TextAlignment.Center,
            };

            layout.Children.Add(_logo, new Point(150, 150));
            layout.Children.Add(label, new Point(150, 350));

            Content = layout;
        }
    }
}
