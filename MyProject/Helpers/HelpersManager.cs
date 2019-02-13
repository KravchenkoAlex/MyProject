using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace MyProject
{
    public class HelpersManager
    {
        protected IWebDriver driver;

        public LoginHelper LoginHelper { get; }
        public NavigationHelper NavigationHelper { get; }
        public GroupHelper GroupHelper { get; }
        public ContactHelper ContactHelper { get; }
        public BaseHelper BaseHelper { get; }

        public HelpersManager()
        {
            driver = new ChromeDriver();
            LoginHelper = new LoginHelper(driver);
            NavigationHelper = new NavigationHelper(driver);
            GroupHelper = new GroupHelper(driver);
            ContactHelper = new ContactHelper(driver);
            BaseHelper = new BaseHelper(driver);
        }

        public void Stop()
        {
            driver.Quit();
        }
    }
}
