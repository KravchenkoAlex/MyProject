using NUnit.Framework;

namespace MyProject
{
    [TestFixture]
    public class GroupRemovalTests : BaseTest
    {
        [Test]
        public void GroupRemovalTest()
        {
            helpersManager.GroupHelper.Remove(1);
        }
    }
}
