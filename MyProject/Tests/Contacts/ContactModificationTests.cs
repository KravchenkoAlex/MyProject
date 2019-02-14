using NUnit.Framework;

namespace MyProject
{
    [TestFixture]
    public class ContactModificationTests : BaseTest
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
