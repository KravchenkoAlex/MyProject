using NUnit.Framework;

namespace MyProject
{
    [TestFixture]
    public class GroupCreationTests : AuthBaseTest
    {
        [Test]
        public void GroupCreationTest()
        {
            #region SetUp Data
            GroupData groupData = new GroupData
            {
                Name = "aaa",
                Header = "bbb",
                Footer = "ccc"
            };
            #endregion

            helpersManager.GroupHelper.Create(groupData);
        }

        [Test]
        public void EmptyGroupCreationTest()
        {
            #region SetUp Data
            GroupData groupData = new GroupData
            {
                Name = "",
                Header = "",
                Footer = ""
            };
            #endregion

            helpersManager.GroupHelper.Create(groupData);
        }
    }
}
