using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.PageObjects;

namespace Unosquare.ATDemo.Framework.Pages
{
    public class Pages
    {
        private static T GetPage<T>() where T:new()
        {
            var page = new T();
            PageFactory.InitElements(Browser.webdriver, page);
            return page;
        }


        public static HomePage Home
        {
            get { return GetPage<HomePage>(); } 
        }

        public static AboutPage About
        {
            get { return GetPage<AboutPage>(); }
        }

        public static TopNavigationPage TopNavigation
        {
            get { return GetPage<TopNavigationPage>(); }
        }

        public static ServicesPage Services
        {
            get { return GetPage<ServicesPage>(); }
        }

        public static ContactPage Contact
        {
            get { return GetPage<ContactPage>(); }
        }
    }
}
