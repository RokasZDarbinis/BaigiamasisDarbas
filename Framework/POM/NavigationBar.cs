using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.POM
{
    public class NavigationBar
    {
        public static void NavigatingNavBar(string menuLocator, string submenuLocator)
        {
            Common.MouseHover_SubMenuClick(menuLocator, submenuLocator);
        }
        public static void ClickingOnWantedMenu(string locator)
        {
            Common.WaitAndClick(locator);
        }

    }
}
