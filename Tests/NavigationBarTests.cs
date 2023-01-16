using Framework;
using Framework.POM;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    internal class NavigationBarTests
    {
        [SetUp]

        public static void SetUp() { HomePage.Startup(); }

        [Test]
        public static void Testas()
        {
            NavigationBar.NavigatingNavBar("//*[@id=\"navbar\"]/li[1]/a", "//*[@id=\"navbar\"]/li[1]/div/div[2]/div[12]/a");
            NavigationBar.ClickingOnWantedMenu("//*[@id=\"centerpanel\"]/div[3]/div/table/tbody/tr/td/table/tbody/tr[3]/td/table/tbody/tr/td/div[1]/div/ul/li[1]/a");
            ProductListPage.ClickOnDesiredItem("//*[@id=\"centerpanel\"]/div[2]/table[1]/tbody/tr[6]/td[3]/a");
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
}
