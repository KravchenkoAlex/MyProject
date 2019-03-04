using NUnit.Framework;

namespace MyProject
{
    [TestFixture]
    class GroupModificationTests : AuthBaseTest
    {
        [Test]
        public void GroupModificationTest()
        {
            #region SetUp Data
            GroupData groupData = new GroupData
            {
                Name = "111",
                Header = null,
                Footer = null
            };
            #endregion

            helpersManager.GroupHelper.Modify(1, groupData);
        }
    }
}
