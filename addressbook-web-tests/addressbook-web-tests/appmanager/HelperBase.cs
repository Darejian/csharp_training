using OpenQA.Selenium;

namespace WebAddressbookTests
{
    public class HelperBase
    {
        protected IWebDriver driver;
        protected ApplicationManager manager;
        public HelperBase(ApplicationManager manager)
        {
            this.manager = manager;
            driver = manager.Driver;
        }

        public void ClearAndFillTextField(string fieldName, string newValue)
        {
            driver.FindElement(By.Name(fieldName)).Clear();
            driver.FindElement(By.Name(fieldName)).SendKeys(newValue);
        }
    }
}
