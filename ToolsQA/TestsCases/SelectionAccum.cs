using NUnit.Framework;
using OpenQA.Selenium;
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
            //test = extent.StartTest("AccumVoltageSearchResultMustBeSuccess");
            //test.Log(LogStatus.Pass, "Pass");

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
            //test = extent.StartTest("AccumCapacitySearchResultMustBeSuccess");
            //test.Log(LogStatus.Pass, "Pass");

            WaitForElementXpath(".//*[@id='menu']/li[2]/span");
            accumSelection.OpenAccumCapacityDdl();
            accumSelection.ChooseCapasity();
            accumSelection.ClickOnButtonApplyInAdvancedSearch();
            var SearchResultTires = _browser.FindElement(By.LinkText("EB5L-B"));
            Assert.IsTrue(SearchResultTires.Displayed);
        }

        [Test]

        public void AccumAmperegeSearchResultMustBeSuccess()
        {
            //test = extent.StartTest("AccumAmperegeSearchResultMustBeSuccess");
            //test.Log(LogStatus.Pass, "Pass");

            WaitForElementXpath(".//*[@id='menu']/li[2]/span");
            accumSelection.OpenAccumAmperegeDdl();
            accumSelection.ChooseAmperege();
            accumSelection.ClickOnButtonApplyInAdvancedSearch();
            var SearchResultTires = _browser.FindElement(By.LinkText("EB4L-B"));
            Assert.IsTrue(SearchResultTires.Displayed);
        }

        [Test]

        public void AccumLengthSearchResultMustBeSuccess()
        {
            //test = extent.StartTest("AccumLengthSearchResultMustBeSuccess");
            //test.Log(LogStatus.Pass, "Pass");


            WaitForElementXpath(".//*[@id='menu']/li[2]/span");
            accumSelection.OpenAccumLengthDdl();
            accumSelection.ChooseLength();
            accumSelection.ClickOnButtonApplyInAdvancedSearch();
            var SearchResultTires = _browser.FindElement(By.LinkText("6N11A-1B"));
            Assert.IsTrue(SearchResultTires.Displayed);
        }

        [Test]

        public void AccumSelectedSearchResultMustBeSuccess()
        {
            //test = extent.StartTest("AccumSelectedSearchResultMustBeSuccess");
            //test.Log(LogStatus.Pass, "Pass");


            WaitForElementXpath(".//*[@id='menu']/li[2]/span");
            accumSelection.OpenAccumSelectedDdl();
            accumSelection.ChooseSelected();
            accumSelection.ClickOnButtonApplyInAdvancedSearch();
            var SearchResultTires = _browser.FindElement(By.LinkText("EB5L-B"));
            Assert.IsTrue(SearchResultTires.Displayed);
        }

        [Test]
        public void AccumHeightSearchResultMustBeSuccess()
        {
            //test = extent.StartTest("AccumHeightSearchResultMustBeSuccess");
            //test.Log(LogStatus.Pass, "Pass");

            WaitForElementXpath(".//*[@id='menu']/li[2]/span");
            accumSelection.OpenAccumHeightDdl();
            accumSelection.ChooseHeight();
            accumSelection.ClickOnButtonApplyInAdvancedSearch();
            var SearchResultTires = _browser.FindElement(By.LinkText("5237994780"));
            Assert.IsTrue(SearchResultTires.Displayed);
        }

        [Test]
        public void AccumPolaritySearchResultMustBeSuccess()
        {
            //test = extent.StartTest("AccumPolaritySearchResultMustBeSuccess");
            //test.Log(LogStatus.Pass, "Pass");

            WaitForElementXpath(".//*[@id='menu']/li[2]/span");
            accumSelection.OpenAccumPolarityDdl();
            accumSelection.ChoosePolarity();
            accumSelection.ClickOnButtonApplyInAdvancedSearch();
            var SearchResultTires = _browser.FindElement(By.LinkText("6СТ-190 АЗ (3)"));
            Assert.IsTrue(SearchResultTires.Displayed);
        }

        [Test]
        public void AccumTerminalSearchResultMustBeSuccess()
        {
            //test = extent.StartTest("AccumTerminalSearchResultMustBeSuccess");
            //test.Log(LogStatus.Pass, "Pass");

            WaitForElementXpath(".//*[@id='menu']/li[2]/span");
            accumSelection.OpenAccumTerminalDdl();
            accumSelection.ChooseTerminal();
            accumSelection.ClickOnButtonApplyInAdvancedSearch();
            var SearchResultTires = _browser.FindElement(By.LinkText("6СТ-190 АЗ (3)"));
            Assert.IsTrue(SearchResultTires.Displayed);
        }

        [Test]
        public void AccumSelected1SearchResultMustBeSuccess()
        {
            //test = extent.StartTest("AccumSelected1SearchResultMustBeSuccess");
            //test.Log(LogStatus.Pass, "Pass");

            WaitForElementXpath(".//*[@id='menu']/li[2]/span");
            accumSelection.OpenAccumSelected1Ddl();
            accumSelection.ChooseSelected1();
            accumSelection.ClickOnButtonApplyInAdvancedSearch();
            var SearchResultTires = _browser.FindElement(By.LinkText("6СТ-95A1 (1)"));
            Assert.IsTrue(SearchResultTires.Displayed);
        }

        [Test]
        public void AccumMustHavePrices()
        {
            //test = extent.StartTest("AccumMustHavePrices");
            //test.Log(LogStatus.Pass, "Pass");

            WaitForElementXpath(".//*[@id='menu']/li[2]/span");
            var priceText = _browser.FindElement(By.CssSelector("td:nth-child(8) > span")).Text;
            double number = 0;
            Assert.DoesNotThrow(() => number = double.Parse(priceText.Replace(".", ",")));
            Assert.Greater(number, 0);
        }

        [Test]
        public void AccumMustHaveRests()
        {
            //test = extent.StartTest("AccumMustHaveRests");
            //test.Log(LogStatus.Pass, "Pass");

            WaitForElementXpath(".//*[@id='menu']/li[2]/span");
            var restsText = _browser.FindElement(By.CssSelector(".hidden-sm.hidden-xs")).Text;
            if (restsText.Trim().Contains("-"))
            {
                Assert.Fail();
            }


        }
    }
}