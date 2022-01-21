using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryPageObject.Pages
{
    public class GmailHomePage : BasePage
    {
        public GmailHomePage(IWebDriver driver) : base(driver) {}

        public IWebElement SignInButton => driver
            .FindElement(By.CssSelector("a.button.button--medium.button--mobile-before-hero-only"));
        
        
    }
}
