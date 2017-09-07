using NUnit.Framework;
using ToolsQA.pages;

namespace ToolsQA.TestsCases
{
    [TestFixture]
    class LoginTest : BaseTest
    {
        public LoginTest() : base() { }

        [Test]
        public void LoginMustBeSuccess()
        {
            var loginPage = new LoginPage(_browser);
            loginPage.LoginToApplication();

            _browser.WaitForAngular();

            Assert.IsTrue(_browser.Url.Contains("dashboard"));
        }
    }
}
