using NUnit.Framework;
using OpenQA.Selenium;
using ToolsQA.pages;

namespace ToolsQA.TestsCases
{
    [TestFixture]
    class SelectionOil : BaseTest
    {
        private readonly OilSelection oilSelection;

        public SelectionOil() : base()
        {
            oilSelection = new OilSelection(_browser);
        }

        [OneTimeSetUp]
        public void HideAdvancedSearch()
        {
            WaitForElementID("sidebarCategoryOil");
            oilSelection.OpenSelectionOil();
            oilSelection.OpenCategoryOilSelection();

        }

        [SetUp]
        public void CloseAdvancedsearchIfTheyOpen()
        {
            IWebElement headerMainFilter = _driver.FindElement(By.CssSelector(".header-main-filter"));
            IWebElement checkBoxOnlyProductsInStock = _driver.FindElement(By.XPath("/html/body/div[2]/div[3]/div/div[2]/div/div/aside/div/section[1]/accordion/div/section/form/div[2]/div[1]/div[1]/label/span"));

            if (checkBoxOnlyProductsInStock.Displayed)
            {
                headerMainFilter.Click();
            }
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
        public void OilPurposeResultMustBeSuccess()
        {
            WaitForElementXpath(".//*[@id='menu']/li[2]/span");
            oilSelection.OpenOilPurposeDdl();
            oilSelection.ChooseOilPurpose();
            oilSelection.ClickOnButtonApplyInAdvancedSearch();
            WaitForElementCSS(".table > tbody:nth-child(2) > tr:nth-child(1) > td:nth-child(4) > div:nth-child(1)");
            Assert.IsTrue(_driver.FindElement(By.CssSelector(".table > tbody:nth-child(2) > tr:nth-child(1) > td:nth-child(4) > div:nth-child(1)")).Text.Contains("Масло компресс"));

        }

        [Test]
        public void OilViscosityResultMustBeSuccess()
        {
            WaitForElementXpath(".//*[@id='menu']/li[2]/span");
            oilSelection.OpenOilViscosityDdl();
            oilSelection.ChooseOilViscosity();
            oilSelection.ClickOnButtonApplyInAdvancedSearch();
            WaitForElementCSS(".table > tbody:nth-child(2) > tr:nth-child(1) > td:nth-child(4) > div:nth-child(1)");
            Assert.IsTrue(_driver.FindElement(By.CssSelector(".table > tbody:nth-child(2) > tr:nth-child(1) > td:nth-child(4) > div:nth-child(1)")).Text.Contains("Масло"));

        }



        [Test]
        public void OilApplicabilityResultMustBeSuccess()
        {
            WaitForElementXpath(".//*[@id='menu']/li[2]/span");
            oilSelection.OpenOilApplicabilityDdl();
            oilSelection.ChooseOilApplicability();
            oilSelection.ClickOnButtonApplyInAdvancedSearch();
            WaitForElementCSS(".table > tbody:nth-child(2) > tr:nth-child(1) > td:nth-child(4) > div:nth-child(1)");
            Assert.IsTrue(_driver.FindElement(By.CssSelector(".table > tbody:nth-child(2) > tr:nth-child(1) > td:nth-child(4) > div:nth-child(1)")).Text.Contains("Масл"));

        }

        [Test]
        public void OilTypeResultMustBeSuccess()
        {
            WaitForElementXpath(".//*[@id='menu']/li[2]/span");
            oilSelection.OpenOilTypeDdl();
            oilSelection.ChooseOilType();
            oilSelection.ClickOnButtonApplyInAdvancedSearch();
            WaitForElementCSS(".table > tbody:nth-child(2) > tr:nth-child(1) > td:nth-child(4) > div:nth-child(1)");
            Assert.IsTrue(_driver.FindElement(By.CssSelector(".table > tbody:nth-child(2) > tr:nth-child(1) > td:nth-child(4) > div:nth-child(1)")).Text.Contains("Масло моторн"));

        }


        [Test]
        public void OilSpecificationsAPIResultMustBeSuccess()
        {
            WaitForElementXpath(".//*[@id='menu']/li[2]/span");
            oilSelection.OpenOilSpecificationsAPIDdl();
            oilSelection.ChooseOilSpecificationsAPI();
            oilSelection.ClickOnButtonApplyInAdvancedSearch();
            WaitForElementCSS(".table > tbody:nth-child(2) > tr:nth-child(1) > td:nth-child(4) > div:nth-child(1)");
            Assert.IsTrue(_driver.FindElement(By.CssSelector(".table > tbody:nth-child(2) > tr:nth-child(1) > td:nth-child(4) > div:nth-child(1)")).Text.Contains("CC"));

        }

        [Test]
        public void OilSpecificationsACEAResultMustBeSuccess()
        {
            WaitForElementXpath(".//*[@id='menu']/li[2]/span");
            oilSelection.OpenOilSpecificationsACEA();
            oilSelection.ChooseOilSpecificationsACEA();
            oilSelection.ClickOnButtonApplyInAdvancedSearch();
            WaitForElementCSS(".table > tbody:nth-child(2) > tr:nth-child(1) > td:nth-child(4) > div:nth-child(1)");
            Assert.IsTrue(_driver.FindElement(By.CssSelector(".table > tbody:nth-child(2) > tr:nth-child(1) > td:nth-child(4) > div:nth-child(1)")).Text.Contains("Масло моторн"));

        }

        [Test]
        public void OilSpecificationsLSACResultMustBeSuccess()
        {
            WaitForElementXpath(".//*[@id='menu']/li[2]/span");
            oilSelection.OpenOilSpecificationsLSAC();
            oilSelection.ChooseOilSpecificationsLSAC();
            oilSelection.ClickOnButtonApplyInAdvancedSearch();
            WaitForElementCSS(".table > tbody:nth-child(2) > tr:nth-child(1) > td:nth-child(4) > div:nth-child(1)");
            Assert.IsTrue(_driver.FindElement(By.CssSelector(".table > tbody:nth-child(2) > tr:nth-child(1) > td:nth-child(4) > div:nth-child(1)")).Text.Contains("Масло моторн"));

        }

        [Test]
        public void OilSpecificationsJASOResultMustBeSuccess()
        {
            WaitForElementXpath(".//*[@id='menu']/li[2]/span");
            oilSelection.OpenOilSpecificationsJASO();
            oilSelection.ChooseOilSpecificationsJASO();
            oilSelection.ClickOnButtonApplyInAdvancedSearch();
            WaitForElementCSS(".table > tbody:nth-child(2) > tr:nth-child(1) > td:nth-child(4) > div:nth-child(1)");
            Assert.IsTrue(_driver.FindElement(By.CssSelector(".table > tbody:nth-child(2) > tr:nth-child(1) > td:nth-child(4) > div:nth-child(1)")).Text.Contains("Масло моторн"));

        }

        [Test]
        public void OilSpecificationsOEMResultMustBeSuccess()
        {
            WaitForElementXpath(".//*[@id='menu']/li[2]/span");
            oilSelection.OpenOilSpecificationsOEM();
            oilSelection.ChooseOilSpecificationsOEM();
            oilSelection.ClickOnButtonApplyInAdvancedSearch();
            WaitForElementCSS(".table > tbody:nth-child(2) > tr:nth-child(1) > td:nth-child(4) > div:nth-child(1)");
            Assert.IsTrue(_driver.FindElement(By.CssSelector(".table > tbody:nth-child(2) > tr:nth-child(1) > td:nth-child(4) > div:nth-child(1)")).Text.Contains("Масло трансмисс"));

        }

        //[Test]
        //public void OilVolumetResultMustBeSuccess()
        //{
        //    WaitForElementXpath(".//*[@id='menu']/li[2]/span");
        //    oilSelection.OpenOilVolumeDdl();
        //    oilSelection.ChooseOilVolume();
        //    oilSelection.ClickOnButtonApplyInAdvancedSearch();
        //    WaitForElementCSS(".table > tbody:nth-child(2) > tr:nth-child(1) > td:nth-child(4) > div:nth-child(1)");
        //    Assert.IsTrue(_driver.FindElement(By.CssSelector(".table > tbody:nth-child(2) > tr:nth-child(1) > td:nth-child(4) > div:nth-child(1)")).Text.Contains("Масло"));

        //}

        //[Test]
        //public void OilSpecificationsISOResultMustBeSuccess()
        //{

        //    WaitForElementXpath(".//*[@id='menu']/li[2]/span");
        //    oilSelection.OpenOilSpecificationsISO();
        //    IJavaScriptExecutor js = (IJavaScriptExecutor)_browser;
        //    js.ExecuteScript(@"return  $('html, body').animate({
        //        scrollTop: $('#asideOilSpecificationsISO').offset().top
        //     });");
        //    WaitForElementXpath("/html/body/div[1]/div[3]/div/div[2]/div/div/aside/div/section[2]/div[1]/div/div/accordion/div/div[5]/div/div[2]/div/div/div[11]/div/span/div/div[1]/div[2]/input");
        //    oilSelection.ChooseOilSpecificationsISO();
        //    IJavaScriptExecutor js2 = (IJavaScriptExecutor)_browser;
        //    js.ExecuteScript(@"return  $('html, body').animate({
        //        scrollTop: $('#asideOilPurpose').offset().top
        //     });");
        //    oilSelection.ClickOnButtonApplyInAdvancedSearch();
        //    WaitForElementCSS(".table > tbody:nth-child(2) > tr:nth-child(1) > td:nth-child(4) > div:nth-child(1)");
        //    Assert.IsTrue(_driver.FindElement(By.CssSelector(".table > tbody:nth-child(2) > tr:nth-child(1) > td:nth-child(4) > div:nth-child(1)")).Text.Contains("Остальное"));
        //}
    }

}
