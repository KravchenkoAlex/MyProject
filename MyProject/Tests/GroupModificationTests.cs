using NUnit.Framework;

namespace MyProject
{
    [TestFixture]
    class GroupModificationTests : BaseTest
    {
        [Test]
        public void GroupModificationTest()
        {
            #region SetUp Data
            GroupData groupData = new GroupData
            {
                Name = "111",
                Header = "222",
                Footer = "333"
            };
            #endregion

            helpersManager.GroupHelper.Modify(1, groupData);
        }
    }
}
