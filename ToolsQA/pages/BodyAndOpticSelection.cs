using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;


namespace ToolsQA.pages
{
    public class BodyAndOpticSelection
    {
        private IWebDriver _driver;

        public BodyAndOpticSelection (IWebDriver driver)
        {
            _driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.Id, Using = "sidebarCategoryOptic")]
        [CacheLookup]
        private IWebElement ButtonCategoryOptic { get; set; }

        [FindsBy(How = How.Id, Using = "advancedsearchcategory")]
        [CacheLookup]
        private IWebElement ButtonEnterAdvancedSearch { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='chatbar']/div/div/aside/div/section[1]/accordion/div/h2/i")]
        [CacheLookup]
        private IWebElement ClickChatbar { get; set; }

        [FindsBy(How = How.Id, Using = "asideOpticGroup")]
        [CacheLookup]
        private IWebElement ButtonAsideOpticGroup  { get; set; }

        [FindsBy(How = How.Id, Using = "asideOpticNbodySide")]
        [CacheLookup]
        private IWebElement ButtonAsideOpticNbodySide { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@class='checkBoxContainer']//*[contains(text(),'Зеркала')]")]
        [CacheLookup]
        private IWebElement ParametrGroup { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@class='checkBoxContainer']//*[contains(text(),'право')]")]
        [CacheLookup]
        private IWebElement ParametrSide { get; set; }


        public void OpenSelectionBodyAndOptic()
        {
            ButtonCategoryOptic.Click();
        }

        
        public void ChatbarHide()
        {
            ClickChatbar.Click();
        }
        public void ClickOnButtonApplyInAdvancedSearch()
        {
            ButtonEnterAdvancedSearch.Click();
        }

        public void OpenAsideOpticGroupDdl()
        {
            ButtonAsideOpticGroup.Click();
        }

        public void OpenAsideOpticNbodySideDdl()
        {
            ButtonAsideOpticNbodySide.Click();
        }

        public void ChooseParametrGroup()
        {
            ParametrGroup.Click();
        }

        public void ChooseParametrSide()
        {
            ParametrSide.Click();
        }

       

    }
}
