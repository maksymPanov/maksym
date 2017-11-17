using NUnit.Framework;
using OpenQA.Selenium;
using System.Collections.Generic;
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
            //tiresSelection.OpenSelectionTires();
            WaitForElementXpath(".//*[@id='menu']/li[2]/span");
            //var SearchResultTires = _browser.FindElement(By.XPath(".//*[@id='menu']/li[2]/span"));
            //Assert.IsTrue(SearchResultTires.Displayed);
            tiresSelection.OpenDiametrDdl();
            tiresSelection.ChooseDiametr();
            //tiresSelection.OpenDiametrDdl();
            //tiresSelection.ChatbarHide();

            tiresSelection.ClickOnButtonApplyInAdvancedSearch();

            var SearchResultTires = _browser.FindElement(By.LinkText("TS00107"));
            Assert.IsTrue(SearchResultTires.Displayed);

        }


        [Test]
        public void TiresSearchSizeResultMustBeSuccess()
        {

            WaitForElementXpath(".//*[@id='menu']/li[2]/span");

            tiresSelection.OpenSizeDdl();
            tiresSelection.ChooseSize();
            tiresSelection.ClickOnButtonApplyInAdvancedSearch();

            var SearchResultTires = _browser.FindElement(By.LinkText("1017412"));
            Assert.IsTrue(SearchResultTires.Displayed);

        }

        [Test]
        public void TiresSearchSeasonsresultMustBeSuccess()
        {

            WaitForElementXpath(".//*[@id='menu']/li[2]/span");
            tiresSelection.OpenSeasonDdl();
            tiresSelection.ChooseSeason();
            tiresSelection.ClickOnButtonApplyInAdvancedSearch();

            var SearchResultTires = _browser.FindElement(By.LinkText("TW00154"));
            Assert.IsTrue(SearchResultTires.Displayed);

        }

        [Test]
        public void TiresSearchAppointmentMustBeSuccess()
        {

            WaitForElementXpath(".//*[@id='menu']/li[2]/span");
            tiresSelection.OpenAppointmentDdl();
            tiresSelection.ChooseAppointment();
            tiresSelection.ClickOnButtonApplyInAdvancedSearch();

            var SearchResultTires = _browser.FindElement(By.LinkText("TS01153"));
            Assert.IsTrue(SearchResultTires.Displayed);

        }

        [Test]
        public void TiresMustHavePrices()
        {
            WaitForElementXpath(".//*[@id='menu']/li[2]/span");

            var priceText = _browser.FindElement(By.CssSelector("td:nth-child(8) > span")).Text;
            double number = 0;

            Assert.DoesNotThrow(() => number = double.Parse(priceText.Replace(".", ",")));
            Assert.Greater(number, 0);

        }

        [Test]
        public void TiresMustHaveRests()
        {
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
