using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Unosquare.ATDemo.Framework.Pages
{
    public class TopNavigationPage
    {
        [FindsBy(How = How.LinkText,Using = "home")]
        private IWebElement homeLink;

        [FindsBy(How = How.LinkText, Using = "about")]
        private IWebElement aboutLink;

        [FindsBy(How = How.LinkText, Using = "services")]
        private IWebElement servicesLink;

        [FindsBy(How = How.LinkText, Using = "portfolio")]
        private IWebElement portfolioLink;

        [FindsBy(How = How.LinkText, Using = "partners")]
        private IWebElement partnersLink;

        [FindsBy(How = How.LinkText, Using = "careers")]
        private IWebElement careersLink;

        [FindsBy(How = How.LinkText, Using = "social")]
        private IWebElement socialLink;

        [FindsBy(How = How.LinkText, Using = "contact")]
        private IWebElement contactLink;

        public void Home()
        {
            homeLink.Click();
        }

        public void About()
        {
            aboutLink.Click();
        }

        public void Services()
        {
            servicesLink.Click();
        }

        public void Portfolio()
        {
            portfolioLink.Click();
        }

        public void Partners()
        {
            partnersLink.Click();
        }

        public void Careers()
        {
            careersLink.Click();
        }

        public void Social()
        {
            socialLink.Click();
        }

        public void Contact()
        {
            contactLink.Click();
        }

    }
}
