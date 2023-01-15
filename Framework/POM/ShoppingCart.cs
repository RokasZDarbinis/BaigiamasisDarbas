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
    }
}
