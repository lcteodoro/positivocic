using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;

namespace BATDemoFramework
{
    public static class Browser
    {
        private static string baseUrl = "http://localhost:12142/";
		private static IWebDriver webDriver;
        public static void Initialize()
        {
			webDriver = new FirefoxDriver();			
			//webDriver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(5));
            Goto(string.Empty);
        }

        public static string Title
        {
            get { return webDriver.Title; }
        }

        public static ISearchContext Driver
        {
            get { return webDriver; }
        }

        public static void Goto(string url)
        {
	        webDriver.Navigate().GoToUrl(baseUrl + url);
        }

        public static void Close()
        {
            //webDriver.Close();
        }
    }
}