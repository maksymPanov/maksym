using NUnit.Framework;
using RelevantCodes.ExtentReports;

namespace ToolsQA.TestsCases
{
    [TestFixture]
    class LoginTest : BaseTest
    {

        public LoginTest() : base() { }

        [Test]
        public void LoginMustBeSuccess()
        {
            //test = extent.StartTest("LoginTest");
            //test.Log(LogStatus.Pass, "Pass");

            Assert.IsTrue(_browser.Url.Contains("dashboard"));
        }
    }
}
