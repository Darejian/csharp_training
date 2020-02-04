namespace WebAddressbookTests
{
    public class ContactBuilder
    {
        private readonly ContactFixtureBuilder contactFixtureBuilder;
        private readonly ApplicationManager manager;

        public ContactBuilder(ApplicationManager manager)
        {
            this.contactFixtureBuilder = new ContactFixtureBuilder();
            this.manager = manager;
        }

        public ContactBuilder WithFirstName(string firstName)
        {
            this.contactFixtureBuilder.WithFirstName(firstName);
            return this;
        }
        public ContactBuilder WithMiddleName(string middleName)
        {
            this.contactFixtureBuilder.WithMiddleName(middleName);
            return this;
        }

        public ContactBuilder WithLastName(string lastName)
        {
            this.contactFixtureBuilder.WithLastName(lastName);
            return this;
        }

        public ContactBuilder WithNickname(string nickname)
        {
            this.contactFixtureBuilder.WithNickname(nickname);
            return this;
        }

        public ContactBuilder WithPhotoPath(string photoPath)
        {
            this.contactFixtureBuilder.WithPhotoName(photoPath);
            return this;
        }

        public ContactBuilder WithTitle(string title)
        {
            this.contactFixtureBuilder.WithTitle(title);
            return this;
        }

        public ContactBuilder WithCompany(string company)
        {
            this.contactFixtureBuilder.WithCompany(company);
            return this;
        }

        public ContactBuilder WithAddress(string address)
        {
            this.contactFixtureBuilder.WithAddress(address);
            return this;
        }

        public ContactBuilder WithPhoneHome(string phoneHome)
        {
            this.contactFixtureBuilder.WithPhoneHome(phoneHome);
            return this;
        }

        public ContactBuilder WithPhoneMobile(string phoneMobile)
        {
            this.contactFixtureBuilder.WithPhoneMobile(phoneMobile);
            return this;
        }

        public ContactBuilder WithPhoneWork(string phoneWork)
        {
            this.contactFixtureBuilder.WithPhoneWork(phoneWork);
            return this;
        }

        public ContactBuilder WithPhoneFax(string phoneFax)
        {
            this.contactFixtureBuilder.WithPhoneFax(phoneFax);
            return this;
        }

        public ContactBuilder WithEmail1(string email1)
        {
            this.contactFixtureBuilder.WithEmail1(email1);
            return this;
        }

        public ContactBuilder WithEmail2(string email2)
        {
            this.contactFixtureBuilder.WithEmail2(email2);
            return this;
        }

        public ContactBuilder WithEmail3(string email3)
        {
            this.contactFixtureBuilder.WithEmail3(email3);
            return this;
        }

        public ContactBuilder WithHomepage(string homepage)
        {
            this.contactFixtureBuilder.WithHomepage(homepage);
            return this;
        }

        public ContactBuilder WithBirthDay(string birthDay)
        {
            this.contactFixtureBuilder.WithBirthDay(birthDay);
            return this;
        }

        public ContactBuilder WithBirthMonth(string birthMonth)
        {
            this.contactFixtureBuilder.WithBirthMonth(birthMonth);
            return this;
        }

        public ContactBuilder WithBirthYear(string birthYear)
        {
            this.contactFixtureBuilder.WithBirthYear(birthYear);
            return this;
        }

        public ContactBuilder WithAnniversaryDay(string anniversaryDay)
        {
            this.contactFixtureBuilder.WithAnniversaryDay(anniversaryDay);
            return this;
        }

        public ContactBuilder WithAnniversaryMonth(string anniversaryMonth)
        {
            this.contactFixtureBuilder.WithAnniversaryMonth(anniversaryMonth);
            return this;
        }

        public ContactBuilder WithAnniversaryYear(string anniversaryYear)
        {
            this.contactFixtureBuilder.WithAnniversaryYear(anniversaryYear);
            return this;
        }

        public ContactBuilder WithGroup(string group)
        {
            this.contactFixtureBuilder.WithGroup(group);
            return this;
        }

        public ContactBuilder WithSecondaryAddress(string secondaryAddress)
        {
            this.contactFixtureBuilder.WithSecondaryAddress(secondaryAddress);
            return this;
        }

        public ContactBuilder WithSecondaryHome(string secondaryHome)
        {
            this.contactFixtureBuilder.WithSecondaryHome(secondaryHome);
            return this;
        }

        public ContactBuilder WithSecondaryNotes(string secondaryNotes)
        {
            this.contactFixtureBuilder.WithSecondaryNotes(secondaryNotes);
            return this;
        }

        public void Build()
        {
            var createContactFixture = this.contactFixtureBuilder.Build();
            this.manager.Contact.Create(createContactFixture);
        }
    }
}
