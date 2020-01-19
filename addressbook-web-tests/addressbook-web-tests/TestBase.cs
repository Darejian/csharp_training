using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;
using System.IO;

namespace WebAddressbookTests
{
    public class TestBase
    {
        protected IWebDriver driver; 

        [SetUp]
        public void SetUp()
        {
            driver = new ChromeDriver();
        }

        [TearDown]
        protected void TearDown()
        {
            driver.Quit();
        }
        protected void Login(AccountData account)
        {
            driver.FindElement(By.Name("user")).SendKeys(account.Username);
            driver.FindElement(By.Name("pass")).SendKeys(account.Password);
            driver.FindElement(By.CssSelector("input[type='submit'][value='Login']")).Click();
        }

        protected void Logout()
        {
            driver.FindElement(By.XPath("//a[@onclick='document.logout.submit();']")).Click();
        }

        protected void OpenHomePage()
        {
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("http://localhost/addressbook/");
        }

        protected void GoToGroupsPage()
        {
            driver.FindElement(By.XPath("//a[@href='group.php']")).Click();
        }

        protected void ReturnToGroupsPage()
        {
            driver.FindElement(By.LinkText("group page")).Click();
        }

        protected void InitGroupCreation()
        {
            driver.FindElement(By.Name("new")).Click();
        }

        protected void FillGroupForm(GroupData group)
        {
            driver.FindElement(By.Name("group_name")).Click();
            driver.FindElement(By.Name("group_name")).SendKeys(group.Name);
            driver.FindElement(By.Name("group_header")).Click();
            driver.FindElement(By.Name("group_header")).SendKeys(group.Header);
            driver.FindElement(By.Name("group_footer")).Click();
            driver.FindElement(By.Name("group_footer")).SendKeys(group.Footer);
        }

        protected void SubmitGroupCreation()
        {
            driver.FindElement(By.Name("submit")).Click();
        }

        protected void SelectGroup(string index)
        {
            driver.FindElement(By.XPath("(//input[@name='selected[]'])[" + index + "]")).Click();
        }

        protected void DeleteGroup()
        {
            driver.FindElement(By.Name("delete")).Click();
        }

        protected void InitContactCreation()
        {
            driver.FindElement(By.XPath("//a[@href='edit.php']")).Click();
        }

        protected void FillContactForm(ContactData contact)
        {
            driver.FindElement(By.Name("firstname")).SendKeys(contact.FirstName);
            driver.FindElement(By.Name("middlename")).SendKeys(contact.MiddleName);
            driver.FindElement(By.Name("lastname")).SendKeys(contact.LastName);
            driver.FindElement(By.Name("nickname")).SendKeys(contact.Nickname);

            string fileName = "testAvatar.png";
            string dirName = @"TestImages\";
            string pathToFile = Path.Combine(TestContext.CurrentContext.TestDirectory, dirName, fileName);
            driver.FindElement(By.Name("photo")).SendKeys(pathToFile);

            driver.FindElement(By.Name("title")).SendKeys(contact.Title);
            driver.FindElement(By.Name("company")).SendKeys(contact.Company);
            driver.FindElement(By.Name("address")).SendKeys(contact.Address);
            driver.FindElement(By.Name("home")).SendKeys(contact.PhoneHome);
            driver.FindElement(By.Name("mobile")).SendKeys(contact.PhoneMobile);
            driver.FindElement(By.Name("work")).SendKeys(contact.PhoneWork);
            driver.FindElement(By.Name("fax")).SendKeys(contact.PhoneFax);
            driver.FindElement(By.Name("email")).SendKeys(contact.Email1);
            driver.FindElement(By.Name("email2")).SendKeys(contact.Email2);
            driver.FindElement(By.Name("email3")).SendKeys(contact.Email3);
            driver.FindElement(By.Name("homepage")).SendKeys(contact.Homepage);
            driver.FindElement(By.Name("address2")).SendKeys(contact.SecondaryAddress);
            driver.FindElement(By.Name("phone2")).SendKeys(contact.SecondaryHome);
            driver.FindElement(By.Name("notes")).SendKeys(contact.SecondaryNotes);
        }

        protected void SelectBirthday(ContactData contact)
        {
            driver.FindElement(By.Name("bday")).Click();
            driver.FindElement(By.XPath($"//select[@name='bday']/option[@value='{contact.BirthDay}']")).Click();
            driver.FindElement(By.Name("bmonth")).Click();
            driver.FindElement(By.XPath($"//select[@name='bmonth']/option[@value='{contact.BirthMonth}']")).Click();
            driver.FindElement(By.Name("byear")).Click();
            driver.FindElement(By.Name("byear")).SendKeys(contact.BirthYear);
        }

        protected void SelectAnniversaryDate(ContactData contact)
        {
            driver.FindElement(By.Name("aday")).Click();
            driver.FindElement(By.XPath($"//select[@name='aday']/option[@value='{contact.AnniversaryDay}']")).Click();
            driver.FindElement(By.Name("amonth")).Click();
            driver.FindElement(By.XPath($"//select[@name='amonth']/option[@value='{contact.AnniversaryMonth}']")).Click();
            driver.FindElement(By.Name("ayear")).Click();
            driver.FindElement(By.Name("ayear")).SendKeys(contact.AnniversaryYear);
        }

        protected void SubmitContactCreation()
        {
            driver.FindElement(By.CssSelector("input[type='submit']~input[type='submit']")).Click();
        }
    }
}
