using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Protractor;
using System;

namespace ToolsQA.TestsCases
{
    public class BaseTest
    {
        protected const string Url = "http://new.omega-auto.biz/#/login";
        protected readonly IWebDriver _driver;
        protected readonly NgWebDriver _browser;

        public BaseTest()
        {
            _driver = new ChromeDriver(System.Reflection.Assembly.GetExecutingAssembly().Location.Replace("ToolsQA.exe", ""));
            _driver.Manage().Timeouts().SetScriptTimeout(TimeSpan.FromSeconds(40));
            _browser = new NgWebDriver(_driver);
        }

        [TearDown]
        public void Fisnish()
        {
            _browser.Close();
        }
    }
}
