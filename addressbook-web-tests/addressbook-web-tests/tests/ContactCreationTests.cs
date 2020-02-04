using NUnit.Framework;

namespace WebAddressbookTests 
{
    [TestFixture]
    public class ContactCreationTests : TestBase
    {
        [Test]
        public void CreateContactTest()
        {
            app.ContactBuilder.Build();
        }
    }
}
