using NUnit.Framework;

namespace MyProject
{
    [TestFixture]
    public class ContactRemovalTests : BaseTest
    {
        [Test]
        public void ContactRemovalTest()
        {
            helpersManager.ContactHelper.Remove(1);
        }
    }
}
