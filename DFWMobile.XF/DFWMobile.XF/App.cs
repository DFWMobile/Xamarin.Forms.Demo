using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DFWMobile.XF.Models;
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

        private static List<TwitterHandle> _twitterHandles = null;
        public static List<TwitterHandle> TwitterHandles
        {
            get
            {
                if (_twitterHandles == null)
                {
                    _twitterHandles = GenerateTwitterHandles();
                }

                return _twitterHandles;
            }
        }

        private static List<TwitterHandle> GenerateTwitterHandles()
        {
            return new List<TwitterHandle>
            {
                new TwitterHandle()
                {
                    DisplayName = "No Kia",
                    Twitter = "@Nokia",
                    ImageUri = "https://pbs.twimg.com/profile_images/459664041934213120/9TaLwmxi_bigger.png"
                },
                new TwitterHandle()
                {
                    DisplayName = "Matrix Dallas",
                    Twitter = "@MATRIX_Dallas",
                    ImageUri = "https://pbs.twimg.com/profile_images/3153848807/e15d4182aa3042fcd3e5fc37fd1b3cd6_bigger.png"
                },
                new TwitterHandle()
                {
                    DisplayName = "Sean Sparkman",
                    Twitter = "@seansparkman",
                    ImageUri = "https://pbs.twimg.com/profile_images/454656615392636928/nqyXVThx_bigger.png"
                }
            };
        }
    }
}
