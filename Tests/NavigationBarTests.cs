using Framework;
using Framework.POM;
using NUnit.Framework;
using NUnit.Framework.Interfaces;

namespace Tests
{
    internal class NavigationBarTests

    {
        internal class SingleItemNavBarTest
        {
            [SetUp]

            public static void SetUp() 
            { 
                HomePage.Startup(); 
            }

            [Test]
            public static void SingleItemNavBarTestt()
            {
                NavigationBar.NavigatingNavBar("//a[contains(text(),'Kompiuteriai, Komponentai')]", "//a[contains(text(),'Korpusai ir priedai')]");
                NavigationBar.ClickingOnWantedMenu("//a[contains(text(),'Korpusai (')]");
                ProductListPage.ClickOnDesiredItem("//a[contains(text(),'AEROPGSCS-107')]");
                string productPrice = "Suma: 40.79 €";
                ProductPage.CheckIfSelectedItemIsCorrect("AEROCOOL PGS CS-107-A-BK-v2 FRGB - PC case");
                ShoppingCart.GoToShoppingCart();
                string cartPrice = ShoppingCart.CheckingIfThePriceIsStillCorrect();
                Assert.AreEqual(productPrice, cartPrice);
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

        internal class Multiple
        {
            [SetUp]

            public static void SetUp() 
            { 
                HomePage.Startup(); 
            }

            [Test]
            public static void MultipleItemNavBarTest()
            {
                NavigationBar.NavigatingNavBar("//a[contains(text(),'Kompiuteriai, Komponentai')]", "//a[contains(text(),'SSD')]");
                NavigationBar.ClickingOnWantedMenu("//a[contains(text(),'SSD diskai (')]");
                ProductListPage.ClickOnDesiredItem("//a[contains(text(),'Adata Ulitimate SU650 SSD 960GB')]");
                ProductPage.CheckIfSelectedItemIsCorrect("Adata Ulitimate SU650 SSD 960GB SATA3 Read/Write 520/450MB/s retail");
                NavigationBar.NavigatingNavBar("//a[contains(text(),'Kompiuteriai, Komponentai')]", "//a[contains(text(),'Maitinimo blokai')]");
                ProductListPage.ClickOnDesiredItem("//a[contains(text(),'1600')]");
                ProductPage.CheckIfSelectedItemIsCorrect("Power Supply|BE QUIET|1500 Watts|Peak Power 1600 Watts|Efficiency 80 PLUS TITANIUM|PFC Active|MTBF 300000 hours|BN312");
                ShoppingCart.GoToShoppingCart();
                string productsPrice = "Suma: 504.99 €";
                string cartPrice=ShoppingCart.CheckingIfThePriceIsStillCorrect();
                Assert.AreEqual(productsPrice, cartPrice);

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
