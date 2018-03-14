using NUnit.Framework;
using OpenQA.Selenium;
using RelevantCodes.ExtentReports;
using ToolsQA.pages;

namespace ToolsQA.TestsCases
{
    [TestFixture]
    class SelectionTiresTests : BaseTest
    {
        private readonly TiresSelection tiresSelection;

        public SelectionTiresTests() : base()
        {
            tiresSelection = new TiresSelection(_browser);
        }

        [OneTimeSetUp]
        public void HideAdvancedSearch()
        {
            WaitForElementID("sidebarCategoryTires");
            tiresSelection.OpenSelectionTires();
            tiresSelection.ChatbarHide();
        }

        [TearDown]
        public void ClearSearchParametrs()
        {
            _browser.WaitForAngular();
            var removeLables = _browser.FindElements(By.XPath(".//*[@id='menu']/object/li[1]/span"));
            for (var i = 0; i < removeLables.Count; i++)
            {
                removeLables[i].Click();
            }

        }

        [Test]
        public void TiresSearchDiametrResultMustBeSuccess()
        {
            //test = extent.StartTest("TiresSearchDiametrResultMustBeSuccess");
            //test.Log(LogStatus.Pass, "Pass");

            WaitForElementXpath(".//*[@id='menu']/li[2]/span");
            tiresSelection.OpenDiametrDdl();
            tiresSelection.ChooseDiametr();
            tiresSelection.ClickOnButtonApplyInAdvancedSearch();
            //var SearchResultTires = _browser.FindElement(By.LinkText("205/65R15"));
            //Assert.IsTrue(SearchResultTires.Displayed);
            WaitForElementCSS(".table > tbody:nth-child(2) > tr:nth-child(1) > td:nth-child(4) > div:nth-child(1)");
            Assert.IsTrue(_driver.FindElement(By.CssSelector(".table > tbody:nth-child(2) > tr:nth-child(1) > td:nth-child(4) > div:nth-child(1)")).Text.Contains("15"));

        }


        [Test]
        public void TiresSearchSizeResultMustBeSuccess()
        {
            //test = extent.StartTest("TiresSearchSizeResultMustBeSuccess");
            //test.Log(LogStatus.Pass, "Pass");

            WaitForElementXpath(".//*[@id='menu']/li[2]/span");
            tiresSelection.OpenSizeDdl();
            tiresSelection.ChooseSize();
            tiresSelection.ClickOnButtonApplyInAdvancedSearch();
            //var SearchResultTires = _browser.FindElement(By.LinkText("1017412"));
            //Assert.IsTrue(SearchResultTires.Displayed);
            WaitForElementCSS(".table > tbody:nth-child(2) > tr:nth-child(1) > td:nth-child(4) > div:nth-child(1)");
            Assert.IsTrue(_driver.FindElement(By.CssSelector(".table > tbody:nth-child(2) > tr:nth-child(1) > td:nth-child(4) > div:nth-child(1)")).Text.Contains("/50"));

        }

        [Test]
        public void TiresSearchSeasonsresultMustBeSuccess()
        {
            //test = extent.StartTest("TiresSearchSeasonsresultMustBeSuccess");
            //test.Log(LogStatus.Pass, "Pass");

            WaitForElementXpath(".//*[@id='menu']/li[2]/span");
            tiresSelection.OpenSeasonDdl();
            tiresSelection.ChooseSeason();
            tiresSelection.ClickOnButtonApplyInAdvancedSearch();
            var SearchResultTires = _browser.FindElement(By.LinkText("4823044902842"));
            Assert.IsTrue(SearchResultTires.Displayed);
           
        }

        [Test]
        public void TiresSearchAppointmentMustBeSuccess()
        {
            //test = extent.StartTest("TiresSearchAppointmentMustBeSuccess");
            //test.Log(LogStatus.Pass, "Pass");

            WaitForElementXpath(".//*[@id='menu']/li[2]/span");
            tiresSelection.OpenAppointmentDdl();
            tiresSelection.ChooseAppointment();
            tiresSelection.ClickOnButtonApplyInAdvancedSearch();
            var SearchResultTires = _browser.FindElement(By.LinkText("1020988-1"));
            Assert.IsTrue(SearchResultTires.Displayed);
            

        }

        [Test]
        public void TiresMustHavePrices()
        {
            //test = extent.StartTest("TiresMustHavePrices");
            //test.Log(LogStatus.Pass, "Pass");

            WaitForElementXpath(".//*[@id='menu']/li[2]/span");
            var priceText = _browser.FindElement(By.CssSelector("td:nth-child(8) > span")).Text;
            double number = 0;
            Assert.DoesNotThrow(() => number = double.Parse(priceText.Replace(".", ",")));
            Assert.Greater(number, 0);

        }

        [Test]
        public void TiresMustHaveRests()
        {
            //test = extent.StartTest("TiresMustHaveRests");
            //test.Log(LogStatus.Pass, "Pass");

            WaitForElementXpath(".//*[@id='menu']/li[2]/span");
            var restsText = _browser.FindElement(By.CssSelector(".hidden-sm.hidden-xs")).Text;
            if (restsText.Trim().Contains("-"))
            {
                Assert.Fail();
            }


        }


        //[Test]
        //public void TiresSearchAllMustBeSuccess()
        //{

        //    WaitForElementXpath(".//*[@id='menu']/li[2]/span");
        //    tiresSelection.OpenDiametrDdl();
        //    tiresSelection.ChooseDiametrAll();
        //    tiresSelection.OpenDiametrDdl();
        //    tiresSelection.OpenSizeDdl();
        //    tiresSelection.ChooseSize();
        //    tiresSelection.OpenSizeDdl();
        //    tiresSelection.OpenSeasonDdl();
        //    tiresSelection.ChooseSeason();
        //    tiresSelection.OpenAppointmentDdl();
        //    tiresSelection.ChooseAllAppointment();

        //    tiresSelection.ClickOnButtonApplyInAdvancedSearch();

        //    var SearchResultTires = _browser.FindElement(By.LinkText("1017412"));
        //    Assert.IsTrue(SearchResultTires.Displayed);


        //    var restsText = _browser.FindElement(By.CssSelector(".hidden-sm.hidden-xs")).Text;

        //    if (restsText.Trim().Contains("-"))
        //    {
        //        Assert.Fail();
        //    }

        //}


    }
}
