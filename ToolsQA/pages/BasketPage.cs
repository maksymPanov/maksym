using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace ToolsQA.pages
{
    public class BasketPage
    {
        private IWebDriver _driver;


        [FindsBy(How = How.Id, Using = "navbarBasket")]
        [CacheLookup]
        private IWebElement Basket { get; set; }

        [FindsBy(How = How.Id, Using = "inputBasketAddCardNumber")]
        [CacheLookup]
        private IWebElement InputBasketAddCard { get; set; }

        [FindsBy(How = How.Id, Using = "buttonBasketCreateInvoice")]
        [CacheLookup]
        private IWebElement ButtonSaveInvoice { get; set; }

        [FindsBy(How = How.Id, Using = "buttonBasketReservationInvoice")]
        [CacheLookup]
        private IWebElement ButtonReservationInvoice { get; set; }

        
        [FindsBy(How = How.Id, Using = "tblBasket")]
        [CacheLookup]
        public IWebElement BasketTable { get; set; }

        [FindsBy(How = How.Id, Using = "accordionInvoiceList")]
        [CacheLookup]
        public IWebElement InvoiceTable { get; set; }

        [FindsBy(How = How.Id, Using = "accordionInvoiceList")]
        [CacheLookup]
        public IWebElement TblInvoice { get; set; }

        [FindsBy(How = How.Id, Using = "buttonBasketGo")]
        [CacheLookup]
        public IWebElement GoButton { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".btn.btn-darkorange.btn-sm")]
        [CacheLookup]
        public IWebElement ClearCartButton { get; set; }

        [FindsBy(How = How.Id, Using = "buttonBasketRemoveInvoice")]
        [CacheLookup]
        public IWebElement ButtonRemoveInvoiceFromBasket { get; set; }

        public BasketPage(IWebDriver driver)
        {
            _driver = driver;
            PageFactory.InitElements(driver, this);

        }

        public void SaveInvoice()
        {
            ButtonSaveInvoice.Click();
        }
        public void ReservationInvoice()
        {
            ButtonReservationInvoice.Click();
        }

        public void OpenBasket()
        {
            Basket.Click();
        }

        public void RemoveInvoiceFromBasket()
        {
            ButtonRemoveInvoiceFromBasket.Click();
        }

        public void DeleteInvoiceSendYes()
        {
            var alertWnd = _driver.SwitchTo().Alert();
            alertWnd.Accept();
        }

        public void DeleteInvoiceSendNo()
        {
            var alertWnd = _driver.SwitchTo().Alert();
            alertWnd.Dismiss();
        }


        public void InputBasketAddPosition(string text)
        {
            InputBasketAddCard.SendKeys(text);
            GoButton.Click();
        }

        public void ClearCart()
        {
            Basket.Click();
        }


    }
}