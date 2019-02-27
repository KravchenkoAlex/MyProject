using NUnit.Framework;

namespace MyProject
{
    public class BaseTest
    {
        protected HelpersManager helpersManager;

        [SetUp]
        public void SetupTest()
        {
            helpersManager = HelpersManager.GetInstance();
        }
    }
}
