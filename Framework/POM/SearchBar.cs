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



        public static void ClearSearchAndTypeAndSearch(string text)
        {
            Common.ClearInputElement("//input[@type='text']");
            Common.SendKeys("//input[@type='text']", text);
            Common.ClickElement("//input[@class='search-button']");
        }
        

    }
}
