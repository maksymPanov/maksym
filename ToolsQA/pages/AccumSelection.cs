using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
namespace ToolsQA.pages
{
    class AccumSelection
    {
        private IWebDriver _driver;

        public AccumSelection(IWebDriver driver)
        {
            _driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.Id, Using = "sidebarCategoryAccum")]
        [CacheLookup]
        private IWebElement ButtonCategoryAccum { get; set; }

        [FindsBy(How = How.Id, Using = "advancedsearchcategory")]
        [CacheLookup]
        private IWebElement ButtonEnterAdvancedSearch { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='chatbar']/div/div/aside/div/section[1]/accordion/div/h2/i")]
        [CacheLookup]
        private IWebElement ClickChatbar { get; set; }

        [FindsBy(How = How.Id, Using = "asideAccumSelectedVoltage")]
        [CacheLookup]
        private IWebElement ButtonAccumVoltage { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@class='checkBoxContainer']//*[contains(text(),'6 В')]")]
        [CacheLookup]
        private IWebElement ParametrAsideChooseVoltage { get; set; }

        [FindsBy(How = How.Id, Using = "asideAccumSelectedCapacity")]
        [CacheLookup]
        private IWebElement ButtonAccumCapacity { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@class='checkBoxContainer']//*[contains(text(),'5 А/ч')]")]
        [CacheLookup]
        private IWebElement ParametrAsideChooseCapacity { get; set; }

        public void OpenSelectionAccum()
        {
            ButtonCategoryAccum.Click();
        }

        public void ClickOnButtonApplyInAdvancedSearch()
        {
            ButtonEnterAdvancedSearch.Click();
        }

        public void ChatbarHide()
        {
            ClickChatbar.Click();
        }
        public void OpenAccumVoltageDdl()
        {
            ButtonAccumVoltage.Click();
        }
    
        public void ChooseVoltage()
        {
            ParametrAsideChooseVoltage.Click();
        }
        public void OpenAccumCapacityDdl()
        {
            ButtonAccumCapacity.Click();
        }
        public void ChooseCapasity()
        {
            ParametrAsideChooseCapacity.Click();
        }
    }
}
