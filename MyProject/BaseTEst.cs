using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace MyProject
{
    public class BaseTest
    {
        protected IWebDriver driver;
        private string baseUrl = "http://localhost:8089/addressbook/";

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

        protected void RemoveGroup()
        {
            driver.FindElement(By.XPath("//input[@name='delete'][1]")).Click();
        }

        protected void SelectGroup(int index)
        {
            driver.FindElement(By.XPath($"//input[@name='selected[]'][{index}]")).Click();
        }

        protected void Login(AccountData accountData)
        {
            driver.FindElement(By.Name("user")).Clear();
            driver.FindElement(By.Name("user")).SendKeys(accountData.Username);
            driver.FindElement(By.Name("pass")).Clear();
            driver.FindElement(By.Name("pass")).SendKeys(accountData.Password);
            driver.FindElement(By.XPath("//input[@type='submit']")).Click();
        }

        protected void ReturnToGroupsPage()
        {
            driver.FindElement(By.LinkText("group page")).Click();
        }

        protected void SubmitCreation()
        {
            driver.FindElement(By.Name("submit")).Click();
        }

        protected void FillGroupFields(GroupData groupData)
        {
            driver.FindElement(By.Name("group_name")).Clear();
            driver.FindElement(By.Name("group_name")).SendKeys(groupData.Name);
            driver.FindElement(By.Name("group_header")).Clear();
            driver.FindElement(By.Name("group_header")).SendKeys(groupData.Header);
            driver.FindElement(By.Name("group_footer")).Clear();
            driver.FindElement(By.Name("group_footer")).SendKeys(groupData.Footer);
        }

        protected void InitGroupCreation()
        {
            driver.FindElement(By.Name("new")).Click();
        }

        protected void GoToGroupsPage()
        {
            driver.FindElement(By.LinkText("groups")).Click();
        }

        protected void GoToHomePage()
        {
            driver.Navigate().GoToUrl(baseUrl);
        }

        protected void FillContactFields(ContactData contactData)
        {
            driver.FindElement(By.Name("firstname")).Clear();
            driver.FindElement(By.Name("firstname")).SendKeys(contactData.FirstName);
            driver.FindElement(By.Name("lastname")).Clear();
            driver.FindElement(By.Name("lastname")).SendKeys(contactData.LastName);
        }

        protected void InitContactCreation()
        {
            driver.FindElement(By.XPath("//a[contains(text(), 'add new')]")).Click();
        }

        protected void SubmitContactCreation()
        {
            driver.FindElement(By.Name("submit")).Click();
        }

        protected void ReturnToHomePage()
        {
            driver.FindElement(By.XPath("//a[contains(text(), 'home page')]")).Click();
        }
    }
}
