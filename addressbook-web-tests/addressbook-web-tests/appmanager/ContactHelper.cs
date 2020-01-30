using NUnit.Framework;
using OpenQA.Selenium;
using System.IO;

namespace WebAddressbookTests
{
    public class ContactHelper : HelperBase
    {
        public ContactHelper(ApplicationManager manager) : base(manager) {}

        public void InitContactCreation()
        {
            driver.FindElement(By.XPath("//a[@href='edit.php']")).Click();
        }

        public void Create(ContactData defaultContact)
        {
            FillContactForm(defaultContact);
            SelectBirthday(defaultContact);
            SelectAnniversaryDate(defaultContact);
            SubmitContactCreation();
        }

        public void Remove(string index)
        {
            Select(index);
            SubmitContactRemoval();
            ConfirmRemovealPopUp();
        }

        public void Modify(ContactData modifiedContact)
        {
            manager.Navigator.GoToHomePage();
            InitTopContactModification();
            FillContactForm(modifiedContact);
            SubmitContactModification();
        }

        public ContactHelper Select(string index)
        {
            driver.FindElement(By.XPath("(//input[@name='selected[]'])[" + index + "]")).Click();
            return this;
        }

        public void FillContactForm(ContactData contact)
        {
            ClearAndFillTextField("firstname", contact.FirstName);
            ClearAndFillTextField("middlename", contact.MiddleName);
            ClearAndFillTextField("lastname", contact.LastName);
            ClearAndFillTextField("nickname", contact.Nickname);
            
            string fileName = "testAvatar.png";
            string dirName = @"TestImages\";
            string pathToFile = Path.Combine(TestContext.CurrentContext.TestDirectory, dirName, fileName);
            ClearAndFillTextField("photo", pathToFile);

            ClearAndFillTextField("title", contact.Title);
            ClearAndFillTextField("company", contact.Company);
            ClearAndFillTextField("address", contact.Address);
            ClearAndFillTextField("home", contact.PhoneHome);
            ClearAndFillTextField("mobile", contact.PhoneMobile);
            ClearAndFillTextField("work", contact.PhoneWork);
            ClearAndFillTextField("fax", contact.PhoneFax);
            ClearAndFillTextField("email", contact.Email1);
            ClearAndFillTextField("email2", contact.Email2);
            ClearAndFillTextField("email3", contact.Email3);
            ClearAndFillTextField("homepage", contact.Homepage);
            ClearAndFillTextField("address2", contact.SecondaryAddress);
            ClearAndFillTextField("phone2", contact.SecondaryHome);
            ClearAndFillTextField("notes", contact.SecondaryNotes);
        }

        public void SelectBirthday(ContactData contact)
        {
            driver.FindElement(By.Name("bday")).Click();
            driver.FindElement(By.XPath($"//select[@name='bday']/option[@value='{contact.BirthDay}']")).Click();
            driver.FindElement(By.Name("bmonth")).Click();
            driver.FindElement(By.XPath($"//select[@name='bmonth']/option[@value='{contact.BirthMonth}']")).Click();
            driver.FindElement(By.Name("byear")).Click();
            driver.FindElement(By.Name("byear")).SendKeys(contact.BirthYear);
        }

        public void SelectAnniversaryDate(ContactData contact)
        {
            driver.FindElement(By.Name("aday")).Click();
            driver.FindElement(By.XPath($"//select[@name='aday']/option[@value='{contact.AnniversaryDay}']")).Click();
            driver.FindElement(By.Name("amonth")).Click();
            driver.FindElement(By.XPath($"//select[@name='amonth']/option[@value='{contact.AnniversaryMonth}']")).Click();
            driver.FindElement(By.Name("ayear")).Click();
            driver.FindElement(By.Name("ayear")).SendKeys(contact.AnniversaryYear);
        }

        public void SubmitContactCreation()
        {
            driver.FindElement(By.CssSelector("input[type='submit']~input[type='submit']")).Click();
        }

        public ContactHelper SubmitContactRemoval()
        {
            driver.FindElement(By.CssSelector("input[type='button'][value='Delete']")).Click();
            return this;
        }

        public ContactHelper SubmitContactModification()
        {
            driver.FindElement(By.CssSelector("input[type='submit'][value='Update']")).Click();
            return this;
        }

        public ContactHelper ConfirmRemovealPopUp()
        {
            driver.SwitchTo().Alert().Accept();
            return this;
        }

        public ContactHelper InitTopContactModification()
        {
            driver.FindElement
                (By.CssSelector("tr:nth-child(2) > .center:nth-child(8) a")) //locate the top contact in the table
                .Click();
            return this;
        }

        public ContactHelper ClearAndFillTextField(string fieldName, string newValue)
        {
            driver.FindElement(By.Name(fieldName)).Clear();
            driver.FindElement(By.Name(fieldName)).SendKeys(newValue);
            return this;
        }
    }
}
