using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Appsss.views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TabbedPageAll : Shell
    {
        public TabbedPageAll ()
        {
            InitializeComponent();

            NavigationPage.SetHasNavigationBar(this, false);
            Shell.SetTabBarIsVisible(this, true);
        }
    }
}