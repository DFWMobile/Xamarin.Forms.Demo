using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DFWMobile.XF
{
    public class EntryPage
        : ContentPage
    {
        private Entry _firstName;
        private Entry _lastName;
        private Entry _twitter;
        public EntryPage()
        {
            Title = "Data Entry";
            Icon = "about.png";
            Padding = 20;


            var layout = new StackLayout
            {
                Orientation = StackOrientation.Vertical,
                Spacing = 10
            };

            layout.Children.Add(new Label
            {
                Text = "First Name"
            });

            _firstName = new Entry
            {
                WidthRequest = 300,
                HorizontalOptions = LayoutOptions.FillAndExpand
            };
            layout.Children.Add(_firstName);

            layout.Children.Add(new Label
            {
                Text = "Last Name"
            });

            _lastName = new Entry
            {
                WidthRequest = 300,
                HorizontalOptions = LayoutOptions.FillAndExpand
            };
            layout.Children.Add(_lastName);

            layout.Children.Add(new Label
            {
                Text = "Twitter"
            });

            _twitter = new Entry
            {
                WidthRequest = 300,
                HorizontalOptions = LayoutOptions.FillAndExpand
            };
            layout.Children.Add(_twitter);

            Content = layout;
        }
    }
}
