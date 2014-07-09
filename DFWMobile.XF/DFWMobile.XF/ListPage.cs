using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DFWMobile.XF.Models;
using Xamarin.Forms;

namespace DFWMobile.XF
{
    public class ListPage
        : ContentPage
    {
        public ListPage()
        {
            Title = "List";
            Icon = "about.png";
            Padding = 30;

            var listView = new ListView
            {
                RowHeight = 60
            };
            listView.ItemsSource = App.TwitterHandles;
            listView.ItemTemplate = new DataTemplate(typeof(TwitterHandleCell));

            Content = listView;
        }
    }
}
