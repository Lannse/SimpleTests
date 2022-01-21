using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaybeTestWillWorkDotFremework.Pages
{
    public class SeleniumHomePage : BasePage
    {
        public string ExpectedURL => "https://www.selenium.dev/";
        public string ActualURL => driver.Url;
        public SeleniumHomePage(IWebDriver driver) : base(driver)
        {
        }
    }
}
