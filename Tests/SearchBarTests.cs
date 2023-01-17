using Framework;
using Framework.POM;
using NUnit.Framework;
using NUnit.Framework.Interfaces;

namespace Tests
{
    internal class SearchBarTests
    {
        internal class SearchBarTestSingle
        {
            [SetUp]
            public static void SetUp() 
            { 
                HomePage.Startup(); 
            }

            [Test]

            public static void SingleItemSearch()
            {
                SearchBar.TypeAndSeach("Z690");
                ProductListPage.ClickOnDesiredItem("//a[contains(text(),'MSI PRO')]");
                ProductPage.CheckIfSelectedItemIsCorrect("MSI PRO Z690-A WIFI DDR4 Processor family Intel, Processor socket LGA 1700, DDR4 DIMM, Memory slots 4, Supported hard disk drive interfaces SATA, M.2, Nu...");
                ShoppingCart.GoToShoppingCart();
                string esamaSuma = ShoppingCart.CheckingIfThePriceIsStillCorrect();
                string tikimasiSuma = "Suma: 234.99 €";
                Assert.AreEqual(tikimasiSuma, esamaSuma);
            }

            [TearDown]
            public static void ProgramSTOP()
            {
                if (TestContext.CurrentContext.Result.Outcome != ResultState.Failure)
                {
                    Driver.StopDriver();
                }
                else
                {
                    Driver.TakeScreenshot();
                    Driver.StopDriver();
                }
            }
        }

        internal class SearchBarTestsMultipleOfItem
        {
            [SetUp]
            public static void SetUp() 
            { 
                HomePage.Startup(); 
            }

            [Test]
            public static void MultipleOfItem()
            {
                SearchBar.TypeAndSeach("DDR4 Ram");
                ProductListPage.SelectListingOption();
                ProductListPage.ClickOnDesiredItem("//a[contains(text(),'ADATA Premier DDR4 RAM 8 GB, DIMM')]");
                ProductPage.AddMoreOfItem();
                ProductPage.CheckIfSelectedItemIsCorrect("ADATA Premier DDR4 RAM 8 GB, DIMM, 3200 MHz");
                ShoppingCart.GoToShoppingCart();
                string tikimasiSuma = "Suma: 41.98 €";
                string esamaSuma = ShoppingCart.CheckingIfThePriceIsStillCorrect();
                Assert.AreEqual(tikimasiSuma, esamaSuma);

            }

            [TearDown]
            public static void ProgramSTOP()
            {
                if (TestContext.CurrentContext.Result.Outcome != ResultState.Failure)
                {

                    Driver.StopDriver();
                }
                else
                {
                    Driver.TakeScreenshot();
                    Driver.StopDriver();
                }
            }
        }
        internal class SearchBarTestMultipleOfItems
        {
            [SetUp]
            public static void SetUp() 
            { 
                HomePage.Startup(); 
            }

            [Test]
            public static void MultipleItems()
            {
                SearchBar.TypeAndSeach("I7 13700K");
                ProductListPage.ClickOnDesiredItem("//a[contains(text(),'Intel® Core™ i7-13700K Processor')]");
                ProductPage.CheckIfSelectedItemIsCorrect2("Intel® Core™ i7-13700K Processor, 16Cores (8P+8E) 2.5-5.4GHz, LGA 1700 (dėžutėje Intel aušintuvo neprideda)");
                SearchBar.ClearSearchAndTypeAndSearch("RTX 4090");
                ProductListPage.ClickOnDesiredItem("//a[contains(text(),'ASUS TUF Gaming GeForce RTX4090')]");
                ProductPage.AddMoreOfItem();
                ProductPage.CheckIfSelectedItemIsCorrect("ASUS TUF Gaming GeForce RTX4090 OC 24GB GDDR6X Graphics Card PCIe 4.0 HDMI 2.1a DisplayPort 1.4a");
                ShoppingCart.GoToShoppingCart();
                string tikimasiSuma = "Suma: 5 265.00 €";
                string esamaSuma = ShoppingCart.CheckingIfThePriceIsStillCorrect();
                Assert.AreEqual(tikimasiSuma, esamaSuma);
            }

            [TearDown]
            public static void ProgramSTOP()
            {
                if (TestContext.CurrentContext.Result.Outcome != ResultState.Failure)
                {
                    
                    Driver.StopDriver();
                }
                else
                {
                    Driver.TakeScreenshot();
                    Driver.StopDriver();
                }
            }
        }
    }
}