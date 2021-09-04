using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace CohesionTest.Drivers
{
    public class BrowserDrivers
    {
        IWebDriver _driver;
        public BrowserDrivers()
        {

            ChromeOptions opt = new ChromeOptions();
            opt.AddAdditionalCapability("useAutomationExtension", false);
            opt.AddArgument("headless");
            opt.PageLoadStrategy = PageLoadStrategy.Eager;

            _driver = new ChromeDriver(opt);

            _driver.Manage().Window.Maximize();
        }

        public IWebDriver Current => _driver;
    }
}
