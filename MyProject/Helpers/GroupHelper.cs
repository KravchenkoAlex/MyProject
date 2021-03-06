﻿using OpenQA.Selenium;

namespace MyProject
{
    public class GroupHelper : BaseHelper
    {
        public GroupHelper(HelpersManager helpersManager) : base(helpersManager)
        {
        }

        public GroupHelper Create(GroupData groupData)
        {
            helpersManager.NavigationHelper.GoToGroupsPage();
            InitGroupCreation();
            FillGroupFields(groupData);
            SubmitCreation();
            ReturnToGroupsPage();
            return this;
        }

        public GroupHelper Modify(int index, GroupData groupData)
        {
            helpersManager.NavigationHelper.GoToGroupsPage();

            if (IsElementPresent(By.XPath($"//input[@name='selected[]'][{index}]")))
            {
                SelectGroup(index);
                InitGroupModify();
                FillGroupFields(groupData);
                SubmitUpdate();
                ReturnToGroupsPage();
                return this;
            }

            Create(new GroupData { Name = "aaa", Footer = "bbb", Header = "ccc" });
            helpersManager.NavigationHelper.GoToGroupsPage();
            SelectGroup(index);
            InitGroupModify();
            FillGroupFields(groupData);
            SubmitUpdate();
            ReturnToGroupsPage();
            return this;
        }

        public GroupHelper Remove(int index)
        {
            helpersManager.NavigationHelper.GoToGroupsPage();

            if (IsElementPresent(By.XPath($"//input[@name='selected[]'][{index}]")))
            {
                SelectGroup(index);
                RemoveGroup();
                ReturnToGroupsPage();
                return this;
            }

            Create(new GroupData { Name = "aaa", Footer = "bbb", Header = "ccc" });
            SelectGroup(index);
            RemoveGroup();
            ReturnToGroupsPage();
            return this;
        }
        
        public GroupHelper InitGroupModify()
        {
            driver.FindElement(By.Name("edit")).Click();
            return this;
        }

        public GroupHelper RemoveGroup()
        {
            driver.FindElement(By.XPath("//input[@name='delete'][1]")).Click();
            return this;
        }

        public GroupHelper SelectGroup(int index)
        {
            driver.FindElement(By.XPath($"//input[@name='selected[]'][{index}]")).Click();
            return this;
        }

        public GroupHelper ReturnToGroupsPage()
        {
            driver.FindElement(By.LinkText("group page")).Click();
            return this;
        }

        public GroupHelper InitGroupCreation()
        {
            driver.FindElement(By.Name("new")).Click();
            return this;
        }

        public GroupHelper FillGroupFields(GroupData groupData)
        {
            Type(By.Name("group_name"), groupData.Name);
            Type(By.Name("group_header"), groupData.Header);
            Type(By.Name("group_footer"), groupData.Footer);
            return this;
        }
    }
}
