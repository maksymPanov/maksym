//using NUnit.Framework;
//using OpenQA.Selenium;
//using RelevantCodes.ExtentReports;
//using ToolsQA.pages;

//namespace ToolsQA.TestsCases
//{
//    [TestFixture]
//    class SelectionTechnicalFluid : BaseTest
//    {
//        private readonly TechnicalFluidSelection technicalFluidSelection;

//        public SelectionTechnicalFluid() : base()
//        {
//            technicalFluidSelection = new TechnicalFluidSelection(_browser);
//        }

//        [OneTimeSetUp]
//        public void HideAdvancedSearch()
//        {
//            WaitForElementID("sidebarCategoryOil");
//            technicalFluidSelection.OpenSelectionOIL();
//            technicalFluidSelection.OpenSelectionTechnicalFluid();
//            //technicalFluidSelection.ChatbarHide();
//        }

//        [SetUp]
//        public void CloseAdvancedsearchIfTheyOpen()
//        {
//            IWebElement headerMainFilter = _driver.FindElement(By.CssSelector(".header-main-filter"));
//            IWebElement checkBoxOnlyProductsInStock = _driver.FindElement(By.XPath("/html/body/div[2]/div[3]/div/div[2]/div/div/aside/div/section[1]/accordion/div/section/form/div[2]/div[1]/div[1]/label/span"));

//            if (checkBoxOnlyProductsInStock.Displayed)
//            {
//                headerMainFilter.Click();
//            }
//        }

//        [TearDown]
//        public void ClearSearchParametrs()
//        {
//            _browser.WaitForAngular();
//            var removeLables = _browser.FindElements(By.XPath(".//*[@id='menu']/object/li[1]/span"));
//            for (var i = 0; i < removeLables.Count; i++)
//            {
//                removeLables[i].Click();
//            }
//        }

//        [Test]
//        public void TLAppointmentResultMustBeSuccess()
//        {
//            //test = extent.StartTest("TLAppointmentResultMustBeSuccess");
//            //test.Log(LogStatus.Pass, "Pass");


//            WaitForElementXpath(".//*[@id='menu']/li[2]/span");
//            technicalFluidSelection.OpenTFPurposeDdl();
//            technicalFluidSelection.ChooseTFPurpose();
//            technicalFluidSelection.ClickOnButtonApplyInAdvancedSearch();
//            //var SearchResultTires = _browser.FindElement(By.LinkText("4802617334"));
//            //Assert.IsTrue(SearchResultTires.Displayed);
//            WaitForElementCSS(".table > tbody:nth-child(2) > tr:nth-child(1) > td:nth-child(4) > div:nth-child(1)");
//            Assert.IsTrue(_driver.FindElement(By.CssSelector(".table > tbody:nth-child(2) > tr:nth-child(1) > td:nth-child(4) > div:nth-child(1)")).Text.Contains("Жидкость торм"));

//        }

//        [Test]
//        public void TLColorResultMustBeSuccess()
//        {
//            //test = extent.StartTest("TLColorResultMustBeSuccess");
//            //test.Log(LogStatus.Pass, "Pass");



//            WaitForElementXpath(".//*[@id='menu']/li[2]/span");
//            technicalFluidSelection.OpenTFColorDdl();
//            technicalFluidSelection.ChooseTFColor();
//            technicalFluidSelection.ClickOnButtonApplyInAdvancedSearch();
//            //var SearchResultTires = _browser.FindElement(By.LinkText("26580"));
//            //Assert.IsTrue(SearchResultTires.Displayed);
//            WaitForElementCSS(".table > tbody:nth-child(2) > tr:nth-child(1) > td:nth-child(4) > div:nth-child(1)");
//            Assert.IsTrue(_driver.FindElement(By.CssSelector(".table > tbody:nth-child(2) > tr:nth-child(1) > td:nth-child(4) > div:nth-child(1)")).Text.Contains("зеленый"));

//        }

//        [Test]
//        public void TFSeasonalityResultMustBeSuccess()
//        {
//            //test = extent.StartTest("TFSeasonalityResultMustBeSuccess");
//            //test.Log(LogStatus.Pass, "Pass");

