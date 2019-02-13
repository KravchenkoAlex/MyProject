using NUnit.Framework;

namespace MyProject
{
    [TestFixture]
    public class GroupCreationTests : BaseTest
    {
        [Test]
        public void GroupCreationTest()
        {
            navigationHelper.GoToHomePage();
            loginHelper.Login(new AccountData { Username = "admin", Password = "secret" });
            navigationHelper.GoToGroupsPage();
            groupHelper.InitGroupCreation();
            GroupData groupData = new GroupData
            {
                Name = "aaa",
                Header = "bbb",
                Footer = "ccc"
            };
            groupHelper.FillGroupFields(groupData);
            baseHelper.SubmitCreation();
            groupHelper.ReturnToGroupsPage();
        }

        [Test]
        public void GroupRemovalTest()
        {
            navigationHelper.GoToHomePage();
            loginHelper.Login(new AccountData { Username = "admin", Password = "secret" });
            navigationHelper.GoToGroupsPage();
            groupHelper.SelectGroup(1);
            groupHelper.RemoveGroup();
            groupHelper.ReturnToGroupsPage();
        }
    }
}
