using NUnit.Framework;
using OpenQA.Selenium;
using System.Collections.Generic;
using ToolsQA.pages;

namespace ToolsQA.TestsCases
{
    [TestFixture]
    class SelectionTiresTests : BaseTest
    {
        private readonly TiresSelection tiresSelection;

        public SelectionTiresTests() : base()
        {
            tiresSelection = new TiresSelection(_browser);
        }
        
        [OneTimeSetUp]
        public void HideAdvancedSearch()
        {
            WaitForElementID("sidebarCategoryTires");
            tiresSelection.OpenSelectionTires();
            tiresSelection.ChatbarHide();
        }

        [TearDown]
        public void ClearSearchParametrs()
        {
            _browser.FindElement(By.XPath(".//*[@id='menu']/object/li[1]/span")).Click(); 
            
        }

        [Test]
        public void TiresSearchDiametrResultMustBeSuccess()
        {
            //tiresSelection.OpenSelectionTires();
            WaitForElementXpath(".//*[@id='menu']/li[2]/span");
            //var SearchResultTires = _browser.FindElement(By.XPath(".//*[@id='menu']/li[2]/span"));
            //Assert.IsTrue(SearchResultTires.Displayed);
            tiresSelection.OpenDiametrDdl();
            tiresSelection.ChooseDiametr();
            //tiresSelection.OpenDiametrDdl();
            //tiresSelection.ChatbarHide();
            
            tiresSelection.ClickOnButtonApplyInAdvancedSearch();
            
            var SearchResultTires = _browser.FindElement(By.LinkText("TS00107"));
            Assert.IsTrue(SearchResultTires.Displayed);
                        
        }


        [Test]
        public void TiresSearchSizeResultMustBeSuccess()
        {
            
            WaitForElementXpath(".//*[@id='menu']/li[2]/span");
          
            tiresSelection.OpenSizeDdl();
            tiresSelection.ChooseSize();
            tiresSelection.ClickOnButtonApplyInAdvancedSearch();

            var SearchResultTires = _browser.FindElement(By.LinkText("1017412"));
            Assert.IsTrue(SearchResultTires.Displayed);

        }




    }
}
