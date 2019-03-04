using NUnit.Framework;

namespace MyProject
{
    public class AuthBaseTest : BaseTest
    {
        [SetUp]
        public void SetupLogin()
        {
            #region TestData
            AccountData accountData = new AccountData
            {
                Username = "admin",
                Password = "secret"
            };
            #endregion
            
            helpersManager.LoginHelper.Login(accountData);
        }
    }
}
