using NUnit.Framework;
using OpenQA.Selenium;
using System.Collections.Generic;
using ToolsQA.pages;

namespace ToolsQA.TestsCases
{
    class SelectionBodyAndOptic
    {
        [TestFixture]
        class SelectionBodyAndOpticTests : BaseTest
        {
            private readonly BodyAndOpticSelection bodyAndOptic;

            public SelectionBodyAndOpticTests() : base()
            {
                bodyAndOptic = new BodyAndOpticSelection(_browser);
            }

            [OneTimeSetUp]
            public void HideAdvancedSearch()
            {
                WaitForElementID("sidebarCategoryOptic");
                bodyAndOptic.OpenSelectionBodyAndOptic();
                bodyAndOptic.ChatbarHide();
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

            public void BodyAndOpticGroupSearchResultMustBeSuccess()
            {

                WaitForElementXpath(".//*[@id='menu']/li[2]/span");

                bodyAndOptic.OpenAsideOpticGroupDdl();
                bodyAndOptic.ChooseParametrGroup();
                bodyAndOptic.ClickOnButtonApplyInAdvancedSearch();

                var SearchResultTires = _browser.FindElement(By.LinkText("8791047320"));
                Assert.IsTrue(SearchResultTires.Displayed);

            }
            [Test]

            public void BodyAndOpticSideSearchResultMustBeSuccess()
            {

                WaitForElementXpath(".//*[@id='menu']/li[2]/span");

                bodyAndOptic.OpenAsideOpticNbodySideDdl();
                bodyAndOptic.ChooseParametrSide();
                bodyAndOptic.ClickOnButtonApplyInAdvancedSearch();

                var SearchResultTires = _browser.FindElement(By.LinkText("6182008D00"));
                Assert.IsTrue(SearchResultTires.Displayed);

            }
            [Test]
            public void BodyAndOpticsMustHavePrices()
            {
                WaitForElementXpath(".//*[@id='menu']/li[2]/span");

                var priceText = _browser.FindElement(By.CssSelector("td:nth-child(8) > span")).Text;
                double number = 0;

                Assert.DoesNotThrow(() => number = double.Parse(priceText.Replace(".", ",")));
                Assert.Greater(number, 0);

            }

            [Test]
            public void BodyAndOpticsMustHaveRests()
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
}
