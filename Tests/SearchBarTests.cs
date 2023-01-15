using Framework;
using Framework.POM;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    internal class SearchBarTests
    {
        internal class SearchBarTestSingle
        {
            [SetUp]
            public static void SetUp() { HomePage.Startup(); }

            [Test]

            public static void SingleItemSearch()
            {
                SearchBar.TypeAndSeach("Z690");
                SearchBar.ClickOnDesiredItem("//*[@id=\"centerpanel\"]/div[1]/table[1]/tbody/tr[2]/td[3]/a");
                //string norimasTekstas = "Gigabyte Z690 GAMING X DDR4 1.0 M/B Processor family Intel, Processor socket LGA1700, DDR4 DIMM, Memory slots 4, Supported hard disk drive interfaces ...";
                //string patikrinimas = SearchBar.CheckIfSelectedItemIsCorrect();
                //Assert.AreEqual(norimasTekstas, patikrinimas );
                SearchBar.CheckIfSelectedItemIsCorrect("Gigabyte Z690 GAMING X DDR4 1.0 M/B Processor family Intel, Processor socket LGA1700, DDR4 DIMM, Memory slots 4, Supported hard disk drive interfaces ...");
                string esamaSuma = ShoppingCart.CheckingIfThePriceIsStillCorrect();
                string tikimasiSuma = "Suma: 214.89 €";
                Assert.AreEqual(tikimasiSuma, esamaSuma);
            }
            [TearDown]
            public static void ProgramSTOP()
            {
                Driver.StopDriver();
            }

        }
        internal class SearchBarTestsMultipleOfItem
        {
            [SetUp]
            public static void SetUp() { HomePage.Startup(); }

            [Test]

            public static void MultipleOfItem()
            {
                SearchBar.TypeAndSeach("DDR4 Ram");
                SearchBar.SelectListingOption();
                SearchBar.ClickOnDesiredItem("//*[@id=\"centerpanel\"]/div[1]/table[1]/tbody/tr[56]/td[3]/a");
                SearchBar.AddMoreOfItem();
                SearchBar.CheckIfSelectedItemIsCorrect("ADATA Premier DDR4 RAM 8 GB, DIMM, 3200 MHz");
                string tikimasiSuma = "Suma: 41.98 €";
                string esamaSuma = ShoppingCart.CheckingIfThePriceIsStillCorrect();
                Assert.AreEqual(tikimasiSuma, esamaSuma);

            }
            [TearDown]
            public static void ProgramSTOP()
            {
                Driver.StopDriver();
            }
        }
        internal class SearchBarTestMultipleOfItems
        {
            [SetUp]
            public static void SetUp() { HomePage.Startup(); }

            [Test]
            public static void MultipleItems()
            {
                SearchBar.TypeAndSeach("I7 13700K");
                SearchBar.ClickOnDesiredItem("//*[@id=\"centerpanel\"]/div[1]/table[1]/tbody/tr[2]/td[3]/a");
                SearchBar.CheckIfSelectedItemIsCorrect2("Intel® Core™ i7-13700K Processor, 16Cores (8P+8E) 2.5-5.4GHz, LGA 1700 (dėžutėje Intel aušintuvo neprideda)"//:C
);
                SearchBar.ClearSearchAndTypeAndSearch("RTX 4090");
                SearchBar.ClickOnDesiredItem("//*[@id=\"centerpanel\"]/div[1]/table[1]/tbody/tr[19]/td[3]/a");
                SearchBar.AddMoreOfItem();
                SearchBar.CheckIfSelectedItemIsCorrect("ASUS TUF Gaming GeForce RTX4090 OC 24GB GDDR6X Graphics Card PCIe 4.0 HDMI 2.1a DisplayPort 1.4a");
                string tikimasiSuma = "Suma: 5 265.00 €";
                string esamaSuma = ShoppingCart.CheckingIfThePriceIsStillCorrect();
                Assert.AreEqual(tikimasiSuma, esamaSuma);

                

            }
            [TearDown]
            public static void ProgramSTOP()
            {
                Driver.StopDriver();
            }
        }
    }
}
        

           
        
        


