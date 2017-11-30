using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
namespace ToolsQA.pages
{
    class LampsSelection
    {
        private IWebDriver _driver;

        public LampsSelection(IWebDriver driver)
        {
            _driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.Id, Using = "sidebarCategoryLamps")]
        [CacheLookup]
        private IWebElement ButtonCategoryLamps { get; set; }

        [FindsBy(How = How.Id, Using = "advancedsearchcategory")]
        [CacheLookup]
        private IWebElement ButtonEnterAdvancedSearch { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='chatbar']/div/div/aside/div/section[1]/accordion/div/h2/i")]
        [CacheLookup]
        private IWebElement ClickChatbar { get; set; }

        //[FindsBy(How = How.XPath, Using = "/html/body/div[2]/div[3]/div/div[3]/div[2]/div/div[1]/div/div/div[1]/div")]
        //[CacheLookup]
        //private IWebElement ClickVidgetCollapse { get; set; }

        [FindsBy(How = How.Id, Using = "asideLampsPower")]
        [CacheLookup]
        private IWebElement ButtonLampsPower { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@class='checkBoxContainer']//*[contains(text(),'1.12')]")]
        [CacheLookup]
        private IWebElement ParametrChooseLampsPower { get; set; }

        [FindsBy(How = How.Id, Using = "asideLampsBase")]
        [CacheLookup]
        private IWebElement ButtonLampsBase{ get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@class='checkBoxContainer']//*[contains(text(),'BA15d')]")]
        [CacheLookup]
        private IWebElement ParametrChooseLampsBase { get; set; }

        [FindsBy(How = How.Id, Using = "asideLampsVoltage")]
        [CacheLookup]
        private IWebElement ButtonLampsVoltage { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@class='checkBoxContainer']//*[contains(text(),'24')]")]
        [CacheLookup]
        private IWebElement ParametrChooseLampsVoltage { get; set; }

        [FindsBy(How = How.Id, Using = "asideLampsXenon")]
        [CacheLookup]
        private IWebElement ButtonLampsXenon { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@class='checkBoxContainer']//*[contains(text(),'D2R')]")]
        [CacheLookup]
        private IWebElement ParametrChooseLampsXenon { get; set; }

        public void OpenSelectionLamps()
        {
            ButtonCategoryLamps.Click();
        }

        public void ClickOnButtonApplyInAdvancedSearch()
        {
            ButtonEnterAdvancedSearch.Click();
        }

        public void ChatbarHide()
        {
            ClickChatbar.Click();
        }

        //public void VidgetCollapseHide()
        //{
        //    ClickVidgetCollapse.Click();
        //}
        public void OpenlampsPowerDdl()
        {
            ButtonLampsPower.Click();
        }

        public void ChooseLampsPower()
        {
            ParametrChooseLampsPower.Click();
        }
        public void OpenlampsBaseDdl()
        {
            ButtonLampsBase.Click();
        }

        public void ChooseLampsBase()
        {
            ParametrChooseLampsBase.Click();
        }
        public void OpenlampsVoltageDdl()
        {
            ButtonLampsVoltage.Click();
        }

        public void ChooseLampsVoltage()
        {
            ParametrChooseLampsVoltage.Click();
        }
        public void OpenlampsXenonDdl()
        {
            ButtonLampsXenon.Click();
        }

        public void ChooseLampsXenon()
        {
            ParametrChooseLampsXenon.Click();
        }
    }
    
}