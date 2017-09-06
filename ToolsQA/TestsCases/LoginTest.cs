using NUnit.Framework;
using ToolsQA.pages;

namespace ToolsQA.TestsCases
{
    [TestFixture]
    class LoginTest : BaseTest
    {
        [Test]
        public void LoginMustBeSuccess()
        {
            _browser.Url = Url;

            var loginPage = new LoginPage(_browser);
            loginPage.LoginToApplication();

            _browser.WaitForAngular();

            Assert.IsTrue(_browser.Url.Contains("dashboard"));
        }
    }
}
