using NUnit.Framework;

namespace WebAddressbookTests
{
    [TestFixture]
    public class GroupRemovalTests : TestBase
    {
        [Test]
        public void GroupRemovalTest()
        {
            string groupIndex = "1";
            app.Group.Remove(groupIndex);
            app.Navigator.ReturnToGroupsPage();
        }
    }
}
