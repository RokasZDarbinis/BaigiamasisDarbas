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
                Common.WaitAndClick("//div[@class='krepselis-button']//div[@class='button-label']");
            }
        }

        public static void CheckIfSelectedItemIsCorrect2(string header)
        {
            string patikrinimas = Common.GetElementText("//h1");
            if (patikrinimas == header)
            {
                Common.ClickElement("//div[@class='krepselis-button']//div[@class='button-label']");
                Driver.PageBack();
            }
        }
    }
}
