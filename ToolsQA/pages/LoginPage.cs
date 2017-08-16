using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace ToolsQA.pages
{
    public class LoginPage
    {
        private IWebDriver _driver;

        [FindsBy(How = How.Id, Using = "loginInputEmail")]
        [CacheLookup]
        private IWebElement UserName { get; set; }

        [FindsBy(How = How.Id, Using = "loginInputPassword")]
        [CacheLookup]
        private IWebElement Password { get; set; }

        [FindsBy(How = How.Id, Using = "buttonLogin")]
        [CacheLookup]
        private IWebElement Submit { get; set; }

        public LoginPage(IWebDriver driver)
        {
            _driver = driver;
            PageFactory.InitElements(driver, this);
        }

        public void LoginToApplication()
        {
            UserName.SendKeys("skytechdev06");
            Password.SendKeys("htpth8fwbz");
            Submit.Submit();
        }
    }
}
