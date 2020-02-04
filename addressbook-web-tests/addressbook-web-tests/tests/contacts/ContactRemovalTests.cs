using NUnit.Framework;

namespace WebAddressbookTests
{
    [TestFixture]
    public class ContactRemovalTests : TestBase
    {
        [Test]
        public void ContactRemovalTest()
        {
            string contactIndex = "1";
            app.Contact.Remove(contactIndex);
        }
    }
}
