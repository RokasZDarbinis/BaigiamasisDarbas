using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;

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

        internal static string GetElementText(string locator)
        {
            return GetElement(locator).Text;
        }

        internal static void ClearInputElement(string locator)
        {
            GetElement(locator).Clear();
        }

        public static void MouseHover_SubMenuClick(string PrimaryMenu, string SubMenu)
        {
            WebDriverWait wait = new WebDriverWait(Driver.GetDriver(), TimeSpan.FromSeconds(10));
            var element = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(PrimaryMenu)));
            Actions action = new Actions(Driver.GetDriver());
            action.MoveToElement(element).Perform();
             
            var menuelement = GetElement(SubMenu);
            menuelement.Click();
        }
    }
}
