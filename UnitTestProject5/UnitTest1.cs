using System;
using System.Configuration;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace UnitTestProject5
{
    [TestClass]
    public class UnitTest1
    {
        /**
         * This particular test class is designed to retrieve the browser configuration from 
         * the App.config. Base on what browser it retrieves, it will configure the corresponding
         * driver using an external class 'BrowserConfig' which takes in the string formatted value
         * of the browser config from the App.config. 
         **/

        private IWebDriver driver = null;
        [TestMethod]
        public void TestMethod1()
        {
            driver.Navigate().GoToUrl("http://www.google.com");
        }

        [TestInitialize]
        public void Setup()
        {
            string browserToSetup = ConfigurationManager.AppSettings["Browser"].ToString();
            BrowserConfig config = new BrowserConfig(browserToSetup);
            driver = config.SetupBrowser();
            
            driver.Manage().Window.Maximize();
        }

        [TestCleanup]
        public void Teardown()
        {
            driver.Quit();
        }
    }
}
