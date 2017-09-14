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


        [SetUp]
        public void RunBeforeAllTestLigin()
        {
            var loginPage = new LoginPage(_browser);
            loginPage.LoginToApplication();
            _browser.WaitForAngular();
            _browser.Navigate().GoToUrl(Url + "/dashboard");
        }


        [Test]
        public void SimpleSearchMustBeSuccess()
        {
                                             
            var dashboard = new DashboardPage(_browser);
            dashboard.EnableSearch("4610495");
            WaitForElementID("addBasket");
            var priceText = _browser.FindElement(By.CssSelector("td:nth-child(8) > span")).Text;
            double number = 0;

            Assert.DoesNotThrow(() => number = double.Parse(priceText.Replace(".", ",")));
            Assert.Greater(number, 0);
        }

        [Test]
        public void SearchOpenAnalogs()
        {
            var dashboard = new DashboardPage(_browser);
            dashboard.EnableSearch("6900260289");
            WaitForElementID("addBasket");
            dashboard.LoadMoreAnalogsClick();
            var priceText = _browser.FindElement(By.CssSelector("td:nth-child(8) > span")).Text;
            double number = 0;
            Assert.DoesNotThrow(() => number = double.Parse(priceText.Replace(".", ",")));
            Assert.Greater(number, 0);
        }
        [Test]
        public void OpenAdvancedSearchMustBeSuccess()
        {
            var dashboard = new DashboardPage(_browser);
            dashboard.OpenAdvancedSearch();
            WaitForElementCSS(".header-main-filter");
            Assert.AreEqual(true, _browser.FindElement(By.CssSelector(".header-main-filter")).Displayed);
        }

        [Test]
        public void CloseAdvancedSearchMustBeSuccess()
        {
            var dashboard = new DashboardPage(_browser);
            dashboard.OpenAdvancedSearch();
            WaitForElementCSS(".header-main-filter");
            dashboard.OpenAdvancedSearch();
            Assert.AreEqual(false, _browser.FindElement(By.CssSelector(".header-main-filter")).Displayed);
        }

        [TearDown]
        public void RunAfterAllTestsCloseBrowser()
        {
            _browser.Close();
            _driver.Quit();
        }
    }
}
