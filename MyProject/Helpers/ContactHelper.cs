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
            if (IsElementPresent(By.XPath($"//tr[@name='entry'][{index}]/td/input")))
            {
                SelectContact(index);
                InitContactModify(index);
                FillContactFields(contactData);
                SubmitUpdate();
                ReturnToHomePage();
                return this;
            }

            Create(new ContactData { FirstName = "First", LastName = "Last" });
            SelectContact(index);
            InitContactModify(index);
            FillContactFields(contactData);
            SubmitUpdate();
            ReturnToHomePage();
            return this;
        }

        public ContactHelper Create(ContactData contactData)
        {
            helpersManager.NavigationHelper.InitContactCreation();
            FillContactFields(contactData);
            SubmitCreation();
            ReturnToHomePage();
            return this;
        }

        public ContactHelper Remove(int index)
        {
            if (IsElementPresent(By.XPath($"//tr[@name='entry'][{index}]/td/input")))
            {
                SelectContact(index);
                InitContactModify(index);
                SubmitDelete();
                helpersManager.NavigationHelper.NavigateToHome();
                return this;
            }

            Create(new ContactData { FirstName = "First", LastName = "Last" });
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
            Type(By.Name("firstname"), contactData.FirstName);
            Type(By.Name("lastname"), contactData.LastName);

            return this;
        }
    }
}
