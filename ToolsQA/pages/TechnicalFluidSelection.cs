using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
namespace ToolsQA.pages
{
    class TechnicalFluidSelection
    {
        private IWebDriver _driver;

        public TechnicalFluidSelection(IWebDriver driver)
        {
            _driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.Id, Using = "sidebarCategoryOil")]
        [CacheLookup]
        private IWebElement ButtonCategoryOil { get; set; }

        [FindsBy(How = How.Id, Using = "sidebarCategoryTechnicalFluid")]
        [CacheLookup]
        private IWebElement ButtonCategoryTechnicalFluid { get; set; }

        [FindsBy(How = How.Id, Using = "advancedsearchcategory")]
        [CacheLookup]
        private IWebElement ButtonEnterAdvancedSearch { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='chatbar']/div/div/aside/div/section[1]/accordion/div/h2/i")]
        [CacheLookup]
        private IWebElement ClickChatbar { get; set; }

        [FindsBy(How = How.Id, Using = "asideTFPurpose")]
        [CacheLookup]
        private IWebElement ButtonAsideTFPurpose { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@class='checkBoxContainer']//*[contains(text(),'Жидкость тормозная')]")]
        [CacheLookup]
        private IWebElement ParametrAsideChooseTFPurpose { get; set; }

        [FindsBy(How = How.Id, Using = "asideTFColor")]
        [CacheLookup]
        private IWebElement ButtonAsideTFColor { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@class='checkBoxContainer']//*[contains(text(),'Зеленый')]")]
        [CacheLookup]
        private IWebElement ParametrAsideChooseTFColor { get; set; }

        [FindsBy(How = How.Id, Using = "asideTFSeasonality")]
        [CacheLookup]
        private IWebElement ButtonAsideTFSeasonality { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@class='checkBoxContainer']//*[contains(text(),'Зимний')]")]
        [CacheLookup]
        private IWebElement ParametrAsideChooseTFSeasonality { get; set; }

        [FindsBy(How = How.Id, Using = "asideTFSpecOEM")]
        [CacheLookup]
        private IWebElement ButtonAsideTFSpecOEM { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@class='checkBoxContainer']//*[contains(text(),'G12')]")]
        [CacheLookup]
        private IWebElement ParametrAsideChooseTFSpecOEM { get; set; }

        [FindsBy(How = How.Id, Using = "asideTFScope")]
        [CacheLookup]
        private IWebElement ButtonAsideTFScope { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@class='checkBoxContainer']//*[contains(text(),'0,1')]")]
        [CacheLookup]
        private IWebElement ParametrAsideChooseTFScope { get; set; }

        public void OpenSelectionOIL()
        {
            ButtonCategoryOil.Click();
        }

        public void OpenSelectionTechnicalFluid()
        {
            ButtonCategoryTechnicalFluid.Click();
        }

        public void ClickOnButtonApplyInAdvancedSearch()
        {
            ButtonEnterAdvancedSearch.Click();
        }

        public void ChatbarHide()
        {
            ClickChatbar.Click();
        }

        public void OpenTFPurposeDdl()
        {
            ButtonAsideTFPurpose.Click();
        }

        public void ChooseTFPurpose()
        {
            ParametrAsideChooseTFPurpose.Click();
        }

        public void OpenTFColorDdl()
        {
            ButtonAsideTFColor.Click();
        }

        public void ChooseTFColor()
        {
            ParametrAsideChooseTFColor.Click();
        }

        public void OpenTFSeasonalityDdl()
        {
            ButtonAsideTFSeasonality.Click();
        }

        public void ChooseTFSeasonality()
        {
            ParametrAsideChooseTFSeasonality.Click();
        }

        public void OpenTFSpecOEMyDdl()
        {
            ButtonAsideTFSpecOEM.Click();
        }

        public void ChooseTFSpecOEM()
        {
            ParametrAsideChooseTFSpecOEM.Click();
        }

        public void OpenTFScopeDdl()
        {
            ButtonAsideTFScope.Click();
        }

        public void ChooseTFScope()
        {
            ParametrAsideChooseTFScope.Click();
        }
    }
}

