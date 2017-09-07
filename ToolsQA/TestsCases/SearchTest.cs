using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using ToolsQA.pages;

namespace ToolsQA.TestsCases
{
    [TestFixture]
    class SearchTest : BaseTest
    {
        public SearchTest() : base() { }


        public void WaitUntilAnalogsLoaded()
        {
            WebDriverWait wait = new WebDriverWait(_driver, new System.TimeSpan(0, 60, 0));
            IJavaScriptExecutor jsExec = (IJavaScriptExecutor)_driver;

            var angularReadyScript = "!!angular.element(document).injector().get('$http').pendingRequests.find(t=>t.url.includes('search/getanalogs'))";

            var angularReady = bool.Parse(jsExec.ExecuteScript(angularReadyScript).ToString());

            if (!angularReady)
            {
                wait.Until<bool>(driver => bool.Parse(((IJavaScriptExecutor)driver).ExecuteScript(angularReadyScript).ToString()));
            }
        }

        [Test]
        public void SearchMustBeSuccess()
        {
            
            LoginOnTheSite();

            _browser.WaitForAngular();
            _browser.ExecuteAsyncScript("return angu");

            _browser.Navigate().GoToUrl(Url + "/dashboard");

            var dashboard = new DashboardPage(_browser);
            dashboard.EnableSearch("4610495");

            WaitForElement("addBasket");

            var priceText = _browser.FindElement(By.CssSelector("td:nth-child(8) > span")).Text;
            double number = 0;

            Assert.DoesNotThrow(() => number = double.Parse(priceText.Replace(".", ",")));
            Assert.Greater(number, 0);
        }

        //[Test]
        //public void SearchOpenAnalogs()
        //{
        //    LoginOnTheSite();
        //    var dashboard = new DashboardPage(_browser);
        //    dashboard.EnableSearch();

        //    WaitForElement("addBasket");
        //}
    }
}
