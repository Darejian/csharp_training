using NUnit.Framework;

namespace WebAddressbookTests
{
    [TestFixture]
    public class ContactModificationTests : TestBase
    {
        [Test]
        public void ContactModifyAllFields()
        {
            string contactId = "44";
            ContactData modifiedContact = app.Contact.NewContactData();
            app.Contact.Modify(contactId, modifiedContact);
        }
    }
}
