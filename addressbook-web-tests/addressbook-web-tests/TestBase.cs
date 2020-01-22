using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;

namespace WebAddressbookTests
{
    public class TestBase
    {
        protected IWebDriver driver;
        protected string baseUrl;
        protected LoginHelper loginHelper;
        protected NavigationHelper navigator;
        protected GroupHelper groupHelper;
        protected ContactHelper contactHelper;

        [SetUp]
        public void SetUp()
        {
            driver = new ChromeDriver();
            baseUrl = "http://localhost/addressbook/";
            loginHelper = new LoginHelper(driver);
            navigator = new NavigationHelper(driver, baseUrl);
            groupHelper = new GroupHelper(driver);
            contactHelper = new ContactHelper(driver);
        }

        [TearDown]
        protected void TearDown()
        {
            driver.Quit();
        }
    }
}
