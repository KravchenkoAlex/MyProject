using System;
using NUnit.Framework;
using OpenQA.Selenium;

namespace MyProject
{
    class ContactCreationTests : TestBase
    {
        private GroupCreationTests _groupCreationTests = new GroupCreationTests();

        [Test]
        public void ContectCreationTest()
        {
            _groupCreationTests.GoToHomePage();
            _groupCreationTests.Login(new AccountData { Username = "admin", Password = "secret" });
            InitContactCreation();
            ContactData contactData = new ContactData
            {
                FirstName = "Alex",
                LastName = "Kravchenko"
            };
            FillContactFields(contactData);
            _groupCreationTests.SubmitCreation();
            ReturnToHomePage();
        }

        private void FillContactFields(ContactData contactData)
        {
            driver.FindElement(By.Name("firstname")).Clear();
            driver.FindElement(By.Name("firstname")).SendKeys(contactData.FirstName);
            driver.FindElement(By.Name("lastname")).Clear();
            driver.FindElement(By.Name("lastname")).SendKeys(contactData.LastName);
        }

        private void InitContactCreation()
        {
            driver.FindElement(By.XPath("//a[contains(text(), 'add new')]")).Click();
        }

        private void SubmitContactCreation()
        {
            driver.FindElement(By.Name("submit")).Click();
        }

        private void ReturnToHomePage()
        {
            driver.FindElement(By.XPath("//a[contains(text(), 'home page')]")).Click();
        }
    }
}
