using NUnit.Framework;
using OpenQA.Selenium;
using System.Collections.Generic;
using ToolsQA.pages;

namespace ToolsQA.TestsCases
{
    [TestFixture]
    class SelectionAccum : BaseTest
    {
        private readonly AccumSelection accumSelection;

        public SelectionAccum() : base()
        {
            accumSelection = new AccumSelection(_browser);
        }

        [OneTimeSetUp]
        public void HideAdvancedSearch()
        {
            WaitForElementID("sidebarCategoryAccum");
            accumSelection.OpenSelectionAccum();
            accumSelection.ChatbarHide();
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

        public void AccumVoltageSearchResultMustBeSuccess()
        {

            WaitForElementXpath(".//*[@id='menu']/li[2]/span");

            accumSelection.OpenAccumVoltageDdl();
            accumSelection.ChooseVoltage();
            accumSelection.ClickOnButtonApplyInAdvancedSearch();

            var SearchResultTires = _browser.FindElement(By.LinkText("5237994734"));
            Assert.IsTrue(SearchResultTires.Displayed);

        }
        [Test]

        public void AccumCapacitySearchResultMustBeSuccess()
        {

            WaitForElementXpath(".//*[@id='menu']/li[2]/span");

            accumSelection.OpenAccumCapacityDdl();
            accumSelection.ChooseCapasity();
            accumSelection.ClickOnButtonApplyInAdvancedSearch();

            var SearchResultTires = _browser.FindElement(By.LinkText("EB5L-B"));
            Assert.IsTrue(SearchResultTires.Displayed);

        }
    }
}