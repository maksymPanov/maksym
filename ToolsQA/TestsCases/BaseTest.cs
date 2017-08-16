using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace ToolsQA.TestsCases
{
    public class BaseTest
    {
        protected IWebDriver _driver;

        public BaseTest()
        {
            _driver = new FirefoxDriver();

            _driver.Url = "http://localhost:36174/";
        }

        protected void WaitForAngular()
        {
            WebDriverWait wait = new WebDriverWait(_driver, new System.TimeSpan(0, 60, 0));
            IJavaScriptExecutor jsExec = (IJavaScriptExecutor)_driver;

            var angularReadyScript = "return angular.element(document).injector().get('$http').pendingRequests.length === 0";

            var angularReady = bool.Parse(jsExec.ExecuteScript(angularReadyScript).ToString());

            if (!angularReady)
            {
                wait.Until<bool>(driver => bool.Parse(((IJavaScriptExecutor)driver).ExecuteScript(angularReadyScript).ToString()));
            }
        }

        public void End()
        {
            _driver.Close();
        }
    }
}
