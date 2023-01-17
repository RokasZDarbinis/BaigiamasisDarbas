﻿namespace Framework.POM
{
    public class ShoppingCart
    {
        public static string CheckingIfThePriceIsStillCorrect()
        {
            return Common.GetElementText("//b[@id='cart-total']");
        }
        public static void GoToShoppingCart()
        {
            Common.MouseHover_SubMenuClick("//div[@id='krepselis']", "//div[@id='krepselis-popup-wrap']//div[@class='button-label']");
        }
    }
}
