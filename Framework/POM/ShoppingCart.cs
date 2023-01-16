using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.POM
{
    public class ShoppingCart
    {
        public static string CheckingIfThePriceIsStillCorrect()
        {
            return Common.GetElementText("//b[@id='cart-total']");
        }
        public static void GoToShoppingCart()
        {
            Common.MouseHover_SubMenuClick("//*[@id=\"krepselis\"]/div/a/span", "//*[@id=\"krepselis-popup-bottom\"]/div/table/tbody/tr[2]/td/div/div/div[2]/input");
        }
    }
}
