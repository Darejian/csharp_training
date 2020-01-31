using OpenQA.Selenium;

namespace WebAddressbookTests
{
    public class GroupHelper : HelperBase
    {
        public GroupHelper(ApplicationManager manager) : base(manager) {}

        public GroupHelper Create(GroupData group)
        {
            manager.Navigator.GoToGroupsPage();
            InitGroupCreation();
            FillGroupForm(group);
            SubmitGroupCreation();
            return this;
        }

        public GroupHelper Remove(string groupId)
        {
            manager.Navigator.GoToGroupsPage();
            SelectGroup(groupId);
            DeleteGroup();
            return this;
        }

        public GroupHelper Modify(string groupIndex, GroupData newData)
        {
            manager.Navigator.GoToGroupsPage();
            SelectGroup(groupIndex);
            InitGroupModification();
            FillGroupForm(newData);
            SubmitGroupModification();
            return this;
        }

        public GroupHelper InitGroupCreation()
        {
            driver.FindElement(By.Name("new")).Click();
            return this;
        }

        public GroupHelper FillGroupForm(GroupData group)
        {

            ClearAndFillTextField("group_name", group.Name);
            ClearAndFillTextField("group_header", group.Header);
            ClearAndFillTextField("group_footer", group.Footer);
            return this;
        }

        public GroupHelper SubmitGroupCreation()
        {
            driver.FindElement(By.Name("submit")).Click();
            return this;
        }

        public GroupHelper SelectGroup(string index)
        {
            driver.FindElement(By.XPath("(//input[@name='selected[]'])[" + index + "]")).Click();
            return this;
        }

        public GroupHelper DeleteGroup()
        {
            driver.FindElement(By.Name("delete")).Click();
            return this;
        }

        public GroupHelper InitGroupModification()
        {
            driver.FindElement(By.Name("edit")).Click();
            return this;
        }

        public GroupHelper SubmitGroupModification()
        {
            driver.FindElement(By.Name("update")).Click();
            return this;
        }
    }
}
