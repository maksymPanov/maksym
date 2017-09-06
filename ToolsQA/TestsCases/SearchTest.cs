using NUnit.Framework;
using OpenQA.Selenium;
using ToolsQA.pages;

namespace ToolsQA.TestsCases
{
    [TestFixture]
    class SearchTest : BaseTest
    {
        [Test]
        public void SearchMustBeSuccess()
        {
            _browser.Url += "/dashboard";

            var loginPage = new LoginPage(_driver);
            loginPage.LoginToApplication();

            _browser.WaitForAngular();

            var dashboard = new DashboardPage(_driver);
            dashboard.EnableSearch();

            _browser.WaitForAngular();

            var priceText = _driver.FindElement(By.CssSelector("td:nth-child(8) > span")).Text;
            double number = 0;

            Assert.DoesNotThrow(() => number = double.Parse(priceText.Replace(".", ",")));
            Assert.Greater(number, 0);
        }
    }
}
