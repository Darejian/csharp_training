using OpenQA.Selenium;

namespace WebAddressbookTests
{
    public class LoginHelper : HelperBase
    {
        public LoginHelper(IWebDriver driver) : base(driver) {}

        public void Login(AccountData account)
        {
            driver.FindElement(By.Name("user")).SendKeys(account.Username);
            driver.FindElement(By.Name("pass")).SendKeys(account.Password);
            driver.FindElement(By.CssSelector("input[type='submit'][value='Login']")).Click();
        }

        public void Logout()
        {
            driver.FindElement(By.XPath("//a[@onclick='document.logout.submit();']")).Click();
        }
    }
}
