using NUnit.Framework;

namespace WebAddressbookTests 
{

    [TestFixture]
    public class ContactCreationTests : TestBase
    {
        [Test]
        public void createContact()
        {
            navigator.GoToHomePage("http://localhost/addressbook/");
            loginHelper.Login(new AccountData("admin", "secret"));
            contactHelper.InitContactCreation();
            ContactData defaultContact = new ContactData();
            contactHelper.FillContactForm(defaultContact);
            contactHelper.SelectBirthday(defaultContact);
            contactHelper.SelectAnniversaryDate(defaultContact);
            contactHelper.SubmitContactCreation();
            loginHelper.Logout();
        }
    }
}
