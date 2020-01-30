using NUnit.Framework;

namespace WebAddressbookTests
{
    [TestFixture]
    public class ContactModificationTests : TestBase
    {
        [Test]
        public void ContactModifyAllFields()
        {
            ContactData modifiedContact = new ContactData();
            modifiedContact.FirstName = "New First Name";
            modifiedContact.LastName = "New Last Name";
            app.Contact.Modify(modifiedContact);
        }
    }
}
