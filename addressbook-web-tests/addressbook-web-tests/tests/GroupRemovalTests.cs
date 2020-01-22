using NUnit.Framework;

namespace WebAddressbookTests
{
    [TestFixture]
    public class GroupRemovalTests : TestBase
    {
        [Test]
        public void GroupRemovalTest()
        {
            app.Group.Remove(1);
            app.Navigator.ReturnToGroupsPage();
        }
    }
}
