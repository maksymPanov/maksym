using NUnit.Framework;
using OpenQA.Selenium;
using RelevantCodes.ExtentReports;
using ToolsQA.pages;

namespace ToolsQA.TestsCases
{
    [TestFixture]
    class SelectionLamps : BaseTest
    {
        private readonly LampsSelection lampsSelection;

        public SelectionLamps() : base()
        {
            lampsSelection = new LampsSelection(_browser);
        }

        [OneTimeSetUp]
        public void HideAdvancedSearch()
        {
            WaitForElementID("sidebarCategoryLamps");
            lampsSelection.OpenSelectionLamps();
            lampsSelection.ChatbarHide();

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

        public void LampsPowerSearchResultMustBeSuccess()
        {
            //test = extent.StartTest("LampsPowerSearchResultMustBeSuccess");
            //test.Log(LogStatus.Pass, "Pass");


            WaitForElementXpath(".//*[@id='menu']/li[2]/span");
            //lampsSelection.VidgetCollapseHide();
            lampsSelection.OpenlampsPowerDdl();
            lampsSelection.ChooseLampsPower();
            lampsSelection.ClickOnButtonApplyInAdvancedSearch();

            var SearchResultTires = _browser.FindElement(By.LinkText("12638CP"));
            Assert.IsTrue(SearchResultTires.Displayed);
        }

        [Test]

        public void LampsBaseSearchResultMustBeSuccess()
        {
            //test = extent.StartTest("LampsBaseSearchResultMustBeSuccess");
            //test.Log(LogStatus.Pass, "Pass");


            WaitForElementXpath(".//*[@id='menu']/li[2]/span");
            lampsSelection.OpenlampsBaseDdl();
            lampsSelection.ChooseLampsBase();
            lampsSelection.ClickOnButtonApplyInAdvancedSearch();

            var SearchResultTires = _browser.FindElement(By.LinkText("1 987 302 527"));
            Assert.IsTrue(SearchResultTires.Displayed);
        }

        [Test]

        public void LampsXenonSearchResultMustBeSuccess()
        {
            //test = extent.StartTest("LampsXenonSearchResultMustBeSuccess");
            //test.Log(LogStatus.Pass, "Pass");


            WaitForElementXpath(".//*[@id='menu']/li[2]/span");
            lampsSelection.OpenlampsXenonDdl();
            lampsSelection.ChooseLampsXenon();
            lampsSelection.ClickOnButtonApplyInAdvancedSearch();

            var SearchResultTires = _browser.FindElement(By.LinkText("66250"));
            Assert.IsTrue(SearchResultTires.Displayed);
        }

        [Test]
        public void LampsMustHavePrices()
        {
            //test = extent.StartTest("LampsMustHavePrices");
            //test.Log(LogStatus.Pass, "Pass");

            WaitForElementXpath(".//*[@id='menu']/li[2]/span");
            var priceText = _browser.FindElement(By.CssSelector("td:nth-child(8) > span")).Text;
            double number = 0;
            Assert.DoesNotThrow(() => number = double.Parse(priceText.Replace(".", ",")));
            Assert.Greater(number, 0);

        }

        [Test]
        public void LampsMustHaveRests()
        {
            //test = extent.StartTest("LampsMustHaveRests");
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
