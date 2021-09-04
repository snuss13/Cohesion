using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace CohesionTest.Pages
{
    public class AmazonResults
    {
        private readonly IWebDriver _webDriver;

        public AmazonResults(IWebDriver driver)
        {
            _webDriver = driver;
            WebDriverWait wait = new WebDriverWait(_webDriver, TimeSpan.FromSeconds(30));
            wait.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector("#title")));
        }

        private IWebElement title => _webDriver.FindElement(By.CssSelector("#title"));
       
        public string getTitle()
        {
            return title.Text;
        }
    }
}
