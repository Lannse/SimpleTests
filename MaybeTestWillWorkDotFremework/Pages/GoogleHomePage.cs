using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaybeTestWillWorkDotFremework.Pages
{
    public class GoogleHomePage : BasePage
    {
        public GoogleHomePage(IWebDriver driver) : base(driver)
        {
        }

        public IWebElement SearchField => driver.FindElement(By.CssSelector("input[title='Пошук']"));

        public IWebElement SearchButton => driver.FindElement(By.CssSelector("[class='gNO89b']"));

    }
}
