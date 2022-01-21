using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryPageObject.Pages
{
    public class SignInPage : BasePage
    {
        public SignInPage(IWebDriver driver) : base(driver) {}

        public IWebElement EmailField => driver
            .FindElement(By.XPath("//input[@type='email']"));
        public IWebElement ContinueButton => driver
            .FindElements(By.CssSelector("div.VfPpkd-RLmnJb")).First();
        public IWebElement PasswordField => driver
            .FindElements(By.CssSelector("input.whsOnd.zHQkBf")).First();
    }
}
