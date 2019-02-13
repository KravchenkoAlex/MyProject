using NUnit.Framework;

namespace MyProject
{
    class ContactCreationTests : BaseTest
    {
        [Test]
        public void ContectCreationTest()
        {
            GoToHomePage();
            Login(new AccountData
            {
                Username = "admin",
                Password = "secret"
            });
            InitContactCreation();
            ContactData contactData = new ContactData
            {
                FirstName = "Alex",
                LastName = "Kravchenko"
            };
            FillContactFields(contactData);
            SubmitCreation();
            ReturnToHomePage();
        }
    }
}
