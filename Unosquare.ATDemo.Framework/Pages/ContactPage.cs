using System;
using System.Collections.Generic;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;

namespace Unosquare.ATDemo.Framework.Pages
{
    public class ContactPage
    {
        [FindsBy(How = How.CssSelector, Using = "input.btn-blue1:nth-child(2)")]
        private IWebElement _submitFormButton;

        [FindsBy(How = How.CssSelector, Using = ".tooltip-inner")]
        private IList<IWebElement> _validatorList;

        private const int ValidatorCount = 6;

        public bool IsAt()
        {
            return Browser.GetTitle().Contains("Contact and Locations");
        }

        public void GoTo()
        {
            Pages.TopNavigation.Contact();
        }

        public void SubmitForm()
        {
           Browser.ScrollTo(0,_submitFormButton.Location.Y-100);
           _submitFormButton.Click();

        }

        public bool AreValidatorsVisible()
        {
            return _validatorList.Count == ValidatorCount;
        }        
    }
}