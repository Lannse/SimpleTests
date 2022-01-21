using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TryPageObject.Pages;

namespace TryPageObject
{
   public class POTests
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
        public void GmailSignIn()
        {
            driver.Url = "https://gmail.com/";
            string email = "lannseK@gmail.com";
            string password = "Test1111";


            GmailHomePage gmailHomePage = new GmailHomePage(driver);
            gmailHomePage.SignInButton.Click();

            SignInPage signInPage = new SignInPage(driver);
            signInPage.EmailField.SendKeys(email);
            signInPage.ContinueButton.Click();
            signInPage.PasswordField.SendKeys(password);
            signInPage.ContinueButton.Click();
            
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            string ExpectedURL = "https://mail.google.com/mail/u/0/#inbox";
            string ActualURL = driver.Url;

            Assert.AreEqual(ExpectedURL, ActualURL);
        }
   }
}
