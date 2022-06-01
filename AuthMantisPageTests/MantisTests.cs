using AuthMantisPageTests.PageObjects;
using NUnit.Framework;
using OpenQA.Selenium;
using System.Threading;

namespace AuthMantisPageTests
{
    public class Tests
    {
        private IWebDriver _webDriver;

        private readonly By _userInfo = By.XPath("//span[@class='user-info']");

        [SetUp]
        public void Setup()
        {
            _webDriver = new OpenQA.Selenium.Chrome.ChromeDriver();
            _webDriver.Navigate().GoToUrl("https://www.mantisbt.org/bugs/my_view_page.php");
            _webDriver.Manage().Window.Maximize();
        }

        [Test]
        public void AuthMantis()
        {
            var myView = new MyViewPageObject(_webDriver);
            var user = _webDriver.FindElement(_userInfo).Text;
            myView
                .SignIn()
                .Login(UserNameForTests.UserLogin,
                       UserNameForTests.UserPassword);

            string actualLogin = myView.GetUserLogin();

            Assert.AreEqual(UserNameForTests.UserLogin, actualLogin, "Login is wrong");

            var viewIssue = new ViewWithAuthorizedPageObject(_webDriver).GetIssue();
             

            var bugReportIssue = new BugReportPageObject(_webDriver);
            bugReportIssue
                .CreateIssue(UserNameForTests.sendSummary, UserNameForTests.sendDescription);
        }

        [TearDown]
        public void TearDown()
        {
            _webDriver.Quit();
        }
    }
}