using NUnit.Framework;

namespace MyProject
{
    public class LoginTests : BaseTest
    {
        [Test]
        public void LoginWithValidCredentials()
        {
            #region TestData
            AccountData accountData = new AccountData
            {
                Username = "admin",
                Password = "secret"
            };

            helpersManager.LoginHelper.Logout();
            #endregion
            
            helpersManager.LoginHelper.Login(accountData);

            Assert.IsTrue(helpersManager.LoginHelper.IsLoggedIn(accountData));
        }

        [Test]
        public void LoginWithInValidCredentials()
        {
            #region TestData
            AccountData accountData = new AccountData
            {
                Username = "admin",
                Password = "123123"
            };

            helpersManager.LoginHelper.Logout();
            #endregion

            helpersManager.LoginHelper.Login(accountData);

            Assert.IsFalse(helpersManager.LoginHelper.IsLoggedIn(accountData));
        }
    }
}
