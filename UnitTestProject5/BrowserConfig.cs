using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject5
{
    public class BrowserConfig
    {
        private string _browserConfig = null;
        public IWebDriver _driver;
        private FirefoxDriverService service = null;
        public BrowserConfig(string browserconfig)
        {
            _browserConfig = browserconfig;

        }

        public IWebDriver SetupBrowser()
        {
            switch (_browserConfig)
            {
                case "Chrome":
                    _driver = new ChromeDriver();
                    break;
                case "Edge":
                    _driver = new EdgeDriver();
                    break;
                case "IE":
                    _driver = new InternetExplorerDriver();
                    break;
                case "FireFox":
                    service = FirefoxDriverService.CreateDefaultService(@"C:\Users\antwan.maddox\source\repos\UnitTestProject5\Drivers\");
                    service.FirefoxBinaryPath = @"C:\Program Files\Mozilla Firefox\firefox.exe";
                    _driver = new FirefoxDriver(service);
                    break;

                   
            }
            return _driver;
        }
    }
}
