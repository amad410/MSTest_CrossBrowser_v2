using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.IE;

namespace IETest
{
    [TestClass]
    public class IETestProject
    {
        private IWebDriver driver = null;
        [TestMethod]
        public void IETest()
        {
            driver.Navigate().GoToUrl("http://www.google.com");
        }

        [TestInitialize]
        public void Setup()
        {
            driver = new InternetExplorerDriver();
            driver.Manage().Window.Maximize();
        }

        [TestCleanup]
        public void Teardown()
        {
            driver.Quit();
        }
    }
}
