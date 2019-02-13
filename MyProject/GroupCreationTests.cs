using NUnit.Framework;

namespace MyProject
{
    [TestFixture]
    public class GroupCreationTests : BaseTest
    {
        [Test]
        public void GroupCreationTest()
        {
            GoToHomePage();
            Login(new AccountData { Username = "admin", Password = "secret" });
            GoToGroupsPage();
            InitGroupCreation();
            GroupData groupData = new GroupData
            {
                Name = "aaa",
                Header = "bbb",
                Footer = "ccc"
            };
            FillGroupFields(groupData);
            SubmitCreation();
            ReturnToGroupsPage();
        }

        [Test]
        public void GroupRemovalTest()
        {
            GoToHomePage();
            Login(new AccountData { Username = "admin", Password = "secret" });
            GoToGroupsPage();
            SelectGroup(1);
            RemoveGroup();
            ReturnToGroupsPage();
        }
    }
}
