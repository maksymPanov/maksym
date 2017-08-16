using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace ToolsQA.pages
{
    class DashboardPage
    {
        private IWebDriver _driver;

        [FindsBy(How = How.Id, Using = "headerInputSearch")]
        [CacheLookup]
        private IWebElement SearchInput { get; set; }

        [FindsBy(How = How.Id, Using = "headerButtonSearch")]
        [CacheLookup]
        private IWebElement SearchButton { get; set; }

        public DashboardPage(IWebDriver driver)
        {
            _driver = driver;
            PageFactory.InitElements(driver, this);
        }

        public void EnableSearch()
        {
            SearchInput.SendKeys("4610495");
            SearchButton.Click();
        }
    }
}
