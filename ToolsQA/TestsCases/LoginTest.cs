using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Protractor;
using System;
using ToolsQA.pages;

namespace ToolsQA.TestsCases
{
    [TestFixture]
    class LoginTest
    {
        private const string Url = "http://new.omega-auto.biz/#/login";
        private readonly IWebDriver _driver;
        private readonly NgWebDriver _browser;

        public LoginTest()
        {
            _driver = new ChromeDriver(System.Reflection.Assembly.GetExecutingAssembly().Location.Replace("ToolsQA.exe", ""));
            _driver.Manage().Timeouts().SetScriptTimeout(TimeSpan.FromSeconds(40));
            _browser = new NgWebDriver(_driver);
        }

        [Test]
        public void LoginMustBeSuccess()
        {
            _browser.Url = Url;
            var loginPage = new LoginPage(_browser);
            loginPage.LoginToApplication();

            _browser.WaitForAngular();

            Assert.IsTrue(_browser.Url.Contains("dashboard"));

            _browser.Close();
        }

    }
}
