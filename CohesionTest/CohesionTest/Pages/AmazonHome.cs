using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;
using SeleniumExtras.WaitHelpers;

namespace CohesionTest.Pages
{
    public class AmazonHome
    {
        private readonly IWebDriver _webDriver;

        public AmazonHome(IWebDriver driver)
        {
            _webDriver = driver;
        }

        private IWebElement SearchBar => _webDriver.FindElement(By.CssSelector("#twotabsearchtextbox"));

        internal void go(string url)
        {
            if (!url.StartsWith("http://"))
                url = "http://" + url;

            _webDriver.Navigate().GoToUrl(url);
        }

        public void doSearch(string wordToSearch)
        {
            SearchBar.SendKeys(wordToSearch);
            SearchBar.SendKeys(Keys.Enter);
        }

        public void openFirstResult()
        {
            WebDriverWait wait = new WebDriverWait(_webDriver, TimeSpan.FromSeconds(30));
            string elementCss = ".s-result-item";

            wait.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector(elementCss)));
                
            IWebElement firstResult = _webDriver.FindElements(By.CssSelector(elementCss))[1];

            firstResult.Click();
        }
    }
}
