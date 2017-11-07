using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace ToolsQA.pages
{
    class BasketPage
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

        [FindsBy(How = How.Id, Using = "tableBasket")]
        [CacheLookup]
        private IWebElement BasketTable { get; set; }

        public BasketPage(IWebDriver driver)
        {
            _driver = driver;
            PageFactory.InitElements(driver, this);

        }
        

        public void OpenBasket()
        {
            Basket.Click();
        }

        public void InputBasketAddPosition(string text)
        {            
            InputBasketAddCard.SendKeys(text);
            InputBasketAddCard.Click();
        }


    }
}