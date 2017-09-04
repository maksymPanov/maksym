//using NUnit.Framework;
//using OpenQA.Selenium;
//using ToolsQA.pages;

//namespace ToolsQA.TestsCases
//{
//    [TestFixture]
//    class SearchTest : BaseTest
//    {
//        public SearchTest()
//        {
//            _driver.Url += "/dashboard";
//        }

//        [Test]
//        public void SearchMustBeSuccess()
//        {
//            var loginPage = new LoginPage(_driver);
//            loginPage.LoginToApplication();

//            WaitForAngular();

//            var dashboard = new DashboardPage(_driver);
//            dashboard.EnableSearch();

//            WaitForAngular();

//            var priceText = _driver.FindElement(By.CssSelector("td:nth-child(8) > span")).Text;
//            double number = 0;

//            Assert.DoesNotThrow(() => number = double.Parse(priceText.Replace(".", ",")));
//            Assert.Greater(number, 0);
//        }
//    }
//}
