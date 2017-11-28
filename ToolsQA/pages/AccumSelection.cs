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

        [FindsBy(How = How.Id, Using = "asideAccumSelectedStartAmperage")]
        [CacheLookup]
        private IWebElement ButtonAccumAmperege { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@class='checkBoxContainer']//*[contains(text(),'50 А')]")]
        [CacheLookup]
        private IWebElement ParametrAsideChooseAmperege { get; set; }

        [FindsBy(How = How.Id, Using = "asideAccumSelectedLength")]
        [CacheLookup]
        private IWebElement ButtonAccumLength { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@class='checkBoxContainer']//*[contains(text(),'121 мм')]")]
        [CacheLookup]
        private IWebElement ParametrAsideChooseLength { get; set; }

        [FindsBy(How = How.Id, Using = "asideAccumSelected")]
        [CacheLookup]
        private IWebElement ButtonAccumSelected { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@class='checkBoxContainer']//*[contains(text(),'60 мм')]")]
        [CacheLookup]
        private IWebElement ParametrAsideChooseSelected { get; set; }

        [FindsBy(How = How.Id, Using = "asideAccumSelectedHeight")]
        [CacheLookup]
        private IWebElement ButtonAccumHeight { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@class='checkBoxContainer']//*[contains(text(),'104 мм')]")]
        [CacheLookup]
        private IWebElement ParametrAsideChooseHeight { get; set; }

        [FindsBy(How = How.Id, Using = "asideAccumSelectedPolarity")]
        [CacheLookup]
        private IWebElement ButtonAccumPolarity { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@class='checkBoxContainer']//*[contains(text(),'L')]")]
        [CacheLookup]
        private IWebElement ParametrAsideChoosePolarity { get; set; }

        [FindsBy(How = How.Id, Using = "asideAccumSelectedTerminal")]
        [CacheLookup]
        private IWebElement ButtonAccumTerminal { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@class='checkBoxContainer']//*[contains(text(),'1')]")]
        [CacheLookup]
        private IWebElement ParametrAsideChooseTerminal { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='chatbar']/div/div/aside/div/section[2]/div[1]/div/div/accordion/div/div[4]/div/div[2]/div/accum-category/div/div[9]/div/span/button")]
        [CacheLookup]
        private IWebElement ButtonAccumSelected1 { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@class='checkBoxContainer']//*[contains(text(),'Азия')]")]
        [CacheLookup]
        private IWebElement ParametrAsideChooseSelected1 { get; set; }

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
        public void OpenAccumAmperegeDdl()
        {
            ButtonAccumAmperege.Click();
        }

        public void ChooseAmperege()
        {
            ParametrAsideChooseAmperege.Click();
        }

        public void OpenAccumLengthDdl()
        {
            ButtonAccumLength.Click();
        }

        public void ChooseLength()
        {
            ParametrAsideChooseLength.Click();
        }

        public void OpenAccumSelectedDdl()
        {
            ButtonAccumSelected.Click();
        }

        public void ChooseSelected()
        {
            ParametrAsideChooseSelected.Click();
        }

        public void OpenAccumHeightDdl()
        {
            ButtonAccumHeight.Click();
        }
        
        public void ChooseHeight()
        {
            ParametrAsideChooseHeight.Click();
        }

        public void OpenAccumPolarityDdl()
        {
            ButtonAccumPolarity.Click();
        }

        public void ChoosePolarity()
        {
            ParametrAsideChoosePolarity.Click();
        }
        public void OpenAccumTerminalDdl()
        {
            ButtonAccumTerminal.Click();
        }

        public void ChooseTerminal()
        {
            ParametrAsideChooseTerminal.Click();
        }

        public void OpenAccumSelected1Ddl()
        {
            ButtonAccumSelected1.Click();
        }

        public void ChooseSelected1()
        {
            ParametrAsideChooseSelected1.Click();
        }

    }
    
}
