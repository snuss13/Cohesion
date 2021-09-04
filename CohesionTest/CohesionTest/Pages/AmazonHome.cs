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
            string elementCss = "#search > div.s-desktop-width-max.s-desktop-content.s-opposite-dir.sg-row > div.s-matching-dir.sg-col-16-of-20.sg-col.sg-col-8-of-12.sg-col-12-of-16 > div > span:nth-child(4) > div.s-main-slot.s-result-list.s-search-results.sg-row > div:nth-child(8) > div";

            wait.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector(elementCss)));
                
            IWebElement firstResult = _webDriver.FindElement(By.CssSelector(elementCss));

            firstResult.Click();
        }
    }
}
