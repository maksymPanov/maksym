using NUnit.Framework;
using OpenQA.Selenium;
using System.Collections.Generic;
using ToolsQA.pages;

namespace ToolsQA.TestsCases

{
    [TestFixture]
    class BasketTests : BaseTest
    {
        private BasketPage basketpage;
        


        [OneTimeSetUp]
        public void LoadBasket()
        {
            _browser.WaitForAngular();
            _browser.Navigate().GoToUrl(Url + "app/basket");
            basketpage = new BasketPage(_browser);
        }

        [SetUp]

        public void ClearInvoiceTbl()
        {
            _browser.WaitForAngular();
            WaitForElementID("buttonBasketCreateInvoice");
            //basketpage.RemoveInvoiceFromBasket();
            //var listInvoice = basketpage.RemoveInvoiceFromBasket();
            var removeInvoice = _browser.FindElements(By.Id("buttonBasketRemoveInvoice"));
            for (var i = 0; i < removeInvoice.Count; i++)
            {
                removeInvoice[i].Click();
                basketpage.DeleteInvoiceSendYes();
            }
        }

        [Test]
        public void AddCardToBasket()
        {
            WaitForElementID("buttonBasketCreateInvoice");
            basketpage.InputBasketAddPosition("oc90");
            _browser.WaitForAngular();

            var listRows = basketpage.BasketTable.FindElements(By.TagName("tr"));
            var listItems = new List<string>();

            for (var i = 1; i < listRows.Count; i++)
            {
                var rowItem = basketpage.BasketTable.FindElement(By.XPath($".//tbody/tr[{i}]/td[3]"));
                if (rowItem != null && rowItem.Text != "")
                {
                    listItems.Add(rowItem.Text);
                }
            }

            Assert.Greater(listItems.Count, 0);
            Assert.Contains("OC90", listItems);
        }


        [Test]
        public void SaveInvoice()
        {
            WaitForElementID("buttonBasketCreateInvoice");
            basketpage.InputBasketAddPosition("oc90");
            _browser.WaitForAngular();
            basketpage.SaveInvoice();
            WaitForElementID("buttonBasketSaveInvoice");
            var save = _driver.FindElement(By.Id("buttonBasketSaveInvoice"));
            Assert.IsTrue(save.Displayed);

        }

        [Test]
        public void ReservationInvoice()
        {
            WaitForElementID("buttonBasketCreateInvoice");
            basketpage.InputBasketAddPosition("oc90");
            _browser.WaitForAngular();
            basketpage.ReservationInvoice();
            WaitForElementID("buttonBasketReadyInvoice");
            var reservation = _driver.FindElement(By.Id("buttonBasketReadyInvoice"));
            Assert.IsTrue(reservation.Displayed);

        }


    }
}
