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

            _browser.Url = Url + "/login";
        }

        [OneTimeSetUp]
        public void RunBeforeAllTestLigin()
        {
            var loginPage = new LoginPage(_browser);
            loginPage.LoginToApplication();
            _browser.WaitForAngular();
        }

        public void OpenDeashbordPage()
        {
            var dashboard = new DashboardPage(_browser);
        }

        public void WaitForElementID(string selector)
        {
            WebDriverWait wait = new WebDriverWait(_browser, TimeSpan.FromSeconds(30));
            IWebElement element = wait.Until(ExpectedConditions.ElementToBeClickable(By.Id(selector)));
        }

        public void WaitForElementCSS(string selector)
        {
            WebDriverWait wait = new WebDriverWait(_browser, TimeSpan.FromSeconds(30));
            IWebElement element = wait.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector(selector)));
        }

        public void WaitForElementXpath(string selector)
        {
            WebDriverWait wait = new WebDriverWait(_browser, TimeSpan.FromSeconds(30));
            IWebElement element = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(selector)));
        }

        [OneTimeTearDown]
        public void RunAfterAllTestsCloseBrowser()
        {
            _browser.Close();
            _driver.Quit();
        }
    }
}
