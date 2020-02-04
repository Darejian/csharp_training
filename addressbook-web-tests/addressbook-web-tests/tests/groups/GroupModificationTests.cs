using NUnit.Framework;

namespace WebAddressbookTests
{
    [TestFixture]
    public class GroupModificationTests : TestBase
    {
        [Test]
        public void GroupModificationTest()
        {
            string groupId = "1";
            var newGroupDataModel = new GroupFixtureBuilder().Build();      
            app.Group.Modify(groupId, newGroupDataModel);
        }
    }
}
