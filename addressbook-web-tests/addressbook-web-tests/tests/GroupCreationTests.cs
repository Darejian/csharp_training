using NUnit.Framework;

namespace WebAddressbookTests
{
    [TestFixture]
    public class GroupCreationTests : TestBase
    { 
        [Test]
        public void GroupCreationTest()
        {
            GroupData group = new GroupData();
            app.Group.Create(group);
            app.Navigator.ReturnToGroupsPage();
        }

        [Test]
        public void EmptyGroupCreationTest()
        {
            GroupData group = new GroupData();
            group.Name = "";
            group.Header = "";
            group.Footer = "";

            app.Group.Create(group);
            app.Navigator.ReturnToGroupsPage();
        }
    }
}
