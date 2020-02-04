namespace WebAddressbookTests
{
    public class GroupBuilder
    {
        private readonly GroupFixtureBuilder groupFixtureBuilder;
        private readonly ApplicationManager manager;

        public GroupBuilder(ApplicationManager manager)
        {
            this.groupFixtureBuilder = new GroupFixtureBuilder();
            this.manager = manager;
        }
        public GroupBuilder WithName(string name)
        {
            this.groupFixtureBuilder.WithName(name);
            return this;
        }
        public GroupBuilder WithHeader(string header)
        {
            this.groupFixtureBuilder.WithHeader(header);
            return this;
        }
        public GroupBuilder WithFooter(string footer)
        {
            this.groupFixtureBuilder.WithFooter(footer);
            return this;
        }

        public void Build()
        {
            var createGroupFixture = this.groupFixtureBuilder.Build();
            this.manager.Group.Create(createGroupFixture);
        }
    }
}
