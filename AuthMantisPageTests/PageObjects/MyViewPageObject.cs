using OpenQA.Selenium;

namespace AuthMantisPageTests.PageObjects
{
    class MyViewPageObject
    {
        private IWebDriver _webDriver;

        private readonly By _signInButton = By.XPath("//a[normalize-space()='Вход']");
        private readonly By _userLogin = By.XPath("//span[@class='user-info']");

        public MyViewPageObject(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }

        public AuthPageObject SignIn()
        {
            _webDriver.FindElement(_signInButton).Click();

            return new AuthPageObject(_webDriver);
        }

        public string GetUserLogin()
        {
            string userLogin = _webDriver.FindElement(_userLogin).Text;
            return userLogin;
        }
    }
}
