using NUnit.Framework;

namespace MyProject
{
    class ContactCreationTests : BaseTest
    {
        [Test]
        public void ContectCreationTest()
        {
            helpersManager.NavigationHelper.GoToHomePage();
            helpersManager.LoginHelper.Login(new AccountData
            {
                Username = "admin",
                Password = "secret"
            });
            helpersManager.ContactHelper.InitContactCreation();
            ContactData contactData = new ContactData
            {
                FirstName = "Alex",
                LastName = "Kravchenko"
            };
            helpersManager.ContactHelper.FillContactFields(contactData);
            helpersManager.BaseHelper.SubmitCreation();
            helpersManager.BaseHelper.ReturnToHomePage();
        }
    }
}
