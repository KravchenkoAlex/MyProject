using OpenQA.Selenium;

namespace MyProject
{
    public class LoginHelper : BaseHelper
    {
        public LoginHelper(HelpersManager helpersManager) : base(helpersManager)
        {
        }

        public LoginHelper Login(AccountData accountData)
        {
            driver.FindElement(By.Name("user")).Clear();
            driver.FindElement(By.Name("user")).SendKeys(accountData.Username);
            driver.FindElement(By.Name("pass")).Clear();
            driver.FindElement(By.Name("pass")).SendKeys(accountData.Password);
            driver.FindElement(By.XPath("//input[@type='submit']")).Click();
            return this;
        }
    }
}
