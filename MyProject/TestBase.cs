using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace MyProject
{
    public class TestBase
    {
        protected static IWebDriver driver;
        
        [OneTimeSetUp]
        public void SetupTest()
        {
            driver = new ChromeDriver();
        }

        [OneTimeTearDown]
        public void TeardownTest()
        {
            driver.Quit();
        }
    }
}
