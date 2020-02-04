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
            var newContactDataModel = new ContactFixtureBuilder().Build();
            app.Contact.Modify(contactIndex, newContactDataModel);
        }
    }
}
