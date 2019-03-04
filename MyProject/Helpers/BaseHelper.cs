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

        public BaseHelper SubmitUpdate()
        {
            driver.FindElement(By.XPath("//input[@value='Update']")).Click();
            return this;
        }

        public void Type(By locator, string text)
        {
            if (text != null)
            {
                driver.FindElement(locator).Clear();
                driver.FindElement(locator).SendKeys(text);
            }
        }

        public bool IsElementPresent(By by)
        {
            try
            {
                driver.FindElement(by);
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }
    }
}
