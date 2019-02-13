using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace MyProject
{
    public class BaseTest
    {
        protected IWebDriver driver;
        protected LoginHelper loginHelper;
        protected NavigationHelper navigationHelper;
        protected GroupHelper groupHelper;
        protected ContactHelper contactHelper;
        protected BaseHelper baseHelper;

        [SetUp]
        public void SetupTest()
        {
            driver = new ChromeDriver();
            loginHelper = new LoginHelper(driver);
            navigationHelper = new NavigationHelper(driver);
            groupHelper = new GroupHelper(driver);
            contactHelper = new ContactHelper(driver);
            baseHelper = new BaseHelper(driver);
        }

        [TearDown]
        public void TeardownTest()
        {
            driver.Quit();
        }
    }
}
