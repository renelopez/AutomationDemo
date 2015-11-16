using System.Collections.Generic;
using System.Linq;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Unosquare.ATDemo.Framework.Pages
{
    public class ServicesPage
    {
        [FindsBy(How = How.CssSelector,Using = "h5")]
        private IList<IWebElement> servicesList;

        private List<string> _services = new List<string>()
        {
            "Software Development",
            "Quality Assurance",
            "Business Intelligence",
            "UX/UI Services",
            "Creative Services",
            "Mobile Applications"
        }; 


        public bool IsAt()
        {
            return Browser.GetTitle().Contains("Service Offerings");
        }

        public bool AreServicesListed()
        {
            var currentServices = servicesList.Select(elem => elem.Text.RemoveSpecialCharacters()).OrderBy(str=>str).ToList();
            return
                currentServices.SequenceEqual(
                    _services.Select(str => str.RemoveSpecialCharacters()).OrderBy(str => str).ToList());
        }


        public void GoTo()
        {
            Pages.TopNavigation.Services();
        }
    }
}