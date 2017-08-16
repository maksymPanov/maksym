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
            var loginPage = new LoginPage(_driver);
            loginPage.LoginToApplication();

            WaitForAngular();

            Assert.IsTrue(_driver.Url.Contains("dashboard"));
        }

    }
}
