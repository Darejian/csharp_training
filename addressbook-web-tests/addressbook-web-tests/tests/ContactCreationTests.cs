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
            app.Contact.Create(defaultContact);
        }
    }
}
