using NUnit.Framework;

namespace MyProject
{
    [TestFixture]
    public class ContactRemovalTests : AuthBaseTest
    {
        [Test]
        public void ContactRemovalTest()
        {
            helpersManager.ContactHelper.Remove(1);
        }
    }
}
