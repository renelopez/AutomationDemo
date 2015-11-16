using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Unosquare.ATDemo.Framework.Pages
{
    public class AboutPage
    {

        [FindsBy(How = How.CssSelector, Using = "#leadership div.leaders-team h4")]
        private IList<IWebElement> leadersList;

        public void GoTo()
        {
            Pages.TopNavigation.About();
        }

        public bool isAt()
        {
            return Browser.GetTitle().Contains("About");
        }

        public bool isCIONameVisible()
        {
           return leadersList.Any(elem => elem.Text.Contains("MARIO DI VECE"));
            
        }
    }
}
