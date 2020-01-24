using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace WebAddressbookTests
{
    public class ApplicationManager
    {
        protected IWebDriver driver;
        protected string baseUrl;
        protected LoginHelper loginHelper;
        protected NavigationHelper navigator;
        protected GroupHelper groupHelper;
        protected ContactHelper contactHelper;

        public ApplicationManager()
        {
            driver = new ChromeDriver();
            baseUrl = "http://localhost/addressbook/";
            loginHelper = new LoginHelper(this);
            navigator = new NavigationHelper(this, baseUrl);
            groupHelper = new GroupHelper(this);
            contactHelper = new ContactHelper(this);
        }

        public LoginHelper Auth => loginHelper; 

        public NavigationHelper Navigator => navigator; 

        public GroupHelper Group => groupHelper; 

        public ContactHelper Contact => contactHelper;

        public IWebDriver Driver => driver;

        public void Stop()
        {
            driver.Quit();
        }
    }
}
