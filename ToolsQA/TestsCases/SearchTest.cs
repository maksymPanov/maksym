using NUnit.Framework;
using OpenQA.Selenium;
using ToolsQA.pages;

namespace ToolsQA.TestsCases
{
    [TestFixture]
    class SearchTest : BaseTest
    {
        public SearchTest() : base() { }

        [Test]
        public void SearchMustBeSuccess()
        {
            var loginPage = new LoginPage(_browser);
            loginPage.LoginToApplication();

            _browser.WaitForAngular();

            _browser.Navigate().GoToUrl(Url + "/dashboard");

            var dashboard = new DashboardPage(_browser);
            dashboard.EnableSearch();

            WaitForElement("addBasket");

            var priceText = _browser.FindElement(By.CssSelector("td:nth-child(8) > span")).Text;
            double number = 0;

            Assert.DoesNotThrow(() => number = double.Parse(priceText.Replace(".", ",")));
            Assert.Greater(number, 0);
        }
    }
}
