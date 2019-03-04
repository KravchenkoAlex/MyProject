using NUnit.Framework;

namespace MyProject
{
    [TestFixture]
    public class ContactModificationTests : AuthBaseTest
    {
        [Test]
        public void ContactModificationTest()
        {
            #region SetUp Data
            ContactData contactData = new ContactData
            {
                FirstName = "Alex123",
                LastName = "Kravchenko321"
            };
            #endregion

            helpersManager.ContactHelper.Modify(1, contactData);
        }
    }
}
