using OpenQA.Selenium;

namespace MyProject
{
    public class BaseHelper
    {
        protected IWebDriver driver;
        protected HelpersManager helpersManager;
        
        public BaseHelper(HelpersManager helpersManager)
        {
            this.helpersManager = helpersManager;
            this.driver = helpersManager.Driver;
        }

        public BaseHelper SubmitCreation()
        {
            driver.FindElement(By.Name("submit")).Click();
            return this;
        }

        public BaseHelper ReturnToHomePage()
        {
            driver.FindElement(By.LinkText("home page")).Click();
            return this;
        }
    }
}
