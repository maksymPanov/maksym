using NUnit.Framework;
using OpenQA.Selenium;
using System.Collections.Generic;
using ToolsQA.pages;

namespace ToolsQA.TestsCases
{
    [TestFixture]
    class SelectionTechnicalFluid : BaseTest
    {
        private readonly TechnicalFluidSelection technicalFluidSelection;

        public SelectionTechnicalFluid() : base()
        {
            technicalFluidSelection = new TechnicalFluidSelection(_browser);
        }

        [OneTimeSetUp]
        public void HideAdvancedSearch()
        {
            WaitForElementID("sidebarCategoryOil");
            technicalFluidSelection.OpenSelectionOIL();
            technicalFluidSelection.OpenSelectionTechnicalFluid();
            technicalFluidSelection.ChatbarHide();
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
        public void TLAppointmentResultMustBeSuccess()
        {

            WaitForElementXpath(".//*[@id='menu']/li[2]/span");
            technicalFluidSelection.OpenTFPurposeDdl();
            technicalFluidSelection.ChooseTFPurpose();
            technicalFluidSelection.ClickOnButtonApplyInAdvancedSearch();
            var SearchResultTires = _browser.FindElement(By.LinkText("4802617334"));
            Assert.IsTrue(SearchResultTires.Displayed);

        }

        [Test]
        public void TLColorResultMustBeSuccess()
        {

            WaitForElementXpath(".//*[@id='menu']/li[2]/span");
            technicalFluidSelection.OpenTFColorDdl();
            technicalFluidSelection.ChooseTFColor();
            technicalFluidSelection.ClickOnButtonApplyInAdvancedSearch();
            var SearchResultTires = _browser.FindElement(By.LinkText("26580"));
            Assert.IsTrue(SearchResultTires.Displayed);

        }

        [Test]
        public void TFSeasonalityResultMustBeSuccess()
        {

            WaitForElementXpath(".//*[@id='menu']/li[2]/span");
            technicalFluidSelection.OpenTFSeasonalityDdl();
            technicalFluidSelection.ChooseTFSeasonality();
            technicalFluidSelection.ClickOnButtonApplyInAdvancedSearch();
            var SearchResultTires = _browser.FindElement(By.LinkText("5363"));
            Assert.IsTrue(SearchResultTires.Displayed);

        }

        [Test]
        public void SpecOEMResultMustBeSuccess()
        {

            WaitForElementXpath(".//*[@id='menu']/li[2]/span");
            technicalFluidSelection.OpenTFSpecOEMyDdl();
            technicalFluidSelection.ChooseTFSpecOEM();
            technicalFluidSelection.ClickOnButtonApplyInAdvancedSearch();
            var SearchResultTires = _browser.FindElement(By.LinkText("12710"));
            Assert.IsTrue(SearchResultTires.Displayed);

        }

        [Test]
        public void TFScopeResultMustBeSuccess()
        {

            WaitForElementXpath(".//*[@id='menu']/li[2]/span");
            technicalFluidSelection.OpenTFScopeDdl();
            technicalFluidSelection.ChooseTFScope();
            technicalFluidSelection.ClickOnButtonApplyInAdvancedSearch();
            var SearchResultTires = _browser.FindElement(By.LinkText("4102816901"));
            Assert.IsTrue(SearchResultTires.Displayed);

        }

        [Test]
        public void TFMustHavePrices()
        {
            WaitForElementXpath(".//*[@id='menu']/li[2]/span");
            var priceText = _browser.FindElement(By.CssSelector("td:nth-child(8) > span")).Text;
            double number = 0;
            Assert.DoesNotThrow(() => number = double.Parse(priceText.Replace(".", ",")));
            Assert.Greater(number, 0);

        }

        [Test]
        public void TFMustHaveRests()
        {
            WaitForElementXpath(".//*[@id='menu']/li[2]/span");
            var restsText = _browser.FindElement(By.CssSelector(".hidden-sm.hidden-xs")).Text;
            if (restsText.Trim().Contains("-"))
            {
                Assert.Fail();
            }
        }

    }
}
