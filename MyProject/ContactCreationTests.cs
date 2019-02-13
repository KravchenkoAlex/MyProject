using NUnit.Framework;

namespace MyProject
{
    class ContactCreationTests : BaseTest
    {
        [Test]
        public void ContectCreationTest()
        {
            navigationHelper.GoToHomePage();
            loginHelper.Login(new AccountData
            {
                Username = "admin",
                Password = "secret"
            });
            contactHelper.InitContactCreation();
            ContactData contactData = new ContactData
            {
                FirstName = "Alex",
                LastName = "Kravchenko"
            };
            contactHelper.FillContactFields(contactData);
            baseHelper.SubmitCreation();
            baseHelper.ReturnToHomePage();
        }
    }
}
