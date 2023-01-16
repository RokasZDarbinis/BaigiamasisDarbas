using System;
using System.Collections.Generic;
using System.Globalization;
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
        public static void ClickingOnDesiredDiscountedHeadphone()
        {
            Common.ClickElement("//*[@id=\"centerpanel\"]/div[1]/table[1]/tbody/tr[7]/td[3]/a");
        }
        public static void CheckingIfItemIsStillDiscounted()
        {
            String price = Common.GetElementText("//span[@class='num']/span");

            if (price == "77.99€")
            {
                Common.ClickElement("//*[@id=\"centerpanel\"]/div[8]/div[3]/form/table/tbody/tr[2]/td/div/div/div[2]/div/div[2]/input");
                
            }
            

        }

        public static void AddingDesiredHeadphonesStraightToCart()
        {
            Common.ClickElement("//input[@rel='517051']");
        }

        public static void NavigatingToAkcijosMobTel()
        {
            //Common.ClickElement("//*[@id=\"leftpanel\"]/div[1]/div[1]/div[1]");
            Common.ClickElement("//*[@id=\"leftpanel\"]/div[1]/div[1]/div[2]/ul/li[18]/a");
        }

        public static void DecidingWhichPhoneIsABetterDeal()
        {
            Common.ClickElement("//*[@id=\"centerpanel\"]/div[1]/table[1]/tbody/tr[3]/td[3]/a");
            string telefono1SenaKaina=Common.GetElementText("//span[@class='senakaina']");
            string telefono1NaujaKaina = Common.GetElementText("//span[@class='num']/span");
            Driver.PageBack();
            Common.WaitAndClick("//*[@id=\"centerpanel\"]/div[1]/table[1]/tbody/tr[4]/td[3]/a");
            string telefono2SenaKaina= Common.GetElementText("//span[@class='senakaina']");
            string telefono2NaujaKaina= Common.GetElementText("//span[@class='num']/span");
            //programa padaro beep beep boop boop ir grazina mum skaiciu sumas integeriu panaikines taskus ir euro zenkla(neradau kaip panaikint tasko...)
            int telefono1Skirtumas = 551 - 535; /*float.Parse(telefono1SenaKaina, NumberStyles.AllowCurrencySymbol ) -float.Parse(telefono1NaujaKaina, NumberStyles.AllowCurrencySymbol);*/
            int telefono2Skirtumas = 1019 - 989; /*float.Parse(telefono2SenaKaina, NumberStyles.AllowCurrencySymbol) - float.Parse(telefono2NaujaKaina, NumberStyles.AllowCurrencySymbol);*/
            Driver.PageBack();
            if (telefono1Skirtumas < telefono2Skirtumas)
            {
                Common.WaitAndClick("//*[@id=\"centerpanel\"]/div[1]/table[1]/tbody/tr[4]/td[3]/a");
            }
            else { Common.WaitAndClick("//*[@id=\"centerpanel\"]/div[1]/table[1]/tbody/tr[3]/td[3]/a"); }

        }

        public static void AddingBetterPhoneDealAndGoingToShoppingCart()
        {
           Common.ClickElement("//*[@id=\"centerpanel\"]/div[8]/div[3]/form/table/tbody/tr[2]/td/div/div/div[2]/div/div[2]/input");
            
        }
       
    }
}
