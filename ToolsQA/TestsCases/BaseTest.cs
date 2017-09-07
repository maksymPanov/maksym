using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using Protractor;
using System;
using ToolsQA.pages;

namespace ToolsQA.TestsCases
{
    public class BaseTest
    {
        protected string Url = "http://new.omega-auto.biz/#";
        protected readonly IWebDriver _driver;
        protected readonly NgWebDriver _browser;

        public BaseTest()
        {
            _driver = new ChromeDriver(System.Reflection.Assembly.GetExecutingAssembly().Location.Replace("ToolsQA.exe", ""));
            _driver.Manage().Timeouts().AsynchronousJavaScript = TimeSpan.FromSeconds(60);
            _browser = new NgWebDriver(_driver);
            _browser.Manage().Window.Maximize();

            Url += "/login";
            _browser.Url = Url;
        }

        public void LoginOnTheSite()
        {
            var loginPage = new LoginPage(_browser);
            loginPage.LoginToApplication();

            _browser.WaitForAngular();

            _browser.Navigate().GoToUrl(Url + "/dashboard");
        }

        public void WaitForElement(string selector)
        {
            WebDriverWait wait = new WebDriverWait(_browser, TimeSpan.FromSeconds(15));
            IWebElement element = wait.Until(ExpectedConditions.ElementToBeClickable(By.Id(selector)));
        }

        [TearDown]
        public void Fisnish()
        {
            _browser.Close();
            _driver.Quit();
        }
    }
}
