using System;
using OpenQA.Selenium;

namespace MyProject
{
    public class LoginHelper : BaseHelper
    {
        public LoginHelper(HelpersManager helpersManager) : base(helpersManager)
        {
        }

        public void Login(AccountData accountData)
        {
            if (IsLoggedIn())
            {
                if (IsLoggedIn(accountData))
                {
                    return;
                }

                Logout();
            }
            Type(By.Name("user"), accountData.Username);
            Type(By.Name("pass"), accountData.Password);
            driver.FindElement(By.XPath("//input[@type='submit']")).Click();
        }

        public bool IsLoggedIn(AccountData accountData)
        {
            return IsLoggedIn() && driver.FindElement(By.Name("logout"))
                .FindElement(By.TagName("b")).Text == $"({accountData.Username})";
        }

        public bool IsLoggedIn()
        {
            return IsElementPresent(By.Name("logout"));
        }

        public void Logout()
        {
            if (IsLoggedIn())
            {
                driver.FindElement(By.XPath("//a[text()='Logout']")).Click();
            }
        }
    }
}
