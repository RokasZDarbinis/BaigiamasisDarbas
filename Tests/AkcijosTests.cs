using Framework;
using Framework.POM;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    internal class AkcijosTests
    {
        internal class SingularItem
        {
            [SetUp]
            public void Setup()
            {
                HomePage.Startup();

            }

            [Test]

            public void BuyingFromAkcijos()
            {
                Akcijos.GoingToAkcijosAusines();
                Akcijos.ClickingOnDesiredDiscountedHeadphone();
                Akcijos.CheckingIfItemIsStillDiscounted();
                string actualPrice = ShoppingCart.CheckingIfThePriceIsStillCorrect();
                string desiredPrice = "Suma: 77.99 €";

                Assert.AreEqual(desiredPrice, actualPrice);
            }
            [TearDown]

            public void Stop()
            {
                Driver.StopDriver();
            }
        }
        internal class MultipleItems
        {
            [SetUp]
            public void Setup()
            {
                HomePage.Startup(); 
            }
            [Test]
            public void BuyingFromAkcijosMultiple()
            {
                Akcijos.GoingToAkcijosAusines();
                Akcijos.AddingDesiredHeadphonesStraightToCart();
                Akcijos.NavigatingToAkcijosMobTel();
                Akcijos.DecidingWhichPhoneIsABetterDeal();
                Akcijos.AddingBetterPhoneDealAndGoingToShoppingCart();
                string actualPrice=ShoppingCart.CheckingIfThePriceIsStillCorrect();
                string desiredPrice = "Suma: 1 066.99 €";

                Assert.AreEqual(desiredPrice, actualPrice);


            }
            [TearDown]
            public static void ProgramSTOP()
            {
                Driver.StopDriver();
            }
        }
    }
}
