using OpenQA.Selenium;

namespace MyProject
{
    public class NavigationHelper : BaseHelper
    {
        private string baseUrl = "http://localhost:8089/addressbook/";

        public NavigationHelper(HelpersManager helpersManager) : base(helpersManager)
        {
        }

        public void GoToGroupsPage()
        {
            if (driver.Url == baseUrl + "group.php"
                && IsElementPresent(By.Name("new")))
            {
                return;
            }

            driver.FindElement(By.LinkText("groups")).Click();
        }

        public void GoToHomePage()
        {
            if (driver.Url == baseUrl)
            {
                return;
            }

            driver.Navigate().GoToUrl(baseUrl);
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
