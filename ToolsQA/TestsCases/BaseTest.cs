using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using Protractor;
using System;
using ToolsQA.pages;

namespace ToolsQA.TestsCases
{
    //internal class ExtentManager
    //{
    //    private static readonly ExtentReports _instance =
    //        new ExtentReports("Extent.Net.html", DisplayOrder.OldestFirst);

    //    static ExtentManager() { }

    //    private ExtentManager() { }

    //    public static ExtentReports Instance
    //    {
    //        get
    //        {
    //            return _instance;
    //        }
    //    }
    //}


    public class BaseTest
    {
        protected string Url = "http://new.omega-auto.biz/#";
        protected readonly IWebDriver _driver;
        protected readonly NgWebDriver _browser;
        //protected ExtentReports extent;
        //protected ExtentTest test;

        public BaseTest()
        {
            // _driver = new ChromeDriver(System.Reflection.Assembly.GetExecutingAssembly().Location.Replace("ToolsQA.dll", ""));

            var opts = new ChromeOptions();
            opts.PlatformName = "Windows";

            _driver = new RemoteWebDriver(new Uri("http://192.168.100.32:5555/wd/hub"), opts.ToCapabilities(), TimeSpan.FromMinutes(1));
            _driver.Manage().Timeouts().AsynchronousJavaScript = TimeSpan.FromSeconds(60);
            _driver.Manage().Window.Maximize();
            _browser = new NgWebDriver(_driver);
            _browser.Manage().Window.Maximize();
            _browser.Url = Url + "/login";

        }

        [OneTimeSetUp]
        public void RunBeforeAllTestLogin()
        {
            //extent = ExtentManager.Instance;

            var loginPage = new LoginPage(_browser);
            WaitForElementID("loginInputEmail");
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

        //[TearDown]
        //public void TearDown()
        //{
        //    var status = TestContext.CurrentContext.Result.Outcome.Status;
        //    var stacktrace = string.IsNullOrEmpty(TestContext.CurrentContext.Result.StackTrace)
        //            ? ""
        //            : string.Format("<pre>{0}</pre>", TestContext.CurrentContext.Result.StackTrace);
        //    LogStatus logstatus;

        //    switch (status)
        //    {
        //        case TestStatus.Failed:
        //            logstatus = LogStatus.Fail;
        //            break;
        //        case TestStatus.Inconclusive:
        //            logstatus = LogStatus.Warning;
        //            break;
        //        case TestStatus.Skipped:
        //            logstatus = LogStatus.Skip;
        //            break;
        //        default:
        //            logstatus = LogStatus.Pass;
        //            break;
        //    }

        //    test.Log(logstatus, "Test ended with " + logstatus + stacktrace);

        //    extent.EndTest(test);
        //    extent.Flush();
        //}

        [OneTimeTearDown]
        public void RunAfterAllTestsCloseBrowser()
        {

            _browser.Close();
            _driver.Quit();
        }
    }
}
