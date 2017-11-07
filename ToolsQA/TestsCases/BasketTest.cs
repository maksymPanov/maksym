using NUnit.Framework;
using OpenQA.Selenium;
using ToolsQA.pages;

namespace ToolsQA.TestsCases

{
    [TestFixture]
    class CreateNewInvoice : BaseTest
    {
        private readonly BasketPage basketpage;
        public CreateNewInvoice() : base()
        {
            basketpage = new BasketPage(_browser);
            
        }

        [OneTimeSetUp]
        public void LoadBasket()
        {
_browser.WaitForAngular();
            _browser.Navigate().GoToUrl("http://shop-mvc.omega-auto.biz/#/app/basket");
        }

        [Test]
        public void AddCardToBasket()
        {
            //basketpage.OpenBasket();
            WaitForElementID("buttonBasketCreateInvoice");
            basketpage.InputBasketAddPosition("oc90");
            
            //var priceText = _browser.FindElement(By.CssSelector("td:nth-child(8) > span")).Text;
            //double number = 0;

            //Assert. (() => number = double.Parse(priceText.Replace(".", ",")));
            //Assert.Greater(number, 0);
        }

        //[Test]
        //public void SaveInvoice()
        //{
        //    basketpage.OpenBasket();
        //    WaitForElementID("buttonBasketCreateInvoice");
        //    basketpage.InputBasketAddPosition("oc90");
        //}


        //[Test]
        //public void ReservedInvoice()
        //{
        //    basketpage.OpenBasket();
        //    WaitForElementID("buttonBasketCreateInvoice");
        //    basketpage.InputBasketAddPosition("oc90");
        //}


    }
}
