using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Imaging;
using System.IO;

namespace Framework
{
    public class Driver
    {
        private static IWebDriver driver;

        public static IWebDriver GetDriver() { return driver; }

        public static void StartDriver()
        {
            driver = new ChromeDriver();
        }
        public static void StopDriver() { driver.Quit(); }

        public static void OpenPage(string url)
        {
            driver.Navigate().GoToUrl(url);
        }
        public static void PageBack()
        {
            driver.Navigate().Back();
        }
        public static void TakeScreenshot()
        {
            string screenshotsDirectoryPath = $"{AppDomain.CurrentDomain.BaseDirectory}screenshots";
            string screenshotName = $"{screenshotsDirectoryPath}\\scr-{Guid.NewGuid()}.png";
            Directory.CreateDirectory(screenshotsDirectoryPath);
            Screenshot screenshot = ((ITakesScreenshot)driver).GetScreenshot();
            screenshot.SaveAsFile(screenshotName, ScreenshotImageFormat.Png);
        }
    }
}
