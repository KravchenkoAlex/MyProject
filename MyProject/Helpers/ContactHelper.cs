using OpenQA.Selenium;

namespace MyProject
{
    public class ContactHelper : BaseHelper
    {
        public ContactHelper(HelpersManager helpersManager) : base(helpersManager)
        {
        }

        public ContactHelper Modify(int index, ContactData contactData)
        {
            SelectContact(index);
            InitContactModify(index);
            FillContactFields(contactData);
            helpersManager.GroupHelper.SubmitUpdate();
            ReturnToHomePage();
            return this;
        }

        public ContactHelper Create(ContactData contactData)
        {
            helpersManager.NavigationHelper.InitContactCreation();
            FillContactFields(contactData);
            helpersManager.BaseHelper
                .SubmitCreation()
                .ReturnToHomePage();
            return this;
        }

        public ContactHelper Remove(int index)
        {
            SelectContact(index);
            InitContactModify(index);
            SubmitDelete();
            helpersManager.NavigationHelper.NavigateToHome();
            return this;
        }

        public ContactHelper SubmitDelete()
        {
            driver.FindElement(By.XPath("//input[@value='Delete']")).Click();
            return this;
        }

        public ContactHelper InitContactModify(int index)
        {
            driver.FindElement(By.XPath($"//tr[@name='entry'][{index}]/td[8]/a")).Click();
            return this;
        }

        public ContactHelper SelectContact(int index)
        {
            driver.FindElement(By.XPath($"//tr[@name='entry'][{index}]/td/input")).Click();
            return this;
        }

        public ContactHelper FillContactFields(ContactData contactData)
        {
            driver.FindElement(By.Name("firstname")).Clear();
            driver.FindElement(By.Name("firstname")).SendKeys(contactData.FirstName);
            driver.FindElement(By.Name("lastname")).Clear();
            driver.FindElement(By.Name("lastname")).SendKeys(contactData.LastName);
            return this;
        }
    }
}
