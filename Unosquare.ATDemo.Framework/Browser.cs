using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;

namespace Unosquare.ATDemo.Framework
{
    public class Browser:IDisposable
    {
        public const string BASE_URL="http://preview.unosquare.net";

        public static IWebDriver webdriver;

        public Browser()
        {
            Init();
        }

        public static void Init()
        {
            switch (ConfigurationManager.AppSettings.Get("workingBrowser"))
            {
                case "Chrome":webdriver=new ChromeDriver();
                    break;
                case "Firefox":webdriver=new FirefoxDriver();
                    break;
                default:webdriver=new InternetExplorerDriver();
                    break;
            }
            GoTo("");
        }

        public static ISearchContext Driver
        {
            get { return webdriver; } 
        }

        public static void GoTo(string url)
        {
            webdriver.Url = BASE_URL + url;
        }

        public static string GetTitle()
        {
            return webdriver.Title;
        }


        public void Dispose()
        {
            //webdriver.Close();
        }

        public static void ScrollTo(int xPosition = 0, int yPosition = 0)
        {
            var js = string.Format("window.scrollTo({0}, {1})", xPosition, yPosition);
            ((IJavaScriptExecutor)webdriver).ExecuteScript(js);
        }
    }
}