//            WaitForElementXpath(".//*[@id='menu']/li[2]/span");
//            technicalFluidSelection.OpenTFSeasonalityDdl();
//            technicalFluidSelection.ChooseTFSeasonality();
//            technicalFluidSelection.ClickOnButtonApplyInAdvancedSearch();
//            //var SearchResultTires = _browser.FindElement(By.LinkText("5363"));
//            //Assert.IsTrue(SearchResultTires.Displayed);
//            WaitForElementCSS(".table > tbody:nth-child(2) > tr:nth-child(1) > td:nth-child(4) > div:nth-child(1)");
//            Assert.IsTrue(_driver.FindElement(By.CssSelector(".table > tbody:nth-child(2) > tr:nth-child(1) > td:nth-child(4) > div:nth-child(1)")).Text.Contains("зим"));

//        }

//        [Test]
//        public void SpecOEMResultMustBeSuccess()
//        {
//            //test = extent.StartTest("SpecOEMResultMustBeSuccess");
//            //test.Log(LogStatus.Pass, "Pass");

//            WaitForElementXpath(".//*[@id='menu']/li[2]/span");
//            technicalFluidSelection.OpenTFSpecOEMyDdl();
//            technicalFluidSelection.ChooseTFSpecOEM();
//            technicalFluidSelection.ClickOnButtonApplyInAdvancedSearch();
//            //var SearchResultTires = _browser.FindElement(By.LinkText("12710"));
//            //Assert.IsTrue(SearchResultTires.Displayed);
//            WaitForElementCSS(".table > tbody:nth-child(2) > tr:nth-child(1) > td:nth-child(4) > div:nth-child(1)");
//            Assert.IsTrue(_driver.FindElement(By.CssSelector(".table > tbody:nth-child(2) > tr:nth-child(1) > td:nth-child(4) > div:nth-child(1)")).Text.Contains("G12"));

//        }

//        [Test]
//        public void TFScopeResultMustBeSuccess()
//        {
//            //test = extent.StartTest("TFScopeResultMustBeSuccess");
//            //test.Log(LogStatus.Pass, "Pass");

//            WaitForElementXpath(".//*[@id='menu']/li[2]/span");
//            technicalFluidSelection.OpenTFScopeDdl();
//            technicalFluidSelection.ChooseTFScope();
//            technicalFluidSelection.ClickOnButtonApplyInAdvancedSearch();
//            //var SearchResultTires = _browser.FindElement(By.LinkText("4102816901"));
//            //Assert.IsTrue(SearchResultTires.Displayed);
//            WaitForElementCSS(".table > tbody:nth-child(2) > tr:nth-child(1) > td:nth-child(4) > div:nth-child(1)");
//            Assert.IsTrue(_driver.FindElement(By.CssSelector(".table > tbody:nth-child(2) > tr:nth-child(1) > td:nth-child(4) > div:nth-child(1)")).Text.Contains("0,1"));

//        }

//        [Test]
//        public void TFMustHavePrices()
//        {
//            //test = extent.StartTest("TFMustHavePrices");
//            //test.Log(LogStatus.Pass, "Pass");

//            WaitForElementXpath(".//*[@id='menu']/li[2]/span");
//            var priceText = _browser.FindElement(By.CssSelector("td:nth-child(8) > span")).Text;
//            double number = 0;
//            Assert.DoesNotThrow(() => number = double.Parse(priceText.Replace(".", ",")));
//            Assert.Greater(number, 0);

//        }

//        [Test]
//        public void TFMustHaveRests()
//        {
//            //test = extent.StartTest("TFMustHaveRests");
//            //test.Log(LogStatus.Pass, "Pass");

//            WaitForElementXpath(".//*[@id='menu']/li[2]/span");
//            var restsText = _browser.FindElement(By.CssSelector(".hidden-sm.hidden-xs")).Text;
//            if (restsText.Trim().Contains("-"))
//            {
//                Assert.Fail();
//            }
//        }

//    }
//}
