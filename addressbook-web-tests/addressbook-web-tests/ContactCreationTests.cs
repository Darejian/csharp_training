using NUnit.Framework;

namespace WebAddressbookTests 
{

    [TestFixture]
    public class ContactCreationTests : TestBase
    {
        [Test]
        public void createContact()
        {
            OpenHomePage();
            Login(new AccountData("admin", "secret"));
            InitContactCreation();
            ContactData defaultContact = new ContactData();
            FillContactForm(defaultContact);
            SelectBirthday(defaultContact);
            SelectAnniversaryDate(defaultContact);
            SubmitContactCreation();
            Logout();
        }
    }
}
