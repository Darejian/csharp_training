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
            GroupData newData = new GroupData();
            newData.Name = "zzz";
            newData.Header = "ttt";
            newData.Footer = "qqq";    

            app.Group.Modify(groupId, newData);
        }
    }
}
