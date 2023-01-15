using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.POM
{
    public class SearchBar
    {
        public static void TypeAndSeach( string text)
        {
            Common.SendKeys("//input[@type='text']", text);
            Common.ClickElement("//input[@class='search-button']");
        }
        public static void ClickOnDesiredItem(string locator)
        {
            Common.WaitAndClick(locator);
        }
            
        public static void CheckIfSelectedItemIsCorrect(string header)
        {
         string patikrinimas= Common.GetElementText("//h1");
            if (patikrinimas == header) { Common.ClickElement("//*[@id=\"centerpanel\"]/div[8]/div[3]/form/table/tbody/tr[2]/td/div/div/div[2]/div/div[2]/input");
                Common.GoToShoppingCart();
            }
            
        }
        public static void CheckIfSelectedItemIsCorrect2(string header)
        {
            string patikrinimas = Common.GetElementText("//h1");
            if (patikrinimas == header)
            {
                Common.ClickElement("//*[@id=\"centerpanel\"]/div[8]/div[3]/form/table/tbody/tr[2]/td/div/div/div[2]/div/div[2]/input");
                Driver.PageBack();
            }
            
        }

        public static void ClearSearchAndTypeAndSearch(string text)
        {
            Common.ClearInputElement("//input[@type='text']");
            Common.SendKeys("//input[@type='text']", text);
            Common.ClickElement("//input[@class='search-button']");
        }

        public static void SelectListingOption()
        {
            Common.ClickElement("//*[@id=\"listing-filter-panel-rusiavimas\"]/li");
            Common.ClickElement("//*[@id=\"listing-filter-panel-rusiavimas\"]/li/ul/li[4]/a");
        }

        public static void AddMoreOfItem()
        {
            Common.ClickElement("//div[@class='up']");
        }
        

    }
}
