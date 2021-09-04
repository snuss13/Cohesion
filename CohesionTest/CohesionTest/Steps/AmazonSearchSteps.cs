using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Xunit;
using CohesionTest.Drivers;

namespace CohesionTest.Steps
{
    [Binding]
    public class AmazonSearchSteps
    {
        IWebDriver driver;
        Pages.AmazonHome home;
        private AmazonSearchSteps(ScenarioContext scenario)
        {
            driver = (IWebDriver)scenario["driver"];
            home = new Pages.AmazonHome(driver);
        }

        [Given(@"user navigates to (.*)")]
        public void GivenUserNavigatesTo(string url)
        {
            home.go(url);
        }
        
        [Given(@"search for (.*)")]
        public void GivenSearchFor(string wordToSearch)
        {
            home.doSearch(wordToSearch);
        }

        [When(@"Open the first item from the results list")]
        public void WhenOpenTheFirstItemFromTheResultsList()
        {
            home.openFirstResult();
        }

        [Then(@"the item's title must contains (.*)")]
        public void ThenTheItemSTitleMustContains(string wordToVaidate)
        {
            Pages.AmazonResults results = new Pages.AmazonResults(driver);

            Assert.Contains(wordToVaidate, results.getTitle());
        }
    }
}
