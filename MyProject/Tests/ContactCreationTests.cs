﻿using NUnit.Framework;

namespace MyProject
{
    class ContactCreationTests : BaseTest
    {
        [Test]
        public void ContectCreationTest()
        {
            #region SetUpData
            ContactData contactData = new ContactData
            {
                FirstName = "Alex",
                LastName = "Kravchenko"
            };
            #endregion

            helpersManager.ContactHelper
                .InitContactCreation()
                .FillContactFields(contactData);
            helpersManager.BaseHelper
                .SubmitCreation()
                .ReturnToHomePage();
        }
    }
}
