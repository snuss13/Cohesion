using BoDi;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace CohesionTest.Hooks
{
    [Binding]
    public class AmazonSearchHooks
    {
        [BeforeScenario]
        public static void OpenBrowser(ScenarioContext scenario)
        {
            //testThreadContainer.BaseContainer.Resolve<Drivers.BrowserDrivers>();
            scenario.Add("driver", new Drivers.BrowserDrivers().Current);
        }

        [AfterScenario]
        public static void CloseBrowser(ScenarioContext scenario)
        {
            IWebDriver driver = (IWebDriver)scenario["driver"];
            driver.Quit();
        }
    }
}
