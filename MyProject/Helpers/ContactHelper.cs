using OpenQA.Selenium;

namespace MyProject
{
    public class ContactHelper : BaseHelper
    {
        public ContactHelper(HelpersManager helpersManager) : base(helpersManager)
        {
        }

        public ContactHelper FillContactFields(ContactData contactData)
        {
            driver.FindElement(By.Name("firstname")).Clear();
            driver.FindElement(By.Name("firstname")).SendKeys(contactData.FirstName);
            driver.FindElement(By.Name("lastname")).Clear();
            driver.FindElement(By.Name("lastname")).SendKeys(contactData.LastName);
            return this;
        }

        public ContactHelper InitContactCreation()
        {
            driver.FindElement(By.LinkText("add new")).Click();
            return this;
        }
    }
}
