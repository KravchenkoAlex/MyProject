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
            LoginHelper = new LoginHelper(this);
            NavigationHelper = new NavigationHelper(this);
            GroupHelper = new GroupHelper(this);
            ContactHelper = new ContactHelper(this);
            BaseHelper = new BaseHelper(this);
        }

        public IWebDriver Driver
        {
            get
            {
                return driver;
            }
        }

        public void Stop()
        {
            driver.Quit();
        }
    }
}
