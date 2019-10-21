using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Edge;

namespace EdgeTest
{
    [TestClass]
    public class EdgeTestProject
    {
        private IWebDriver driver = null;
        [TestMethod]
        public void EdgeTest()
        {
            driver.Navigate().GoToUrl("http://www.google.com");
        }

        [TestInitialize]
        public void Setup()
        {
            driver = new EdgeDriver();
            driver.Manage().Window.Maximize();
        }

        [TestCleanup]
        public void Teardown()
        {
            driver.Quit();
        }
    }
}
