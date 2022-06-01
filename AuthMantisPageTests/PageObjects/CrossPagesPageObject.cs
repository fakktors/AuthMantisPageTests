using OpenQA.Selenium;

namespace AuthMantisPageTests.PageObjects
{
    class CrossPagesPageObject
    {
        private IWebDriver _webDriver;

        private readonly By _submitButton = By.XPath("//input[@type='submit']");

        public CrossPagesPageObject(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }

        public AuthPageObject Button()
        {
            _webDriver.FindElement(_submitButton).Click();
            return new AuthPageObject(_webDriver);
        }
    }
}
