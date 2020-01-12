using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;
using System.IO;
using System;

namespace WebAddressbookTests
{

    [TestFixture]
    public class ContactCreationTests
    {
        private IWebDriver driver;
        private IJavaScriptExecutor js;
        [SetUp]
        public void SetUp()
        {
            driver = new ChromeDriver();
            js = (IJavaScriptExecutor)driver;
        }
        [TearDown]
        protected void TearDown()
        {
            driver.Quit();
        }
        [Test]
        public void createContact()
        {
            OpenHomePage();
            Login();
            InitContactCreation();
            ContactData defaultContact = new ContactData();
            FillContactForm(defaultContact);
            SelectBirthday(defaultContact);
            SelectAnniversaryDate(defaultContact);
            SubmitContactCreation();
            Logout();
        }

        private void CleanUpCopiedFile(string path)
        {
            if (File.Exists(path))
            {
                File.Delete(path);
            }
        }

        private void Logout()
        {
            driver.FindElement(By.XPath("//a[@onclick='document.logout.submit();']")).Click();
        }

        private void SubmitContactCreation()
        {
            driver.FindElement(By.CssSelector("input[type='submit']~input[type='submit']")).Click();
        }

        private void FillContactForm(ContactData contact)
        {
            driver.FindElement(By.Name("firstname")).SendKeys(contact.FirstName);
            driver.FindElement(By.Name("middlename")).SendKeys(contact.MiddleName);
            driver.FindElement(By.Name("lastname")).SendKeys(contact.LastName);
            driver.FindElement(By.Name("nickname")).SendKeys(contact.Nickname);
 
            string fileName = "testAvatar.png";
            string workingDirectory = Directory.GetParent(TestContext.CurrentContext.TestDirectory).Parent.FullName;
            string destPath = AppDomain.CurrentDomain.BaseDirectory;
            destPath = Directory.GetParent(destPath).Parent.FullName;
            destPath = Path.Combine(destPath, fileName);
            string sourcePath = Path.Combine(workingDirectory, @"TestImages\", fileName);
            File.Copy(sourcePath, destPath);
            driver.FindElement(By.Name("photo")).SendKeys(destPath);
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

        private void SelectBirthday (ContactData contact)
        {
            driver.FindElement(By.Name("bday")).Click();
            driver.FindElement(By.XPath($"//select[@name='bday']/option[@value='{contact.BirthDay}']")).Click();
            driver.FindElement(By.Name("bmonth")).Click();
            driver.FindElement(By.XPath($"//select[@name='bmonth']/option[@value='{contact.BirthMonth}']")).Click();
            driver.FindElement(By.Name("byear")).Click();
            driver.FindElement(By.Name("byear")).SendKeys(contact.BirthYear);
        }

        private void SelectAnniversaryDate(ContactData contact)
        {
            driver.FindElement(By.Name("aday")).Click();
            driver.FindElement(By.XPath($"//select[@name='aday']/option[@value='{contact.AnniversaryDay}']")).Click();
            driver.FindElement(By.Name("amonth")).Click();
            driver.FindElement(By.XPath($"//select[@name='amonth']/option[@value='{contact.AnniversaryMonth}']")).Click();
            driver.FindElement(By.Name("ayear")).Click();
            driver.FindElement(By.Name("ayear")).SendKeys(contact.AnniversaryYear);
        }

        private void InitContactCreation()
        {
            driver.FindElement(By.XPath("//a[@href='edit.php']")).Click();
        }

        private void Login()
        {
            driver.FindElement(By.Name("user")).SendKeys("admin");
            driver.FindElement(By.Name("pass")).SendKeys("secret");
            driver.FindElement(By.CssSelector("input[type='submit'][value='Login']")).Click();
        }

        private void OpenHomePage()
        {
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("http://localhost/addressbook/");
        }
    }
}
