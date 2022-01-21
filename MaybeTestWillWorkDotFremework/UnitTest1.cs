using MaybeTestWillWorkDotFremework.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace MaybeTestWillWorkDotFremework
{
    //[TestClass]
    public class UnitTest1
    {
        private IWebDriver driver;

        [SetUp]
        public void BeforeEveryTest()
        {
            driver = new ChromeDriver();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }

        [TearDown]
        public void AfterEveryTest()
        {
            driver.Quit();
        }

        [Test]
        public void CheckThatGoogleSearchWorkCorrect()
        {
            driver.Url = "https://www.google.com";

            GoogleHomePage googleHomePage = new GoogleHomePage(driver);
            googleHomePage.SearchField.SendKeys("Selenium");
            googleHomePage.SearchButton.Click();

            GoogleSearchResultPage googleSearchResultPage = new GoogleSearchResultPage(driver);
            googleSearchResultPage.FirstLinkInSearchResults.Click();

            SeleniumHomePage seleniumHomePage = new SeleniumHomePage(driver);
            Assert.AreEqual(seleniumHomePage.ExpectedURL, seleniumHomePage.ActualURL
                , $"Expected URL({seleniumHomePage.ExpectedURL}) are not the same as actual URL({seleniumHomePage.ActualURL}).");

        }
    }
}
