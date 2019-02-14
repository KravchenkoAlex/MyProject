using NUnit.Framework;

namespace MyProject
{
    public class BaseTest
    {
        protected HelpersManager helpersManager;

        [SetUp]
        public void SetupTest()
        {
            #region TestData
            AccountData accountData = new AccountData
            {
                Username = "admin",
                Password = "secret"
            };
            #endregion

            helpersManager = new HelpersManager();
            helpersManager.NavigationHelper.GoToHomePage();
            helpersManager.LoginHelper.Login(accountData);
        }

        [TearDown]
        public void TeardownTest()
        {
            helpersManager.Stop();
        }
    }
}
