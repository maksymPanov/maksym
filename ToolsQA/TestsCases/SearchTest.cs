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
            
            LoginOnTheSite();

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
