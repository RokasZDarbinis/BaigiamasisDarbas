using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.POM
{
    public class ProductPage
    {
        public static void AddMoreOfItem()
        {
            Common.ClickElement("//div[@class='up']");
        }
        public static string GetPrice()
        {
            return Common.GetElementText("//span[@class='num']/span");
        }

        public static void CheckIfSelectedItemIsCorrect(string header)
        {
            string patikrinimas = Common.GetElementText("//h1");
            if (patikrinimas == header)
            {
                Common.ClickElement("//*[@id=\"centerpanel\"]/div[8]/div[3]/form/table/tbody/tr[2]/td/div/div/div[2]/div/div[2]/input");
                
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
    }
}
