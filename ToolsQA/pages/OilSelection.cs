using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
namespace ToolsQA.pages

{
    class OilSelection

    {
        private IWebDriver _driver;

        public OilSelection(IWebDriver driver)
        {
            _driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.Id, Using = "sidebarCategoryOil")]
        [CacheLookup]
        private IWebElement ButtonCategoryOil { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".nav > li:nth-child(13) > ul:nth-child(2) > li:nth-child(1) > a:nth-child(1)")]
        [CacheLookup]
        private IWebElement ButtonCategoryOilSelection { get; set; }


        [FindsBy(How = How.Id, Using = "advancedsearchcategory")]
        [CacheLookup]
        private IWebElement ButtonEnterAdvancedSearch { get; set; }

        [FindsBy(How = How.Id, Using = "asideOilPurpose")]
        [CacheLookup]
        private IWebElement ButtonAsideOilPurpose { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@class='checkBoxContainer']//*[contains(text(),'Компрессорные масла')]")]
        [CacheLookup]
        private IWebElement ParametrAsideChooseOilPurpose { get; set; }

        [FindsBy(How = How.Id, Using = "asideOilViscosity")]
        [CacheLookup]
        private IWebElement ButtonAsideOilViscosity { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@class='checkBoxContainer']//*[contains(text(),'10W-40')]")]
        [CacheLookup]
        private IWebElement ParametrAsideChooseOilViscosity { get; set; }

        [FindsBy(How = How.Id, Using = "asideOilVolume")]
        [CacheLookup]
        private IWebElement ButtonAsideOilVolume { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@class='checkBoxContainer']//*[contains(text(),'6')]")]
        [CacheLookup]
        private IWebElement ParametrAsideChooseOilVolume { get; set; }

        [FindsBy(How = How.Id, Using = "asideOilApplicability")]
        [CacheLookup]
        private IWebElement ButtonAsideOilApplicability { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@class='checkBoxContainer']//*[contains(text(),'Промывочные')]")]
        [CacheLookup]
        private IWebElement ParametrAsideChooseOilApplicability { get; set; }

        [FindsBy(How = How.Id, Using = "asideOilType")]
        [CacheLookup]
        private IWebElement ButtonAsideOilType { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@class='checkBoxContainer']//*[contains(text(),'Синтетическое')]")]
        [CacheLookup]
        private IWebElement ParametrAsideChooseOilType { get; set; }

        [FindsBy(How = How.Id, Using = "asideOilSpecificationsAPI")]
        [CacheLookup]
        private IWebElement ButtonAsideOilSpecificationsAPI { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@class='checkBoxContainer']//*[contains(text(),'CC')]")]
        [CacheLookup]
        private IWebElement ParametrAsideChooseOilSpecificationsAPI { get; set; }

        [FindsBy(How = How.Id, Using = "asideOilSpecificationsACEA")]
        [CacheLookup]
        private IWebElement ButtonAsideOilSpecificationsACEA { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@class='checkBoxContainer']//*[contains(text(),'C4')]")]
        [CacheLookup]
        private IWebElement ParametrAsideChooseOilSpecificationsACEA { get; set; }

        [FindsBy(How = How.Id, Using = "asideOilSpecificationsLSAC")]
        [CacheLookup]
        private IWebElement ButtonAsideOilSpecificationsLSAC { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@class='checkBoxContainer']//*[contains(text(),'GF-4')]")]
        [CacheLookup]
        private IWebElement ParametrAsideChooseOilSpecificationsLSAC { get; set; }

        [FindsBy(How = How.Id, Using = "asideOilSpecificationsJASO")]
        [CacheLookup]
        private IWebElement ButtonAsideOilSpecificationsJASO { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@class='checkBoxContainer']//*[contains(text(),'DL-1')]")]
        [CacheLookup]
        private IWebElement ParametrAsideChooseOilSpecificationsJASO { get; set; }


        [FindsBy(How = How.Id, Using = "asideOilSpecificationsOEM")]
        [CacheLookup]
        private IWebElement ButtonAsideOilSpecificationsOEM { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@class='checkBoxContainer']//*[contains(text(),'1A')]")]
        [CacheLookup]
        private IWebElement ParametrAsideChooseOilSpecificationsOEM { get; set; }

        [FindsBy(How = How.Id, Using = "asideOilSpecificationsISO")]
        [CacheLookup]
        private IWebElement ButtonAsideOilSpecificationsISO { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@class='checkBoxContainer']//*[contains(text(),'М10Г2к')]")]
        [CacheLookup]
        private IWebElement ParametrAsideChooseOilSpecificationsISO { get; set; }

        public void OpenSelectionOil()
        {
            ButtonCategoryOil.Click();
        }

        public void OpenCategoryOilSelection()
        {
            ButtonCategoryOilSelection.Click();
        }

        public void ClickOnButtonApplyInAdvancedSearch()
        {
            ButtonEnterAdvancedSearch.Click();
        }
        public void OpenOilPurposeDdl()
        {
            ButtonAsideOilPurpose.Click();
        }

        public void ChooseOilPurpose()
        {
            ParametrAsideChooseOilPurpose.Click();
        }
        public void OpenOilViscosityDdl()
        {
            ButtonAsideOilViscosity.Click();
        }

        public void ChooseOilViscosity()
        {
            ParametrAsideChooseOilViscosity.Click();
        }
        public void OpenOilVolumeDdl()
        {
            ButtonAsideOilVolume.Click();
        }

        public void ChooseOilVolume()
        {
            ParametrAsideChooseOilVolume.Click();
        }
        public void OpenOilApplicabilityDdl()
        {
            ButtonAsideOilApplicability.Click();
        }

        public void ChooseOilApplicability()
        {
            ParametrAsideChooseOilApplicability.Click();
        }
        public void OpenOilTypeDdl()
        {
            ButtonAsideOilType.Click();
        }

        public void ChooseOilType()
        {
            ParametrAsideChooseOilType.Click();
        }
        public void OpenOilSpecificationsAPIDdl()
        {
            ButtonAsideOilSpecificationsAPI.Click();
        }

        public void ChooseOilSpecificationsAPI()
        {
            ParametrAsideChooseOilSpecificationsAPI.Click();
        }

        public void OpenOilSpecificationsACEA()
        {
            ButtonAsideOilSpecificationsACEA.Click();
        }

        public void ChooseOilSpecificationsACEA()
        {
            ParametrAsideChooseOilSpecificationsACEA.Click();
        }

        public void OpenOilSpecificationsLSAC()
        {
            ButtonAsideOilSpecificationsLSAC.Click();
        }

        public void ChooseOilSpecificationsLSAC()
        {
            ParametrAsideChooseOilSpecificationsLSAC.Click();
        }
        public void OpenOilSpecificationsJASO()
        {
            ButtonAsideOilSpecificationsJASO.Click();
        }

        public void ChooseOilSpecificationsJASO()
        {
            ParametrAsideChooseOilSpecificationsJASO.Click();
        }

        public void OpenOilSpecificationsOEM()
        {
            ButtonAsideOilSpecificationsJASO.Click();
        }

        public void ChooseOilSpecificationsOEM()
        {
            ParametrAsideChooseOilSpecificationsOEM.Click();
        }

        public void OpenOilSpecificationsISO()
        {
            ButtonAsideOilSpecificationsISO.Click();
        }

        public void ChooseOilSpecificationsISO()
        {
            ParametrAsideChooseOilSpecificationsISO.Click();
        }
    }
}
