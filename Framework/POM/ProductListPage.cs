namespace Framework.POM
{
    public class ProductListPage
    {
        public static void SelectListingOption()
        {
            Common.ClickElement("//*[@id='listing-filter-panel-rusiavimas']/li");
            Common.ClickElement("//*[@id='listing-filter-panel-rusiavimas']//a[contains(text(),'Kaina 1-100')]");
        }

        public static void ClickOnDesiredItem(string locator)
        {
            Common.WaitAndClick(locator);
        }
    }
}
