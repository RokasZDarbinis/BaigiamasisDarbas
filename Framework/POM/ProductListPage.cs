using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.POM
{
    public class ProductListPage
    {
        public static void SelectListingOption()
        {
            Common.ClickElement("//*[@id=\"listing-filter-panel-rusiavimas\"]/li");
            Common.ClickElement("//*[@id=\"listing-filter-panel-rusiavimas\"]/li/ul/li[4]/a");
        }

        public static void ClickOnDesiredItem(string locator)
        {
            Common.WaitAndClick(locator);
        }
    }
}
