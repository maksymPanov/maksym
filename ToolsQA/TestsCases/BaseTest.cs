using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace ToolsQA.TestsCases
{
    public class BaseTest
    {
        protected IWebDriver _driver;
        protected string Url = "http://new.omega-auto.biz/";

        public BaseTest()
        {
            _driver = new ChromeDriver(@"C:\Users\aleksandr.rezenkov\Documents\Visual Studio 2015\Projects\omega.autotest\ToolsQA\bin\Debug\");
            _driver.Manage().Timeouts().AsynchronousJavaScript = TimeSpan.FromSeconds(15);
            _driver.Url = Url;
        }

        //[TearDown]
        //public void End()
        //{
        //    _driver.Quit();
        //}
    }
}
