using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework
{
    internal class Common
    {
        private static IWebElement GetElement(string locator)
        {
            return Driver.GetDriver().FindElement(By.XPath(locator));
        }
        public static void ClickElement(string locator)
        {
            Driver.GetDriver().FindElement(By.XPath(locator)).Click();
        }
        internal static void SendKeys(string locator, string keys)
        {
            GetElement(locator).SendKeys(keys);

        }
        internal static void WaitForElementToBeClickable(string locator)
        {
            WebDriverWait wait = new WebDriverWait(Driver.GetDriver(), TimeSpan.FromSeconds(5));
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(locator)));
        }

        internal static void WaitAndClick(string locator)
        {
            WaitForElementToBeClickable(locator);
            ClickElement(locator);
        }
        private static SelectElement GetSelectElement(string locator)
        {
            IWebElement element = GetElement(locator);
            return new SelectElement(element);
        }
        internal static void SelectOptionByValue(string selectElementLocator, string value)
        {
            SelectElement selectElement = GetSelectElement(selectElementLocator);
            selectElement.SelectByValue(value);
        }
        internal static string GetElementText(string locator)
        {
            return GetElement(locator).Text;
        }

        internal static void GoToShoppingCart()
        {
            Driver.OpenPage("https://www.skytech.lt/shopping_cart.php");
        }

        //internal static void HoverAction(string locator)
        //{
        //    IWebElement target = GetElement(locator);
        //    Actions action= new Actions(Driver.GetDriver());
        //    action.MoveToElement(target);
        //}

    }
}
