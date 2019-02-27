using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject
{
    [SetUpFixture]
    public class TestSuiteFixture
    {
        [OneTimeSetUp]
        public void InitHelpersManager()
        {
            #region TestData
            AccountData accountData = new AccountData
            {
                Username = "admin",
                Password = "secret"
            };
            #endregion

            HelpersManager helpersManager = HelpersManager.GetInstance();
            helpersManager.NavigationHelper.GoToHomePage();
            helpersManager.LoginHelper.Login(accountData);
        }
    }
}
