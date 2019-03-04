using NUnit.Framework;

namespace MyProject
{
    [TestFixture]
    public class GroupRemovalTests : AuthBaseTest
    {
        [Test]
        public void GroupRemovalTest()
        {
            helpersManager.GroupHelper.Remove(1);
        }
    }
}
