using NUnit.Framework;
using OpenQA.Selenium;
using RelevantCodes.ExtentReports;
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
        public void ClearSearchFild()
        {
            dashboard.ClearHeaderSearchFild();
        }


       

        [Test]
        public void SimpleSearchMustBeSuccess()
        {
            //test = extent.StartTest("SearchTest");
            //test.Log(LogStatus.Pass, "Pass");
            WaitForElementID("headerInputSearch");                        
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
            //test = extent.StartTest("AnalogsTest");
            //test.Log(LogStatus.Pass, "Pass");

            dashboard.EnableSearch("6900260289");
            WaitForElementID("addBasket");
            dashboard.LoadMoreAnalog();
            var priceText = _browser.FindElement(By.CssSelector("td:nth-child(8) > span")).Text;
            double number = 0;

            Assert.DoesNotThrow(() => number = double.Parse(priceText.Replace(".", ",")));
            Assert.Greater(number, 0);

        }

    }
}
