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
            
            Assert.IsTrue(_browser.Url.Contains("dashboard"));
        }
    }
}
