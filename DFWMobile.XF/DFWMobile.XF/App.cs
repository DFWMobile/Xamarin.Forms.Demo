using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace DFWMobile.XF
{
    public class App
    {
        private static Page _homePage;
        public static Page HomePage
        {
            get { return _homePage ?? (_homePage = new HomePage()); }
        }
    }
}
