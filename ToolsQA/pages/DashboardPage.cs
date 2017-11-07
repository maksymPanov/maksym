﻿using OpenQA.Selenium;
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

        [FindsBy(How = How.CssSelector, Using = ".btn.btn-palegreen.shiny")]
        [CacheLookup]
        private IWebElement LoadMoreAnalogs { get; set; }

        [FindsBy(How = How.Id, Using = "navbarIconFilter")]
        [CacheLookup]
        private IWebElement AdvancedSearch { get; set; }


        public DashboardPage(IWebDriver driver)
        {
            _driver = driver;
            PageFactory.InitElements(driver, this);
        }

        public void LoadMoreAnalog()
        {
            LoadMoreAnalogs.Click();
        }

        public void OpenAdvancedSearch()
        {
            AdvancedSearch.Click();
        }

        public void Clear()
        {
            _driver.Navigate().Refresh();
        }

        public void EnableSearch(string text)
        {
            SearchInput.SendKeys(text);
            SearchButton.Click();
        }
    }
}
