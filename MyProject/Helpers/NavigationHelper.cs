using OpenQA.Selenium;

namespace MyProject
{
    public class NavigationHelper : BaseHelper
    {
        private string baseUrl = "http://localhost:8089/addressbook/";

        public NavigationHelper(IWebDriver driver) : base(driver)
        {
        }

        public void GoToGroupsPage()
        {
            driver.FindElement(By.LinkText("groups")).Click();
        }

        public void GoToHomePage()
        {
            driver.Navigate().GoToUrl(baseUrl);
        }
    }
}
