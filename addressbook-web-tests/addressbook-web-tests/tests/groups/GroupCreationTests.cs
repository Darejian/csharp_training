using NUnit.Framework;

namespace WebAddressbookTests
{
    [TestFixture]
    public class GroupCreationTests : TestBase
    { 
        [Test]
        public void GroupCreationTest()
        {
            app.GroupBuilder.Build(); 
            app.Navigator.ReturnToGroupsPage();
        }

        [Test]
        public void EmptyGroupCreationTest()
        {
            app.GroupBuilder
                .WithName("")
                .WithHeader("")
                .WithFooter("")
                .Build();
            app.Navigator.ReturnToGroupsPage();
        }
    }
}
