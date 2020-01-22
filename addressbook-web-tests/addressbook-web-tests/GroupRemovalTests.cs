using NUnit.Framework;

namespace WebAddressbookTests
{
    [TestFixture]
    public class GroupRemovalTests : TestBase
    {
        [Test]
        public void GroupRemovalTest()
        {
            navigator.GoToHomePage("http://localhost/addressbook/");
            loginHelper.Login(new AccountData("admin", "secret"));
            navigator.GoToGroupsPage();
            groupHelper.SelectGroup("1");
            groupHelper.DeleteGroup();
            navigator.ReturnToGroupsPage();
            loginHelper.Logout();
        }
    }
}
