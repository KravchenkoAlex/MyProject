using System;
using System.Text;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace MyProject
{
    [TestFixture]
    public class GroupCreationTests
    {
        private IWebDriver driver;
        private StringBuilder verificationErrors;
        private bool acceptNextAlert = true;

        [SetUp]
        public void SetupTest()
        {
            driver = new ChromeDriver();
            verificationErrors = new StringBuilder();
        }

        [TearDown]
        public void TeardownTest()
        {
            try
            {
                driver.Quit();
            }
            catch (Exception)
            {
                // Ignore errors if unable to close the browser
            }
            Assert.AreEqual("", verificationErrors.ToString());
        }

        [Test]
        public void GroupCreationTest()
        {
            GoToHomePage();
            Login();
            OpenGroupPage();
            InitGroupCreation();
            FillGroupsFields();
            SubmitGroupCreation();
            ReturnToMainPage();
        }

        private void ReturnToMainPage()
        {
            driver.FindElement(By.LinkText("group page")).Click();
        }

        private void SubmitGroupCreation()
        {
            driver.FindElement(By.Name("submit")).Click();
        }

        private void FillGroupsFields()
        {
            driver.FindElement(By.Name("group_name")).Clear();
            driver.FindElement(By.Name("group_name")).SendKeys("1");
            driver.FindElement(By.Name("group_header")).Clear();
            driver.FindElement(By.Name("group_header")).SendKeys("1");
            driver.FindElement(By.Name("group_footer")).Clear();
            driver.FindElement(By.Name("group_footer")).SendKeys("1");
        }

        private void InitGroupCreation()
        {
            driver.FindElement(By.Name("new")).Click();
        }

        private void OpenGroupPage()
        {
            driver.FindElement(By.LinkText("groups")).Click();
        }

        private void Login()
        {
            driver.FindElement(By.Name("user")).Clear();
            driver.FindElement(By.Name("user")).SendKeys("admin");
            driver.FindElement(By.Name("pass")).Clear();
            driver.FindElement(By.Name("pass")).SendKeys("secret");
            driver.FindElement(By.XPath("//input[@type='submit']")).Click();
        }

        private void GoToHomePage()
        {
            driver.Navigate().GoToUrl("http://localhost/addressbook/");
        }

        private bool IsElementPresent(By by)
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

        private bool IsAlertPresent()
        {
            try
            {
                driver.SwitchTo().Alert();
                return true;
            }
            catch (NoAlertPresentException)
            {
                return false;
            }
        }

        private string CloseAlertAndGetItsText()
        {
            try
            {
                IAlert alert = driver.SwitchTo().Alert();
                string alertText = alert.Text;
                if (acceptNextAlert)
                {
                    alert.Accept();
                }
                else
                {
                    alert.Dismiss();
                }
                return alertText;
            }
            finally
            {
                acceptNextAlert = true;
            }
        }
    }
}
