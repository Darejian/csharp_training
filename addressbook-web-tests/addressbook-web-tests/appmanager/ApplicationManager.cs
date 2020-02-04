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
        protected GroupBuilder groupBuilder;
        protected ContactBuilder contactBuilder;

        public ApplicationManager()
        {
            driver = new ChromeDriver();
            baseUrl = "http://localhost/addressbook/";
            loginHelper = new LoginHelper(this);
            navigator = new NavigationHelper(this, baseUrl);
            groupHelper = new GroupHelper(this);
            contactHelper = new ContactHelper(this);
            groupBuilder = new GroupBuilder(this);
            contactBuilder = new ContactBuilder(this);
        }

        public LoginHelper Auth => loginHelper; 

        public NavigationHelper Navigator => navigator; 

        public GroupHelper Group => groupHelper; 

        public ContactHelper Contact => contactHelper;

        public GroupBuilder GroupBuilder => groupBuilder;

        public ContactBuilder ContactBuilder => contactBuilder;

        public IWebDriver Driver => driver;

        public void Stop()
        {
            driver.Quit();
        }
    }
}
