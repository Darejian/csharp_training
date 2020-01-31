using NUnit.Framework;

namespace WebAddressbookTests 
{
    [TestFixture]
    public class ContactCreationTests : TestBase
    {
        [Test]
        public void CreateContactTest()
        {
            ContactData defaultContact = new ContactData();
            app.Contact.Create(defaultContact);
        }
    }
}
