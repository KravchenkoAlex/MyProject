using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace MyProject
{
    public class TestBase
    {
        protected IWebDriver driver;

        [SetUp]
        public void SetupTest()
        {
            driver = new ChromeDriver();
        }

        [TearDown]
        public void TeardownTest()
        {
            driver.Quit();
        }
    }
}
