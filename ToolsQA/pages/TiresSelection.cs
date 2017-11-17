using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace ToolsQA.pages
{
    public class TiresSelection
    {
        private IWebDriver _driver;

        public TiresSelection(IWebDriver driver)
        {
            _driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.Id, Using = "sidebarCategoryTires")]
        [CacheLookup]
        private IWebElement ButtonCategoryTires { get; set; }

        [FindsBy(How = How.Id, Using = "asideTiresDiametr")]
        [CacheLookup]
        private IWebElement ButtonAsideTiresDiametr { get; set; }


        [FindsBy(How = How.Id, Using = "asideTiresFrameSize")]
        [CacheLookup]
        private IWebElement ButtonAsideTiresFrameSize { get; set; }

        [FindsBy(How = How.Id, Using = "asideTiresSeason")]
        [CacheLookup]
        private IWebElement ButtonAsideTiresSeason { get; set; }

        [FindsBy(How = How.Id, Using = "asideTiresUsage")]
        [CacheLookup]
        private IWebElement ButtonAsideTiresUsage { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@class='checkBoxContainer']//*[contains(text(),'15')]")]  
        [CacheLookup]
        private IWebElement ParametrAsideTiresDiametr { get; set; }
        
        [FindsBy(How = How.XPath, Using = ".//*[@class='checkBoxContainer']//*[contains(text(),'/50')]")]
        [CacheLookup]
        private IWebElement ParametrAsideTiresFrameSize { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@class='checkBoxContainer']//*[contains(text(),'Зима')]")]
        [CacheLookup]
        private IWebElement ParamertAsideTiresSeason { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@class='checkBoxContainer']//*[contains(text(),'Легковая')]")]
        [CacheLookup]
        private IWebElement ParamertAsideTiresAppointment { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@class='checkBoxContainer']//*[contains(text(),'20')]")]
        [CacheLookup]
        private IWebElement ParametrAsideTiresAllDiametr { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@class='checkBoxContainer']//*[contains(text(),'Внедорожники')]")]
        [CacheLookup]
        private IWebElement ParamertAsideTiresAllAppointment { get; set; }

        [FindsBy(How = How.Id, Using = "advancedsearchcategory")]
        [CacheLookup]
        private IWebElement ButtonEnterAdvancedSearch { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='chatbar']/div/div/aside/div/section[1]/accordion/div/h2/i")]
        [CacheLookup]
        private IWebElement ClickChatbar { get; set; }


       

        public void ChatbarHide()
        {
            ClickChatbar.Click();
        }
                      

        public void OpenDiametrDdl()
        {
            ButtonAsideTiresDiametr.Click();
        }

        public void ClickOnButtonApplyInAdvancedSearch()
        {
            ButtonEnterAdvancedSearch.Click();
        }

        public void OpenSizeDdl()
        {
            ButtonAsideTiresFrameSize.Click();
        }

        public void OpenSeasonDdl()
        {
            ButtonAsideTiresSeason.Click();
        }
        public void OpenAppointmentDdl()
        {
            ButtonAsideTiresUsage.Click();
        }

        public void ChooseDiametr()
        {
            ParametrAsideTiresDiametr.Click();
        }

        public void ChooseSize()
        {
            ParametrAsideTiresFrameSize.Click();
        }

        public void ChooseSeason()
        {
            ParamertAsideTiresSeason.Click();
        }
        public void ChooseAppointment()
        {
            ParamertAsideTiresAppointment.Click();
        }

        public void OpenSelectionTires()
        {
            ButtonCategoryTires.Click();
        }


        public void ChooseAllAppointment()
        {
            ParamertAsideTiresAllAppointment.Click();
        }

        public void ChooseDiametrAll()
        {
            ParametrAsideTiresAllDiametr.Click();
        }



    }
}
