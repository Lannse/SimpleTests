using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaybeTestWillWorkDotFremework.Pages
{
    public class GoogleSearchResultPage : BasePage
    {
        public GoogleSearchResultPage(IWebDriver driver) : base(driver)
        {
        }

        public IWebElement FirstLinkInSearchResults => driver.FindElement(By.CssSelector("a[href='https://www.selenium.dev/']"));

    }
}
