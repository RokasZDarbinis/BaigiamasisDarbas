using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.POM
{
   public class Akcijos
    {
        public static void GoingToAkcijosAusines()
        {
            Common.ClickElement("//*[@id=\"leftpanel\"]/div[1]/div[1]/div[1]");
            Common.ClickElement("//*[@id=\"leftpanel\"]/div[1]/div[1]/div[2]/ul/li[2]/a");
        }
        public static void SelectingDesiredDiscountedHeadphone()
        {
            Common.ClickElement("//*[@id=\"centerpanel\"]/div[1]/table[1]/tbody/tr[7]/td[3]/a");
        }
        public static void CheckingIfItemIsStillDiscounted()
        {
            String price = Common.GetElementText("//span[@class='num']/span");

            if (price == "77.99€")
            {
                Common.ClickElement("//*[@id=\"centerpanel\"]/div[8]/div[3]/form/table/tbody/tr[2]/td/div/div/div[2]/div/div[2]/input");
                Common.GoToShoppingCart();
            }
            else
            {
                Driver.StopDriver();
            }

        }
        public static string CheckingIfThePriceIsStillCorrect()
        {
            return Common.GetElementText("//b[@id='cart-total']");
        }
    }
}
