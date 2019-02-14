using OpenQA.Selenium;

namespace MyProject
{
    public class NavigationHelper : BaseHelper
    {
        private string baseUrl = "http://localhost:8089/addressbook/";

        public NavigationHelper(HelpersManager helpersManager) : base(helpersManager)
        {
        }

        public NavigationHelper GoToGroupsPage()
        {
            driver.FindElement(By.LinkText("groups")).Click();
            return this;
        }

        public NavigationHelper GoToHomePage()
        {
            driver.Navigate().GoToUrl(baseUrl);
            return this;
        }

        public NavigationHelper NavigateToHome()
        {
            driver.FindElement(By.LinkText("home")).Click();
            return this;
        }

        public NavigationHelper InitContactCreation()
        {
            driver.FindElement(By.LinkText("add new")).Click();
            return this;
        }
    }
}
