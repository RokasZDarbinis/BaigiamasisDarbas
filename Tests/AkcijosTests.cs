﻿using Framework;
using Framework.POM;
using NUnit.Framework;
using NUnit.Framework.Interfaces;

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
                ShoppingCart.GoToShoppingCart();
                string actualPrice = ShoppingCart.CheckingIfThePriceIsStillCorrect();
                string desiredPrice = "Suma: 77.99 €";

                Assert.AreEqual(desiredPrice, actualPrice);
            }
            
            [TearDown]
            public void Stop()
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
                ShoppingCart.GoToShoppingCart();
                string actualPrice = ShoppingCart.CheckingIfThePriceIsStillCorrect();
                string desiredPrice = "Suma: 1 066.99 €";

                Assert.AreEqual(desiredPrice, actualPrice);


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