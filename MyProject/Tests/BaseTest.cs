using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace MyProject
{
    public class BaseTest
    {
        protected HelpersManager helpersManager;

        [SetUp]
        public void SetupTest()
        {
            helpersManager = new HelpersManager();
        }

        [TearDown]
        public void TeardownTest()
        {
            helpersManager.Stop();
        }
    }
}
