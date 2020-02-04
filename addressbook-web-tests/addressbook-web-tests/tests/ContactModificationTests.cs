using NUnit.Framework;

namespace WebAddressbookTests
{
    [TestFixture]
    public class ContactModificationTests : TestBase
    {
        [Test]
        public void ContactModifyAllFields()
        {
            int contactIndex = 1;
            ContactData modifiedContact = app.Contact.NewContactData();
            app.Contact.Modify(contactIndex, modifiedContact);
        }
    }
}
