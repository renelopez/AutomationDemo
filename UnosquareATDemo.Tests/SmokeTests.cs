using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unosquare.ATDemo.Framework;
using Unosquare.ATDemo.Framework.Pages;
using Xunit;

namespace UnosquareATDemo.Tests
{
    public class SmokeTests:IClassFixture<Browser>
    {
        [Fact]
        public void CanGoHome()
        {
            Pages.Home.GoTo();
            Assert.True(Pages.Home.isAt());
        }

        [Fact]
        public void ItHasAboutUsPhrase()
        {
            Pages.Home.GoTo();
            Assert.True(Pages.Home.hasAboutUsPhrase());
        }

        [Fact]
        public void CanGoToAboutPage()
        {
            Pages.About.GoTo();
            Assert.True(Pages.About.isAt());
        }

        [Fact]
        public void CanSeeCIOName()
        {
            Pages.About.GoTo();
            Assert.True(Pages.About.isCIONameVisible());
        }

        [Fact]
        public void CanGoToServicesPage()
        {
            Pages.Services.GoTo();
            Assert.True(Pages.Services.IsAt());
        }

        [Fact]
        public void AreServicesListed()
        {
            Pages.Services.GoTo();
            Assert.True(Pages.Services.AreServicesListed());
        }

        [Fact]
        public void CanGoContactPage()
        {
            Pages.Contact.GoTo();
            Assert.True(Pages.Contact.IsAt());
        }

        [Fact]
        public void AreValidatorsListedForContactForm()
        {
            Pages.Contact.GoTo();
            Pages.Contact.SubmitForm();
            Assert.True(Pages.Contact.AreValidatorsVisible());
        }
    }

    
}
