using NUnit.Framework;

namespace MyProject
{
    [TestFixture]
    public class GroupCreationTests : BaseTest
    {
        [Test]
        public void GroupCreationTest()
        {
            helpersManager.NavigationHelper.GoToHomePage();
            helpersManager.LoginHelper.Login(new AccountData { Username = "admin", Password = "secret" });
            helpersManager.NavigationHelper.GoToGroupsPage();
            helpersManager.GroupHelper.InitGroupCreation();
            GroupData groupData = new GroupData
            {
                Name = "aaa",
                Header = "bbb",
                Footer = "ccc"
            };
            helpersManager.GroupHelper.FillGroupFields(groupData);
            helpersManager.BaseHelper.SubmitCreation();
            helpersManager.GroupHelper.ReturnToGroupsPage();
        }

        [Test]
        public void GroupRemovalTest()
        {
            helpersManager.NavigationHelper.GoToHomePage();
            helpersManager.LoginHelper.Login(new AccountData { Username = "admin", Password = "secret" });
            helpersManager.NavigationHelper.GoToGroupsPage();
            helpersManager.GroupHelper.SelectGroup(1);
            helpersManager.GroupHelper.RemoveGroup();
            helpersManager.GroupHelper.ReturnToGroupsPage();
        }
    }
}
