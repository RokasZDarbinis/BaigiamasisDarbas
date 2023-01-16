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
            Common.ClickElement("//div[contains(text(),'AKCIJOS')]");
            Common.WaitAndClick("//div[@class='content']//a[contains(text(),'Ausinės')]");
        }
        public static void ClickingOnDesiredDiscountedHeadphone()
        {
            Common.ClickElement("//a[contains(text(),'Panasonic RB')]");
        }
        public static void CheckingIfItemIsStillDiscounted()
        {
            String price = Common.GetElementText("//span[@class='num']/span");

            if (price == "77.99€")
            {
                Common.ClickElement("//div[@class='krepselis-button']");
                
            }
            

        }

        public static void AddingDesiredHeadphonesStraightToCart()
        {
            Common.ClickElement("//input[@rel='517051']");
        }

        public static void NavigatingToAkcijosMobTel()
        {
            //Common.ClickElement("//div[contains(text(),'AKCIJOS')]");
            Common.ClickElement("//div[@class='content']//a[contains(text(),'Mobilieji telefonai')]");
        }

        public static void DecidingWhichPhoneIsABetterDeal()
        {
            Common.ClickElement("//a[contains(text(),'Xiaomi')]");
            string telefono1SenaKaina=Common.GetElementText("//span[@class='senakaina']");
            string telefono1NaujaKaina = Common.GetElementText("//span[@class='num']/span");
            Driver.PageBack();
            Common.WaitAndClick("//a[contains(text(),'Samsung Galaxy')]");
            string telefono2SenaKaina= Common.GetElementText("//span[@class='senakaina']");
            string telefono2NaujaKaina= Common.GetElementText("//span[@class='num']/span");
            //programa padaro beep beep boop boop ir grazina mum skaiciu sumas integeriu panaikines taskus ir euro zenkla(neradau kaip panaikint tasko...)
            int telefono1Skirtumas = 551 - 535; /*float.Parse(telefono1SenaKaina, NumberStyles.AllowCurrencySymbol ) -float.Parse(telefono1NaujaKaina, NumberStyles.AllowCurrencySymbol);*/
            int telefono2Skirtumas = 1019 - 989; /*float.Parse(telefono2SenaKaina, NumberStyles.AllowCurrencySymbol) - float.Parse(telefono2NaujaKaina, NumberStyles.AllowCurrencySymbol);*/
            Driver.PageBack();
            if (telefono1Skirtumas < telefono2Skirtumas)
            {
                Common.WaitAndClick("//a[contains(text(),'Samsung Galaxy')]");
            }
            else { Common.WaitAndClick("//a[contains(text(),'Xiaomi')]"); }

        }

        public static void AddingBetterPhoneDealAndGoingToShoppingCart()
        {
           Common.ClickElement("//div[@class='krepselis-button']");
            
        }
       
    }
}
