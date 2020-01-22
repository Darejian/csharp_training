using NUnit.Framework;

namespace WebAddressbookTests 
{

    [TestFixture]
    public class ContactCreationTests : TestBase
    {
        [Test]
        public void CreateContact()
        {
            app.Contact.InitContactCreation();
            ContactData defaultContact = new ContactData();
            app.Contact.FillContactForm(defaultContact);
            app.Contact.SelectBirthday(defaultContact);
            app.Contact.SelectAnniversaryDate(defaultContact);
            app.Contact.SubmitContactCreation();
        }
    }
}
