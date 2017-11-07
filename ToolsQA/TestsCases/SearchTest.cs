using NUnit.Framework;
using OpenQA.Selenium;
using ToolsQA.pages;

namespace ToolsQA.TestsCases
{
    [TestFixture]
    class SearchTest : BaseTest
    {
        private readonly DashboardPage dashboard;
        public SearchTest() : base()
        {
            dashboard = new DashboardPage(_browser);
        }

        [TearDown]
        public void Clear()
        {
            dashboard.Clear();
        }

        [Test]
        public void SimpleSearchMustBeSuccess()
        {
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
            dashboard.EnableSearch("6900260289");
            WaitForElementID("addBasket");
            dashboard.LoadMoreAnalog();
            var priceText = _browser.FindElement(By.CssSelector("td:nth-child(8) > span")).Text;
            double number = 0;

            Assert.DoesNotThrow(() => number = double.Parse(priceText.Replace(".", ",")));
            Assert.Greater(number, 0);
            
        }
        //[Test]
        //public void OpenAdvancedSearchMustBeSuccess()
        //{
        //    dashboard.OpenAdvancedSearch();
        //    WaitForElementCSS(".header-main-filter");

        //    Assert.AreEqual(true, _browser.FindElement(By.CssSelector("header-advanced-search button-apply")).Displayed);

        //}

        //[Test]
        //public void CloseAdvancedSearchMustBeSuccess()
        //{
        //    var dashboard = new DashboardPage(_browser);
        //    dashboard.OpenAdvancedSearch();
        //    WaitForElementCSS(".header-main-filter");
        //    dashboard.OpenAdvancedSearch();
        //    Assert.AreEqual(false, _browser.FindElement(By.CssSelector(".header-main-filter")).Displayed);
        //}

              

    }
}
