using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace FireFoxTest
{
    [TestClass]
    public class FireFox
    {
        private IWebDriver driver = null;
        private FirefoxDriverService service = null;
        [TestMethod]
        public void FireFoxTest()
        {
            driver.Navigate().GoToUrl("http://www.google.com");
        }

        [TestInitialize]
        public void Setup()
        {
            //change the paths to fit your local paths
            service = FirefoxDriverService.CreateDefaultService(@"C:\Users\antwan.maddox\source\repos\UnitTestProject5\Drivers\");
            service.FirefoxBinaryPath = @"C:\Program Files\Mozilla Firefox\firefox.exe";
            driver = new FirefoxDriver(service);
            driver.Manage().Window.Maximize();
        }

        [TestCleanup]
        public void Teardown()
        {
            driver.Quit();
        }
    }
}
