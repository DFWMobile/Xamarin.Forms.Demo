using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DFWMobile.XF
{
    public class DashboardPage
        : TabbedPage
    {
        public DashboardPage()
        {
            Children.Add(new HomePage());
            Children.Add(new HomePage());
        }
    }
}
