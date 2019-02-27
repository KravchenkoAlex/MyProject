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
            Type(By.Name("user"), accountData.Username);
            Type(By.Name("pass"), accountData.Password);
            driver.FindElement(By.XPath("//input[@type='submit']")).Click();
            return this;
        }
    }
}
