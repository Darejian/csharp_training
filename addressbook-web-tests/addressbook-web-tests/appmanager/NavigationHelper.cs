using OpenQA.Selenium;

namespace WebAddressbookTests
{
    public class NavigationHelper : HelperBase
    {
    
        private string baseUrl;
        public NavigationHelper(ApplicationManager manager, string baseUrl) : base(manager)
        {
            this.baseUrl = baseUrl;
        }

        public void GoToHomePage()
        {
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl(this.baseUrl);
        }

        public void GoToGroupsPage()
        {
            driver.FindElement(By.XPath("//a[@href='group.php']")).Click();
        }

        public void ReturnToGroupsPage()
        {
            driver.FindElement(By.LinkText("group page")).Click();
        }
    }
}
