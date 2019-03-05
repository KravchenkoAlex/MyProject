using NUnit.Framework;

namespace MyProject
{
    class ContactCreationTests : AuthBaseTest
    {
        [Test]
        public void ContactCreationTest()
        {
            #region SetUpData
            ContactData contactData = new ContactData
            {
                FirstName = "Alex",
                LastName = "Kravchenko"
            };
            #endregion

            helpersManager.ContactHelper.Create(contactData);
        }
    }
}
