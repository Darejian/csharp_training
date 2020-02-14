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
            var newGroupDataModel = GroupFixtureBuilder.CreateNew().Build();       
            app.Group.Modify(groupId, newGroupDataModel);
        }
    }
}
