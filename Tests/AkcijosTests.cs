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
        [SetUp]
        public void Setup()
        {
            HomePage.Startup();
            
        }

        [Test]
        
        public void BuyingFromAkcijos()
        {
            Akcijos.GoingToAkcijosAusines();
            Akcijos.SelectingDesiredDiscountedHeadphone();
            Akcijos.CheckingIfItemIsStillDiscounted();
            string actualPrice= Akcijos.CheckingIfThePriceIsStillCorrect();
            string desiredPrice = "Suma: 77.99 €";

            Assert.AreEqual(desiredPrice, actualPrice);
        }
        [TearDown]

        public void Stop()
        {
            Driver.StopDriver();
        }
    }
}
