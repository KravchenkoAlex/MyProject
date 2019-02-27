using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;

namespace MyProject
{
    public class HelpersManager
    {
        protected IWebDriver driver;
        private static ThreadLocal<HelpersManager> instance = new ThreadLocal<HelpersManager>();

        public LoginHelper LoginHelper { get; }
        public NavigationHelper NavigationHelper { get; }
        public GroupHelper GroupHelper { get; }
        public ContactHelper ContactHelper { get; }
        public BaseHelper BaseHelper { get; }

        private HelpersManager()
        {
            driver = new ChromeDriver();
            LoginHelper = new LoginHelper(this);
            NavigationHelper = new NavigationHelper(this);
            GroupHelper = new GroupHelper(this);
            ContactHelper = new ContactHelper(this);
            BaseHelper = new BaseHelper(this);
        }

        ~HelpersManager()
        {
            driver.Quit();
        }

        public static HelpersManager GetInstance()
        {
            if (! instance.IsValueCreated)
            {
                instance.Value = new HelpersManager();
            }

            return instance.Value;
        }

        public IWebDriver Driver
        {
            get
            {
                return driver;
            }
        }
    }
}
