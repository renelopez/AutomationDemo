using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using Xunit;

namespace Unosquare.ATDemo.Framework.Pages
{
    public class HomePage
    {
        [FindsBy(How = How.CssSelector, Using = "div.banner-about-us.container")]
        private IWebElement aboutUsBanner;
        
        
        private string _homePageTitle = "Unosquare - Information Technology Consulting Services";
        private string _aboutUsText = "engineering excellence,the smart way to build great digital experiences";

        public bool isAt()
        {
            return Browser.GetTitle() == _homePageTitle;
        }

        public bool hasAboutUsPhrase()
        {
            var browserText = aboutUsBanner.Text.RemoveSpecialCharacters();
            return browserText.Contains(_aboutUsText.RemoveSpecialCharacters());
        }

        public void GoTo()
        {
            Pages.TopNavigation.Home();
        }
    }
}
