using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace DFWMobile.XF
{
    public class App
    {
        private static Page _mainPage;
        public static Page MainPage
        {
            get { return _mainPage ?? (_mainPage = new DashboardPage()); }
        }
    }
}
