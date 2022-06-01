using OpenQA.Selenium;

namespace AuthMantisPageTests.PageObjects
{
    class AuthPageObject
    {
        private IWebDriver _webDriver;

        private readonly By _submitButton = By.XPath("//input[@type='submit']");
        private readonly By _loginUser = By.XPath("//input[@id='username']");
        private readonly By _passwordUser = By.XPath("//input[@id='password']");


        public AuthPageObject(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }

        public MyViewPageObject Login(string login, string password)
        {
            _webDriver.FindElement(_loginUser).SendKeys(login);
            _webDriver.FindElement(_submitButton).Click();
            _webDriver.FindElement(_passwordUser).SendKeys(password);
            _webDriver.FindElement(_submitButton).Click();

            return new MyViewPageObject(_webDriver);

        }
    }
}
